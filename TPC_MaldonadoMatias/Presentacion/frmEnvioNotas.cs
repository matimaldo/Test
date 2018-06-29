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
using Dominio;
using System.Net;
using System.Net.Mail;

namespace Presentacion
{
    public partial class frmEnvioNotas : Form
    {
        public frmEnvioNotas()
        {
            InitializeComponent();
        }

        CursadaBusiness cursadaBusiness = new CursadaBusiness();
        ExamenBusiness examenBusiness = new ExamenBusiness();
        MailBusiness mailBusiness = new MailBusiness();

        public Cursada cursada = new Cursada();

        public string Desde = "";
        public string Clave = "";
        public string Hasta = "";
        //public bool Enviar = false;

        private void frmEnvioNotas_Load(object sender, EventArgs e)
        {
            cboCursada.DataSource = cursadaBusiness.listarxProfesor((this.Owner as frmMenu).usuario.Persona.IdPersona);
            cboCursada.ValueMember = "IdCursada";
            cboCursada.DisplayMember = "ACC";
        }

        private void cboCursada_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cboExamen.DataSource = examenBusiness.ListarExamen((Cursada)cboCursada.SelectedItem);
            cboExamen.ValueMember = "IdExamen";
            cboExamen.DisplayMember = "NombreExamen";
        }

        private void cboCursada_SelectedValueChanged(object sender, EventArgs e)
        {
            cboExamen.DataSource = examenBusiness.ListarExamen((Cursada)cboCursada.SelectedItem);
            cboExamen.ValueMember = "IdExamen";
            cboExamen.DisplayMember = "NombreExamen";
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {

            Desde = "maldito.test@gmail.com";
            Clave = "M123456m";
            Hasta = "maldito.test@gmail.com";

            using (SmtpClient cliente = new SmtpClient("smtp.gmail.com", 587))
            //using (SmtpClient cliente = new SmtpClient("smtp.live.com", 25))
            {
                cliente.EnableSsl = true;
                cliente.Credentials = new NetworkCredential(Desde, Clave);
                MailMessage mensaje = new MailMessage(Desde, Hasta, "Nota de Examen", "NOTA 10");

                foreach (string item in mailBusiness.listar())
                {
                    mensaje.Bcc.Add(item.ToString());
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
