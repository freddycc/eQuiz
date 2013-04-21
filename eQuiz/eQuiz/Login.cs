using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eQuiz
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.txtContrasena.Focus();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.txtUsuario.Focus();
        }

        private void bnIniciar_Click(object sender, EventArgs e)
        {
            String user = this.txtUsuario.Text;
            String pass = this.txtContrasena.Text;
            Profesor profesor = new Profesor();
            Boolean prof = profesor.logprof(user, pass);

            if (user.Equals("Admin") && pass.Equals("12345"))
            {
                Mantenimiento inicio = new Mantenimiento();
                inicio.Show();
            }
            else
            {
                if (prof == true)
                {
                    InicioProfe InicioProfe = new InicioProfe();
                    InicioProfe.Show();
                    this.Hide();
                }
                else
                {
                    Boolean est = profesor.logest(user, pass);
                    if (est == true)
                    {
                        inicioEstudiantes inicioEstudiantes = new inicioEstudiantes();
                        inicioEstudiantes.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario Incorrecto, intente de nuevo");
                    }
                }
            }
        }
    }
}
