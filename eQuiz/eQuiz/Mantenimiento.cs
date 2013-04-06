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
        }

        public void actTabla()
        {
            HttpConexion con = new HttpConexion();
            DataSet resorce = con.ConvertXMLToDataSet("http://localhost:3000/profesores.xml");
            DataTable profesores = resorce.Tables[1];
            for (int i = 0; i <= profesores.Rows.Count - 1; i++)
            {
                this.gridProfes.Rows.Add(profesores.Rows[i].ItemArray[1].ToString(), profesores.Rows[i].ItemArray[4].ToString(),
                profesores.Rows[i].ItemArray[0].ToString(), profesores.Rows[i].ItemArray[6].ToString(), profesores.Rows[i].ItemArray[3].ToString(), profesores.Rows[i].ItemArray[5].ToString());
            }

            //this.gridProfes.DataSource = resorce.Tables[1];
            resorce = con.ConvertXMLToDataSet("http://localhost:3000/estudiantes.xml");
            DataTable estud = resorce.Tables[1];
            for (int i = 0; i <= estud.Rows.Count - 1; i++)
            {
                this.gridEstud.Rows.Add(estud.Rows[i].ItemArray[1].ToString(), estud.Rows[i].ItemArray[4].ToString(),
                estud.Rows[i].ItemArray[0].ToString(), estud.Rows[i].ItemArray[6].ToString(), estud.Rows[i].ItemArray[3].ToString(), estud.Rows[i].ItemArray[5].ToString());
            }
        }

        private void bnCrearProfe_Click(object sender, EventArgs e)
        {
            FormNuevoProf form = new FormNuevoProf();
            form.Show();
        }

        private void bnCrearEstd_Click(object sender, EventArgs e)
        {
            FormNuevoEst form = new FormNuevoEst("2");
            form.Show();
        }

        private void Mantenimiento_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            Application.Exit();
        }
    }
}
