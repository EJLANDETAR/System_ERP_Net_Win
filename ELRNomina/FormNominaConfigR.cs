using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ELRNomina
{
    public partial class FormNominaConfigR : WinControl_ELR_NET.ELRFormRegistro
    {
        public FormNominaConfigR()
        {
            InitializeComponent();
        }

        public override bool GetData()
        {
            bool resultado = false;
            DataTable DTData;

            try
            {
                //return base.GetData();

                objDB.LimpiarFiltros();
                objDB.AddFiltroIgualA("Empresa_Id", EMPRESA_ID.ToString());
                DTData = objDB.GetAll(TablaEncabezado, 1, objDB.Filtros);
                DTData.TableName = "Encabezado";
                DSDatos.Tables.Add(DTData);

                esNuevo = (DTData.Rows.Count == 0);

                MostrarDataEnControles();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }

            

            return resultado;
        }

        private void btnIrATablaISR_Click(object sender, EventArgs e)
        {
            FormNominaTablaISR frm = new FormNominaTablaISR();

            try
            {
                frm.empresaID = EMPRESA_ID;
                frm.oficinaID = OFICINA_ID;
                frm.EnEjecusion = true;
                frm.nombreUsuario = nombreUsuario;

                frm.ShowDialog();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }
    }
}
