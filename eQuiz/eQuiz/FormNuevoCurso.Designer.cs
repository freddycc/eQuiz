namespace eQuiz
{
    partial class FormNuevoCurso
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescripcion = new System.Windows.Forms.RichTextBox();
            this.bnCancelar = new System.Windows.Forms.Button();
            this.bnCrear = new System.Windows.Forms.Button();
            this.txtCod = new System.Windows.Forms.NumericUpDown();
            this.cbxProfe = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtCod)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(207, 104);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(229, 22);
            this.txtNombre.TabIndex = 21;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(84, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "Código";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(84, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "Descripción";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Nombre";
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescripcion.Location = new System.Drawing.Point(207, 166);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(229, 155);
            this.txtDescripcion.TabIndex = 28;
            this.txtDescripcion.Text = "";
            // 
            // bnCancelar
            // 
            this.bnCancelar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnCancelar.Location = new System.Drawing.Point(278, 398);
            this.bnCancelar.Name = "bnCancelar";
            this.bnCancelar.Size = new System.Drawing.Size(122, 36);
            this.bnCancelar.TabIndex = 30;
            this.bnCancelar.Text = "Cancelar";
            this.bnCancelar.UseVisualStyleBackColor = false;
            this.bnCancelar.Click += new System.EventHandler(this.bnCancelar_Click);
            // 
            // bnCrear
            // 
            this.bnCrear.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bnCrear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnCrear.Location = new System.Drawing.Point(101, 398);
            this.bnCrear.Name = "bnCrear";
            this.bnCrear.Size = new System.Drawing.Size(122, 36);
            this.bnCrear.TabIndex = 29;
            this.bnCrear.Text = "Crear";
            this.bnCrear.UseVisualStyleBackColor = false;
            this.bnCrear.Click += new System.EventHandler(this.bnCrear_Click);
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(207, 49);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(229, 20);
            this.txtCod.TabIndex = 31;
            // 
            // cbxProfe
            // 
            this.cbxProfe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxProfe.FormattingEnabled = true;
            this.cbxProfe.Location = new System.Drawing.Point(207, 342);
            this.cbxProfe.Name = "cbxProfe";
            this.cbxProfe.Size = new System.Drawing.Size(229, 24);
            this.cbxProfe.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(84, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 16);
            this.label3.TabIndex = 33;
            this.label3.Text = "Profesor";
            // 
            // FormNuevoCurso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(501, 456);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbxProfe);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.bnCancelar);
            this.Controls.Add(this.bnCrear);
            this.Controls.Add(this.txtDescripcion);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormNuevoCurso";
            this.Text = "FormNuevoCurso";
            ((System.ComponentModel.ISupportInitialize)(this.txtCod)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox txtDescripcion;
        private System.Windows.Forms.Button bnCancelar;
        private System.Windows.Forms.Button bnCrear;
        private System.Windows.Forms.NumericUpDown txtCod;
        private System.Windows.Forms.ComboBox cbxProfe;
        private System.Windows.Forms.Label label3;
    }
}