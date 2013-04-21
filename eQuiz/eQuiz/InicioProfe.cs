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
            }

            //resorce = con.ConvertXMLToDataSet("http://localhost:3000/profesores/12/activas.xml");
            if (resorce != null) 
            {

            }
        }

        private void bnBuscar_Click(object sender, EventArgs e)
        {
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

        private void bnBuscarAct_Click(object sender, EventArgs e)
        {
<<<<<<< HEAD
            this.cargaratvias();
=======
            Cursos curso = new Cursos();
            this.gridPruebActivas.Rows.Clear();
            string curso_id = this.cbxCurs.SelectedValue.ToString();
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
                                resource.Tables[1].Rows[i].ItemArray[1].ToString(),
                                resource.Tables[2].Rows[i].ItemArray[0].ToString(),
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
>>>>>>> b1b0993a2194e35cc618da17645c4fe7b767b284
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
<<<<<<< HEAD
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
             this.cargaratvias();
         }
=======

        private void bnNueva_Click(object sender, EventArgs e)
        {
            string curso_id = this.cbxCurso.SelectedValue.ToString();
            FormNuevaPrueba nueva = new FormNuevaPrueba(curso_id);
            nueva.Show();
        }
>>>>>>> b1b0993a2194e35cc618da17645c4fe7b767b284
    }
}
