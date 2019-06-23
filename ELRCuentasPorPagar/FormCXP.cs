using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ELRCuentasPorPagar
{
    public partial class FormCXP : WinControl_ELR_NET.FormPlantillaIndex
    {
        public FormCXP()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            bool esValido = false;
            string valorId = "0";
            string temporalId = "";
            List<DataDB_ELR_NET.Parametro> MyParametros = new List<DataDB_ELR_NET.Parametro>();
            int spReturn = 0;
            try
            {
                var senderGrid = (DataGridView)sender;
                if (senderGrid.RowCount <= 0) return;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewLinkColumn)
                {
                    esValido = Valida();
                    if (!esValido) return;

                    valorId = senderGrid["Entidad_Id", senderGrid.CurrentRow.Index].Value.ToString();
                    temporalId = objUtil.GetTemporalID();
                    //Agregamos Parametros Para Ejecutar el SP PARA CARGAR A TEMPORAL
                    MyParametros.Add(new DataDB_ELR_NET.Parametro("Id", valorId));
                    MyParametros.Add(new DataDB_ELR_NET.Parametro("IdentificadorTemp", temporalId));
                    MyParametros.Add(new DataDB_ELR_NET.Parametro("Autor", nombreUsuario));

                    this.Cursor = Cursors.WaitCursor;

                    objDB.iniciarTransaccion();
                    spReturn = objDB.EjecutarSP("SP_CXP_PAGO_ATEMPORAL", MyParametros);
                    if (spReturn < 0)
                    {
                        //MOSTRAMOS ERRORES DEL SISTEMA
                        WinControl_ELR_NET.ELRFormMensajeErrores objMsgERRORES = new WinControl_ELR_NET.ELRFormMensajeErrores();

                        objMsgERRORES.TemporalId = temporalId;
                        objMsgERRORES.objDB = objDB;

                        objMsgERRORES.ShowDialog();
                    }
                    else objDB.confirmarTransaccion();

                    if (spReturn > 0)
                    {
                        FormCXPPagoR frm = new FormCXPPagoR();

                        frm.VALOR_ID = valorId;
                        frm.EMPRESA_ID = empresaID;
                        frm.OFICINA_ID = oficinaID;
                        frm.nombreUsuario = nombreUsuario;
                        frm.DSGlobal = DSGlobal;
                        frm.esNuevo = false;
                        frm.temporalID = temporalId;
                        frm.DTVariablesSYS = DTVariablesSYS;

                        frm.EnEjecusion = true;

                        frm.ShowDialog();

                        RealizarBusquedaSencilla();
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
            }
        }

        public override void Imprimir()
        {
            WinControl_ELR_NET.ELRFormPreviewRDLC frm = new WinControl_ELR_NET.ELRFormPreviewRDLC();
            string pathReporte = "";
            try
            {
                pathReporte = objUtil.GetPathReportRDLC("RptCXCPorAntiguedadSaldo2");

                frm.pathReporte = pathReporte;
                frm.DTData = MyData;
                frm.DTOficina = DTOficina;
                frm.oficinaId = oficinaID;
                frm.empresaId = empresaID;
                frm.nombreUsuario = nombreUsuario;
                frm.titulo = "CUENTAS POR PAGAR POR ANTIGUEDAD DE SALDO A FECHA:  " + objUtil.GetDateAsString(DateTime.Now);
                frm.ShowDialog();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                frm.Dispose();
            }
        }

    }
}
