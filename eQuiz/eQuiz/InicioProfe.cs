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
    public partial class InicioProfe : Form
    {
        HttpConexion con = new HttpConexion();
        public InicioProfe()
        {
            InitializeComponent();
            this.actTablas();
            this.cbxCurso.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        public void actTablas()
        {
            DataSet resorce = con.ConvertXMLToDataSet("http://localhost:3000/cursos.xml");
            if (resorce != null)
            {
                DataTable cursos = resorce.Tables[1], cursosCombo = new DataTable();
                
                cursosCombo.Columns.Add("nombre", typeof(string));
                cursosCombo.Columns.Add("id", typeof(string));
                for (int i = 0; i <= cursos.Rows.Count - 1; i++)
                {
                    //this.gridCursos.Rows.Add(resorce.Tables[3].Rows[i].ItemArray[1].ToString(), cursos.Rows[i].ItemArray[2].ToString(), cursos.Rows[i].ItemArray[1].ToString(), resorce.Tables[4].Rows[i].ItemArray[1].ToString(), resorce.Tables[2].Rows[i].ItemArray[1].ToString());
                    cursosCombo.Rows.Add(cursos.Rows[i].ItemArray[2].ToString(), resorce.Tables[4].Rows[i].ItemArray[1].ToString());
                }
                this.cbxCurso.DataSource = cursosCombo;
                this.cbxCurso.DisplayMember = "nombre";
                this.cbxCurso.ValueMember = "id";
                this.cbxCurso.SelectedIndex = 0;
            }
        }
    }
}
