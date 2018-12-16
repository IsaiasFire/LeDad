using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LeDad.conexion;

namespace LeDad
{
    public partial class Login : Form
    {

        Conexion conexion = new Conexion();

        public Login()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegistroUsuario window = new RegistroUsuario();         
            window.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            conexion.AbrirConexion();
            VentanaPrincipal mainWindow = new VentanaPrincipal();
            this.Hide();
            mainWindow.Show();
        }
    }
}
