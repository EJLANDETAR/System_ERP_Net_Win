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
    public partial class FormVentasNotasCreditos : WinControl_ELR_NET.FormPlantillaIndex
    {

        int Id = 0;
        bool esAplicado = false;
        string nombre = "";

        public FormVentasNotasCreditos()
        {
            InitializeComponent();
        }

        public override void Agregar()
        {
            //base.Agregar();
            FormNCTipo frmTipo = new FormNCTipo();
            FormFacturaDevoluciones frmDev = new FormFacturaDevoluciones();
            FormNCPorDescuento frmDesc = new FormNCPorDescuento();

            try
            {
                frmTipo.ShowDialog();

                if(frmTipo.tipo == 1) //NOTA DE CREDITO POR DEVOLUCION
                {
                    frmDev.tipo = frmTipo.tipo;
                    frmDev.empresaID = empresaID;
                    frmDev.oficinaID = oficinaID;
                    frmDev.nombreUsuario = nombreUsuario;
                    frmDev.DTVariablesSYS = DTVariablesSYS;
                    frmDev.EnEjecusion = true;

                    frmDev.ShowDialog();
                    GetData();
                }
                else if(frmTipo.tipo == 2) //NOTA DE CREDITO POR DESCUENTO
                {
                    frmDesc.tipo = frmTipo.tipo;
                    frmDesc.empresaID = empresaID;
                    frmDesc.oficinaID = oficinaID;
                    frmDesc.nombreUsuario = nombreUsuario;
                    frmDesc.DTVariablesSYS = DTVariablesSYS;
                    frmDesc.EnEjecusion = true;

                    frmDesc.ShowDialog();
                    GetData();
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void FormVentasNotasCreditos_Load(object sender, EventArgs e)
        {
            cboTipo.SelectedIndex = 0;
            GetData();
        }

        public override void GetData(int opcion = 0)
        {
            try
            {
                if (cboTipo.SelectedIndex == 1) objDB.AddFiltroEmpieceEN("TIPO", "DEV");
                else if (cboTipo.SelectedIndex == 2) objDB.AddFiltroEmpieceEN("TIPO", "DESCTO");

                base.GetData(opcion);
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            string comentario = "";
            int index = 0;
            DataRow fila0;
            DataRow[] filas;
            string valorUnico = "0";
            string numero = "0";
            try
            {
                if(DataGridConsulta.RowCount > 0)
                {
                    index = DataGridConsulta.CurrentRow.Index;
                    valorUnico = DataGridConsulta["Unico", index].Value.ToString();
                    filas = MyData.Select("Unico = " + valorUnico);

                    if (filas.Count() > 0)
                    {
                        fila0 = filas[0];
                        numero = objUtil.GetAsString("Identificador_Id", fila0);
                        comentario = "Numero: " + numero + "; " + objUtil.GetAsString("Concepto", fila0);
                    }
                }
                txtComentario.Text = comentario;
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = 0;
            string valorUnico = "0";
            DataRow fila0;
            
            try
            {
                if(DataGridConsulta.RowCount > 0)
                {
                    index = DataGridConsulta.CurrentRow.Index;
                    valorUnico = DataGridConsulta["Unico", index].Value.ToString();
                    fila0 = MyData.Select("Unico = " + valorUnico)[0];
                    Id = objUtil.GetAsInt("Identificador_Id", fila0);
                    esAplicado = objUtil.GetAsBoolean("EsAplicado", fila0);
                    nombre = objUtil.GetAsString("ANombre", fila0);

                    if (DataGridConsulta.Columns[e.ColumnIndex] is DataGridViewButtonColumn) Anular();
                }
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        public override void Anular()
        {
            //base.Anular();
            DialogResult resp;
            string temporalId = "";
            List<DataDB_ELR_NET.Parametro> parms = new List<DataDB_ELR_NET.Parametro>();
            int spReturn = -1;
            string valor = "0";
            try
            {
                if(Id > 0)
                {
                    if (esAplicado)
                    {
                        objUtil.MostrarMensajeAdvertencia("No Puede Anular una Nota de Credito Ya Aplicada");
                        return;
                    }

                    resp = objUtil.MostrarMensajePregunta("Esta Seguro?\r\r" +  "Desea Anular Nota de Credito No.: " + Id.ToString() + "\rA Nombre de: " + nombre);
                    if(resp == DialogResult.Yes)
                    {
                        temporalId = objUtil.GetTemporalID();
                        parms.Add(new DataDB_ELR_NET.Parametro("IdentificadorTemp", temporalId));
                        parms.Add(new DataDB_ELR_NET.Parametro("Id", Id));
                        parms.Add(new DataDB_ELR_NET.Parametro("Autor", nombreUsuario));

                        objDB.iniciarTransaccion();
                        spReturn = objDB.EjecutarSP("SP_VENTAS_ANULAR_NOTA_CREDITO", parms);
                        if (spReturn < 0)
                        {
                            MostrarErrorTemporal(temporalId);
                            objDB.cancelarTransaccion();
                        }
                        else
                        {
                            objDB.confirmarTransaccion();
                            objUtil.MostrarMensajeInformacion("Nota de Credito Anulada de Forma Satisfactoria...");

                            RealizarBusquedaSencilla();

                            //Recorremos los Datos del DataGrid para Ubicarnos en la fila donde esta el Id 
                            for (int i = 0; i < DataGridConsulta.RowCount; i++)
                            {
                                valor = DataGridConsulta["Identificador_Id", i].Value.ToString();
                                if(valor == Id.ToString())
                                {
                                    DataGridConsulta.CurrentCell = DataGridConsulta["Identificador_Id", i];
                                    break;
                                }
                            }
                            
                        }
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        public override void Imprimir()
        {
            string valorId = "0";
            int index = 0;
            DataTable DTData = null;
            WinControl_ELR_NET.ELRFormPreviewRDLC frm = new WinControl_ELR_NET.ELRFormPreviewRDLC();

            try
            {
                if (DataGridConsulta.RowCount <= 0) return;
                if (MyData == null) return;
                if (MyData.Rows.Count <= 0) return;

                index = DataGridConsulta.CurrentRow.Index;
                valorId = DataGridConsulta["Identificador_Id", index].Value.ToString();
                DTData = objDB.GetById("VDEVOLUCIONES_DETALLES", valorId, "Identificador_Id");
                frm.empresaId = empresaID;
                frm.oficinaId = oficinaID;
                frm.nombreUsuario = nombreUsuario;
                frm.DTData = DTData;
                frm.pathReporte = objUtil.GetPathReportRDLC("rptDevolucion");
                frm.titulo = "NOTA DE CREDITO";

                frm.ShowDialog();
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
