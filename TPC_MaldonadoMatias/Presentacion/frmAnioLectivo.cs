using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;
using System.Data.SqlClient;

namespace Presentacion
{
    public partial class frmAnioLectivo : Form
    {
        public frmAnioLectivo()
        {
            InitializeComponent();
        }

        AnioLectivoBusiness anioLectivoBusiness = new AnioLectivoBusiness();
        AnioLectivo anio = new AnioLectivo();

        public bool validar()
        {
            foreach (AnioLectivo itemOtro in mlbAnio.Items)
            {
                if (cboAnio.SelectedItem.ToString() == itemOtro.Anio.ToString())
                {
                    MessageBox.Show("Este Año ya existe!");
                    return false;
                }
            }
            return true;
        }

        private void frmAnioLectivo_Load(object sender, EventArgs e)
        {
            
            anio.Anio = DateTime.Today.Year;

            try
            {
                for (int i = anio.Anio - 50; i < anio.Anio + 50; i++)
                {
                    cboAnio.Items.Add(i);
                }

                cboAnio.SelectedItem = anio.Anio;

                mlbAnio.DataSource = anioLectivoBusiness.listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if(validar())
                {
                    anio.Anio = Convert.ToInt32(cboAnio.SelectedItem) ;
                    anioLectivoBusiness.agregar(anio);
                }

                mlbAnio.DataSource = anioLectivoBusiness.listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                anio = (AnioLectivo)mlbAnio.SelectedItem;

                anioLectivoBusiness.eliminar(anio);

                mlbAnio.DataSource = anioLectivoBusiness.listar();
            }
            catch (SqlException ex)
            {
                if (ex.Number == 547)
                    MessageBox.Show("No se puede eliminar porque tiene Cursos Asignados!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnCerrrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
