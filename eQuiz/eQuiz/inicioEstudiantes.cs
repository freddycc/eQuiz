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
    public partial class inicioEstudiantes : Form
    {
        public inicioEstudiantes()
        {

            InitializeComponent();
            this.actTabla();
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void actTabla()
        {
            HttpConexion con = new HttpConexion();
          
            DataSet resorce = con.ConvertXMLToDataSet("http://localhost:3000/cursos.xml");
            if (resorce != null)
            {
                DataTable cursos = resorce.Tables[1], cursosCombo = new DataTable();
            
                cursosCombo.Columns.Add("nombre", typeof(string));
                cursosCombo.Columns.Add("id", typeof(string));
                for (int i = 0; i <= cursos.Rows.Count - 1; i++)
                {
                    cursosCombo.Rows.Add(cursos.Rows[i].ItemArray[2].ToString(), resorce.Tables[4].Rows[i].ItemArray[1].ToString());
                }
                this.comboBox1.DataSource = cursosCombo;
                this.comboBox1.DisplayMember = "nombre";
                this.comboBox1.ValueMember = "id";
                this.comboBox1.SelectedIndex = 0;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cursos curso = new Cursos();
            this.gridPruebActivas.Rows.Clear();
            string curso_id = this.comboBox1.SelectedValue.ToString();
            DataSet resource = curso.obtenerPruebas(curso_id);
            if (resource != null)
            {
                for (int i = 0; i <= resource.Tables[1].Rows.Count - 1; i++)
                {
                    this.gridPruebActivas.Rows.Add(resource.Tables[1].Rows[i].ItemArray[4].ToString(),
                        resource.Tables[1].Rows[i].ItemArray[3].ToString(),
                        resource.Tables[1].Rows[i].ItemArray[2].ToString(),
                        resource.Tables[1].Rows[i].ItemArray[0].ToString(),
                        resource.Tables[2].Rows[i].ItemArray[1].ToString(),
                        resource.Tables[3].Rows[i].ItemArray[1].ToString());
                }
            }

            this.comboBox1.ValueMember = "id";
        }
    }
}
