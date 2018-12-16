using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LeDad.Controladores;

namespace LeDad
{
    public partial class Listado : Form
    {
        public Listado()
        {
            InitializeComponent();
        }

        ControladorEstudiante controlador = new ControladorEstudiante();

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            VentanaPrincipal ventana = new VentanaPrincipal();
            ventana.Show();
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea cerrar la aplicacion?", "LeDad 2.0",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Listado_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controlador.MostrarEstudiantes();
        }
    }
}
