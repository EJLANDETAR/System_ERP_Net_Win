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
    public partial class FormAnularConduceCotizacion : WinControl_ELR_NET.FormPlantillaIndex
    {
        public FormAnularConduceCotizacion()
        {
            InitializeComponent();
        }

        private void FormAnularConduceCotizacion_Load(object sender, EventArgs e)
        {
            cboTipo.SelectedIndex = 0;
            GetData();
        }

        public override void GetData(int opcion = 0)
        {
            try
            {
                if (cboTipo.SelectedIndex == 0) objDB.AddFiltroIgualA("tipo", "CONDUCE");
                else objDB.AddFiltroIgualA("tipo", "COTIZACION");

                base.GetData(opcion);
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string valorUnico = "0";
            int valorId = 0;
            int index = 0;
            DataRow fila0;
            DialogResult resp;
            List<DataDB_ELR_NET.Parametro> parms = new List<DataDB_ELR_NET.Parametro>();
            string temporalId = "";
            int spReturn = 0;

            try
            {
                if(DataGridConsulta.RowCount > 0)
                {
                    index = DataGridConsulta.CurrentRow.Index;
                    if (DataGridConsulta.Columns[e.ColumnIndex] is DataGridViewLinkColumn || DataGridConsulta.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                    {
                        valorUnico = DataGridConsulta["Unico", index].Value.ToString();
                        fila0 = MyData.Select("Unico = " + valorUnico)[0];
                        valorId = objUtil.GetAsInt("Identificador_Id", fila0);

                        resp = objUtil.MostrarMensajePregunta("Esta Seguro que desea Anular este Registro?");

                        if (resp == DialogResult.Yes)
                        {
                            this.Cursor = Cursors.WaitCursor;

                            temporalId = objUtil.GetTemporalID();
                            parms.Add(new DataDB_ELR_NET.Parametro("IdentificadorTemp", temporalId));
                            parms.Add(new DataDB_ELR_NET.Parametro("Id", valorId));
                            parms.Add(new DataDB_ELR_NET.Parametro("Autor", nombreUsuario));

                            objDB.iniciarTransaccion();
                            spReturn = objDB.EjecutarSP("SP_VENTAS_ANULA_CONDUCE_COTIZACION", parms);
                            if (spReturn < 0) MostrarErrorTemporal(temporalId);
                            else
                            {
                                objDB.confirmarTransaccion();
                                GetData();
                            }
                        }


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
            }
        }
    }
}
