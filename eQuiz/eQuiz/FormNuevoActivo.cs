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
    public partial class FormNuevoActivo : Form
    {
        string curso_id = "";
        string ID = "";
        public FormNuevoActivo(String id, String cursoid)
        {
            InitializeComponent();
            this.ID = id;
            this.curso_id = cursoid;
           
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            Profesor prof = new Profesor();
            prof.editinactivo(ID);
            Cursos cursos = new Cursos();
            DataSet resource = cursos.obtenerEstudiantes(curso_id);
            string[] var = new string[2];
            string[] valor = new string[2];
            if (resource != null)
            {
                for (int i = 0; i <= resource.Tables[1].Rows.Count - 1; i++)
                {
                   String correo = resource.Tables[1].Rows[i].ItemArray[3].ToString();
                   var[0] = "email";
                   valor[0] = correo;

                   string url = "";
                   url = "http://localhost:3000/estudiantes/email";
                   HttpConexion ejecutar = new HttpConexion();
                   ejecutar.HttpPost(url, var, valor, "POST");
                        
                }
                
            }
            this.Close();
            this.Dispose();
        }
        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
