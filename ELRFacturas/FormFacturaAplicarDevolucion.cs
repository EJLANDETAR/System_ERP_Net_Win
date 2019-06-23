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
    public partial class FormFacturaAplicarDevolucion : Form
    {

        WinControl_ELR_NET.ELRUtils util = new WinControl_ELR_NET.ELRUtils();
        DataDB_ELR_NET.DataDB db = new DataDB_ELR_NET.DataDB();

        DataTable MyData = null;

        public bool lOK = false;
        public bool esPorEntidad = true;
        public int entidadId = 0;
        public int Id = 0;
        public double monto = 0, itbis = 0;
        public string concepto = "";

        public FormFacturaAplicarDevolucion()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Selecciona();
        }

        void Buscar()
        {
            string numero = "0";
            try
            {
                this.Cursor = Cursors.WaitCursor;

                btnAceptar.Enabled = false;

                numero = txtNumero.Text.Trim();

                if (numero == "") numero = "0";

                db.LimpiarFiltros();

                if (esPorEntidad && entidadId > 0)
                {
                    db.AddFiltroIgualA("Entidad_Id", entidadId.ToString());
                    if(numero != "0") db.AddFiltroIgualA("Identificador_Id", numero);
                }
                else db.AddFiltroIgualA("Identificador_Id", numero);

                db.AddFiltroIgualA("EsAplicado", "0");
                db.AddFiltroIgualA("EsNulo", "0");
                db.AddFiltroMayorA ("Total", "0");
                db.AddFiltroOrderBY("Unico Desc");

                MyData = db.GetAll("TVENTAS_DEVOLUCIONES", -1, db.Filtros);
                dataGridView1.AutoGenerateColumns = false;
                dataGridView1.DataSource = MyData.DefaultView;

                btnAceptar.Enabled = (dataGridView1.RowCount > 0);

            }
            catch (Exception ex)
            {

                util.MostrarMensajeError(ex.Message);
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        void Selecciona()
        {
            string valorUnico = "0";
            DataRow MyFila = null;

            try
            {
                if (dataGridView1.RowCount > 0)
                {
                    valorUnico = dataGridView1["Unico", dataGridView1.CurrentRow.Index].Value.ToString();
                    MyFila = MyData.Select("Unico = " + valorUnico)[0];

                    Id = util.GetAsInt("Identificador_Id", MyFila);
                    monto = util.GetAsDouble("Total", MyFila);
                    itbis = util.GetAsDouble("Total_Itbis", MyFila);
                    concepto =  util.GetAsString("Concepto", MyFila);

                    lOK = true;

                    Close();
                }
            }
            catch (Exception ex)
            {

                util.MostrarMensajeError(ex.Message);
            }
        }

        private void FormFacturaAplicarDevolucion_Load(object sender, EventArgs e)
        {
            btnAceptar.Enabled = false;
            pnEncabezado.Visible = !(esPorEntidad && entidadId > 0);

            if (esPorEntidad) Buscar();
        }

        private void txtNumero_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if ((e.KeyChar == (char)Keys.Enter) || (e.KeyChar == (char)Keys.Tab)) Buscar();
            }
            catch (Exception ex)
            {

                util.MostrarMensajeError(ex.Message);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Selecciona();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Buscar();
        }

    }
}
