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
    public partial class FormNuevoEst : Form
    {
        string ID="";
        public FormNuevoEst()
        {            
            InitializeComponent();
        }
        public FormNuevoEst(string nombre, string apellidos, string cedula, string usuario, string email, string pass, string id)
        {
            this.ID = id;
            InitializeComponent();
            this.txtNombre.Text = nombre;
            this.txtApell.Text = apellidos;
            this.txtCedula.Text = cedula;
            this.txtUsuario.Text = usuario;
            this.txtEmail.Text = email;
            this.txtPass.Text = pass;
            this.txtPass.Hide();
            this.label6.Hide();
            this.bnCrear.Text = "Guardar";
        }
        private void bnCrear_Click(object sender, EventArgs e)
        {
            Estudiante est = new Estudiante();
            if (ID.Equals(""))
            {
                if (est.crear(this.txtNombre.Text, this.txtApell.Text, this.txtCedula.Text, this.txtUsuario.Text, this.txtEmail.Text, this.txtPass.Text))
                {
                    MessageBox.Show("Se guardó correctamente.", "", MessageBoxButtons.OK);
                }
                else
                { MessageBox.Show("Error al guardar.", "", MessageBoxButtons.OK); }
            }
            else
            {
                if (est.edit(this.txtNombre.Text, this.txtApell.Text, this.txtCedula.Text, this.txtUsuario.Text, this.txtEmail.Text, this.txtPass.Text, ID))
                {
                    MessageBox.Show("Se guardó correctamente.", "", MessageBoxButtons.OK);
                }
                else
                { MessageBox.Show("Error al guardar.", "", MessageBoxButtons.OK); }
            }
            this.Dispose();
            this.Close();
        }
    }
}
