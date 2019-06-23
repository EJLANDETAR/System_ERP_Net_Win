using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinControl_ELR_NET
{
    public partial class FormSelectOficina : WinControl_ELR_NET.FormPlantillaIndex
    {
        public FormSelectOficina()
        {
            InitializeComponent();
        }

        private void FormSelectOficina_Load(object sender, EventArgs e)
        {
            
        }

        public override void GetData(int opcion = 0)
        {
            
            base.GetData(opcion);
            TablaOVista = " FN_ACCESOS_USUARIOS_X_OFICINAS('" + nombreUsuario + "', " + empresaID.ToString() + "," + Limite.ToString() +") ";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (DataGridConsulta == null) return;
                if (DataGridConsulta.Columns[e.ColumnIndex] is DataGridViewButtonColumn) Seleccionar();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        void Seleccionar()
        {
            int index = 0, selectOficinaId = 0;
            string SSQL = "";
            try
            {
                if (MyData == null) return;
                if (MyData.Rows.Count <= 0) return;
                if (DataGridConsulta == null) return;

                Cursor = Cursors.WaitCursor;

                index = DataGridConsulta.CurrentRow.Index;
                selectOficinaId = int.Parse( DataGridConsulta["Oficina_Id", index].Value.ToString());


                //ACTUALIZAMOS OFICINA_ID EN LA SESSION DEL USUARIO
                SSQL = " UPDATE TACCESOS_SESIONES SET Oficina_Id = " + selectOficinaId.ToString();
                SSQL += " Where Session_Id = " + sessionId.ToString();
                objDB.EjecutarSQL(SSQL);

                oficinaID = selectOficinaId;
                Close();
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

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Seleccionar();
        }
    }
}
