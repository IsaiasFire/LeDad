using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LeDad
{
    public partial class VentanaPrincipal : Form
    {
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void btnManejo_Click(object sender, EventArgs e)
        {
            ManejoEstudiantil manejo = new ManejoEstudiantil();
            this.Dispose();
            manejo.Show();
        }

        private void btnListado_Click(object sender, EventArgs e)
        {
            Listado listaDeEstudiantes = new Listado();
            this.Dispose();
            listaDeEstudiantes.Show();
        }
    }
}
