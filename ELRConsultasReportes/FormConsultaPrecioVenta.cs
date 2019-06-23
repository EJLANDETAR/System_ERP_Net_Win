using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ELRConsultasReportes
{
    public partial class FormConsultaPrecioVenta : WinControl_ELR_NET.FormPlantillaIndex
    {
        public FormConsultaPrecioVenta()
        {
            InitializeComponent();
        }

        public override void GetData(int opcion = 0)
        {
            string codigo = "", nombreP = "NO ENCONTRADO!!";
            List<DataDB_ELR_NET.Parametro> parms = new List<DataDB_ELR_NET.Parametro>();
            int id = -1;
            try
            {
                Cursor = Cursors.WaitCursor;

                codigo = txtABuscar.Text.Trim();
                if (codigo == "") codigo = "-1";

                parms.Add(new DataDB_ELR_NET.Parametro("Codigo", codigo));
                MyData = objDB.GetFromSP("SP_CLASIFICADORES_PRECIO_VENTA", "", parms);
                dtgPrecio.AutoGenerateColumns = false;
                dtgPrecio.DataSource = MyData.DefaultView;

                MostrarCantidadFilas();

                if(MyData.Rows.Count > 0)
                {
                    id = objDB.GetAsInt("Id", MyData.Rows[0]);
                    nombreP = "     " + objDB.GetAsString("Nombre", MyData.Rows[0]);
                    txtABuscar.Text = "";
                }

                lblNombre.Text = nombreP;
                if (id <= 0) lblNombre.BackColor = Color.Red;
                else lblNombre.BackColor = Color.Green;

                
            }
            catch (Exception ex)
            {

                lblNombre.Text = "     ERROR: " + ex.Message;
                lblNombre.BackColor = Color.Red;
                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
            }

            txtABuscar.SelectAll();
            txtABuscar.Focus();
        }
    }
}
