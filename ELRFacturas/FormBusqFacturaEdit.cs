using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ELRFacturas
{
    public partial class FormBusqFacturaEdit : WinControl_ELR_NET.FormPlantillaIndex
    {
        public FormBusqFacturaEdit()
        {
            InitializeComponent();
        }

        public override void GetData(int opcion = 0)
        {
            DateTime feActual = DateTime.Now.Date;
            string aBuscar = "";
            try
            {
                Cursor = Cursors.WaitCursor;
                objDB.LimpiarFiltros();
                objDB.AddFiltroIgualA("EsNulo", "0");
                if (cajaNo > 0) objDB.AddFiltroIgualA("Caja_Id", cajaNo.ToString());
                if (REQUIERE_CIERRE_OPERACIONES) objDB.AddFiltroMayorOIgualA ("Fecha", objDB.DateToInt(objDB.FECHA_TRABAJO).ToString());
                else objDB.AddFiltroMayorOIgualA("Fecha", objDB.DateToInt(feActual).ToString());
                aBuscar = txtABuscar.Text.Trim();
                if (aBuscar != "") objDB.AddFiltroContengaA("CedulaRNC + IsNull(NCF, '') + IsNull(Nombre, '') + Cast(IsNull(Numero, 0) as Varchar)", aBuscar);
                objDB.AddFiltroOrderBY("Unico Desc");
                MyData = objDB.GetAll("TVENTAS", 25, objDB.Filtros);
                DataGridConsulta.AutoGenerateColumns = false;
                DataGridConsulta.DataSource = MyData.DefaultView;
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }
    }
}
