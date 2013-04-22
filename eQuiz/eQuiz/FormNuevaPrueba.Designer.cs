namespace eQuiz
{
    partial class FormNuevaPrueba
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblTiempo = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblComentario = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.cbxEstado = new System.Windows.Forms.ComboBox();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.txtComentario = new System.Windows.Forms.RichTextBox();
            this.gbxPreguntas = new System.Windows.Forms.GroupBox();
            this.bnAgregarPreguntas = new System.Windows.Forms.Button();
            this.txtPregunta = new System.Windows.Forms.TextBox();
            this.lblPreguntas = new System.Windows.Forms.Label();
            this.txtPreguntas = new System.Windows.Forms.RichTextBox();
            this.bnCrear = new System.Windows.Forms.Button();
            this.bnCancelar = new System.Windows.Forms.Button();
            this.lblIdCurso = new System.Windows.Forms.Label();
            this.gbxPreguntas.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(68, 57);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(137, 16);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre de la Prueba";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(301, 57);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(148, 16);
            this.lblEstado.TabIndex = 1;
            this.lblEstado.Text = "Estado (activa/inactiva)";
            // 
            // lblTiempo
            // 
            this.lblTiempo.AutoSize = true;
            this.lblTiempo.Location = new System.Drawing.Point(518, 56);
            this.lblTiempo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTiempo.Name = "lblTiempo";
            this.lblTiempo.Size = new System.Drawing.Size(206, 16);
            this.lblTiempo.TabIndex = 2;
            this.lblTiempo.Text = "Tiempo de aplicación en minutos";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(780, 57);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(130, 16);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Fecha de aplicación";
            // 
            // lblComentario
            // 
            this.lblComentario.AutoSize = true;
            this.lblComentario.Location = new System.Drawing.Point(1006, 57);
            this.lblComentario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComentario.Name = "lblComentario";
            this.lblComentario.Size = new System.Drawing.Size(182, 16);
            this.lblComentario.TabIndex = 4;
            this.lblComentario.Text = "Comentarios sobre la prueba";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(71, 76);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(150, 22);
            this.txtNombre.TabIndex = 5;
            // 
            // cbxEstado
            // 
            this.cbxEstado.FormattingEnabled = true;
            this.cbxEstado.Location = new System.Drawing.Point(305, 75);
            this.cbxEstado.Name = "cbxEstado";
            this.cbxEstado.Size = new System.Drawing.Size(150, 24);
            this.cbxEstado.TabIndex = 6;
            // 
            // txtTiempo
            // 
            this.txtTiempo.Location = new System.Drawing.Point(551, 75);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.Size = new System.Drawing.Size(150, 22);
            this.txtTiempo.TabIndex = 7;
            // 
            // dtFecha
            // 
            this.dtFecha.Location = new System.Drawing.Point(783, 74);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(200, 22);
            this.dtFecha.TabIndex = 8;
            // 
            // txtComentario
            // 
            this.txtComentario.Location = new System.Drawing.Point(1011, 76);
            this.txtComentario.Name = "txtComentario";
            this.txtComentario.Size = new System.Drawing.Size(263, 131);
            this.txtComentario.TabIndex = 9;
            this.txtComentario.Text = "";
            // 
            // gbxPreguntas
            // 
            this.gbxPreguntas.Controls.Add(this.bnAgregarPreguntas);
            this.gbxPreguntas.Controls.Add(this.txtPregunta);
            this.gbxPreguntas.Controls.Add(this.lblPreguntas);
            this.gbxPreguntas.Controls.Add(this.txtPreguntas);
            this.gbxPreguntas.Location = new System.Drawing.Point(48, 147);
            this.gbxPreguntas.Name = "gbxPreguntas";
            this.gbxPreguntas.Size = new System.Drawing.Size(935, 406);
            this.gbxPreguntas.TabIndex = 10;
            this.gbxPreguntas.TabStop = false;
            this.gbxPreguntas.Text = "Agregar Preguntas";
            // 
            // bnAgregarPreguntas
            // 
            this.bnAgregarPreguntas.Location = new System.Drawing.Point(724, 56);
            this.bnAgregarPreguntas.Name = "bnAgregarPreguntas";
            this.bnAgregarPreguntas.Size = new System.Drawing.Size(139, 30);
            this.bnAgregarPreguntas.TabIndex = 3;
            this.bnAgregarPreguntas.Text = "Agregar pregunta";
            this.bnAgregarPreguntas.UseVisualStyleBackColor = true;
            this.bnAgregarPreguntas.Click += new System.EventHandler(this.bnAgregarPreguntas_Click);
            // 
            // txtPregunta
            // 
            this.txtPregunta.Location = new System.Drawing.Point(180, 61);
            this.txtPregunta.Name = "txtPregunta";
            this.txtPregunta.Size = new System.Drawing.Size(507, 22);
            this.txtPregunta.TabIndex = 2;
            // 
            // lblPreguntas
            // 
            this.lblPreguntas.AutoSize = true;
            this.lblPreguntas.Location = new System.Drawing.Point(57, 63);
            this.lblPreguntas.Name = "lblPreguntas";
            this.lblPreguntas.Size = new System.Drawing.Size(105, 16);
            this.lblPreguntas.TabIndex = 1;
            this.lblPreguntas.Text = "Pregunta Nueva";
            // 
            // txtPreguntas
            // 
            this.txtPreguntas.Enabled = false;
            this.txtPreguntas.Location = new System.Drawing.Point(60, 116);
            this.txtPreguntas.Name = "txtPreguntas";
            this.txtPreguntas.Size = new System.Drawing.Size(845, 265);
            this.txtPreguntas.TabIndex = 0;
            this.txtPreguntas.Text = "";
            // 
            // bnCrear
            // 
            this.bnCrear.Location = new System.Drawing.Point(290, 579);
            this.bnCrear.Name = "bnCrear";
            this.bnCrear.Size = new System.Drawing.Size(131, 30);
            this.bnCrear.TabIndex = 11;
            this.bnCrear.Text = "Crear Prueba";
            this.bnCrear.UseVisualStyleBackColor = true;
            this.bnCrear.Click += new System.EventHandler(this.bnCrear_Click);
            // 
            // bnCancelar
            // 
            this.bnCancelar.Location = new System.Drawing.Point(108, 579);
            this.bnCancelar.Name = "bnCancelar";
            this.bnCancelar.Size = new System.Drawing.Size(111, 30);
            this.bnCancelar.TabIndex = 12;
            this.bnCancelar.Text = "Cancelar";
            this.bnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblIdCurso
            // 
            this.lblIdCurso.AutoSize = true;
            this.lblIdCurso.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCurso.Location = new System.Drawing.Point(43, 9);
            this.lblIdCurso.Name = "lblIdCurso";
            this.lblIdCurso.Size = new System.Drawing.Size(0, 29);
            this.lblIdCurso.TabIndex = 13;
            // 
            // FormNuevaPrueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 667);
            this.Controls.Add(this.lblIdCurso);
            this.Controls.Add(this.bnCancelar);
            this.Controls.Add(this.bnCrear);
            this.Controls.Add(this.gbxPreguntas);
            this.Controls.Add(this.txtComentario);
            this.Controls.Add(this.dtFecha);
            this.Controls.Add(this.txtTiempo);
            this.Controls.Add(this.cbxEstado);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblComentario);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblTiempo);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblNombre);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormNuevaPrueba";
            this.Text = "Nueva Prueba";
            this.Load += new System.EventHandler(this.FormNuevaPrueba_Load);
            this.gbxPreguntas.ResumeLayout(false);
            this.gbxPreguntas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblTiempo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblComentario;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.ComboBox cbxEstado;
        private System.Windows.Forms.TextBox txtTiempo;
        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.RichTextBox txtComentario;
        private System.Windows.Forms.GroupBox gbxPreguntas;
        private System.Windows.Forms.Button bnAgregarPreguntas;
        private System.Windows.Forms.TextBox txtPregunta;
        private System.Windows.Forms.Label lblPreguntas;
        private System.Windows.Forms.RichTextBox txtPreguntas;
        private System.Windows.Forms.Button bnCrear;
        private System.Windows.Forms.Button bnCancelar;
        private System.Windows.Forms.Label lblIdCurso;
    }
}