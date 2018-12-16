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
using LeDad.conexion;

namespace LeDad
{
    public partial class ManejoEstudiantil : Form
    {
        public ManejoEstudiantil()
        {
            InitializeComponent();
        }


        DateTime fechaActual = DateTime.Today;
        Estudiante estudiante = new Estudiante();
        ControladorEstudiante controlador = new ControladorEstudiante();
        private int edad;
        Conexion con = new Conexion();

       

        public int getEdad(string dia, string mes, string anio)
        {
            int MesEstudiante =0;

            switch (mes)
            {
                case "Enero":
                    MesEstudiante = 1;
                    break;

                case "Febrero":
                    MesEstudiante = 2;
                    break;

                case "Marzo":
                    MesEstudiante = 3;
                    break;

                case "Abril":
                    MesEstudiante = 4;
                    break;

                case "Mayo":
                    MesEstudiante = 5;
                    break;

                case "Junio":
                    MesEstudiante = 6;
                    break;

                case "Julio":
                    MesEstudiante = 7;
                    break;

                case "Agosto":
                    MesEstudiante = 8;
                    break;

                case "Septiembre":
                    MesEstudiante = 9;
                    break;

                case "Octubre":
                    MesEstudiante = 10;
                    break;

                case "Noviembre":
                    MesEstudiante = 11;
                    break;

                case "Diciembre":
                    MesEstudiante = 12;
                    break;
            }

            int DiaEstudiante = int.Parse(dia);
            int AnioEstudiante = int.Parse(anio);

            int anoActual = fechaActual.Year;
            edad = anoActual - AnioEstudiante;
            int mesActual = fechaActual.Month;
            int diaActual = fechaActual.Day;

            if (mesActual < MesEstudiante)
            {
                edad--;
            }
            else if (mesActual == MesEstudiante)
            {
                if (diaActual < DiaEstudiante)
                {
                    edad--;
                }
            }
            Console.WriteLine(edad);
            return edad;
        }



        private void txtMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mes = txtMes.SelectedItem.ToString();

            if (mes.Equals("Enero"))
            {
               for(int i = 1; i <= 31; i++)
                {
                    txtDia.Items.Add(i);
                }
            }

            if (mes.Equals("Febrero"))
            {
                for (int i = 1; i <= 28; i++)
                {
                    txtDia.Items.Add(i);
                }
            }

            if (mes.Equals("Marzo"))
            {
                for (int i = 1; i <= 31; i++)
                {
                    txtDia.Items.Add(i);
                }
            }

            if (mes.Equals("Abril"))
            {
                for (int i = 1; i <= 30; i++)
                {
                    txtDia.Items.Add(i);
                }
            }

            if (mes.Equals("Mayo"))
            {
                for (int i = 1; i <= 31; i++)
                {
                    txtDia.Items.Add(i);
                }
            }

            if (mes.Equals("Junio"))
            {
                for (int i = 1; i <= 3; i++)
                {
                    txtDia.Items.Add(i);
                }
            }

            if (mes.Equals("Julio"))
            {
                for (int i = 1; i <= 31; i++)
                {
                    txtDia.Items.Add(i);
                }
            }

            if (mes.Equals("Agosto"))
            {
                for (int i = 1; i <= 31; i++)
                {
                    txtDia.Items.Add(i);
                }
            }

            if (mes.Equals("Septiembre"))
            {
                for (int i = 1; i <= 30; i++)
                {
                    txtDia.Items.Add(i);
                }
            }

            if (mes.Equals("Octubre"))
            {
                for (int i = 1; i <= 31; i++)
                {
                    txtDia.Items.Add(i);
                }
            }

            if (mes.Equals("Noviembre"))
            {
                for (int i = 1; i <= 30; i++)
                {
                    txtDia.Items.Add(i);
                }
            }

