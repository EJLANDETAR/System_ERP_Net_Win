using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinControl_ELR_NET
{
    public partial class ELRFormMensajeErrores : Form
    {
        public string TemporalId = "";
        public  DataDB_ELR_NET.DataDB objDB;
        DataTable MyData;

        public ELRFormMensajeErrores()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ELRFormMensajeErrores_Load(object sender, EventArgs e)
        {
            int Tipo_Error = 0;
            Bitmap bmp;
            ELRUtils objUtil = new ELRUtils();

            try
            {
                objDB.LimpiarFiltros();
                objDB.AddFiltroIgualA("IdentificadorTemp", TemporalId);
                MyData = objDB.GetAll("TSISTEMA_MENSAJES_ERRORES", 1000, objDB.Filtros);
                dtgMensaje.AutoGenerateColumns = false;
                dtgMensaje.DataSource = MyData.DefaultView;
                dtgMensaje.ReadOnly = true;
                

                //CANCELAMOS LA TRANSACCION DE LA BASE DE DATOS
                objDB.cancelarTransaccion();

                //Recorremos el datagrid
                for (int i = 0; i < dtgMensaje.Rows.Count; i++)
                {
                    int.TryParse(dtgMensaje["Tipo_Error", i].Value.ToString(), out Tipo_Error);

                    if (Tipo_Error < 0)
                    {
                        bmp = new Bitmap(Properties.Resources.ErrorFatal);
                    }
                    else
                    {

                        bmp = new Bitmap(Properties.Resources.error);
                    }

                    dtgMensaje["ImgError", i].Value = bmp;

                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                objUtil = null;
            }
        }

        private void dtgMensaje_Click(object sender, EventArgs e)
        {
            
        }

        private void dtgMensaje_SelectionChanged(object sender, EventArgs e)
        {
            ELRUtils objUtil = new ELRUtils();
            int filaId = 0;
            try
            {
                if (dtgMensaje.CurrentRow != null) 
               {
                    filaId = dtgMensaje.CurrentRow.Index;
                    txtMensaje.Text = dtgMensaje["Mensaje", filaId].Value.ToString();
                
               }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                objUtil = null;
            }
        }

        private void ELRFormMensajeErrores_FormClosed(object sender, FormClosedEventArgs e)
        {
            try
            {
                MyData.Dispose();
                objDB = null;
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void chkMostrarSP_CheckedChanged(object sender, EventArgs e)
        {
            dtgMensaje.Columns["Nombre_SP"].Visible = chkMostrarSP.Checked;
            dtgMensaje.Columns["Linea_No"].Visible = chkMostrarSP.Checked;

            if (chkMostrarSP.Checked) WindowState = FormWindowState.Maximized;
            
        }
    }
}
