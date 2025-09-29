using Clases;
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
        ColaSimple<Persona> colaDePersonas = new ColaSimple<Persona>();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEncolar_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.DNI = int.Parse( txtDNI.Text);
            persona.Nombre = txtNombre.Text;

            colaDePersonas.Encolar(persona);
            MessageBox.Show("Persona encolada");

            txtDNI.Clear();
            txtNombre.Clear();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {

        }
    }
}
