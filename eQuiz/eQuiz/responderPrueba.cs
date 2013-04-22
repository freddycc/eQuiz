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
    public partial class responderPrueba : Form
    {
        private string estudiante_id;
        private string prueba_id;
        Pruebas pruebas = new Pruebas();
        public responderPrueba(string prueba_id, string estudiante_id)
        {
            InitializeComponent();
            this.prueba_id = prueba_id;
            this.estudiante_id = estudiante_id;
            this.cargarPreguntas();
        }

        public void cargarPreguntas()
        {
            DataSet resource = pruebas.obtenerPreguntas(this.prueba_id);
            int i = resource.Tables.Count;
            this.txtPreguntas.Text = resource.Tables[0].Rows[0].ItemArray[5].ToString();
            this.lblComentarios.Text = resource.Tables[0].Rows[0].ItemArray[0].ToString();
            this.lblNombre.Text = this.lblNombre.Text + resource.Tables[0].Rows[0].ItemArray[4].ToString();
            this.lblDuracion.Text = "1";// resource.Tables[0].Rows[0].ItemArray[2].ToString();
            int duracion = Int32.Parse(this.lblDuracion.Text);
            duracion = duracion * 60;
            duracion = duracion * 1000;
            this.duracion.Interval = duracion;
            this.duracion.Start();
        }

        private void bnResponder_Click(object sender, EventArgs e)
        {
            Pruebas prueb = new Pruebas();
            var resultado = MessageBox.Show("Las respuestas enviadas no se podran sobrescribir. \n ¿Esta seguro de las respuestas?","Enviar respuestas",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (resultado == DialogResult.Yes)
            {
                if (prueb.crearRespuesta(prueba_id, estudiante_id, this.txtRespuestas.Text))
                {
                    MessageBox.Show("Respuesta enviada correctamente.");
                }
            }
        }

        private void duracion_Tick(object sender, EventArgs e)
        {
            Pruebas prueb = new Pruebas();
            if (prueb.crearRespuesta(prueba_id, estudiante_id, this.txtRespuestas.Text))
            {
                MessageBox.Show("El tiempo para ejecutar la prueba ha terminado. Las respuestas fueron enviadas correctamente.","Tiempo caducado",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                this.duracion.Stop();
                this.Dispose();
                this.Close();
            }
        }

        private void progreso_Tick(object sender, EventArgs e)
        {
            int minutos = Int32.Parse(this.lblTranscurrido.Text) + 1;
            this.lblTranscurrido.Text = minutos + "";
        }
    }
}
