using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ELRControlUsuarios
{
    public partial class FormRoles : WinControl_ELR_NET.FormPlantillaIndex
    {
        public FormRoles()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            string valorUnico = "0";
            string valorId = "0";
            string temporalId = "";
            DataRow fila;
            FormOpcionesXRol frm = new FormOpcionesXRol();
            int spReturn = -1;
            List<DataDB_ELR_NET.Parametro> myParametros = new List<DataDB_ELR_NET.Parametro>();

            try
            {
                this.Cursor = Cursors.WaitCursor;

                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                    e.RowIndex >= 0)
                {
                    //TODO - Button Clicked - Execute Code Here
                    valorUnico = senderGrid["Unico", senderGrid.CurrentRow.Index].Value.ToString();
                    fila = MyData.Select("Unico = " + valorUnico)[0];
                    valorId = objUtil.GetAsString("Rol_Id", fila, "0");

                    //EJECUTAMOS EL STORE PROCEDURE PARA CARGAR AL TEMPORAL
                    temporalId = objUtil.GetTemporalID();
                    myParametros.Add(new DataDB_ELR_NET.Parametro("IdentificadorTemp", temporalId));
                    myParametros.Add(new DataDB_ELR_NET.Parametro("IdentificadorId", valorId));
                    myParametros.Add(new DataDB_ELR_NET.Parametro("Autor", nombreUsuario));

                    objDB.iniciarTransaccion();
                    spReturn = objDB.EjecutarSP("SP_TEMPORAL_OPCIONES_X_ROLES", myParametros);

                    if (spReturn < 0) MostrarErroresSys(temporalId);
                    else objDB.confirmarTransaccion();

                    if (spReturn > 0)
                    {
                        frm.temporalID = temporalId;
                        frm.esNuevo = false;
                        frm.VALOR_ID = fila["Rol_Id"].ToString();
                        frm.nombreUsuario = nombreUsuario;
                        frm.EMPRESA_ID = empresaID;
                        frm.OFICINA_ID = oficinaID;
                        frm.EnEjecusion = true;
                        frm.drRegistroSel = fila;

                        frm.ShowDialog();
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
                objDB.cancelarTransaccion();
            }
        }
    }
}
