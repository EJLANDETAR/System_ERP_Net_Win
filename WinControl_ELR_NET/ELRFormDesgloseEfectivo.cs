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
    public partial class ELRFormDesgloseEfectivo : Form
    {
        public int monedaId = 1;
        public string desglose;
        public double montoDesglose = 0.0;
        public bool lOK = false;

        DataTable MyData;
        string COLUMNA_ACTUAL_GRID_DETALLE = "";
        ELRUtils objUtil = new ELRUtils();

        public ELRFormDesgloseEfectivo()
        {
            InitializeComponent();
        }

        private void ELRFormDesgloseEfectivo_Load(object sender, EventArgs e)
        {

            DataDB_ELR_NET.DataDB objDB = new DataDB_ELR_NET.DataDB();
            try
            {
                lblTotal.Text = "0.00";

                MyData = objDB.GetById("VMONEDAS_BILLETES", monedaId.ToString(), "Moneda_Id");
                dtgData.RowTemplate.Height = 40;
                dtgData.AutoGenerateColumns = false;
                dtgData.DataSource = MyData.DefaultView;

                
                dtgData.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(HandlerEditingControlShowing);
                dtgData.CellEnter += new DataGridViewCellEventHandler(HandlerCellEnter);
                dtgData.CellLeave += new DataGridViewCellEventHandler(HandlerCellLeave);

                dtgData.Focus();
                //dtgData.CurrentCell = dtgData["Cantidad", 1];

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }


        private void HandlerEditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            string nombreColumna = "";
            DataColumn item;

            nombreColumna = dtgData.Columns[dtgData.CurrentCell.ColumnIndex].Name;
            TextBox txt;
            txt = (TextBox)e.Control;

            txt.KeyDown -= HandleCellKeyDown;
            txt.KeyPress -= HandleKeyPressInteger;
            txt.KeyPress -= HandleKeyPressDecimal;

            if (MyData.Columns.Contains(nombreColumna))
            {
                item = MyData.Columns[nombreColumna];

                if (item.DataType == typeof(Int16)) txt.KeyPress += new KeyPressEventHandler(HandleKeyPressInteger);
                else if (item.DataType == typeof(Int32)) txt.KeyPress += new KeyPressEventHandler(HandleKeyPressInteger);
                else if (item.DataType == typeof(Int64)) txt.KeyPress += new KeyPressEventHandler(HandleKeyPressInteger);
                else if (item.DataType == typeof(decimal)) txt.KeyPress += new KeyPressEventHandler(HandleKeyPressDecimal);
                else if (item.DataType == typeof(double)) txt.KeyPress += new KeyPressEventHandler(HandleKeyPressDecimal);
            }

            txt.KeyDown += new KeyEventHandler(HandleCellKeyDown);

        }

        public void HandleKeyPressInteger(object sender, KeyPressEventArgs e)
        {
            //Ignora la tecla presionada si no es dígito o tecla de control      
            if (Char.IsDigit(e.KeyChar)) e.Handled = false;
            else if (Char.IsControl(e.KeyChar)) e.Handled = false;
            else e.Handled = true;

        }

        public virtual void HandleCellKeyDown(object sender, KeyEventArgs e)
        {

        }

        public void HandleKeyPressDecimal(object sender, KeyPressEventArgs e)
        {
            bool IsDec = false;
            int nroDec = 0;
            TextBox txt;

            try
            {
                txt = (TextBox)sender;

                if (Char.IsControl(e.KeyChar)) e.Handled = false;
                else if ((txt.SelectionLength > 0) && (e.KeyChar >= 48 && e.KeyChar <= 57)) e.Handled = false;
                else
                {
                    for (int i = 0; i < txt.Text.Length; i++)
                    {
                        if (txt.Text[i] == '.')
                            IsDec = true;

                        if (IsDec && nroDec++ >= 2)
                        {
                            e.Handled = true;
                            return;
                        }
                    }

                    if (e.KeyChar >= 48 && e.KeyChar <= 57)
                        e.Handled = false;
                    else if (txt.Text.Length >= 12)
                        e.Handled = false;
                    else if (e.KeyChar == 46)
                        e.Handled = (IsDec) ? true : false;
                    else
                        e.Handled = true;
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void HandlerCellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataColumn item;

            try
            {
                COLUMNA_ACTUAL_GRID_DETALLE = dtgData.Columns[dtgData.CurrentCell.ColumnIndex].Name.ToUpper();

                if (dtgData.Columns[COLUMNA_ACTUAL_GRID_DETALLE].ReadOnly == false)
                {
                    item = MyData.Columns[COLUMNA_ACTUAL_GRID_DETALLE];

                    if (item.DataType == typeof(decimal)) dtgData.Columns[COLUMNA_ACTUAL_GRID_DETALLE].DefaultCellStyle.Format = "";
                    else if (item.DataType == typeof(double)) dtgData.Columns[COLUMNA_ACTUAL_GRID_DETALLE].DefaultCellStyle.Format = "";


                    dtgData.BeginEdit(true);

                }


            }
            catch (Exception)
            {

                //throw;
            }
        }

        private void HandlerCellLeave(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dtgData.Columns[COLUMNA_ACTUAL_GRID_DETALLE].ReadOnly == false) dtgData.EndEdit();

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }


        private void dtgData_CellValidated(object sender, DataGridViewCellEventArgs e)
        {
            double total = 0;
            string unico = "0";
            double cantidad, valor;
            object calcObject;
            DataRow fila;
            try
            {
                unico = dtgData["Unico", dtgData.CurrentRow.Index].Value.ToString();
                cantidad = objUtil.ConvertirANumero(dtgData["Cantidad", dtgData.CurrentRow.Index].Value.ToString());

                fila = MyData.Select("Unico = " + unico)[0];
                valor = double.Parse(fila["Valor"].ToString());

                total = cantidad * valor;

                fila["Total"] = total;

                //TOTALIZAMOS LOS DATOS
                total = 0;
                calcObject = MyData.Compute("Sum(Total)", "");
                if (calcObject != null)
                {
                    if (calcObject.ToString().Trim() != "") total = double.Parse(calcObject.ToString());

                    lblTotal.Text = total.ToString("N2");
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lOK = false;
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            int i = 0;
            double cantidad;
            try
            {
                montoDesglose = 0;
                desglose = "";
                foreach (DataRow item in MyData.Rows)
                {
                    lOK = true;
                    montoDesglose += double.Parse(item["Total"].ToString());

                    cantidad = double.Parse(item["Cantidad"].ToString());

                    if (cantidad < 0)
                    {
                        lOK = false;
                        objUtil.MostrarMensajeError("NO PUEDE DIGITAR UNA CANTIDAD NEGATIVA");
                        break;
                    }

                    if (cantidad > 0)
                    {
                        if (i == 0) desglose += item["Billete"].ToString() + ":" + item["Cantidad"].ToString();
                        else desglose += ";" + item["Billete"].ToString() + ":" + item["Cantidad"].ToString();

                        i++;
                    }

                }

                if (lOK) this.Close();

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void dtgData_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            double cantidad = 0;
            try
            {
                cantidad = objUtil.ConvertirANumero(dtgData["Cantidad", dtgData.CurrentRow.Index].Value.ToString());
                if (cantidad <= 0) dtgData["Cantidad", dtgData.CurrentRow.Index].Value = 0;
            }
            catch (Exception)
            {

                dtgData.Rows[e.RowIndex].ErrorText = "El dato introducido No es Valido";
                e.Cancel = true;
            }
        }

        private void dtgData_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dtgData.Rows[e.RowIndex].ErrorText = String.Empty;
        }

        private void dtgData_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            objUtil.MostrarMensajeError("Se Ha Prodicido un Error!!");
        }
    }
}
