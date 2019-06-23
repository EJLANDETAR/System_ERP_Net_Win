using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinControl_ELR_NET
{
    public partial class FormSelectImage : Form
    {

        public string nombreImagen = "";
        public string pathImagen = "";

        ELRUtils objUtil = new ELRUtils();

        public FormSelectImage()
        {
            InitializeComponent();
        }

        private void FormSelectImage_Load(object sender, EventArgs e)
        {
            string sKey = "";
            int i = 0;
            string nombreImagen;

            try
            {
                this.listView1.View = View.LargeIcon;
                this.imageList1.ImageSize = new Size(120, 100);
                this.listView1.LargeImageList = this.imageList1;
                
                DirectoryInfo dir = new DirectoryInfo(Application.StartupPath + @"\images");
                lblCarpetaImagenes.Text = dir.ToString();

                foreach (FileInfo file in dir.GetFiles())
                {
                    sKey = "img" + i.ToString();
                    nombreImagen = file.Name;

                    this.imageList1.Images.Add(sKey, Image.FromFile(file.FullName));

                    ListViewItem item = new ListViewItem();

                    item.ImageIndex = i;
                    item.Text = nombreImagen;
                    item.Tag = file.FullName;

                    this.listView1.Items.Add(item);

                    i++;
                }

            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void SelectImage()
        {
            try
            {
                nombreImagen = "";
                pathImagen = "";
                
                if (listView1.Items.Count > 0)
                {
                    if (listView1.SelectedItems.Count > 0)
                    {
                        ListViewItem item = listView1.SelectedItems[0];
                        nombreImagen = item.Text;
                        pathImagen = item.Tag.ToString();

                        Close();
                    }
                }
            }
            catch (Exception)
            {

                nombreImagen = "";
                pathImagen = "";
                throw;
            }
        }

        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                SelectImage();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            try
            {
                SelectImage();
            }
            catch (Exception ex)
            {

                objUtil.MostrarMensajeError(ex.Message);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
