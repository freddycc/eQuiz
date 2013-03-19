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
    public partial class FormNuevo : Form
    {
        private string rol;
        public FormNuevo(string rol)
        {
            this.rol = rol;
            InitializeComponent();
        }

        private void bnCrear_Click(object sender, EventArgs e)
        {
            string[] var = new string[6];
            string[] valor = new string[6];
            string url = "";        
            var[0] = "nombre";
            valor[0] = this.txtNombre.Text;
            var[1] = "apellido";
            valor[1] = this.txtApell.Text;
            var[2] = "cedula";
            valor[2] = this.txtCedula.Text;
            var[3] = "username";
            valor[3] = this.txtUsuario.Text;
            var[4] = "email";
            valor[4] = this.txtEmail.Text;
            var[5] = "password";
            valor[5] = this.txtPass.Text;

            if(this.rol.Equals("1"))
            {
                url="http://localhost:3000/profesores/add";
            }
            if(this.rol.Equals("2"))
            {
                url = "http://localhost:3000/estudiantes";
            }
            HttpConexion ejecutar = new HttpConexion();
            this.txtResponse.Text = ejecutar.HttpPost(url, var, valor);
        }
    }
}
