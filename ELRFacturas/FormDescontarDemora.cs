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
    public partial class FormDescontarDemora : WinControl_ELR_NET.FormPlantillaIndex
    {
        public FormDescontarDemora()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = 0;
            string entidadId = "0";
            string cedulaRNC = "";
            string nombreCompleto = "";
            DataRow fila0;
            string temporalId = "";
            int spReturn = -1;
            FormPrestamosDescuentos frm = new FormPrestamosDescuentos();
            List<DataDB_ELR_NET.Parametro> parms = new List<DataDB_ELR_NET.Parametro>();

            try
            {
                if(DataGridConsulta.RowCount > 0)
                {
                    index = DataGridConsulta.CurrentRow.Index;
                    entidadId = DataGridConsulta["Entidad_Id", index].Value.ToString();
                    fila0 = MyData.Select("Entidad_Id = " + entidadId)[0];
                    cedulaRNC = objUtil.GetAsString("CedulaRNC", fila0);
                    nombreCompleto = objUtil.GetAsString("ANombre", fila0);

                    if(DataGridConsulta.Columns[e.ColumnIndex] is DataGridViewLinkColumn || DataGridConsulta.Columns[e.ColumnIndex] is DataGridViewButtonColumn)
                    {
                        temporalId = objUtil.GetTemporalID();
                        parms.Add(new DataDB_ELR_NET.Parametro("IdentificadorTemp", temporalId));
                        parms.Add(new DataDB_ELR_NET.Parametro("IdentificadorId", entidadId));
                        parms.Add(new DataDB_ELR_NET.Parametro("Autor", nombreUsuario));

                        objDB.iniciarTransaccion();
                        spReturn = objDB.EjecutarSP("SP_TEMPORAL_PRESTAMOS_DESCUENTOS", parms);
                        if (spReturn < 0)
                        {
                            MostrarErrorTemporal(temporalId);
                            Cursor = Cursors.Default;
                            return;
                        }
                        else
                        {
                            objDB.confirmarTransaccion();

                            frm.temporalID = temporalId;
                            frm.nombreUsuario = nombreUsuario;
                            frm.EMPRESA_ID = empresaID;
                            frm.OFICINA_ID = oficinaID;
                            //frm.VALOR_ID = entidadId;
                            frm.entidadId = entidadId;
                            frm.cedulaRNC = cedulaRNC;
                            frm.ANombre = nombreCompleto;
                            frm.DTVariablesSYS = DTVariablesSYS;
                            frm.DSGlobal = DSGlobal;
                            frm.EnEjecusion = true;

                            frm.ShowDialog();

                            if (frm.lOK) GetData();
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }
    }
}
