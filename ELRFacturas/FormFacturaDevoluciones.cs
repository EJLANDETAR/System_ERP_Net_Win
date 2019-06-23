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
    public partial class FormFacturaDevoluciones : WinControl_ELR_NET.FormPlantillaIndex
    {
        public int tipo = -1;

        public FormFacturaDevoluciones()
        {
            InitializeComponent();
        }

        private void FormFacturaDevoluciones_Load(object sender, EventArgs e)
        {
           
        }

        public override void GetData(int opcion = 0)
        {
          
            string horaLimite = "0";
            string mensaje = "";
            try
            {
                //AGREGAMOS AL FILTRO ESTATTICO LA CANTIDAD DE HORAS TRANSCURRIDAD LIMITE PARA PERMITIR UNA DEVOLUCION
                horaLimite = objUtil.GetValorVariable("Hora_Limite_Devolucion", DTVariablesSYS, "0");
                mensaje = "NO SE PERMITE DEVOLUCIONES DESPUES DE " + horaLimite + " HORAS";
                lblMensaje.Text = mensaje;
                toolTip1.SetToolTip(lblMensaje, mensaje);

                FiltroEstatico = " C_Horas <= " + horaLimite + " And EsNulo = 0 ";

                base.GetData(opcion);

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            FormFacturaDevolucionesR frm = new FormFacturaDevolucionesR();

            try
            {
                this.Cursor = Cursors.WaitCursor;

                var senderGrid = (DataGridView)sender;

                if (senderGrid.Columns[e.ColumnIndex] is DataGridViewLinkColumn &&
                    e.RowIndex >= 0)
                {
                    /*valorUnico = senderGrid["unico", senderGrid.CurrentRow.Index].Value.ToString();

                    frm.nombreUsuario = nombreUsuario;
                    frm.VALOR_ID = valorUnico;
                    frm.DTVariablesSYS = DTVariablesSYS;
                    frm.OFICINA_ID = oficinaID;
                    frm.EMPRESA_ID = empresaID;
                    frm.DSGlobal = DSGlobal;
                    frm.EnEjecusion = true;


                    frm.ShowDialog();*/
                    EsModificar = true;
                    Modificar();

                    if (tipo > 0) Close();

                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
                frm.Dispose();
            }

        }

    }
}
