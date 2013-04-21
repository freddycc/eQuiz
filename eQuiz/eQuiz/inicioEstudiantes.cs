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
    }
}
