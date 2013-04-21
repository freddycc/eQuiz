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
    public partial class FormNuevoActivo : Form
    {
        string ID = "";
        public FormNuevoActivo(String id)
        {
            InitializeComponent();
            this.ID = id;
           
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            Profesor prof = new Profesor();
            prof.editinactivo(ID);
            this.Close();
            this.Dispose();
        }
    }
}
