using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.ComponentModel;

namespace WinControl_ELR_NET
{
    public class ELRCombobox : System.Windows.Forms.ComboBox
    {
        DataDB_ELR_NET.DataDB objDB = new DataDB_ELR_NET.DataDB();

        //VARIABLES PUBLICA
        public DataView dvData;
        public DataTable data;
        public DataSet DSDataGlobal = null;

        [Category("PropiedadesELR")]
        public DataSet DSData { get; set; }

        [Category("PropiedadesELR")]
        public string CampoData { get; set; }

        [Category("PropiedadesELR")]
        public string NombreTabla { get; set; }

        [Category("PropiedadesELR")]
        public bool UsaDataGlobal { get; set; }

        [Category("PropiedadesELR")]
        public string TablaOVistaConsulta { get; set; }

        [Category("PropiedadesELR")]
        public string SSQL { get; set; }

        [Category("PropiedadesELR")]
        public bool EsEditable { get; set; }

        [Category("PropiedadesELR")]
        public string ValorPorDefecto { get; set; }

        [Category("PropiedadesELR")]
        public string FiltroBusqueda { get; set; }

        [Category("PropiedadesELR")]
        public string CampoJoinCombobox2 { get; set; }

        [Category("PropiedadesELR")]
        public ELRCombobox ComboboxAFiltrar { get; set; }

        [Category("PropiedadesELR")]
        public Valida[] AValidar { get; set; }

        public void LlenarCombo()
        {
            string nombre = "";
            
            try
            {
                nombre = Name;
                objDB.LimpiarFiltros();

                if (NombreTabla == null) NombreTabla = "";
                if (TablaOVistaConsulta == null) TablaOVistaConsulta = "";
                if (FiltroBusqueda == null) FiltroBusqueda = "";

                if ((UsaDataGlobal) && (DSDataGlobal != null))
                {
                    data = DSDataGlobal.Tables[TablaOVistaConsulta.Trim()].Copy();
                    dvData = data.DefaultView;

                    //Aplicamos Filtro si Existe
                    if (FiltroBusqueda.Trim() != "") dvData.RowFilter = FiltroBusqueda.Trim();

                }
                else if (TablaOVistaConsulta.Trim() != "")
                {
                    if (FiltroBusqueda.Trim() != "") objDB.AddFiltroPersonalizado(FiltroBusqueda);
                    data = objDB.GetAll(TablaOVistaConsulta, 1000, objDB.Filtros);
                    dvData = data.DefaultView;
                }

                if (dvData != null)
                {
                    this.DataSource = dvData;
                    this.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                }

            }
            catch (Exception ex)
            {

                nombre += ", " + ex.Message;
            }
        }

        public void SetValorEnDS(int posicion = 0)
        {
            string valor = "0";
            try
            {
                if (CampoData == null) CampoData = "";

                if ((DSData != null) && (CampoData.Trim() != ""))
                {
                    if ((this.DataSource != null) && (this.ValueMember.Trim() != "") && (this.SelectedValue != null)) valor = this.SelectedValue.ToString();
                    else if ((this.Items.Count > 0) && (this.SelectedItem != null)) valor = this.SelectedIndex.ToString();
                    else if (this.Text.Trim() != "") valor = this.Text.Trim();

                    if (NombreTabla.Trim() == "") DSData.Tables[0].Rows[posicion][CampoData] = valor;
                    else DSData.Tables[NombreTabla].Rows[posicion][CampoData] = valor;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void GetValorFromDS(bool esNuevo, int posicion = 0)
        {
            string valor = "0";
            try
            {
                if (!esNuevo) this.Enabled = EsEditable;

                if (ValorPorDefecto.Trim() == "") ValorPorDefecto = "0";

                LlenarCombo();
                if (DSData != null)
                {

                    if (esNuevo) valor = ValorPorDefecto;
                    else if (NombreTabla.Trim() == "" && CampoData.Trim() != "")
                    {
                        if (DSData.Tables[0].Rows[posicion][CampoData] is DBNull) valor = ValorPorDefecto;
                        else valor = DSData.Tables[0].Rows[posicion][CampoData].ToString();
                    }
                    else if (CampoData.Trim() != "")
                    {
                        if (DSData.Tables[NombreTabla].Rows[posicion][CampoData] is DBNull) valor = ValorPorDefecto;
                        else valor = DSData.Tables[NombreTabla].Rows[posicion][CampoData].ToString();
                    }


                    if ((this.DataSource != null) && (this.ValueMember.Trim() != ""))
                    {
                        this.SelectedValue = valor;
                        this.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                    }
                    else if (this.Items.Count > 0)
                    {
                        this.SelectedIndex = int.Parse(valor);
                        this.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
                    }
                    else this.Text = valor;
                }

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void FiltrarCombobox2()
        {
            ELRUtils objUtil = new ELRUtils();
            string valor = "0";
            try
            {
                if ((ComboboxAFiltrar != null) && (CampoJoinCombobox2.Trim() != ""))
                {
                    ComboboxAFiltrar.LlenarCombo();

                    if (this.SelectedValue != null)
                    {
                        valor = this.SelectedValue.ToString();
                        ComboboxAFiltrar.dvData.RowFilter = ComboboxAFiltrar.data.Columns[CampoJoinCombobox2].ColumnName + " = '" + valor + "'";
                        ComboboxAFiltrar.dvData.RowFilter += " Or " + ComboboxAFiltrar.data.Columns[CampoJoinCombobox2].ColumnName + " = '0' ";

                        if (ComboboxAFiltrar.ComboboxAFiltrar != null) ComboboxAFiltrar.FiltrarCombobox2();
                    }

                }
            }
            catch (Exception ex)
            {
                objUtil.MostrarMensajeError(ex.Message);

            }
            finally
            {
                objUtil = null;
            }

        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ELRCombobox
            // 

            this.ResumeLayout(false);

        }

        //CONSTRUTOR DE LA CLASE
        public ELRCombobox()
        {
            InitializeComponent();

            CampoData = "";
            NombreTabla = "";
            SSQL = "";
            EsEditable = true;
            ValorPorDefecto = "0";
            this.FiltroBusqueda = "";
            CampoJoinCombobox2 = "";
            TablaOVistaConsulta = "";
            UsaDataGlobal = false;

            this.SelectedValueChanged += new System.EventHandler(this.ELRCombobox_SelectedValueChanged);
        }

        private void ELRCombobox_SelectedValueChanged(object sender, EventArgs e)
        {
            FiltrarCombobox2();
        }
    }
}
