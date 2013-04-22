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
    public partial class FormNuevaPrueba : Form
    {
        public FormNuevaPrueba(string curso_id)
        {
           
            InitializeComponent();
            this.lblIdCurso.Visible = false;
            this.cbxEstado.Items.Add("activa");
            this.cbxEstado.Items.Add("incativa");
            this.cbxEstado.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbxEstado.SelectedIndex = 0;
            this.lblIdCurso.Text = curso_id;
            
        }

        private void FormNuevaPrueba_Load(object sender, EventArgs e)
        {

        }

        private void bnAgregarPreguntas_Click(object sender, EventArgs e)
        {
            this.txtPreguntas.Text = this.txtPreguntas.Text + "\n" + this.txtPregunta.Text;
            this.txtPregunta.Text = "";
        }

        private void bnCrear_Click(object sender, EventArgs e)
        {

            Cursos curso = new Cursos();
            string curso_id = this.lblIdCurso.Text,
                nombre = this.txtNombre.Text,
                estado = this.cbxEstado.SelectedItem.ToString(),
                duracion = this.txtTiempo.Text, 
                fecha = this.dtFecha.Text, 
                comentario = this.txtComentario.Text, 
                preguntas = this.txtPreguntas.Text;
            if (curso.crearPrueba(curso_id,nombre,estado,duracion,comentario,fecha,preguntas))
            {
                MessageBox.Show("La prueba ha sido correctamente creada.");
                this.Dispose();
                this.Close();
            }
        }
    }
}
