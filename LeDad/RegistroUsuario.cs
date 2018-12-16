using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LeDad.Modelos;
using LeDad.Controladores;

namespace LeDad
{
    public partial class RegistroUsuario : Form
    {

        Usuario user = new Usuario();
        ControladorUsuario ctrldr = new ControladorUsuario(); 


        public RegistroUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //editar para 
            //crear una pregunta


            Login login = new Login();
            login.Show();
            this.Dispose();
        }
        

        //btn registrar
        private void button2_Click(object sender, EventArgs e)
        {
            
            user.SetNombre(txtNombre.Text);
            user.SetApellido(txtApellido.Text);
            user.SetCedula(txtCedula.Text);
            user.SetCorreo(txtCorreo.Text);
            user.SetNombreUsuario(txtUsuario.Text);
            user.SetClaveAcceso(txtClave.Text);
            
            if (ctrldr.RegistrarUsuario(user))
            {
                MessageBox.Show("Usuario Registrado Exitosamente");
                Login login = new Login();
                login.Show();
                this.Dispose();
            }
            else
            {
                MessageBox.Show("Error de registro");
            }
        }

      
    }
}
