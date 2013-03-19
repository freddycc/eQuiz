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
            Inicio inicio = new Inicio();
            inicio.Show();            
            this.Hide();
        }
    }
}
