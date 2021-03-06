﻿using System;
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

namespace Presentacion
{
    public partial class frmTomarLista : Form
    {
        private int usuario;

        public frmTomarLista()
        {
            InitializeComponent();
        }

        public frmTomarLista(int usuario)
        {
            this.usuario = usuario;
            InitializeComponent();
        }

        CursadaBusiness cursadaBusiness = new CursadaBusiness();
        public Cursada cursada = new Cursada();

        private void Boton_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;

            cursada = cursadaBusiness.cursadaIrA(4, int.Parse(B.Name));

            frmTomarListaCursada frm = new frmTomarListaCursada();
            frm.Owner = this;
            frm.ShowDialog();
        }

        private void frmTomarLista_Load(object sender, EventArgs e)
        {
            int x = 25, y = 30;
            //foreach (Cursada item in cursadaBusiness.listarxProfesor((this.Owner as frmMenu).usuario.Persona.IdPersona))
            foreach (Cursada item in cursadaBusiness.listarxProfesor(usuario))
            {
                Button boton = new Button();
                boton.Size = new System.Drawing.Size(200, 23);
                boton.Text = item.Curso.NombreCurso +" - " + item.Comision.NombreComision + " - "+ item.Anio.Anio;
                boton.Location = new Point(x,y);
                y += 25;    
                boton.Click += Boton_Click;
                boton.Name = item.IdCursada.ToString();
                this.Controls.Add(boton);
            }
        }
    }
}
