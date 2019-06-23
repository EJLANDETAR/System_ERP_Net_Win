using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace WinControl_ELR_NET
{

    public enum tbTipoCampoBusqueda
    {
        Id,
        CedulaRNC,
        CodigoBarra
    }

    public enum tbFormato
    {
        SoloNumero,
        SoloLetra,
        LetrasYNumeros,
        DecimalPositivo,
        Decimal,
        Default,
        NumerosEnteros,
        NumerosEnterosPositivos,
        NCF,
        NoSpace
    }



    public class ELRTextBox : TextBox
    {
        [Category("PropiedadesELR")]
        public DataSet DSData { get; set; }

        [Category("PropiedadesELR")]
        public string CampoData { get; set; }

        [Category("PropiedadesELR")]
        public string NombreTabla { get; set; }

        [Category("PropiedadesELR")]
        public bool EsEditable { get; set; }

        [Category("PropiedadesELR")]
        public string ValorPorDefecto { get; set; }

        [Category("PropiedadesELR")]
        public bool EsAutoGenerado { get; set; }

        [Category("PropiedadesELR")]
        public Valida[] AValidar { get; set; }

        [Category("FormatoELR")]
        public tbFormato Formato { get; set; }

        [Category("FormatoELR")]
        public char SepDecimal { get; set; }

        [Category("FormatoELR")]
        public int Decimales { get; set; }

        [Category("OpcionesBusqueda")]
        public ControlesMostrar[] AMostrar { get; set; }

        [Category("OpcionesBusqueda")]
        public Boolean EsBusqueda { get; set; }

        [Category("OpcionesBusqueda")]
        public Boolean autoSenTab { get; set; }

        [Category("OpcionesBusqueda")]
        public string CampoBusquedaID { get; set; }

        [Category("OpcionesBusqueda")]
        public bool EsBusquedaAutoIncremental { get; set; }

        [Category("OpcionesBusqueda")]
        public string TablaOVistaBusqueda { get; set; }

        [Category("OpcionesBusqueda")]
        public string FiltroBusqueda { get; set; }

        [Category("OpcionesBusqueda")]
        public MyColumna[] ColumnasBusqGeneral { get; set; }

        [Category("OpcionesBusqueda")]
        public string CondicionABuscar { get; set; }

        [Category("OpcionesBusqueda")]
        public string TituloBusqueda { get; set; }

        [Category("OpcionesBusqueda")]
        public tbTipoCampoBusqueda TipoCampoBusqueda { get; set; }


        //Variables Publica
        public DataRow drFilaSel = null;
        public int TipoDocumento = 0;

        //Variables Privadas
        public String ultimaTecla = "";



        public void SetValorEnDS(int posicion = 0)
        {
            ELRUtils util = new ELRUtils();
            try
            {
                if (CampoData == null) CampoData = "";

                if (EsAutoGenerado) this.Enabled = false;

                if ((DSData != null) && (CampoData.Trim() != ""))
                {
                    if ((!EsAutoGenerado) && (NombreTabla.Trim() == ""))
                    {
                        if (CampoData.ToUpper().Contains("CEDULA")) DSData.Tables[0].Rows[posicion][CampoData] = util.FormatearCedulaRNC(this.Text).Trim();
                        else if (CampoData.ToUpper().Contains("RNC")) DSData.Tables[0].Rows[posicion][CampoData] = util.FormatearCedulaRNC(this.Text).Trim();
                        else if (CampoData.ToUpper().Contains("TELEFONO")) DSData.Tables[0].Rows[posicion][CampoData] = util.FormatearTelefono(this.Text).Trim();
                        else if (CampoData.ToUpper().Contains("CELULAR")) DSData.Tables[0].Rows[posicion][CampoData] = util.FormatearTelefono(this.Text).Trim();
                        else DSData.Tables[0].Rows[posicion][CampoData] = this.Text.Trim();
                    }
                    else if (!EsAutoGenerado)
                    {
                        if (CampoData.ToUpper().Contains("CEDULA")) DSData.Tables[NombreTabla].Rows[posicion][CampoData] = util.FormatearCedulaRNC(this.Text).Trim();
                        else if (CampoData.ToUpper().Contains("RNC")) DSData.Tables[NombreTabla].Rows[posicion][CampoData] = util.FormatearCedulaRNC(this.Text).Trim();
                        else if (CampoData.ToUpper().Contains("TELEFONO")) DSData.Tables[NombreTabla].Rows[posicion][CampoData] = util.FormatearTelefono(this.Text).Trim();
                        else if (CampoData.ToUpper().Contains("CELULAR")) DSData.Tables[NombreTabla].Rows[posicion][CampoData] = util.FormatearTelefono(this.Text).Trim();
                        else DSData.Tables[NombreTabla].Rows[posicion][CampoData] = this.Text.Trim();
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void SetValor(string valor, int posicion = 0)
        {
            this.Text = valor;

            if (DSData != null)
            {
                if ((!EsAutoGenerado) && (NombreTabla.Trim() == "")) DSData.Tables[0].Rows[posicion][CampoData] = this.Text;
                else if (!EsAutoGenerado) DSData.Tables[NombreTabla].Rows[posicion][CampoData] = this.Text;
            }
        }

        public void GetValorFromDS(bool esNuevo, int posicion = 0)
        {
            DataColumn MyColumna;
            DataRow MyFila;
            ELRUtils util = new ELRUtils();
            string NDecim = "N";

            string valor = "";
            try
            {
                valor = ValorPorDefecto;

                if (DSData != null)
                {
                    if (NombreTabla.Trim() == "")
                    {
                        if (!DSData.Tables[0].Columns.Contains(CampoData)) throw new Exception("El Campo [" + CampoData + "] No Existe!!");

                        MyColumna = DSData.Tables[0].Columns[CampoData];
                        MyFila = DSData.Tables[0].Rows[posicion];
                    }
                    else
                    {
                        if (!DSData.Tables[NombreTabla].Columns.Contains(CampoData)) throw new Exception("El Campo [" + CampoData + "] No Existe!!");

                        MyColumna = DSData.Tables[NombreTabla].Columns[CampoData];
                        MyFila = DSData.Tables[NombreTabla].Rows[posicion];
                    }

                    if (MyColumna.MaxLength > 0)
                    {
                        MaxLength = MyColumna.MaxLength;
                    }

                    //APLICAMOS FORMATO DECIMAL
                    if ((MyColumna.DataType == typeof(Decimal)) || (MyColumna.DataType == typeof(Double)))
                    {
                        if (valor.Trim() == "") valor = "0.0";

                        if ((Formato == null) || (Formato == tbFormato.Default))
                        {
                            Formato = tbFormato.DecimalPositivo;
                            if (Decimales <= 0) Decimales = 2;

                        }

                        if (!esNuevo) valor = util.GetAsString(CampoData, MyFila, "0");

                        NDecim += Decimales.ToString();
                        this.Text = util.ConvertirANumero(valor).ToString(NDecim);
                    }
                    else if ((MyColumna.DataType == typeof(Int16)) || (MyColumna.DataType == typeof(Int32)) || (MyColumna.DataType == typeof(Int64)) || (MyColumna.DataType == typeof(Single)) || (MyColumna.DataType == typeof(SByte)))
                    {
                        if (valor.Trim() == "") valor = "0";

                        if ((Formato == null) || (Formato == tbFormato.Default)) Formato = tbFormato.NumerosEnteros;

                        if (!esNuevo) valor = util.GetAsString(CampoData, MyFila, "0");

                        this.Text = valor;
                    }
                    else if ((MyColumna.DataType == typeof(UInt16)) || (MyColumna.DataType == typeof(UInt32)) || (MyColumna.DataType == typeof(UInt64)))
                    {
                        if (valor.Trim() == "") valor = "0";

                        if ((Formato == null) || (Formato == tbFormato.Default)) Formato = tbFormato.NumerosEnterosPositivos;

                        if (!esNuevo) valor = util.GetAsString(CampoData, MyFila, "0");

                        this.Text = valor;
                    }
                    else
                    {
                        if (!esNuevo) valor = util.GetAsString(CampoData, MyFila);

                        if (CampoData.ToUpper().Contains("CEDULA")) valor = util.FormatearCedulaRNC(valor);
                        else if (CampoData.ToUpper().Contains("RNC")) valor = util.FormatearCedulaRNC(valor);
                        else if (CampoData.ToUpper().Contains("TELEFONO")) valor = util.FormatearTelefono(valor);
                        else if (CampoData.ToUpper().Contains("CELULAR")) valor = util.FormatearTelefono(valor);
                        

                        this.Text = valor.Trim();
                    }



                }

                if (EsAutoGenerado) this.Enabled = false;
                if ((!esNuevo) && (this.Enabled)) this.Enabled = EsEditable;

            }
            catch (Exception)
            {

                throw;
            }
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ELRTextBox
            // 
            this.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Enter += new System.EventHandler(this.ELRTextBox_Enter);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ELRTextBox_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ELRTextBox_KeyPress);
            this.Leave += new System.EventHandler(this.ELRTextBox_Leave);
            this.ResumeLayout(false);

        }

        //Construtor de la Clase
        public ELRTextBox()
        {
            InitializeComponent();

            this.CampoData = "";
            this.NombreTabla = "";
            this.EsEditable = true;
            this.ValorPorDefecto = "";
            this.FiltroBusqueda = "";
            this.EsAutoGenerado = false;

            EsBusqueda = false;
            autoSenTab = true;
            EsBusquedaAutoIncremental = false;
            TablaOVistaBusqueda = "";
            CampoBusquedaID = "";
            TituloBusqueda = "BUSQUEDA GENERAL";
            CondicionABuscar = " Campo_Busqueda Like '%' + @aBuscar + '%' ";
            TipoCampoBusqueda = tbTipoCampoBusqueda.Id;
            Formato = tbFormato.Default;

        }

        public void GetById()
        {
            ELRUtils objUtil = new ELRUtils();
            DataDB_ELR_NET.DataDB db = new DataDB_ELR_NET.DataDB();
            DataTable DTData = null;
            string valorId = "";

            try
            {
                this.Cursor = Cursors.WaitCursor;

                if (ultimaTecla != "F9")
                {
                    valorId = this.Text.Trim();
                    drFilaSel = null;

                    if (TipoCampoBusqueda == tbTipoCampoBusqueda.Id) DTData = db.GetById(TablaOVistaBusqueda, valorId, CampoBusquedaID);
                    else if (TipoCampoBusqueda == tbTipoCampoBusqueda.CedulaRNC)
                    {
                        valorId = valorId.Replace("-", string.Empty);

                        //Procedemos a Validar si es Cedula TipoDocumento = 1, RNC TipoDocumento = 2 else TipoDocumento = 3
                        if (objUtil.ValidarCedula(valorId)) TipoDocumento = 1;
                        else if (objUtil.ValidarRNC(valorId)) TipoDocumento = 2;
                        else TipoDocumento = 3;

                        db.LimpiarFiltros();
                        db.AddFiltroPersonalizado("Replace(CedulaRNC, '-', '') = '" + valorId + "'");
                        DTData = db.GetAll(TablaOVistaBusqueda, 1, db.Filtros);
                    }

                    if (DTData.Rows.Count > 0)
                    {
                        MostrarEnControles(DTData.Rows[0]);
                        this.Text = valorId.Trim();
                        //SendKeys.Send("\t");
                    }
                    else
                    {
                        this.Text = "0";
                        MostrarEnControles(null);
                        this.SelectAll();
                    }
                }

                ultimaTecla = "";

            }
            catch (Exception ex)
            {
                objUtil.MostrarMensajeError(ex.Message);

            }
            finally
            {
                this.Cursor = Cursors.Default;
                objUtil = null;
            }
        }


        private void ELRTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode != Keys.Tab) ultimaTecla = "";

                if (e.KeyCode == Keys.Enter && autoSenTab) SendKeys.Send("{TAB}");
                else if ((e.KeyCode == Keys.F9) && (ColumnasBusqGeneral != null) && (EsBusqueda)) RealizarBusquedaGeneral();

            }
            catch (Exception)
            {

                throw;
            }
        }

        public void MostrarEnControles(DataRow dr)
        {
            ELRUtils objUtil = new ELRUtils();
            string nombreControl = "";
            string valor = "0";

            try
            {
                drFilaSel = dr;

                if (AMostrar != null)
                {
                    foreach (ControlesMostrar item in AMostrar)
                    {
                        if (item.LabelControl != null)
                        {
                            if (dr != null) item.LabelControl.Text = dr[item.NombreCampo].ToString();
                            else
                            {
                                item.LabelControl.Text = item.ValorPorDefecto;
                            }

                            nombreControl = item.LabelControl.Name;
                        }


                        if (item.TextBoxControl != null)
                        {
                            nombreControl = item.TextBoxControl.Name;

                            if (dr != null)
                            {
                                valor = objUtil.GetAsString(item.NombreCampo, dr, item.ValorPorDefecto);
                                if (item.NombreCampo.ToUpper() == "CEDULARNC") item.TextBoxControl.Text = objUtil.FormatearCedulaRNC(valor);
                                else item.TextBoxControl.Text = valor;

                                if (item.TextBoxControl != this)
                                {

                                    if (item.EsHabilitar) item.TextBoxControl.Enabled = false;
                                }

                            }
                            else
                            {
                                item.TextBoxControl.Text = item.ValorPorDefecto;
                                if (item.EsHabilitar) item.TextBoxControl.Enabled = true;
                            }
                        }


                        if (item.ComboBoxControl != null)
                        {
                            nombreControl = item.ComboBoxControl.Name;

                            if (dr != null)
                            {
                                valor = objUtil.GetAsString(item.NombreCampo, dr, "0");

                                if (item.ComboBoxControl.ValueMember.Trim() != "") item.ComboBoxControl.SelectedValue = valor;
                                else item.ComboBoxControl.Text = valor;

                                if (item.EsHabilitar) item.ComboBoxControl.Enabled = false;
                            }
                            else if (item.EsHabilitar) item.ComboBoxControl.Enabled = true;
                        }

                        if (item.NumericUpDownControl != null)
                        {
                            nombreControl = item.NumericUpDownControl.Name;

                            if (dr != null)
                            {

                                item.NumericUpDownControl.Value = objUtil.GetAsDecimal(item.NombreCampo.ToString(), dr, 0);

                                if (item.EsHabilitar) item.NumericUpDownControl.Enabled = false;

                            }
                            else
                            {
                                item.NumericUpDownControl.Value = 0;
                                if (item.EsHabilitar) item.NumericUpDownControl.Enabled = true;
                            }
                        }

                    }
                }

                //if ((drFilaSel != null) && (CampoBusquedaID.Trim() != "")) this.Text = dr[CampoBusquedaID].ToString();
                // this.Text = "0";
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError("Error en " + nombreControl + ", " + ex.Message);
            }
        }

        public void RealizarBusquedaGeneral()
        {
            ELRUtils objUtil = new ELRUtils();
            ELRFormBusquedaGeneral frmB = new ELRFormBusquedaGeneral();

            try
            {
                ultimaTecla = "F9";

                frmB.titulo = TituloBusqueda;
                frmB.TablaOVista = TablaOVistaBusqueda;
                frmB.Limite = 100;
                frmB.FiltroEstatico = FiltroBusqueda;
                frmB.columnas = ColumnasBusqGeneral;
                frmB.CondicionABuscar = CondicionABuscar;
                frmB.CondicionOrderBY = "";
                frmB.EsAutoIncremental = true;

                frmB.ShowDialog();
                drFilaSel = frmB.FilaSelecionada;

                MostrarEnControles(drFilaSel);
                if (drFilaSel != null) SendKeys.Send("{TAB}");
                else
                {
                    //this.Text = "0";
                    this.SelectAll();
                    this.Focus();
                }

                if ((drFilaSel != null) && (TipoCampoBusqueda == tbTipoCampoBusqueda.CedulaRNC)) this.Text = drFilaSel["CedulaRNC"].ToString();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void ELRTextBox_Leave(object sender, EventArgs e)
        {
            ELRUtils util = new ELRUtils();
            string NDecim = "N";
            try
            {
                NDecim += Decimales.ToString();

                if (EsBusqueda) GetById();

                if ((Formato == tbFormato.Decimal) || (Formato == tbFormato.DecimalPositivo)) this.Text = util.ConvertirANumero(Text.Trim()).ToString(NDecim);
                if ((Formato == tbFormato.NumerosEnteros) || (Formato == tbFormato.NumerosEnterosPositivos))
                {
                    if (Text.Trim() == "") Text = "0";
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                util = null;
            }
        }

        private void ELRTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool IsDec = false;
            int nroDec = 0;

            try
            {
                //Para obligar a que sólo se introduzcan números
                if (Char.IsControl(e.KeyChar)) //permitir teclas de control como retroceso 
                {
                    e.Handled = false;
                }
                else if (Formato == tbFormato.NoSpace)
                {
                    if (e.KeyChar == (Char)Keys.Space) e.Handled = true;
                }
                else if ((Formato == tbFormato.SoloNumero) || (Formato == tbFormato.NumerosEnteros))
                {
                    if (Char.IsDigit(e.KeyChar)) e.Handled = false;
                    else e.Handled = true;
                }
                else if (Formato == tbFormato.SoloLetra)
                {
                    if (Char.IsLetter(e.KeyChar)) e.Handled = false;
                    else e.Handled = true;
                }
                else if (Formato == tbFormato.LetrasYNumeros)
                {
                    if ((Char.IsLetter(e.KeyChar)) || (Char.IsDigit(e.KeyChar))) e.Handled = false;
                    else e.Handled = true;
                }
                else if ((Formato == tbFormato.Decimal) || (Formato == tbFormato.DecimalPositivo))
                {
                    if (Char.IsControl(e.KeyChar)) e.Handled = false;
                    if (this.Text.Length == 0 && Formato == tbFormato.Decimal && e.KeyChar == 45) e.Handled = false;
                    else if (this.SelectionLength > 0)
                    {
                        if (e.KeyChar >= 48 && e.KeyChar <= 57) e.Handled = false;
                        else if ((Formato == tbFormato.Decimal) && (e.KeyChar == 45)) e.Handled = false;
                        else e.Handled = true;
                    }
                    else
                    {
                        for (int i = 0; i < this.Text.Length; i++)
                        {
                            if (this.Text[i] == '.')
                                IsDec = true;

                            if (IsDec && nroDec++ >= Decimales)
                            {
                                e.Handled = true;
                                return;
                            }
                        }

                        if ((Formato == tbFormato.Decimal) && (this.Text.Length == 0) && (e.KeyChar == 45)) e.Handled = false;
                        else if (e.KeyChar >= 48 && e.KeyChar <= 57)
                            e.Handled = false;
                        else if (e.KeyChar == 46)
                            e.Handled = (IsDec) ? true : false;
                        else
                            e.Handled = true;

                    }
                }
                else if (Formato == tbFormato.NCF)
                {
                    if (this.Text.Length == 0)
                    {
                        if (Char.IsLetter(e.KeyChar)) e.Handled = false;
                        else e.Handled = true;
                    }
                    else
                    {
                        if (Char.IsDigit(e.KeyChar)) e.Handled = false;
                        else e.Handled = true;
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void ELRTextBox_Enter(object sender, EventArgs e)
        {
            ELRUtils util = new ELRUtils();
            try
            {

                if ((Formato == tbFormato.Decimal) || (Formato == tbFormato.DecimalPositivo)) this.Text = util.ConvertirANumero(Text.Trim()).ToString();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                util = null;
            }
        }
    }
}
