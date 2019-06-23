using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinControl_ELR_NET
{
    public partial class ELRDatosEntidad : UserControl
    {
        [Category("PropiedadesELR")]
        public string Titulo { get; set; }
        [Category("PropiedadesELR")]
        public string TablaOVista { get; set; }

        ELRUtils objUtil = new ELRUtils();

        public ELRDatosEntidad()
        {
            InitializeComponent();

            Titulo = "";
            TablaOVista = "VENTIDADES";
        }

        public void GetEntidad(string cedulaRNC)
        {
            DataDB_ELR_NET.DataDB db = new DataDB_ELR_NET.DataDB();
            DataTable MyData = null;
            ELRUtils objUtil = new ELRUtils();

            try
            {
                if (Titulo == null) Titulo = "";
                if (Titulo.Trim() != "") lblTitulo.Text = Titulo.Trim().ToUpper();

                db.LimpiarFiltros();
                db.AddFiltroPersonalizado(" REPLACE (CedulaRNC, '-', '') = '" + cedulaRNC.Replace('-', ' ').Trim()  + "'");

                MyData = db.GetAll(TablaOVista, 1, db.Filtros);

                MostrarData(MyData);
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        public void GetEntidadById(int entidadId)
        {
            DataDB_ELR_NET.DataDB db = new DataDB_ELR_NET.DataDB();
            DataTable MyData = null;
            
            try
            {
                if (Titulo == null) Titulo = "";
                if (Titulo.Trim() != "") lblTitulo.Text = Titulo.Trim().ToUpper();

                MyData = db.GetById(TablaOVista, entidadId.ToString(), "Entidad_Id");

                MostrarData(MyData);
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }


        void MostrarData(DataTable MyData)
        {
            DataRow MyFila = null;

            try
            {
                if (MyData.Rows.Count > 0)
                {
                    MyFila = MyData.Rows[0];

                    lblIdentificadorId.Text = objUtil.GetValorFromDR("CedulaRNC", MyFila, "00000000000");
                    lblNombres.Text = objUtil.GetValorFromDR("Nombres", MyFila);
                    lblApellidos.Text = objUtil.GetValorFromDR("Apellidos", MyFila);
                    lblApodos.Text = objUtil.GetValorFromDR("Apodos", MyFila);
                    lblFechaNacimiento.Text = objUtil.GetDateAsString("Fecha_Nacimiento", MyFila);
                    lblNacionalidad.Text = objUtil.GetValorFromDR("Pais_Nacionalidad", MyFila);
                    lblEstadoCivil.Text = objUtil.GetValorFromDR("Estado_Civil_Descripcion", MyFila, "");
                }
                else
                {
                    lblIdentificadorId.Text = "00000000000";
                    lblNombres.Text = "";
                    lblApellidos.Text = "";
                    lblApodos.Text = "";
                    lblFechaNacimiento.Text = "00/00/0000";
                    lblNacionalidad.Text = "";
                    lblEstadoCivil.Text = "";
                }

            }
            catch (Exception)
            {
                
                throw;
            }
        }

    }
}
