using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ELRCredito
{
    public partial class FormPrestamosRechazar : WinControl_ELR_NET.FormPlantillaIndex
    {
        public FormPrestamosRechazar()
        {
            InitializeComponent();
        }

        private void FormPrestamosRechazar_Load(object sender, EventArgs e)
        {
            FiltroEstatico = " (Solicitud_Id > 0 And Fecha_Otorgado = '" + objUtil.DateToInt(FECHA_TRABAJO).ToString() + "' And Fecha_Ultimo_Abono Is Null )"; 
        }

        private void dtgData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string valorUnico = "0";
            DataRow myFila = null;
            FormPrestamosRechazarR frmRechazar = new FormPrestamosRechazarR();

            try
            {
                this.Cursor = Cursors.WaitCursor;

                 var senderGrid = (DataGridView)sender;

                 if (senderGrid.Columns[e.ColumnIndex] is DataGridViewLinkColumn &&
                     e.RowIndex >= 0)
                 {
                     //TODO - Button Clicked - Execute Code Here
                     valorUnico = senderGrid["unico", senderGrid.CurrentRow.Index].Value.ToString();

                     //BUSCO LA FILA SELECCIONADA POS SU UNICO
                     myFila = MyData.Select("Unico = " + valorUnico.ToString())[0];
                     frmRechazar.prestamoId = objUtil.GetAsInt("Prestamo_Id", myFila);
                     frmRechazar.monto = objUtil.GetAsDouble("Monto", myFila);
                     frmRechazar.ANombre = objUtil.GetAsString("ANombre", myFila);
                     frmRechazar.nombreUsuario = nombreUsuario;
                     frmRechazar.EnEjecusion = true;

                     frmRechazar.ShowDialog();

                     if (frmRechazar.lOK) GetData();
                 }
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
    }
}
