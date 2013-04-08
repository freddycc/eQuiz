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
    public partial class FormNuevoCurso : Form
    {
        private string ID = "";
        public FormNuevoCurso()
        {
            InitializeComponent();
        }
        public FormNuevoCurso(string id, string nombre, string descrip, string cod)
        {
            this.ID = id;
            InitializeComponent();
            this.txtCod.Text = cod;
            this.txtNombre.Text = nombre;
            this.txtDescripcion.Text = descrip;
            this.bnCrear.Text = "Guardar";
        }
        private void bnCrear_Click(object sender, EventArgs e)
        {
            Cursos curso = new Cursos();
            if (ID.Equals(""))
            {
                if (curso.crear(this.txtCod.Text, this.txtNombre.Text, this.txtDescripcion.Text))
                {
                    MessageBox.Show("Se guardó correctamente.", "", MessageBoxButtons.OK);
                }
                else
                { MessageBox.Show("Error al guardar.", "", MessageBoxButtons.OK); }
            }
            else
            {
                if (curso.edit(this.txtCod.Text, this.txtNombre.Text, this.txtDescripcion.Text,ID))
                {
                    MessageBox.Show("Se guardó correctamente.", "", MessageBoxButtons.OK);
                }
                else
                { MessageBox.Show("Error al guardar.", "", MessageBoxButtons.OK); }
            }
            this.Dispose();
            this.Close();
        }             

        private void bnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }        
    }
}
