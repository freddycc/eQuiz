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
    public partial class FormNuevaPrueba : Form
    {
        public FormNuevaPrueba()
        {
            InitializeComponent();
            this.cbxEstado.Items.Add("activa");
            this.cbxEstado.Items.Add("incativa");
            this.cbxEstado.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void FormNuevaPrueba_Load(object sender, EventArgs e)
        {

        }
    }
}
