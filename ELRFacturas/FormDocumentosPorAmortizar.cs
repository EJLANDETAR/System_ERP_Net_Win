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
    public partial class FormDocumentosPorAmortizar : WinControl_ELR_NET.FormPlantillaIndex
    {
        public FormDocumentosPorAmortizar()
        {
            InitializeComponent();
        }

        private void dtgData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dtgData.Columns[e.ColumnIndex] is DataGridViewLinkColumn && e.RowIndex >= 0) Modificar();
        }

        public override void Modificar()
        {
            //base.Modificar();
            string valorUnico;
            DataRow MyFila;
            FormAmortizacionR frm = new FormAmortizacionR();
            int index = 0;
            List<DataDB_ELR_NET.Parametro> parms = new List<DataDB_ELR_NET.Parametro>();
            int spReturn = 0;
            string temporalId = "";

            try
            {
                this.Cursor = Cursors.WaitCursor;
                index = dtgData.CurrentRow.Index;
                
                    valorUnico = dtgData["unico", index].Value.ToString();
                    MyFila = MyData.Select("Unico = '" + valorUnico + "'")[0];

                //Ejecutamos el SP PARA Cargar a Temporal
                temporalId = objUtil.GetTemporalID();
                parms.Add(new DataDB_ELR_NET.Parametro("Id", valorUnico));
                parms.Add(new DataDB_ELR_NET.Parametro("IdentificadorTemp", temporalId));
                parms.Add(new DataDB_ELR_NET.Parametro("Autor", nombreUsuario));

                objDB.iniciarTransaccion();
                spReturn = objDB.EjecutarSP("SP_TEMPORAL_AMORTIZACION", parms);
                if (spReturn < 0) MostrarErrorTemporal(temporalId);
                else
                {
                    objDB.confirmarTransaccion();

                    frm.cajaId = 0;
                    frm.nombreUsuario = nombreUsuario;
                    frm.EsConTemporal = true;
                    frm.temporalID = temporalId;
                    frm.EMPRESA_ID = empresaID;
                    frm.OFICINA_ID = oficinaID;
                    frm.VALOR_ID = MyFila["Identificador_Id"].ToString();
                    frm.ValorParmTipo = MyFila["Tipo"].ToString();

                    frm.drRegistroSel = MyFila;

                    frm.EnEjecusion = true;

                    frm.ShowDialog();

                    if (frm.lOK) GetData();
                }

                
            }
            catch (Exception ex)
            {

                objDB.cancelarTransaccion();
                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
                MyFila = null;
                frm.Dispose();
            }
        }
    }
}
