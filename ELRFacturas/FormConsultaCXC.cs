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
    public partial class FormConsultaCXC : WinControl_ELR_NET.FormPlantillaIndex
    {
        public FormConsultaCXC()
        {
            InitializeComponent();
        }

        private void FormCuentasPorCobrar_Load(object sender, EventArgs e)
        {
            
        }

        private void dtgData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int unico;
            DataRow myFila;
            WinControl_ELR_NET.ELRFormRegistro frm = null;
            List<DataDB_ELR_NET.Parametro> parms = new List<DataDB_ELR_NET.Parametro>();
            string temporalId = "";
            int spReturn = 0;
            string valorId = "0";

            try
            {
                this.Cursor = Cursors.WaitCursor;

                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewLinkColumn &&
                    e.RowIndex >= 0)
                {
                    //TODO - Button Clicked - Execute Code Here
                    unico = int.Parse(senderGrid["unico", senderGrid.CurrentRow.Index].Value.ToString());

                    //BUSCO LA FILA SELECCIONADA POS SU UNICO
                    myFila = MyData.Select("Unico = " + unico.ToString())[0];
                    valorId = objUtil.GetAsString("Prestamo_Id", myFila, "0");

                    if (proximo == "COBRO") frm = new FormCajaReciboCXC();
                    else if (proximo == "DESCTO")
                    {
                        frm = new FormPrestamosDescuentos();
                        temporalId = objUtil.GetTemporalID();
                        parms.Add(new DataDB_ELR_NET.Parametro("IdentificadorTemp", temporalId));
                        parms.Add(new DataDB_ELR_NET.Parametro("IdentificadorId", valorId));
                        parms.Add(new DataDB_ELR_NET.Parametro("Autor", nombreUsuario));

                        objDB.iniciarTransaccion();
                        spReturn = objDB.EjecutarSP("SP_TEMPORAL_PRESTAMOS_DESCUENTOS", parms);
                        if(spReturn < 0)
                        {
                            MostrarErrorTemporal(temporalId);
                            Cursor = Cursors.Default;
                            return;
                        }
                        else
                        {
                            objDB.confirmarTransaccion();
                            frm.temporalID = temporalId;
                        }
                    }
                    else objUtil.MostrarMensajeError("NO SE HA INDICADO EL EVENTO A REALIZAR PARA ESTA ACCION");

                    if (frm != null)
                    {
                        frm.nombreUsuario = nombreUsuario;
                        frm.EMPRESA_ID = empresaID;
                        frm.OFICINA_ID = oficinaID;
                        frm.VALOR_ID = "0";
                        frm.drRegistroSel = myFila;
                        frm.DTVariablesSYS = DTVariablesSYS;
                        frm.DSGlobal = DSGlobal;
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
                frm = null;
            }
        }
    }
}