            if (mes.Equals("Diciembre"))
            {
                for (int i = 1; i <= 31; i++)
                {
                    txtDia.Items.Add(i);
                }
            }
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void txtAnio_Click(object sender, EventArgs e)
        {
            for (int i = 1990; i <= fechaActual.Year; i++)
            {
                txtAnio.Items.Add(i);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string FechaEstudiante = txtDia.Text + "/" + txtMes.Text + "/" + txtAnio.Text;


            

            estudiante.SetNombre(txtNombreEstudiante.Text);
            estudiante.SetApellidos(txtApellidoEstudiante.Text);
            estudiante.SetSexo(txtSexoEstudiante.Text);
            estudiante.SetFechaNacimiento(FechaEstudiante);
            estudiante.SetEdad(getEdad(txtDia.SelectedItem.ToString(), txtMes.SelectedItem.ToString(), txtAnio.SelectedItem.ToString()));
            estudiante.SetTutor(txtTutor.Text);
            estudiante.SetTelefonoTutor(txtTelefonoEstudiante.Text);
            
            if (controlador.RegistrarEstudiante(estudiante))
            {
                MessageBox.Show("Estudiante Registrado Exitosamente");
                txtNombreEstudiante.Text = "";
                txtApellidoEstudiante.Text = "";
                txtTutor.Text = "";
                txtTelefonoEstudiante.Text = "";
            }
            else
            {
                MessageBox.Show("Error de registro");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            VentanaPrincipal ventana = new VentanaPrincipal();
            ventana.Show();
            this.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Desea cerrar la aplicacion?", "LeDad 2.0",
                 MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                 == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void dgv_click(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dataGridView1.Rows[e.RowIndex];
            txtEditarID.Text = Convert.ToString(fila.Cells[0].Value); 
            txtEditarNombre.Text = Convert.ToString(fila.Cells[1].Value);
            txtEditarApellido.Text = Convert.ToString(fila.Cells[2].Value); 
            txtEditarTutor.Text = Convert.ToString(fila.Cells[6].Value); 
            txtEditarTelefono.Text = Convert.ToString(fila.Cells[7].Value); 
        }

        private void ManejoEstudiantil_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = controlador.MostrarEstudiantes();
            dataGridView2.DataSource = controlador.MostrarEstudiantes();

        }

        private void txtEditarMes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string mes = txtEditarMes.SelectedItem.ToString();

            if (mes.Equals("Enero"))
            {
                for (int i = 1; i <= 31; i++)
                {
                    txtEditarDia.Items.Add(i);
                }
            }

            if (mes.Equals("Febrero"))
            {
                for (int i = 1; i <= 28; i++)
                {
                    txtEditarDia.Items.Add(i);
                }
            }

            if (mes.Equals("Marzo"))
            {
                for (int i = 1; i <= 31; i++)
                {
                    txtEditarDia.Items.Add(i);
                }
            }

            if (mes.Equals("Abril"))
            {
                for (int i = 1; i <= 30; i++)
                {
                    txtEditarDia.Items.Add(i);
                }
            }

            if (mes.Equals("Mayo"))
            {
                for (int i = 1; i <= 31; i++)
                {
                    txtEditarDia.Items.Add(i);
                }
            }

            if (mes.Equals("Junio"))
            {
                for (int i = 1; i <= 3; i++)
                {
                    txtEditarDia.Items.Add(i);
                }
            }

            if (mes.Equals("Julio"))
            {
                for (int i = 1; i <= 31; i++)
                {
                    txtEditarDia.Items.Add(i);
                }
            }

            if (mes.Equals("Agosto"))
            {
                for (int i = 1; i <= 31; i++)
                {
                    txtEditarDia.Items.Add(i);
                }
            }

            if (mes.Equals("Septiembre"))
            {
                for (int i = 1; i <= 30; i++)
                {
                    txtEditarDia.Items.Add(i);
                }
            }

            if (mes.Equals("Octubre"))
            {
                for (int i = 1; i <= 31; i++)
                {
                    txtEditarDia.Items.Add(i);
                }
            }

            if (mes.Equals("Noviembre"))
            {
                for (int i = 1; i <= 30; i++)
                {
                    txtEditarDia.Items.Add(i);
                }
            }

            if (mes.Equals("Diciembre"))
            {
                for (int i = 1; i <= 31; i++)
                {
                    txtEditarDia.Items.Add(i);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            string FechaEstudiante = txtEditarDia.Text + "/" + txtEditarMes.Text + "/" + txtEditarAnio.Text;


            estudiante.SetNombre(txtEditarNombre.Text);
            estudiante.SetApellidos(txtEditarApellido.Text);
            estudiante.SetSexo(txtEditarSexo.Text);
            estudiante.SetFechaNacimiento(FechaEstudiante);
            estudiante.SetEdad(getEdad(txtEditarDia.SelectedItem.ToString(), txtEditarMes.SelectedItem.ToString(), txtEditarAnio.SelectedItem.ToString()));
            estudiante.SetTutor(txtEditarTutor.Text);
            estudiante.SetTelefonoTutor(txtEditarTelefono.Text);

            try
            {
                controlador.AtualizarEstudiante(estudiante);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error " + ex);
            }
                //if (controlador.AtualizarEstudiante(estudiante))
                //{
                //    MessageBox.Show("Estudiante Actualizado Exitosamente");
                //    txtEditarNombre.Text = "";
                //    txtEditarApellido.Text = "";
                //    txtEditarTutor.Text = "";
                //    txtEditarTelefono.Text = "";

                //    dataGridView1.DataSource = controlador.MostrarEstudiantes();
                //    dataGridView2.DataSource = controlador.MostrarEstudiantes();
                //}

                //else
                //{
                //    Console.WriteLine("Error de registro" );
                //}         
        }

        private void EditarAnioClick(object sender, EventArgs e)
        {
            for (int i = 1990; i <= fechaActual.Year; i++)
            {
                txtEditarAnio.Items.Add(i);
            }
        }

        private void dgvClic(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dataGridView2.Rows[e.RowIndex];
            txtBorrar.Text = Convert.ToString(fila.Cells[0].Value);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea borrar este estudiante?", "LeDad 2.0",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                == DialogResult.Yes)
            {

                if (controlador.EliminarEstudiante(txtBorrar.Text))
                {
                    MessageBox.Show("Esutdiante Eliminado Correctamente.");
                    dataGridView1.DataSource = controlador.MostrarEstudiantes();
                    dataGridView2.DataSource = controlador.MostrarEstudiantes();
                }
                else
                {
                    MessageBox.Show("Error al borrar el estudiante");
                }
            }
                
        }
    }
}
