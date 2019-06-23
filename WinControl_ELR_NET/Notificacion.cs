using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WinControl_ELR_NET
{
    public partial class Notificacion : UserControl
    {
        public delegate void Enviar(string nombreControl, int value);
        public event Enviar onVerMas;
        public int notificacionId = 0;
        public string formAEjecutar = "";
        public enum TipoNotificacion
        {
            Info,
            Error,
            Warning,
            Success,
            Excel,
            DGII,
            Help
        }

        
        public Notificacion(string mensaje, TipoNotificacion tipo, int id, string form)
        {
            InitializeComponent();
            lblMensaje.Text = mensaje;
            notificacionId = id;
            formAEjecutar = form;
            if (tipo == TipoNotificacion.Error)
            {
                BackColor = Color.FromArgb(178, 34, 34);
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Error;
            }
            else if (tipo == TipoNotificacion.Success)
            {
                BackColor = Color.FromArgb(50, 205, 50);
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            }
            else if (tipo == TipoNotificacion.Excel || tipo == TipoNotificacion.DGII)
            {
                BackColor = Color.FromArgb(0, 100, 0);
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            }
            else if (tipo == TipoNotificacion.Warning)
            {
                BackColor = Color.FromArgb(255, 215, 0);
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Warning;
            }
            else
            {
                BackColor = Color.FromArgb(30, 144, 255);
                notifyIcon1.BalloonTipIcon = ToolTipIcon.Info;
            }

            if (mensaje.Length <= 37) Size = new Size(Size.Width, 133);
            else if (mensaje.Length <= 65) Size = new Size(Size.Width, 153);

            notifyIcon1.BalloonTipText = mensaje;
            notifyIcon1.Visible = true;
            notifyIcon1.ShowBalloonTip(100);
            pnBottom.Visible = (tipo != TipoNotificacion.Help);
        }

        private void lnkOcultar_Click(object sender, EventArgs e)
        {
            try
            {
                onVerMas(this.Name, -1);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void lnkVerMas_Click(object sender, EventArgs e)
        {
            try
            {
                onVerMas(this.Name, 1);
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
