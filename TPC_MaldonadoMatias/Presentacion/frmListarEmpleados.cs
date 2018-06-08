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

namespace Presentacion
{
    public partial class frmListarEmpleados : Form
    {
        public frmListarEmpleados()
        {
            InitializeComponent();
        }
        EmpleadoBusiness empleadoBusiness = new EmpleadoBusiness();

        private void frmListarEmpleados_Load(object sender, EventArgs e)
        {
            empleadoBusiness.agregarDgv(dgvListarEmpleado);
        }
    }
}
