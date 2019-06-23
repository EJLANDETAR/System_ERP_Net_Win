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
    public partial class FormUsuarios : WinControl_ELR_NET.FormPlantillaIndex
    {
        public FormUsuarios()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string valorUnico = "0";
            DataRow fila;
            FormRolesUsuarioR frm = new FormRolesUsuarioR();
            FormUsuarioOficinas frmOficinas = new FormUsuarioOficinas();
            string temporalId = "";
            string valorId = "";
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
                    valorId = objUtil.GetAsString("Nombre_Usuario", fila, "0");

                    if (senderGrid.Columns[e.ColumnIndex] == btnRoles)
                    {
                        //EJECUTAMOS EL STORE PROCEDURE PARA CARGAR AL TEMPORAL
                        temporalId = objUtil.GetTemporalID();
                        myParametros.Add(new DataDB_ELR_NET.Parametro("IdentificadorTemp", temporalId));
                        myParametros.Add(new DataDB_ELR_NET.Parametro("IdentificadorId", valorId));
                        myParametros.Add(new DataDB_ELR_NET.Parametro("Autor", nombreUsuario));

                        objDB.iniciarTransaccion();
                        spReturn = objDB.EjecutarSP("SP_TEMPORAL_ROLES_X_USUARIO", myParametros);

                        if (spReturn < 0) MostrarErroresSys(temporalId);
                        else objDB.confirmarTransaccion();

                        if (spReturn > 0)
                        {
                            frm.temporalID = temporalId;
                            frm.esNuevo = false;
                            frm.VALOR_ID = valorId;
                            frm.nombreUsuario = nombreUsuario;
                            frm.EMPRESA_ID = empresaID;
                            frm.OFICINA_ID = oficinaID;
                            frm.EnEjecusion = true;
                            frm.drRegistroSel = fila;

                            frm.ShowDialog();
                        }
                    }


                    if (senderGrid.Columns[e.ColumnIndex] == btnOficinas)
                    {
                        frmOficinas.VALOR_ID = valorId;
                        frmOficinas.nombreUsuario = nombreUsuario;
                        frmOficinas.EMPRESA_ID = empresaID;
                        frmOficinas.OFICINA_ID = oficinaID;
                        frmOficinas.EnEjecusion = true;


                        frmOficinas.ShowDialog();
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
