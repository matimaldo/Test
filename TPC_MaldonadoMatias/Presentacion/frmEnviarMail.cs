using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using System.Net;
using System.Net.Mail;


namespace Presentacion
{
    public partial class frmEnviarMail : Form
    {
        public frmEnviarMail()
        {
            InitializeComponent();
        }

        CursadaBusiness cursadaBusiness = new CursadaBusiness();
        MailBusiness mailBusiness = new MailBusiness();

        private void rbtnCurso_CheckedChanged(object sender, EventArgs e)
        {
            if(rbtnCurso.Checked == true)
            {
                cboCursada.Enabled = true;
            }
            else
            {
                cboCursada.Enabled = false;
            }
        }

        private void frmEnviarMail_Load(object sender, EventArgs e)
        {
            cboCursada.DataSource = cursadaBusiness.listar();
            cboCursada.ValueMember = "IdCursada";
            cboCursada.DisplayMember = "ACC";
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Se Envio Correctamente!");
            txtAsunto.Text = "";
            txtDetalle.Text = "";
        }

        private void btnEnviar1_Click(object sender, EventArgs e)
        {
            string Desde="";
            string Clave = "";
            string Hasta = "";
            if (rbtnAcademia.Checked == true)
            {
                Desde = "maldito.test@gmail.com";
                Clave = "M123456m";
            }
            else
            {
                Desde = "maldito.test@gmail.com";
                Clave = "M123456m";
            }

            if (rbtnTodos.Checked == true)
            {
                Hasta = "maldito.test@gmail.com";

            }
            else
            {
                Hasta = "maldito.test@gmail.com";
            }
             using (SmtpClient cliente = new SmtpClient("smtp.gmail.com", 587))
            //using (SmtpClient cliente = new SmtpClient("smtp.live.com", 25))
            {
                cliente.EnableSsl = true;
                cliente.Credentials = new NetworkCredential(Desde, Clave);
                MailMessage mensaje = new MailMessage(Desde, Hasta, txtAsunto.Text, txtDetalle.Text);

                if (rbtnTodos.Checked == true)
                {
                    foreach (string item in mailBusiness.listar())
                    {
                        mensaje.Bcc.Add(item.ToString());
                    }

                }

                try
                {
                    cliente.Send(mensaje);
                    MessageBox.Show("El Correo fue Enviado Correctamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }



    }
}
