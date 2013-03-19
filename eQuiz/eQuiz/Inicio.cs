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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            this.actTabla();
        }

        public void actTabla()
        {
            HttpConexion con = new HttpConexion();
            DataSet resorce = con.ConvertXMLToDataSet("http://localhost:3000/profesores.xml");
            this.gridProfes.DataSource = resorce.Tables[1];

        }

        private void bnCrearProfe_Click(object sender, EventArgs e)
        {
            FormNuevo form = new FormNuevo("1");
            form.Show();
        }

        private void bnCrearEstd_Click(object sender, EventArgs e)
        {
            FormNuevo form = new FormNuevo("2");
            form.Show();
        }
    }
}
