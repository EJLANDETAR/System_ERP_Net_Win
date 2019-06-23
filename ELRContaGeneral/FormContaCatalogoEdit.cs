using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinControl_ELR_NET;

namespace ELRContaGeneral
{
    public partial class FormContaCatalogoEdit : WinControl_ELR_NET.FormPlantillaIndex
    {
        public FormContaCatalogoEdit()
        {
            InitializeComponent();
        }

        public override void Imprimir()
        {
            //base.Imprimir();
            DataTable DTCatalogo = null;
            string pathReporte = "";
            ELRFormPreviewRDLC frmPreview = new ELRFormPreviewRDLC();

            try
            {
                objDB.LimpiarFiltros();
                objDB.AddFiltroIgualA("Empresa_Id", empresaID.ToString());
                objDB.AddFiltroPersonalizado("Saldo_Actual <> 0");
                objDB.AddFiltroOrderBY("Cuenta_Contable");

                DTCatalogo = objDB.GetAll("TCONTA_CATALOGO", -1, objDB.Filtros);

                //VALIDAMOS QUE EL ARCHIVO DE REPORTE EXISTA
                pathReporte = objUtil.GetPathReportRDLC("RptContaCatalogo");
                if (pathReporte.Trim() != "")
                {

                    frmPreview.DTOficina = DTOficina;
                    frmPreview.DTData = DTCatalogo;
                    frmPreview.nombreUsuario = nombreUsuario;
                    frmPreview.titulo = "Catalogo de Cuentas";
                    frmPreview.pathReporte = pathReporte.Trim();
                    frmPreview.montoLetras = montoLetras;

                    frmPreview.ShowDialog();
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                frmPreview.Dispose();
            }
        }
    }
}
