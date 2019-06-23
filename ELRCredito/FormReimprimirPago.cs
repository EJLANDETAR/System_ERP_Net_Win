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
    public partial class FormReimprimirPago : WinControl_ELR_NET.FormPlantillaIndex
    {
        DataTable DTData = null, DTDetalle = null;
        string reciboId = "0";
        
        public FormReimprimirPago()
        {
            InitializeComponent();
        }

        public override void Imprimir()
        {
            string valorUnico = "0";
            double monto = 0;
            
            DataRow fila0 = null;
            try
            {
                if (MyData == null) return;
                if (MyData.Rows.Count == 0) return;

                valorUnico = DataGridConsulta["Unico", DataGridConsulta.CurrentRow.Index].Value.ToString();
                fila0 = MyData.Select("Unico = " + valorUnico)[0];
                reciboId = objUtil.GetAsString("Recibo_Id", fila0, "0");
                monto = objUtil.GetAsDouble("Monto", fila0);
                montoLetras = Numalet.ToCardinal(monto);

                DTData = objDB.GetById("VCAJAS_RECIBOS", reciboId, "Recibo_Id");
                DTDetalle = objDB.GetById("TPRESTAMOS_DETALLE_COBRADO", reciboId, "Recibo_Id");

                ImprimirRDLC();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DataGridConsulta.Columns[e.ColumnIndex] is DataGridViewLinkColumn) Imprimir();
        }

        void ImprimirRDLC()
        {
            WinControl_ELR_NET.ELRFormPreviewRDLC frm = new WinControl_ELR_NET.ELRFormPreviewRDLC();
            string pathReporte = "";
            try
            {
                pathReporte = objUtil.GetPathReportRDLC("RptCreditoRecibo");

                frm.pathReporte = pathReporte;

                //Agregamos los DATASET
                frm.AddDS("DSData", DTData);
                frm.AddDS("DSDetalle", DTDetalle);

                frm.montoLetras = montoLetras;
                frm.DTOficina = DTOficina;
                frm.oficinaId = oficinaID;
                frm.empresaId = empresaID;
                frm.nombreUsuario = nombreUsuario;
                frm.titulo = "RECIBO NO.: " + reciboId.PadLeft(7, '0');
                frm.ShowDialog();
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                frm.Dispose();
            }
        }
    }
}
