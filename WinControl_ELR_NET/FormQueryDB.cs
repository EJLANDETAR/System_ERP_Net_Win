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
    public partial class FormQueryDB : Form
    {
        DataTable DTData = null;
        DataTable DTColumnas = null;
        DataTable DTObjetos = null;
        DataView DVObjetos = null;
        DataDB_ELR_NET.DataDB db = new DataDB_ELR_NET.DataDB();
        public string nombreUsuario = "SYS.ADMIN";
        ELRUtils util = new ELRUtils();

        public FormQueryDB()
        {
            InitializeComponent();
        }

        private void tsbExcel_Click(object sender, EventArgs e)
        {
            FormExportToExcel frm = new FormExportToExcel();
            try
            {
                if (DTData.Rows.Count > 0)
                {
                    frm.DTData = DTData;
                    frm.ShowDialog();
                }
            }
            catch (Exception ex)
            {

                util.MostrarMensajeError(ex.Message);
            }
        }

        void run()
        {
            string SSQL = "";
            try
            {
                Cursor = Cursors.WaitCursor;

                tsbExcel.Enabled = false;
                //SSQL = txtTexto.Text.Trim();
                db.NOMBRE_USUARIO = nombreUsuario;
                DTData = db.GetSQL(SSQL);
                //DGData.DataSource = DTData.DefaultView;
                tsbExcel.Enabled = DTData.Rows.Count > 0;
            }
            catch (Exception ex)
            {

                util.MostrarMensajeError(ex.Message);
            }
            finally
            {
                Cursor = Cursors.Default;
            }
        }

        private void tsbRun_Click(object sender, EventArgs e)
        {
            run();
        }

        private void FormQueryDB_Load(object sender, EventArgs e)
        {
            string SSQL = "";
            try
            {
                db.NOMBRE_USUARIO = nombreUsuario;
                SSQL = "SELECT * FROM VCATALOGO_SQL WHERE Tipo in ('V', 'TB') Order by tipo, object_name ";
                DTObjetos = db.GetSQL(SSQL);

                FiltrarObjetos();

            }
            catch (Exception ex)
            {

                util.MostrarMensajeError(ex.Message);
            }
        }

        void FiltrarObjetos(string name = "")
        {
            try
            {
                if (DVObjetos == null) DVObjetos = DTObjetos.DefaultView;
                DVObjetos.RowFilter = "object_name like '%" + name.Trim() + "%'";
                DTGObjetos.AutoGenerateColumns = false;
                DTGObjetos.CellBorderStyle = DataGridViewCellBorderStyle.None;
                DTGObjetos.DataSource = DVObjetos;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void tstABuscar_KeyUp(object sender, KeyEventArgs e)
        {
            FiltrarObjetos(tstABuscar.Text);
        }

        private void DTGObjetos_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int tablaId = 0, index = 0;
            string SSQL = "";
            try
            {
                if (DTGObjetos == null) return;
                if (DTObjetos.Rows.Count <= 0) return;
                if (DVObjetos.Count <= 0) return;

                index = DTGObjetos.CurrentRow.Index;
                tablaId = int.Parse(DTGObjetos["Tabla_Id", index].Value.ToString());

                SSQL = "SELECT * FROM VCOLUMNAS_SQL WHERE Tabla_Id = " + tablaId.ToString();
                DTColumnas = db.GetSQL(SSQL);
                DTGColumns.AutoGenerateColumns = false;
                DTGColumns.DataSource = DTColumnas.DefaultView;
            }
            catch (Exception ex)
            {

                util.MostrarMensajeError(ex.Message);
            }
        }
    }
}
