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
    public partial class Mantenimiento : Form
    {
        public Mantenimiento()
        {
            InitializeComponent();
            this.actTabla();
            this.bxCursos.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void actTabla()
        {
            HttpConexion con = new HttpConexion();
            DataSet resorce = con.ConvertXMLToDataSet("http://localhost:3000/profesores.xml");
            if (resorce != null){
                DataTable profesores = resorce.Tables[1];
                this.gridProfes.Rows.Clear();
                for (int i = 0; i <= profesores.Rows.Count - 1; i++)
                {
                    this.gridProfes.Rows.Add(profesores.Rows[i].ItemArray[1].ToString(), profesores.Rows[i].ItemArray[4].ToString(),
                    profesores.Rows[i].ItemArray[0].ToString(), profesores.Rows[i].ItemArray[6].ToString(), profesores.Rows[i].ItemArray[3].ToString(), resorce.Tables[3].Rows[i].ItemArray[1].ToString(), profesores.Rows[i].ItemArray[5].ToString());
                }
            }
            //this.gridProfes.DataSource = resorce.Tables[1];
            resorce = con.ConvertXMLToDataSet("http://localhost:3000/estudiantes.xml");
            if (resorce != null){
                DataTable estud = resorce.Tables[1];
                this.gridEstud.Rows.Clear();
                for (int i = 0; i <= estud.Rows.Count - 1; i++)
                {
                    this.gridEstud.Rows.Add(estud.Rows[i].ItemArray[1].ToString(), estud.Rows[i].ItemArray[4].ToString(),
                    estud.Rows[i].ItemArray[0].ToString(), estud.Rows[i].ItemArray[6].ToString(), estud.Rows[i].ItemArray[3].ToString(), resorce.Tables[3].Rows[i].ItemArray[1].ToString());
                }
            }

            resorce = con.ConvertXMLToDataSet("http://localhost:3000/cursos.xml");
            if(resorce!=null){
                DataTable cursos = resorce.Tables[1], cursosCombo = new DataTable();
                this.gridCursos.Rows.Clear();
                cursosCombo.Columns.Add("nombre", typeof(string));
                cursosCombo.Columns.Add("id", typeof(string));
                for (int i = 0; i <= cursos.Rows.Count - 1; i++)
                {
                    this.gridCursos.Rows.Add(resorce.Tables[3].Rows[i].ItemArray[1].ToString(), cursos.Rows[i].ItemArray[2].ToString(), cursos.Rows[i].ItemArray[1].ToString(), resorce.Tables[4].Rows[i].ItemArray[1].ToString(),resorce.Tables[2].Rows[i].ItemArray[1].ToString());
                    cursosCombo.Rows.Add(cursos.Rows[i].ItemArray[2].ToString(), resorce.Tables[4].Rows[i].ItemArray[1].ToString());
                }
                this.bxCursos.DataSource = cursosCombo;
                this.bxCursos.DisplayMember = "nombre";
                this.bxCursos.ValueMember = "id";
                this.bxCursos.SelectedIndex = 0;
            }
        }

        private void bnCrearProfe_Click(object sender, EventArgs e)
        {
            FormNuevoProf form = new FormNuevoProf();
            form.Show();
        }

        private void bnCrearEstd_Click(object sender, EventArgs e)
        {
            FormNuevoEst form = new FormNuevoEst();
            form.Show();
        }

        private void bnCrearCurso_Click(object sender, EventArgs e)
        {
            FormNuevoCurso form = new FormNuevoCurso();
            form.Show();
        }

        private void Mantenimiento_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            Application.Exit();
        }

        private void gridProfes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Profesor prof = new Profesor();
            string accion = this.gridProfes.CurrentCell.Value.ToString();
            int row = Convert.ToInt32(this.gridProfes.CurrentRow.Index);
            string id = this.gridProfes.Rows[row].Cells[5].Value+"";
            if (accion.Equals("Editar") || accion.Equals("Eliminar"))
            {
                if (accion.Equals("Editar"))
                {
                    FormNuevoProf edt = new FormNuevoProf(this.gridProfes.Rows[row].Cells[1].Value + "",
                                                            this.gridProfes.Rows[row].Cells[2].Value + "",
                                                            this.gridProfes.Rows[row].Cells[0].Value + "",
                                                            this.gridProfes.Rows[row].Cells[3].Value + "",
                                                            this.gridProfes.Rows[row].Cells[4].Value + "",
                                                            this.gridProfes.Rows[row].Cells["passProf"].Value + "",
                                                            id);
                    edt.Show();
                }
                else {
                    if (MessageBox.Show("¿Esta seguro de eliminar a " + this.gridProfes.Rows[row].Cells[1].Value+" "+this.gridProfes.Rows[row].Cells[2].Value+"?", "Sure?", 
                        MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        prof.delete(id);
                        actTabla();
                    }                    
                }
            }
        }

        private void gridEstud_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Estudiante estud = new Estudiante();
            string accion = this.gridEstud.CurrentCell.Value.ToString();
            int row = Convert.ToInt32(this.gridEstud.CurrentRow.Index);
            string id = this.gridEstud.Rows[row].Cells[5].Value + "";
            if (accion.Equals("Editar") || accion.Equals("Eliminar"))
            {
                if (accion.Equals("Editar"))
                {
                    FormNuevoEst edt = new FormNuevoEst(this.gridEstud.Rows[row].Cells[1].Value + "",
                                                            this.gridEstud.Rows[row].Cells[2].Value + "",
                                                            this.gridEstud.Rows[row].Cells[0].Value + "",
                                                            this.gridEstud.Rows[row].Cells[3].Value + "",
                                                            this.gridEstud.Rows[row].Cells[4].Value + "",
                                                            this.gridEstud.Rows[row].Cells["passEst"].Value + "",
                                                            id);
                    edt.Show();
                }
                else
                {
                    if (MessageBox.Show("¿Esta seguro de eliminar a " + this.gridEstud.Rows[row].Cells[1].Value + " " + this.gridEstud.Rows[row].Cells[2].Value + "?", "Sure?",
                        MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        estud.delete(id);
                        actTabla();
                    }
                }
            }
        }

        private void gridCursos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Cursos cursos = new Cursos();
            string accion = this.gridCursos.CurrentCell.Value.ToString();
            int row = Convert.ToInt32(this.gridCursos.CurrentRow.Index);
            string id = this.gridCursos.Rows[row].Cells[3].Value + "";
            if (accion.Equals("Editar") || accion.Equals("Eliminar"))
            {
                if (accion.Equals("Editar"))
                {
                    FormNuevoCurso edt = new FormNuevoCurso(this.gridCursos.Rows[row].Cells[0].Value + "",
                                                            this.gridCursos.Rows[row].Cells[1].Value + "",
                                                            this.gridCursos.Rows[row].Cells[2].Value + "",                                                            
                                                            this.gridCursos.Rows[row].Cells["profCed"].Value+"",
                                                            id);
                    edt.Show();
                }
                else
                {
                    if (MessageBox.Show("¿Esta seguro de eliminar a " + this.gridEstud.Rows[row].Cells[1].Value + " " + this.gridEstud.Rows[row].Cells[2].Value + "?", "Sure?",
                        MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        cursos.delete(id);
                        actTabla();
                    }
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            actTabla();
        }        

        private void bnMatriculados_Click(object sender, EventArgs e)
        {
            
            Cursos curso = new Cursos();
            string idcurso = this.bxCursos.SelectedValue.ToString();
            DataSet resource = curso.obtenerEstudiantes(idcurso);
            for (int i = 0; i <= resource.Tables[1].Rows.Count - 1; i++)
            {
                this.gridEstCurs.Rows.Add(resource.Tables[1].Rows[i].ItemArray[1].ToString(),
                    resource.Tables[1].Rows[i].ItemArray[4].ToString(),
                    resource.Tables[1].Rows[i].ItemArray[0].ToString(),
                    resource.Tables[1].Rows[i].ItemArray[3].ToString(),
                    resource.Tables[3].Rows[i].ItemArray[1].ToString());
                this.gridEstCurs.Rows[i].Cells["bnAction"].Value = "Eliminar";
            }

        }       
    }
}
