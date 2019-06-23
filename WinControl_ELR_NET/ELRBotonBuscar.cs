using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;

namespace WinControl_ELR_NET
{
    public class ELRBotonBuscar: System.Windows.Forms.Button
    {
        [Category("PropiedadesELR")]
        public string Titulo { get; set; }
        
        [Category("PropiedadesELR")]
        public string TablaOVista { get; set; }

        [Category("PropiedadesELR")]
        public MyColumna[] columnas { get; set; }

        [Category("PropiedadesELR")]
        public List<MostrarBusqueda> AMostrar { get; set; }

        [Category("PropiedadesELR")]
        public string FiltroEstatico { get; set; }

        [Category("PropiedadesELR")]
        public string CondicionABuscar { get; set; }

        [Category("PropiedadesELR")]
        public int Limite { get; set; }

        [Category("PropiedadesELR")]
        public bool EsAutoIncremental { get; set; }

        [Category("PropiedadesELR")]
        public string CondicionOrderBY { get; set; }

        //VARIABLES PUBLICA
       public  DataRow filaSelecionada;
        
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ELRBotonBuscar
            // 
            this.Image = global::WinControl_ELR_NET.Properties.Resources._1378160672_search;
            this.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Text = "Buscar";
            this.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Click += new System.EventHandler(this.ELRBotonBuscar_Click);
            this.ResumeLayout(false);

        }

        public ELRBotonBuscar()
        {
            FiltroEstatico = "";
            CondicionABuscar = "";
            EsAutoIncremental = false;
            Limite = 100;
            CondicionOrderBY = "";
            TablaOVista = "";
            Titulo = "Busqueda General";
            
            this.Text = "Buscar";
            this.Click += new System.EventHandler(this.ELRBotonBuscar_Click);
        }

        public virtual void RealizarBusqueda()
        {
            ELRFormBusquedaGeneral objBusq = new ELRFormBusquedaGeneral();
            filaSelecionada = null;
            try
            {
                objBusq.titulo = Titulo;
                objBusq.TablaOVista = TablaOVista;
                objBusq.Limite = Limite;
                objBusq.FiltroEstatico = FiltroEstatico;
                objBusq.columnas = columnas;
                objBusq.CondicionABuscar = CondicionABuscar;
                objBusq.CondicionOrderBY = CondicionOrderBY;
                objBusq.EsAutoIncremental = EsAutoIncremental;

                objBusq.ShowDialog();
                filaSelecionada = objBusq.FilaSelecionada;
                
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        private void ELRBotonBuscar_Click(object sender, EventArgs e)
        {
            RealizarBusqueda();
        }
    }


    //DEFINIMOS CLASE PARA MOSTRAR RESULTADO EN CONTROLES
    public class MostrarBusqueda
    {
        public string NombreCampoOrigen { get; set; }
        public string NombreCampoDestino { get; set; }
        public DataSet FuenteDatos { get; set; }
        public int TablaIndex { get; set; }
        public ELRTextBox ControlTextBox { get; set; }
        public ELRLabel ControlLabel { get; set; }
        public ELRCombobox ControlCombobox { get; set; }
        public ELRCheckBox ControlCheckBox { get; set; }
        public ELRDatePicker ControlDatePicker { get; set; }

    }

}
