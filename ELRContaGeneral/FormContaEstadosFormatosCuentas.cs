using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ELRContaGeneral
{
    public partial class FormContaEstadosFormatosCuentas : WinControl_ELR_NET.FormPlantillaIndex
    {

        public int formulaId = 0;

        public FormContaEstadosFormatosCuentas()
        {
            InitializeComponent();
        }

        public override void GetData(int opcion = 0)
        {
            FiltroEstatico = "Formula_Id = " + formulaId.ToString();

            base.GetData(opcion);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int valorUnico = 0;
            int index = 0;
            DialogResult resp = DialogResult.No;
            try
            {
                if(DataGridConsulta.RowCount > 0)
                {
                    index = DataGridConsulta.CurrentRow.Index;
                    if (DataGridConsulta.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                    {
                        valorUnico = int.Parse( DataGridConsulta["Unico", index].Value.ToString());
                        resp = objUtil.MostrarMensajePregunta("¿Esta Seguro que desea Eliminar esta Cuenta de la Formula?");
                        if (resp == DialogResult.Yes)
                        {
                            objDB.MarcarRegistroEliminado(TablaOVista, valorUnico.ToString(), "Unico");
                            GetData();
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        public override void Agregar()
        {
            FormContaEstadosFormatosCuentasR frm = new FormContaEstadosFormatosCuentasR();

            try
            {
                //base.Agregar();
                frm.formulaId = formulaId;
                frm.OFICINA_ID = oficinaID;
                frm.EMPRESA_ID = empresaID;
                frm.nombreUsuario = nombreUsuario;
                frm.esNuevo = true;

                frm.EnEjecusion = true;
                frm.ShowDialog();

                if (frm.lOK) GetData();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        public override void Modificar()
        {
            FormContaEstadosFormatosCuentasR frm = new FormContaEstadosFormatosCuentasR();
            int valorUnico = 0;

            try
            {
                //base.Modificar();
                if(DataGridConsulta.RowCount > 0)
                {
                    valorUnico = int.Parse( DataGridConsulta["Unico", DataGridConsulta.CurrentRow.Index].Value.ToString() );

                    frm.formulaId = formulaId;
                    frm.OFICINA_ID = oficinaID;
                    frm.EMPRESA_ID = empresaID;
                    frm.nombreUsuario = nombreUsuario;
                    frm.esNuevo = false;
                    frm.VALOR_ID = valorUnico.ToString();

                    frm.EnEjecusion = true;
                    frm.ShowDialog();

                    if (frm.lOK) GetData();
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
            finally
            {
                frm.Dispose();
            }
        }
    }
}
