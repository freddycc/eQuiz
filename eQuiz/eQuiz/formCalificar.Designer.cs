namespace eQuiz
{
    partial class formCalificar
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblComentarios = new System.Windows.Forms.Label();
            this.txtRespuestas = new System.Windows.Forms.RichTextBox();
            this.txtPreguntas = new System.Windows.Forms.RichTextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.bnCalificar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txNota = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.txNota)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 51);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 16);
            this.label1.TabIndex = 9;
            this.label1.Text = "Comentarios:";
            // 
            // lblComentarios
            // 
            this.lblComentarios.AutoSize = true;
            this.lblComentarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComentarios.Location = new System.Drawing.Point(245, 51);
            this.lblComentarios.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblComentarios.Name = "lblComentarios";
            this.lblComentarios.Size = new System.Drawing.Size(45, 16);
            this.lblComentarios.TabIndex = 8;
            this.lblComentarios.Text = "label2";
            // 
            // txtRespuestas
            // 
            this.txtRespuestas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRespuestas.Location = new System.Drawing.Point(689, 91);
            this.txtRespuestas.Margin = new System.Windows.Forms.Padding(4);
            this.txtRespuestas.Name = "txtRespuestas";
            this.txtRespuestas.Size = new System.Drawing.Size(544, 535);
            this.txtRespuestas.TabIndex = 7;
            this.txtRespuestas.Text = "";
            // 
            // txtPreguntas
            // 
            this.txtPreguntas.Enabled = false;
            this.txtPreguntas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreguntas.Location = new System.Drawing.Point(65, 91);
            this.txtPreguntas.Margin = new System.Windows.Forms.Padding(4);
            this.txtPreguntas.Name = "txtPreguntas";
            this.txtPreguntas.ReadOnly = true;
            this.txtPreguntas.Size = new System.Drawing.Size(544, 535);
            this.txtPreguntas.TabIndex = 6;
            this.txtPreguntas.Text = "";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Modern No. 20", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(60, 14);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(199, 25);
            this.lblNombre.TabIndex = 5;
            this.lblNombre.Text = "Responder prueba: ";
            // 
            // bnCalificar
            // 
            this.bnCalificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnCalificar.Location = new System.Drawing.Point(957, 43);
            this.bnCalificar.Name = "bnCalificar";
            this.bnCalificar.Size = new System.Drawing.Size(150, 26);
            this.bnCalificar.TabIndex = 10;
            this.bnCalificar.Text = "Asignar Calificación";
            this.bnCalificar.UseVisualStyleBackColor = true;
            this.bnCalificar.Click += new System.EventHandler(this.bnCalificar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(691, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Asigne una calificaión:";
            // 
            // txNota
            // 
            this.txNota.DecimalPlaces = 2;
            this.txNota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txNota.Location = new System.Drawing.Point(850, 46);
            this.txNota.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.txNota.Name = "txNota";
            this.txNota.Size = new System.Drawing.Size(81, 22);
            this.txNota.TabIndex = 12;
            this.txNota.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // formCalificar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1293, 691);
            this.Controls.Add(this.txNota);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bnCalificar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblComentarios);
            this.Controls.Add(this.txtRespuestas);
            this.Controls.Add(this.txtPreguntas);
            this.Controls.Add(this.lblNombre);
            this.Name = "formCalificar";
            this.Text = "Prueba - Calificar";
            ((System.ComponentModel.ISupportInitialize)(this.txNota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblComentarios;
        private System.Windows.Forms.RichTextBox txtRespuestas;
        private System.Windows.Forms.RichTextBox txtPreguntas;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button bnCalificar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown txNota;
    }
}