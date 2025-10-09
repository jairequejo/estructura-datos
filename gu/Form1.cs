using Clases;
using Clases.ColaPersonas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gu
{
    public partial class Form1 : Form
    {
        ColaPersona colaDePersonas = new ColaPersona();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncolar_Click(object sender, EventArgs e)
        {
            Persona p = new Persona();
            p.DNI = int.Parse(txtDNI.Text);
            p.Nombre = txtNombre.Text;

            colaDePersonas.Encolar(p);

            txtDNI.Clear();
            txtNombre.Clear();
            MessageBox.Show("Persona encolada");
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Persona p = colaDePersonas.MostrarCola();

            pbFoto.Image = gu.Properties.Resources.peruano01;
            lblNombre.Text = "" + p;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
