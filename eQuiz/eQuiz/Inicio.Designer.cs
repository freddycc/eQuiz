namespace eQuiz
{
    partial class Inicio
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabEstud = new System.Windows.Forms.TabPage();
            this.bnBorrar = new System.Windows.Forms.Button();
            this.bnCrearEstd = new System.Windows.Forms.Button();
            this.gridEstud = new System.Windows.Forms.DataGridView();
            this.tabProfes = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.bnCrearProf = new System.Windows.Forms.Button();
            this.gridProfes = new System.Windows.Forms.DataGridView();
            this.tabControl.SuspendLayout();
            this.tabEstud.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEstud)).BeginInit();
            this.tabProfes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProfes)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabEstud);
            this.tabControl.Controls.Add(this.tabProfes);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(45, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1096, 565);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1088, 536);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabEstud
            // 
            this.tabEstud.Controls.Add(this.bnBorrar);
            this.tabEstud.Controls.Add(this.bnCrearEstd);
            this.tabEstud.Controls.Add(this.gridEstud);
            this.tabEstud.Location = new System.Drawing.Point(4, 25);
            this.tabEstud.Name = "tabEstud";
            this.tabEstud.Padding = new System.Windows.Forms.Padding(3);
            this.tabEstud.Size = new System.Drawing.Size(1088, 536);
            this.tabEstud.TabIndex = 1;
            this.tabEstud.Text = "Administrar Estudiantes";
            this.tabEstud.UseVisualStyleBackColor = true;
            // 
            // bnBorrar
            // 
            this.bnBorrar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnBorrar.Location = new System.Drawing.Point(21, 193);
            this.bnBorrar.Name = "bnBorrar";
            this.bnBorrar.Size = new System.Drawing.Size(122, 36);
            this.bnBorrar.TabIndex = 8;
            this.bnBorrar.Text = "Eliminar";
            this.bnBorrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnBorrar.UseVisualStyleBackColor = false;
            // 
            // bnCrearEstd
            // 
            this.bnCrearEstd.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bnCrearEstd.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnCrearEstd.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bnCrearEstd.Location = new System.Drawing.Point(21, 134);
            this.bnCrearEstd.Name = "bnCrearEstd";
            this.bnCrearEstd.Size = new System.Drawing.Size(122, 36);
            this.bnCrearEstd.TabIndex = 7;
            this.bnCrearEstd.Text = "Crear";
            this.bnCrearEstd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnCrearEstd.UseVisualStyleBackColor = false;
            this.bnCrearEstd.Click += new System.EventHandler(this.bnCrearEstd_Click);
            // 
            // gridEstud
            // 
            this.gridEstud.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridEstud.Location = new System.Drawing.Point(215, 134);
            this.gridEstud.Name = "gridEstud";
            this.gridEstud.Size = new System.Drawing.Size(830, 268);
            this.gridEstud.TabIndex = 0;
            // 
            // tabProfes
            // 
            this.tabProfes.Controls.Add(this.button1);
            this.tabProfes.Controls.Add(this.bnCrearProf);
            this.tabProfes.Controls.Add(this.gridProfes);
            this.tabProfes.Location = new System.Drawing.Point(4, 25);
            this.tabProfes.Name = "tabProfes";
            this.tabProfes.Padding = new System.Windows.Forms.Padding(3);
            this.tabProfes.Size = new System.Drawing.Size(1088, 536);
            this.tabProfes.TabIndex = 2;
            this.tabProfes.Text = "Administrar Profesores";
            this.tabProfes.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(22, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 36);
            this.button1.TabIndex = 11;
            this.button1.Text = "Eliminar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // bnCrearProf
            // 
            this.bnCrearProf.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bnCrearProf.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnCrearProf.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bnCrearProf.Location = new System.Drawing.Point(22, 134);
            this.bnCrearProf.Name = "bnCrearProf";
            this.bnCrearProf.Size = new System.Drawing.Size(122, 36);
            this.bnCrearProf.TabIndex = 10;
            this.bnCrearProf.Text = "Crear";
            this.bnCrearProf.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnCrearProf.UseVisualStyleBackColor = false;
            this.bnCrearProf.Click += new System.EventHandler(this.bnCrearProfe_Click);
            // 
            // gridProfes
            // 
            this.gridProfes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProfes.Location = new System.Drawing.Point(216, 134);
            this.gridProfes.Name = "gridProfes";
            this.gridProfes.Size = new System.Drawing.Size(830, 268);
            this.gridProfes.TabIndex = 9;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 599);
            this.Controls.Add(this.tabControl);
            this.Name = "Inicio";
            this.Text = "Inicio";
            this.tabControl.ResumeLayout(false);
            this.tabEstud.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridEstud)).EndInit();
            this.tabProfes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridProfes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabEstud;
        private System.Windows.Forms.DataGridView gridEstud;
        private System.Windows.Forms.TabPage tabProfes;
        private System.Windows.Forms.Button bnBorrar;
        private System.Windows.Forms.Button bnCrearEstd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button bnCrearProf;
        private System.Windows.Forms.DataGridView gridProfes;
    }
}