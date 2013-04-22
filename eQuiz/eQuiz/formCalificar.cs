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
    public partial class formCalificar : Form
    {
        private string prueba_id;
        private string respuesta_id;
        Pruebas pruebas = new Pruebas();
        public formCalificar( string prueba_id ,string respuesta_id, string respuestas)
        {
            InitializeComponent();
            this.respuesta_id = respuesta_id;
            this.prueba_id = prueba_id;
            this.cargarPreguntas();
            this.txtRespuestas.Text = respuestas;

        }

        public void cargarPreguntas()
        {
            DataSet resource = pruebas.obtenerPreguntas(this.prueba_id);
            DataSet resource2 = pruebas.getRespuesta(respuesta_id);
            int i = resource.Tables.Count;
            this.txtPreguntas.Text = resource.Tables[0].Rows[0].ItemArray[5].ToString();
            this.lblComentarios.Text = resource.Tables[0].Rows[0].ItemArray[0].ToString();
            this.lblNombre.Text = this.lblNombre.Text + resource.Tables[0].Rows[0].ItemArray[4].ToString();
        }

        private void bnCalificar_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("¿Está seguro desea asignar esta nota a la prueba?","Calificar",MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) 
            {
                Pruebas prueb = new Pruebas();
                if (prueb.calificarPrueba(this.respuesta_id, this.txNota.Value.ToString()))
                {
                    MessageBox.Show("Nota asignada correctamente.");
                    this.Dispose(); this.Close();
                }
            }

        }
    }
}
