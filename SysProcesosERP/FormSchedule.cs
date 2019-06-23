using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysProcesosERP
{
    public partial class FormSchedule : WinControl_ELR_NET.FormPlantillaIndex
    {
        public List<Tarea> tareaList = new List<Tarea>();

        public FormSchedule()
        {
            InitializeComponent();
        }

        public override void Agregar()
        {
            FormScheduleR frm = new FormScheduleR();

            try
            {
                frm.OFICINA_ID = oficinaID;
                frm.EMPRESA_ID = empresaID;
                frm.nombreUsuario = nombreUsuario;
                frm.EnEjecusion = true;
                frm.esNuevo = true;
                frm.tareaList = tareaList;

                frm.ShowDialog();

                GetData();
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

        public override void Modificar()
        {
            FormScheduleR frm = new FormScheduleR();
            int valorUnico = 0, index = 0;

            try
            {

                if (MyData == null) return;
                if (MyData.Rows.Count <= 0) return;
                if (DataGridConsulta.Rows.Count <= 0) return;

                index = DataGridConsulta.CurrentRow.Index;
                valorUnico = int.Parse( DataGridConsulta["Unico", index].Value.ToString() );

                frm.OFICINA_ID = oficinaID;
                frm.EMPRESA_ID = empresaID;
                frm.VALOR_ID = valorUnico.ToString();
                frm.nombreUsuario = nombreUsuario;
                frm.EnEjecusion = true;
                frm.esNuevo = false;
                frm.tareaList = tareaList;

                frm.ShowDialog();

                GetData();
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
