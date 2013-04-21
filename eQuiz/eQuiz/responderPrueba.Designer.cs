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
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtPreguntas = new System.Windows.Forms.RichTextBox();
            this.txtRespuestas = new System.Windows.Forms.RichTextBox();
            this.lblComentarios = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bnResponder = new System.Windows.Forms.Button();
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
            this.txtPreguntas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPreguntas.Name = "txtPreguntas";
            this.txtPreguntas.ReadOnly = true;
            this.txtPreguntas.Size = new System.Drawing.Size(544, 535);
            this.txtPreguntas.TabIndex = 1;
            this.txtPreguntas.Text = "";
            // 
            // txtRespuestas
            // 
            this.txtRespuestas.Location = new System.Drawing.Point(676, 88);
            this.txtRespuestas.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.bnResponder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bnResponder.Name = "bnResponder";
            this.bnResponder.Size = new System.Drawing.Size(193, 38);
            this.bnResponder.TabIndex = 5;
            this.bnResponder.Text = "Enviar respuestas";
            this.bnResponder.UseVisualStyleBackColor = true;
            this.bnResponder.Click += new System.EventHandler(this.bnResponder_Click);
            // 
            // responderPrueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 691);
            this.Controls.Add(this.bnResponder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblComentarios);
            this.Controls.Add(this.txtRespuestas);
            this.Controls.Add(this.txtPreguntas);
            this.Controls.Add(this.lblNombre);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
    }
}