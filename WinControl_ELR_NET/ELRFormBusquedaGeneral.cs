using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinControl_ELR_NET
{
    public partial class ELRFormBusquedaGeneral : Form
    {

        public string titulo = "BUSQUEDA GENERAL";
        public string TablaOVista;     
        public MyColumna[] columnas;
        public string FiltroEstatico;
        public string CondicionABuscar;
        public int Limite = 100;
        public bool EsAutoIncremental = true;
        public string CondicionOrderBY = "";
        public DataRow FilaSelecionada;
        public string DefaultColumnaBusqueda = "";

        //VARIABLES PRIVADA
        DataDB_ELR_NET.DataDB objDB = new DataDB_ELR_NET.DataDB();
        string NombreCampoID;
        DataTable MyData;
        DataTable DTBuscarPor = new DataTable();
        

        ELRUtils objUtil = new ELRUtils();


        public ELRFormBusquedaGeneral()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ELRFormBusquedaGeneral_Load(object sender, EventArgs e)
        {
            int I = 0;
            int ancho = 82;
            DataRow fila0;

            try
            {
                //ASIGNAMOS EL TITULO
                this.Text = titulo;

                //Agreganos Columnas Para Buscar
                DTBuscarPor.Columns.Add(new DataColumn("NombreCampo", typeof(string)));
                DTBuscarPor.Columns.Add(new DataColumn("Descripcion", typeof(string)));

                foreach (MyColumna item in columnas)
                {
                   //EL PRIMER CAMPO DEBE SER EL CAMPO Id
                    if (I == 0) NombreCampoID = item.NombreCampo;

                    fila0 = DTBuscarPor.NewRow();
                    fila0["NombreCampo"] = item.NombreCampo;
                    fila0["Descripcion"] = item.HeaderText;
                    DTBuscarPor.Rows.Add(fila0);

                    //DECLARAMOS NUEVA COLUMNA
                    DataGridViewTextBoxColumn cln = new DataGridViewTextBoxColumn();

                    cln.Name = item.NombreCampo;
                    cln.DataPropertyName = item.NombreCampo;
                    cln.HeaderText = item.HeaderText;
                    if (item.Ancho <= 0) cln.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    else
                    {
                        cln.Width = item.Ancho;
                        ancho += item.Ancho;
                    }

                    if (item.Formato.Trim() != "")
                    {
                        cln.DefaultCellStyle.Format = item.Formato;
                        if (item.Formato.ToUpper() == "N2")
                        {
                            cln.DefaultCellStyle.NullValue = "0.00";
                            cln.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                        }
                    }

                    //AGREGO LA COLUMNA
                    dgvData.Columns.Add(cln);

                    I++;
                }

                cboBuscarPor.DataSource = DTBuscarPor.DefaultView;
                if (DefaultColumnaBusqueda.Trim() != "") cboBuscarPor.SelectedValue = DefaultColumnaBusqueda;

                if (ancho > 670) this.Width = ancho;
                else this.Width = 670;

                //INVOCAMOS AL METODO GETDATA
                GetData();

                //MANDAMOS EL FOCUS AL TextBox
                txtABuscar.Focus();

            }
            catch (Exception ex)
            {

                FilaSelecionada = null;
                objUtil.MostrarMensajeError(ex.Message);
               
            }
            finally
            {
                
            }
        }

        private void GetData()
        {
            string aBuscar = "";
            string miFiltro = "";
            string nombreCampo = "";
            DataColumn item;
            try
            {
                objDB.LimpiarFiltros();

                //AGREGAMOS FILTRO ESTATICO
                if (FiltroEstatico == null) FiltroEstatico = "";
                if (FiltroEstatico.Trim() != "") objDB.AddFiltroPersonalizado(FiltroEstatico);

                //AGREGAMOS FILTRO A BUSCAR
                aBuscar = txtABuscar.Text.Trim();
                if (cboBuscarPor.SelectedValue != null) nombreCampo = cboBuscarPor.SelectedValue.ToString().ToUpper();
                if ((aBuscar != "") && (nombreCampo.Trim() != "") )
                {
                    if (MyData != null)
                    {
                        if (MyData.Columns.Contains(nombreCampo))
                        {
                            item = MyData.Columns[nombreCampo];
                            if ((item.DataType == typeof(int)) || (item.DataType == typeof(Int16)) || (item.DataType == typeof(Int32)) || (item.DataType == typeof(Int64)))
                            {
                                miFiltro = nombreCampo + " = " + aBuscar;
                                objDB.AddFiltroPersonalizado(miFiltro);
                            }
                            else if ((nombreCampo == "CEDULARNC") || (nombreCampo == "CEDULA") || (nombreCampo == "RNC") || (nombreCampo == "CEDULA_RNC"))
                            {
                                miFiltro = "REPLACE(" + nombreCampo + ", '-', '') Like '" + aBuscar + "%' ";
                                objDB.AddFiltroPersonalizado(miFiltro);
                            }
                            else if(nombreCampo == "CUENTA_CONTABLE")
                            {
                                miFiltro = nombreCampo + " Like '" + aBuscar + "%'";
                                objDB.AddFiltroPersonalizado(miFiltro);
                            }
                            else
                            {
                                miFiltro = nombreCampo + " Like '%" + aBuscar + "%'";
                                objDB.AddFiltroPersonalizado(miFiltro);
                            }
                        }
                    }
                    else
                    {
                        miFiltro = nombreCampo + " = '" + aBuscar + "' ";
                        objDB.AddFiltroPersonalizado(miFiltro);
                    }
                }

                //AGREGAMOS CONDICION ORDER BY
                objDB.AddFiltroOrderBY(CondicionOrderBY);

                //OBTENEMOS LOS DATOS
                MyData = objDB.GetAll(TablaOVista, Limite, objDB.Filtros);
                dgvData.AutoGenerateColumns = false;
                dgvData.DataSource = MyData.DefaultView;

            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void txtABuscar_TextChanged(object sender, EventArgs e)
        {
            if (EsAutoIncremental) GetData();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            GetData();
        }

        private  void SeleccionarFila()
        {
            string valorID = "0";
            DataRow[] Filas;
            try
            {
                if (dgvData.SelectedRows.Count > 0)
                {
                    //Obtenemos el Id Seleccionado
                    valorID = dgvData.SelectedRows[0].Cells[NombreCampoID].Value.ToString().Trim();
                    Filas = MyData.Select(NombreCampoID + "= '" + valorID + "'");
                    FilaSelecionada = Filas[0];

                    this.Close();
                }
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SeleccionarFila();
        }

        private void dgvData_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SeleccionarFila();
        }

        private void txtABuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            string nombreCampo = "";
            DataColumn item;
            try
            {
                if (e.KeyChar == (char)Keys.Enter) GetData();
                else
                {
                    if(cboBuscarPor.SelectedValue != null)
                    {
                        nombreCampo = cboBuscarPor.SelectedValue.ToString().ToUpper();

                        if( (nombreCampo == "CEDULARNC") || (nombreCampo == "CEDULA") || (nombreCampo== "RNC") || (nombreCampo== "CEDULA_RNC") )
                        {
                            //Ignora la tecla presionada si no es dígito o tecla de control      
                            if (Char.IsDigit(e.KeyChar)) e.Handled = false;
                            else if (Char.IsControl(e.KeyChar)) e.Handled = false;
                            else e.Handled = true;
                        }
                        if(MyData.Columns.Contains(nombreCampo))
                        {
                            item = MyData.Columns[nombreCampo];
                            if ( (item.DataType == typeof(int)) || (item.DataType == typeof(Int16)) || (item.DataType == typeof(Int32)) || (item.DataType == typeof(Int64)))
                            {
                                //Ignora la tecla presionada si no es dígito o tecla de control      
                                if (Char.IsDigit(e.KeyChar)) e.Handled = false;
                                else if (Char.IsControl(e.KeyChar)) e.Handled = false;
                                else e.Handled = true;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void cboBuscarPor_SelectedValueChanged(object sender, EventArgs e)
        {
            string nombreCampo = "";
            DataColumn item;
            try
            {
                txtABuscar.Enabled = (cboBuscarPor.SelectedValue != null);
                txtABuscar.Text = "";

                if (cboBuscarPor.SelectedValue != null)
                {
                    nombreCampo = cboBuscarPor.SelectedValue.ToString().ToUpper();
                    if (MyData.Columns.Contains(nombreCampo))
                    {
                        item = MyData.Columns[nombreCampo];
                        if ((item.DataType == typeof(int)) || (item.DataType == typeof(Int16)) || (item.DataType == typeof(Int32)) || (item.DataType == typeof(Int64)))
                        {
                            txtABuscar.Text = "0";
                        }
                    }

                    txtABuscar.Focus();
                }
            }
            catch (Exception)
            {

                //throw;
            }
        }

        private void ELRFormBusquedaGeneral_Activated(object sender, EventArgs e)
        {
            txtABuscar.Focus();
        }
    }
}
