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
    public partial class FormNuevoCurso : Form
    {
        private string ID = "";
        public FormNuevoCurso()
        {
            InitializeComponent();
            this.cargarCombo();
            this.cbxProfe.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        public FormNuevoCurso(string cod, string nombre, string descrip,string profCed, string id)
        {
            this.ID = id;
            InitializeComponent();
            
            this.txtCod.Text = cod;
            this.txtNombre.Text = nombre;
            this.txtDescripcion.Text = descrip;
            this.bnCrear.Text = "Guardar";
            this.cargarCombo();
            for (int i = 0; i <= this.cbxProfe.Items.Count - 1; i++)
            {
                this.cbxProfe.SelectedIndex = i;
                if (this.cbxProfe.SelectedValue.Equals(profCed))
                {                    
                    i = this.cbxProfe.Items.Count - 1;
                }
            }
            this.cbxProfe.DropDownStyle=ComboBoxStyle.DropDownList;
        }
        private void bnCrear_Click(object sender, EventArgs e)
        {
            Cursos curso = new Cursos();
            string pr = this.cbxProfe.SelectedValue.ToString();
            if (ID.Equals(""))
            {
                
                if (curso.crear(this.txtCod.Text, this.txtNombre.Text, this.txtDescripcion.Text, pr))
                {
                    MessageBox.Show("Se creó correctamente.", "", MessageBoxButtons.OK);
                }
                else
                { MessageBox.Show("Error al guardar.", "", MessageBoxButtons.OK); }
            }
            else
            {
                if (curso.edit(this.txtCod.Text, this.txtNombre.Text, this.txtDescripcion.Text, pr, ID))
                {
                    MessageBox.Show("Se guardó correctamente.", "", MessageBoxButtons.OK);
                }
                else
                { MessageBox.Show("Error al guardar.", "", MessageBoxButtons.OK); }
            }            
            this.Dispose();
            this.Close();
        }             

        private void bnCancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }
        public void cargarCombo()
        { 
            HttpConexion cnx = new HttpConexion();

            DataSet resours = cnx.ConvertXMLToDataSet("http://localhost:3000/profesores.xml");
            if (resours != null)
            {
                DataTable profesores = resours.Tables[1];
                
                this.cbxProfe.DataSource = profesores;
                this.cbxProfe.DisplayMember="apellido";
                this.cbxProfe.ValueMember = "cedula";
                /*
                for (int i = 0; i <= profesores.Rows.Count - 1; i++)
                {
                    this.cbxProfe.Items.Add(profesores.Rows[i].ItemArray[4].ToString());
                    
                }*/
            }
        }
    }
}
