using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELRFacturas
{
    public partial class FormCuadreOCierreCajas : WinControl_ELR_NET.FormPlantillaIndex
    {
        public FormCuadreOCierreCajas()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            FormCerrarCaja frm = new FormCerrarCaja();
            string valorUnico = "0";
            DataRow myFila = null;
            string aperturaNo = "0";
            int spReturn = -1;
            List<DataDB_ELR_NET.Parametro> myParametros = new List<DataDB_ELR_NET.Parametro>();
            string temporalId = "";

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
                    myFila = MyData.Select("Unico = " + valorUnico )[0];
                    aperturaNo = myFila["Apertura_No"].ToString();
                    cajaNo = objUtil.GetAsInt("Caja_Id", myFila);

                    //Vamos a Ejecutar el SP PARA CARGAR AL TEMPORAL
                    temporalId = objUtil.GetTemporalID();
                    myParametros.Add(new DataDB_ELR_NET.Parametro("Id", aperturaNo));
                    myParametros.Add(new DataDB_ELR_NET.Parametro("IdentificadorTemp", temporalId));
                    myParametros.Add(new DataDB_ELR_NET.Parametro("Autor", nombreUsuario));

                    objDB.iniciarTransaccion();
                    spReturn = objDB.EjecutarSP("SP_TEMPORAL_CIERRE_CAJA", myParametros);
                    if (spReturn < 0)
                    {
                        //MOSTRAMOS ERRORES DEL SISTEMA
                       WinControl_ELR_NET.ELRFormMensajeErrores objMsgERRORES = new WinControl_ELR_NET.ELRFormMensajeErrores();

                        objMsgERRORES.TemporalId = temporalId;
                        objMsgERRORES.objDB = objDB;

                        objMsgERRORES.ShowDialog();
                    }
                    else objDB.confirmarTransaccion();

                    if ( (frm != null) && (spReturn > 0) )
                    {
                        frm.nombreUsuario = nombreUsuario;
                        frm.EMPRESA_ID = empresaID;
                        frm.OFICINA_ID = oficinaID;
                        frm.VALOR_ID = aperturaNo;
                        frm.temporalID = temporalId;
                        frm.cajaId = cajaNo;
                        
                        frm.EnEjecusion = true;

                        frm.ShowDialog();

                        if (frm.lOK) GetData();
                    }

                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
                frm.Dispose();
            }

        }
    }
}
