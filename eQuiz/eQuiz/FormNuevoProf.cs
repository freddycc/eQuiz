﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace eQuiz
{
    public partial class FormNuevoProf : Form
    {
        string ID = "";
        public FormNuevoProf()
        {
            InitializeComponent();
        }
        public FormNuevoProf(string nombre, string apellidos, string cedula, string usuario, string email, string pass, string id)
        {
            this.ID = id;
            InitializeComponent();

            this.txtNombre.Text = nombre;
            this.txtApell.Text = apellidos;
            this.txtCedula.Text = cedula;
            this.txtUsuario.Text = usuario;
            this.txtEmail.Text = email;
            this.txtPass.Text = pass;
            this.txtPass.Hide();
            this.label6.Hide();
            this.bnCrear.Text = "Guardar";
        }

        private void bnCrear_Click(object sender, EventArgs e)
        {
            Profesor prof = new Profesor();
            if (ID.Equals(""))
            {
                if (prof.crear(this.txtNombre.Text, this.txtApell.Text, this.txtCedula.Text, this.txtUsuario.Text, this.txtEmail.Text, this.txtPass.Text))
                {
                    MessageBox.Show("Se guardó correctamente.", "", MessageBoxButtons.OK);
                }
                else
                { MessageBox.Show("Error al guardar.", "", MessageBoxButtons.OK); }
            }
            else {
                if (prof.edit(this.txtNombre.Text, this.txtApell.Text, this.txtCedula.Text, this.txtUsuario.Text, this.txtEmail.Text,this.txtPass.Text, ID))
                {
                    MessageBox.Show("Se guardó correctamente.", "", MessageBoxButtons.OK);
                }
                else
                { MessageBox.Show("Error al guardar.", "", MessageBoxButtons.OK); }
            }
            this.Dispose();
            this.Close();
        }
    }
}
