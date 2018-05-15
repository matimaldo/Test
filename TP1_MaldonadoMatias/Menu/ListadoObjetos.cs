using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Menu
{
    public partial class ListadoObjetos : Form
    {
        public ListadoObjetos()
        {
            InitializeComponent();
        }

        private void ListadoObjetos_FormClosing(object sender, FormClosingEventArgs e)
        {
            (this.Owner as formMenu).btnListado.Enabled = true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            bool Agregar = true;
            string Item = "";
            string newItem = txtNewItem.Text.ToUpper().TrimStart().TrimEnd();

            if (newItem != "")
            {
                for (int i = 0; i < clbIzquierda.Items.Count; i++)
                {
                    Item = clbIzquierda.Items[i].ToString();
                    if (Item == newItem)
                    {
                        Agregar = false;
                        i = clbIzquierda.Items.Count;
                        MessageBox.Show("Ya Existe Item : " + Item.ToString());
                    }
                }
            } 
            else
            {
                Agregar = false;
                MessageBox.Show("No hay Item para Agregar");
            }
                if (Agregar)
                clbIzquierda.Items.Add(newItem);
                txtNewItem.Text = "";

            txtNewItem.Focus(); // Seleccionar el txtNewItem
        }

        private void btnTrasAll_Click(object sender, EventArgs e)
        {
            bool msj = false;
            string msjTexto = "";
            if (clbIzquierda.Items.Count == 0)
                MessageBox.Show("No hay Items para Trasladar");

            for (int i = 0; i < clbIzquierda.Items.Count; i++)
            {
                clbIzquierda.SetItemChecked(i, true);

                foreach (string itemOtro in clbDerecha.Items)
                {
                    if (clbIzquierda.Items[i].ToString().CompareTo(itemOtro) == 0)
                    {
                        clbIzquierda.SetItemChecked(i, false);
                        msj = true;
                        msjTexto += "\r\n" + clbIzquierda.Items[i].ToString();
                    }
                }
            }

            foreach (string item in clbIzquierda.CheckedItems)
            {
                clbDerecha.Items.Add(item.ToString());
            }

            for (int i = 0; i < clbIzquierda.Items.Count; i++)
            {
                if (clbIzquierda.GetItemChecked(i) == true)
                {
                    clbIzquierda.Items.RemoveAt(i);
                    i = i - 1;
                }
            }

            if(msj)
            {
                MessageBox.Show("Estos Items ya Existen: " + msjTexto);
            }
        }

        private void btnTrasDer_Click(object sender, EventArgs e)
        {
            bool msj = false;
            string msjTexto = "";

            if (clbIzquierda.Items.Count == 0)
                MessageBox.Show("No hay Items para Trasladar");
            else 
            if (clbIzquierda.CheckedItems.Count == 0)
                MessageBox.Show("No hay Items Seleccionado/s");

            for (int i = 0; i < clbIzquierda.Items.Count; i++)
            {

                if(clbIzquierda.GetItemChecked(i) == true)
                {
                    foreach (string itemOtro in clbDerecha.Items)
                    {
                        if (clbIzquierda.Items[i].ToString().CompareTo(itemOtro) == 0)
                        {
                            clbIzquierda.SetItemChecked(i, false);
                            msj = true;
                            msjTexto += "\r\n" + clbIzquierda.Items[i].ToString();
                        }
                    }
                }
            }

            foreach (string item in clbIzquierda.CheckedItems)
            {
                clbDerecha.Items.Add(item.ToString());
            }


            for (int i = 0; i < clbIzquierda.Items.Count; i++)
            {
                if (clbIzquierda.GetItemChecked(i) == true)
                {
                    clbIzquierda.Items.RemoveAt(i);
                    i--;
                }
            }

            if (msj)
            {
                MessageBox.Show("Estos Items ya Existen: " + msjTexto);
            }
        }

        private void btnTrasIzq_Click(object sender, EventArgs e)
        {
            bool msj = false;
            string msjTexto = "";

            if (clbDerecha.Items.Count == 0)
                MessageBox.Show("No hay Items para Trasladar");
            else
            if (clbDerecha.CheckedItems.Count == 0)
                MessageBox.Show("No hay Items Seleccionado/s");

            for (int i = 0; i < clbDerecha.Items.Count; i++)
            {
                if (clbDerecha.GetItemChecked(i) == true)
                {
                    foreach (string itemOtro in clbIzquierda.Items)
                    {
                        if (clbDerecha.Items[i].ToString().CompareTo(itemOtro) == 0)
                        {
                            clbDerecha.SetItemChecked(i, false);
                            msj = true;
                            msjTexto += "\r\n" + clbDerecha.Items[i].ToString();
                        }
                    }
                }
            }

            foreach (string item in clbDerecha.CheckedItems)
            {
                clbIzquierda.Items.Add(item.ToString());
            }


            for (int i = 0; i < clbDerecha.Items.Count; i++)
            {
                if (clbDerecha.GetItemChecked(i) == true)
                {
                    clbDerecha.Items.RemoveAt(i);
                    i--;
                }
            }

            if (msj)
            {
                MessageBox.Show("Estos Items ya Existen: " + msjTexto);
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            if (clbDerecha.Items.Count == 0)
                MessageBox.Show("No hay Items para Borrar");
            else
            if (clbDerecha.CheckedItems.Count == 0)
                MessageBox.Show("No hay Items Seleccionado/s");

            for (int i = 0; i < clbDerecha.Items.Count; i++)
            {
                if (clbDerecha.GetItemChecked(i) == true)
                {
                    clbDerecha.Items.RemoveAt(i);
                    i--;
                }
            }

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNewItem_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;  //esta instrucción hace la magia
                btnAgregar.PerformClick();
                //txtNewItem.Focus();
            }
        }
    }
}
