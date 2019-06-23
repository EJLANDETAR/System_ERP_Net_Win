using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Mail;

namespace WinControl_ELR_NET
{
    public class Correos
    {

        /*
        * Cliente SMTP
        * Gmail:  smtp.gmail.com  puerto:587
        * Hotmail: smtp.live.com puerto:25
         * Outlokk: smtp-mail.outlook.com:587 
        */

        public enum tbSMTP
        {
            Gmail,
            Hotmail,
            outlook
        }

        public tbSMTP Smtp { get; set; }

        SmtpClient server;

        public Correos()
        {
            Smtp = tbSMTP.Gmail;
            server = new SmtpClient("smtp.gmail.com", 587);
        }

        public Correos(tbSMTP MySmtp)
        {
            Smtp = MySmtp;

            if (Smtp == tbSMTP.Gmail) server = new SmtpClient("smtp.gmail.com", 587);
            else if (Smtp == tbSMTP.Hotmail) server = new SmtpClient("smtp.live.com", 25);
            else server = new SmtpClient("smtp-mail.outlook.com", 587);
        }

        public void SetCredenciales(string email, string contrasena)
        {
            server.EnableSsl = true;
            server.DeliveryMethod = SmtpDeliveryMethod.Network;
            server.UseDefaultCredentials = false;
            server.Credentials = new System.Net.NetworkCredential(email, contrasena);           
        }

        public void MandarCorreo(MailMessage mensaje)
        {
            server.Send(mensaje);
        }

    }
}
