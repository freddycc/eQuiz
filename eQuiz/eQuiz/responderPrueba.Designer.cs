namespace eQuiz
{
    partial class responderPrueba
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
            this.components = new System.ComponentModel.Container();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtPreguntas = new System.Windows.Forms.RichTextBox();
            this.txtRespuestas = new System.Windows.Forms.RichTextBox();
            this.lblComentarios = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bnResponder = new System.Windows.Forms.Button();
            this.duracion = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.lblDuracion = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTranscurrido = new System.Windows.Forms.Label();
            this.progreso = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(47, 11);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(199, 25);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Responder prueba: ";
            // 
            // txtPreguntas
            // 
            this.txtPreguntas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreguntas.Location = new System.Drawing.Point(52, 88);
            this.txtPreguntas.Margin = new System.Windows.Forms.Padding(4);
            this.txtPreguntas.Name = "txtPreguntas";
            this.txtPreguntas.ReadOnly = true;
            this.txtPreguntas.Size = new System.Drawing.Size(544, 535);
            this.txtPreguntas.TabIndex = 1;
            this.txtPreguntas.Text = "";
            // 
            // txtRespuestas
            // 
            this.txtRespuestas.Location = new System.Drawing.Point(676, 88);
            this.txtRespuestas.Margin = new System.Windows.Forms.Padding(4);
            this.txtRespuestas.Name = "txtRespuestas";
            this.txtRespuestas.Size = new System.Drawing.Size(544, 535);
            this.txtRespuestas.TabIndex = 2;
            this.txtRespuestas.Text = "";
            // 
            // lblComentarios
            // 
            this.lblComentarios.AutoSize = true;
            this.lblComentarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComentarios.Location = new System.Drawing.Point(241, 48);
            this.lblComentarios.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComentarios.Name = "lblComentarios";
            this.lblComentarios.Size = new System.Drawing.Size(45, 16);
            this.lblComentarios.TabIndex = 3;
            this.lblComentarios.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 48);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Comentarios:";
            // 
            // bnResponder
            // 
            this.bnResponder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnResponder.Location = new System.Drawing.Point(53, 643);
            this.bnResponder.Margin = new System.Windows.Forms.Padding(4);
            this.bnResponder.Name = "bnResponder";
            this.bnResponder.Size = new System.Drawing.Size(193, 38);
            this.bnResponder.TabIndex = 5;
            this.bnResponder.Text = "Enviar respuestas";
            this.bnResponder.UseVisualStyleBackColor = true;
            this.bnResponder.Click += new System.EventHandler(this.bnResponder_Click);
            // 
            // duracion
            // 
            this.duracion.Tick += new System.EventHandler(this.duracion_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(887, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(149, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tiempo para la prueba:";
            // 
            // lblDuracion
            // 
            this.lblDuracion.AutoSize = true;
            this.lblDuracion.Location = new System.Drawing.Point(1072, 11);
            this.lblDuracion.Name = "lblDuracion";
            this.lblDuracion.Size = new System.Drawing.Size(15, 16);
            this.lblDuracion.TabIndex = 7;
            this.lblDuracion.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(887, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tiempo transcurrido:";
            // 
            // lblTranscurrido
            // 
            this.lblTranscurrido.AutoSize = true;
            this.lblTranscurrido.Location = new System.Drawing.Point(1072, 48);
            this.lblTranscurrido.Name = "lblTranscurrido";
            this.lblTranscurrido.Size = new System.Drawing.Size(15, 16);
            this.lblTranscurrido.TabIndex = 9;
            this.lblTranscurrido.Text = "0";
            // 
            // progreso
            // 
            this.progreso.Enabled = true;
            this.progreso.Interval = 60000;
            this.progreso.Tick += new System.EventHandler(this.progreso_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(1118, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "minutos";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1118, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "minutos";
            // 
            // responderPrueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 691);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblTranscurrido);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblDuracion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bnResponder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblComentarios);
            this.Controls.Add(this.txtRespuestas);
            this.Controls.Add(this.txtPreguntas);
            this.Controls.Add(this.lblNombre);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "responderPrueba";
            this.Text = "Prueba - Preguntas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.RichTextBox txtPreguntas;
        private System.Windows.Forms.RichTextBox txtRespuestas;
        private System.Windows.Forms.Label lblComentarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bnResponder;
        private System.Windows.Forms.Timer duracion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDuracion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTranscurrido;
        private System.Windows.Forms.Timer progreso;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}