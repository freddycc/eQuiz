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
    public partial class InicioProfe : Form
    {
        HttpConexion con = new HttpConexion();
        public InicioProfe()
        {
            InitializeComponent();
            this.actTablas();
            this.cbxCurso.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbxCurs.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cbxCursoResp.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void actTablas()
        {
            DataSet resorce = con.ConvertXMLToDataSet("http://localhost:3000/cursos.xml");
            if (resorce != null)
            {
                DataTable cursos = resorce.Tables[1], cursosCombo = new DataTable();
                
                cursosCombo.Columns.Add("nombre", typeof(string));
                cursosCombo.Columns.Add("id", typeof(string));
                for (int i = 0; i <= cursos.Rows.Count - 1; i++)
                {
                    //this.gridCursos.Rows.Add(resorce.Tables[3].Rows[i].ItemArray[1].ToString(), cursos.Rows[i].ItemArray[2].ToString(), cursos.Rows[i].ItemArray[1].ToString(), resorce.Tables[4].Rows[i].ItemArray[1].ToString(), resorce.Tables[2].Rows[i].ItemArray[1].ToString());
                    cursosCombo.Rows.Add(cursos.Rows[i].ItemArray[2].ToString(), resorce.Tables[4].Rows[i].ItemArray[1].ToString());
                }
                this.cbxCurso.DataSource = cursosCombo;
                this.cbxCurso.DisplayMember = "nombre";
                this.cbxCurso.ValueMember = "id";
                this.cbxCurso.SelectedIndex = 0;
                this.cbxCurs.DataSource = cursosCombo;
                this.cbxCurs.DisplayMember = "nombre";
                this.cbxCurs.ValueMember = "id";
                this.cbxCurs.SelectedIndex = 0;
                this.cbxCursoResp.DataSource = cursosCombo;
                this.cbxCursoResp.DisplayMember = "nombre";
                this.cbxCursoResp.ValueMember = "id";
                this.cbxCursoResp.SelectedIndex = 0;
            }

            //resorce = con.ConvertXMLToDataSet("http://localhost:3000/profesores/12/activas.xml");
            if (resorce != null) 
            {

            }
        }

        private void bnBuscar_Click(object sender, EventArgs e)
        {
            this.cargarPruebas();
        }

        private void bnBuscarAct_Click(object sender, EventArgs e)
        {

            this.cargaratvias();

            

        }
         private void gridPruebActivas_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Estudiante estud = new Estudiante();
            int row = Convert.ToInt32(this.gridPruebActivas.CurrentRow.Index);
            string id = this.gridPruebActivas.Rows[row].Cells[5].Value + "";

            FormNuevoActivo edt = new FormNuevoActivo(id);
            edt.Show();
           // MessageBox.Show("Prueba Activada");

            
        }
         public void cargarRespuestas()
         {
             string curso_id = this.cbxCurso.SelectedValue.ToString();
             Cursos c = new Cursos();
             Pruebas p = new Pruebas();
             DataSet pruebas = c.obtenerPruebas(curso_id), respuestas, estudiante;
             if (pruebas != null)
             {
                 //resource.Tables[5].Rows[i].ItemArray[1].ToString());
                 for (int i = 0; i <= pruebas.Tables[1].Rows.Count - 1; i++)
                 {
                     string idprueba = pruebas.Tables["id"].Rows[i].ItemArray[1].ToString();
                     respuestas = p.obtenerRespuestas(idprueba);
                     if (respuestas != null)
                     {
                         if (respuestas.Tables.Count > 7)
                         {
                             for (int j = 0; j <= respuestas.Tables[1].Rows.Count - 1; j++)
                             {
                                 string idrespuesta = respuestas.Tables["id"].Rows[j].ItemArray[1].ToString();
                                 estudiante = p.estuduateResp(idrespuesta);
                                 if (respuestas.Tables["calificacion"].Rows[j].ItemArray[0].ToString().Equals("true"))
                                 {
                                     this.gridPruebCalif.Rows.Add(pruebas.Tables[1].Rows[i].ItemArray[4].ToString(),
                                         pruebas.Tables[1].Rows[i].ItemArray[0].ToString(),
                                         estudiante.Tables[0].Rows[0].ItemArray[4].ToString(),
                                         estudiante.Tables[0].Rows[0].ItemArray[1].ToString(),
                                         estudiante.Tables[0].Rows[0].ItemArray[3].ToString(),
                                         idrespuesta, idprueba, respuestas.Tables[1].Rows[j].ItemArray[1].ToString());
                                 }
                             }
                         }
                         else
                         {

                         }
                     }
                 }
             }
         }
         public void cargarPruebas() {
             Cursos curso = new Cursos();
             this.gridPruebas.Rows.Clear();
             string curso_id = this.cbxCurs.SelectedValue.ToString();
             DataSet resource = curso.obtenerPruebas(curso_id);
             if (resource != null)
             {
                 for (int i = 0; i <= resource.Tables[1].Rows.Count - 1; i++)
                 {
                     this.gridPruebas.Rows.Add(resource.Tables[1].Rows[i].ItemArray[4].ToString(),
                         resource.Tables[1].Rows[i].ItemArray[3].ToString(),
                         resource.Tables[1].Rows[i].ItemArray[2].ToString(),
                         resource.Tables[1].Rows[i].ItemArray[0].ToString(),
                         resource.Tables[2].Rows[i].ItemArray[1].ToString(),
                         resource.Tables[3].Rows[i].ItemArray[1].ToString());
                 }
             }
         }
         public void cargaratvias() {
             Cursos curso = new Cursos();
             this.gridPruebActivas.Rows.Clear();
             string curso_id = this.cbxCurso.SelectedValue.ToString();
             DataSet resource = curso.obtenerPruebInactivas(curso_id);
             if (resource != null)
             {
                 if (resource.Tables.Count < 8)
                 {
                     for (int i = 0; i <= resource.Tables[1].Rows.Count - 1; i++)
                     {
                         this.gridPruebActivas.Rows.Add(resource.Tables[1].Rows[i].ItemArray[4].ToString(),
                                 resource.Tables[1].Rows[i].ItemArray[3].ToString(),
                                 resource.Tables[1].Rows[i].ItemArray[2].ToString(),
                                 resource.Tables[1].Rows[i].ItemArray[0].ToString(),
                             //resource.Tables[1].Rows[i].ItemArray[1].ToString(),
                                 resource.Tables[2].Rows[i].ItemArray[1].ToString(),
                                 resource.Tables[5].Rows[i].ItemArray[1].ToString());
                     }
                 }
                 else
                 {
                     for (int i = 0; i <= resource.Tables[1].Rows.Count - 1; i++)
                     {
                         if (resource.Tables[2].Rows[i].ItemArray[0].Equals("true"))
                         { }
                         else
                         {
                             this.gridPruebActivas.Rows.Add(resource.Tables[9].Rows[i].ItemArray[1].ToString(),
                                 resource.Tables[6].Rows[i].ItemArray[1].ToString(),
                                 resource.Tables[5].Rows[i].ItemArray[1].ToString(),
                                 resource.Tables[2].Rows[i].ItemArray[1].ToString(),
                                 resource.Tables[3].Rows[i].ItemArray[1].ToString(),
                                 resource.Tables[8].Rows[i].ItemArray[1].ToString());
                         }
                     }
                 }
             }
         }

         private void InicioProfe_Activated(object sender, EventArgs e)
         {
             this.cargarPruebas();
             this.cargaratvias();
             this.cargarRespuestas();
         }


        private void bnNueva_Click(object sender, EventArgs e)
        {
            string curso_id = this.cbxCurso.SelectedValue.ToString();
            FormNuevaPrueba nueva = new FormNuevaPrueba(curso_id);
            nueva.Show();
        }

        private void bnBusRespuestas_Click(object sender, EventArgs e)
        {
            this.cargarRespuestas();
        }

        private void gridPruebCalif_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = Convert.ToInt32(this.gridPruebCalif.CurrentRow.Index);
            string respuesta_id = this.gridPruebCalif.Rows[row].Cells[5].Value + "";
            string prueba_id = this.gridPruebCalif.Rows[row].Cells[6].Value + "";
            string respuestas = this.gridPruebCalif.Rows[row].Cells[7].Value + "";
            formCalificar calificar = new formCalificar(prueba_id, respuesta_id,respuestas);
            calificar.Show();
        }

    }
}
