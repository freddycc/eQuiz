namespace eQuiz
{
    partial class Mantenimiento
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
            this.tabEstud = new System.Windows.Forms.TabPage();
            this.bnCrearEstd = new System.Windows.Forms.Button();
            this.gridEstud = new System.Windows.Forms.DataGridView();
            this.cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_estud = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passEst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editEstud = new System.Windows.Forms.DataGridViewButtonColumn();
            this.elimEstud = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabProfes = new System.Windows.Forms.TabPage();
            this.bnCrearProf = new System.Windows.Forms.Button();
            this.gridProfes = new System.Windows.Forms.DataGridView();
            this.cedulaProf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosProf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.userProf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailProf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_prof = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passProf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editProf = new System.Windows.Forms.DataGridViewButtonColumn();
            this.eliminProf = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabCursos = new System.Windows.Forms.TabPage();
            this.bnCrearCurso = new System.Windows.Forms.Button();
            this.gridCursos = new System.Windows.Forms.DataGridView();
            this.codCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCurso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.editCurso = new System.Windows.Forms.DataGridViewButtonColumn();
            this.deletCurso = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tabControl.SuspendLayout();
            this.tabEstud.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEstud)).BeginInit();
            this.tabProfes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProfes)).BeginInit();
            this.tabCursos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCursos)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabEstud);
            this.tabControl.Controls.Add(this.tabProfes);
            this.tabControl.Controls.Add(this.tabCursos);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.Location = new System.Drawing.Point(45, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(1096, 565);
            this.tabControl.TabIndex = 0;
            // 
            // tabEstud
            // 
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
            this.gridEstud.AllowUserToAddRows = false;
            this.gridEstud.AllowUserToDeleteRows = false;
            this.gridEstud.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.gridEstud.ColumnHeadersHeight = 40;
            this.gridEstud.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cedula,
            this.nombre,
            this.apellidos,
            this.usuario,
            this.email,
            this.id_estud,
            this.passEst,
            this.editEstud,
            this.elimEstud});
            this.gridEstud.Location = new System.Drawing.Point(215, 134);
            this.gridEstud.Name = "gridEstud";
            this.gridEstud.ReadOnly = true;
            this.gridEstud.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridEstud.Size = new System.Drawing.Size(843, 345);
            this.gridEstud.TabIndex = 0;
            this.gridEstud.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridEstud_CellContentClick);
            // 
            // cedula
            // 
            this.cedula.HeaderText = "Cédula";
            this.cedula.Name = "cedula";
            this.cedula.ReadOnly = true;
            this.cedula.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // apellidos
            // 
            this.apellidos.HeaderText = "Apellidos";
            this.apellidos.Name = "apellidos";
            this.apellidos.ReadOnly = true;
            this.apellidos.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // usuario
            // 
            this.usuario.HeaderText = "Nombre Usuario";
            this.usuario.Name = "usuario";
            this.usuario.ReadOnly = true;
            this.usuario.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // email
            // 
            this.email.HeaderText = "Email";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // id_estud
            // 
            this.id_estud.HeaderText = "ID";
            this.id_estud.Name = "id_estud";
            this.id_estud.ReadOnly = true;
            this.id_estud.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // passEst
            // 
            this.passEst.HeaderText = "";
            this.passEst.Name = "passEst";
            this.passEst.ReadOnly = true;
            this.passEst.Visible = false;
            // 
            // editEstud
            // 
            this.editEstud.HeaderText = "";
            this.editEstud.Name = "editEstud";
            this.editEstud.ReadOnly = true;
            this.editEstud.Text = "Editar";
            this.editEstud.UseColumnTextForButtonValue = true;
            // 
            // elimEstud
            // 
            this.elimEstud.HeaderText = "";
            this.elimEstud.Name = "elimEstud";
            this.elimEstud.ReadOnly = true;
            this.elimEstud.Text = "Eliminar";
            this.elimEstud.UseColumnTextForButtonValue = true;
            // 
            // tabProfes
            // 
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
            this.gridProfes.AllowUserToAddRows = false;
            this.gridProfes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridProfes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cedulaProf,
            this.nombreProf,
            this.apellidosProf,
            this.userProf,
            this.emailProf,
            this.id_prof,
            this.passProf,
            this.editProf,
            this.eliminProf});
            this.gridProfes.Location = new System.Drawing.Point(216, 134);
            this.gridProfes.Name = "gridProfes";
            this.gridProfes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridProfes.Size = new System.Drawing.Size(843, 345);
            this.gridProfes.TabIndex = 9;
            this.gridProfes.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridProfes_CellContentClick);
            // 
            // cedulaProf
            // 
            this.cedulaProf.Frozen = true;
            this.cedulaProf.HeaderText = "Cédula";
            this.cedulaProf.Name = "cedulaProf";
            this.cedulaProf.ReadOnly = true;
            // 
            // nombreProf
            // 
            this.nombreProf.Frozen = true;
            this.nombreProf.HeaderText = "Nombre";
            this.nombreProf.Name = "nombreProf";
            this.nombreProf.ReadOnly = true;
            // 
            // apellidosProf
            // 
            this.apellidosProf.Frozen = true;
            this.apellidosProf.HeaderText = "Apellidos";
            this.apellidosProf.Name = "apellidosProf";
            this.apellidosProf.ReadOnly = true;
            // 
            // userProf
            // 
            this.userProf.Frozen = true;
            this.userProf.HeaderText = "Nombre de Usuario";
            this.userProf.Name = "userProf";
            this.userProf.ReadOnly = true;
            // 
            // emailProf
            // 
            this.emailProf.Frozen = true;
            this.emailProf.HeaderText = "Email";
            this.emailProf.Name = "emailProf";
            this.emailProf.ReadOnly = true;
            // 
            // id_prof
            // 
            this.id_prof.Frozen = true;
            this.id_prof.HeaderText = "ID";
            this.id_prof.Name = "id_prof";
            this.id_prof.ReadOnly = true;
            // 
            // passProf
            // 
            this.passProf.Frozen = true;
            this.passProf.HeaderText = "";
            this.passProf.Name = "passProf";
            this.passProf.ReadOnly = true;
            this.passProf.Visible = false;
            // 
            // editProf
            // 
            this.editProf.Frozen = true;
            this.editProf.HeaderText = "";
            this.editProf.Name = "editProf";
            this.editProf.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.editProf.Text = "Editar";
            this.editProf.UseColumnTextForButtonValue = true;
            // 
            // eliminProf
            // 
            this.eliminProf.HeaderText = "";
            this.eliminProf.Name = "eliminProf";
            this.eliminProf.Text = "Eliminar";
            this.eliminProf.UseColumnTextForButtonValue = true;
            // 
            // tabCursos
            // 
            this.tabCursos.Controls.Add(this.bnCrearCurso);
            this.tabCursos.Controls.Add(this.gridCursos);
            this.tabCursos.Location = new System.Drawing.Point(4, 25);
            this.tabCursos.Name = "tabCursos";
            this.tabCursos.Padding = new System.Windows.Forms.Padding(3);
            this.tabCursos.Size = new System.Drawing.Size(1088, 536);
            this.tabCursos.TabIndex = 3;
            this.tabCursos.Text = "Administrar Cursos";
            this.tabCursos.UseVisualStyleBackColor = true;
            // 
            // bnCrearCurso
            // 
            this.bnCrearCurso.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.bnCrearCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnCrearCurso.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.bnCrearCurso.Location = new System.Drawing.Point(24, 134);
            this.bnCrearCurso.Name = "bnCrearCurso";
            this.bnCrearCurso.Size = new System.Drawing.Size(122, 36);
            this.bnCrearCurso.TabIndex = 12;
            this.bnCrearCurso.Text = "Crear";
            this.bnCrearCurso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bnCrearCurso.UseVisualStyleBackColor = false;
            this.bnCrearCurso.Click += new System.EventHandler(this.bnCrearCurso_Click);
            // 
            // gridCursos
            // 
            this.gridCursos.AllowUserToAddRows = false;
            this.gridCursos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCursos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codCurso,
            this.nombreCurso,
            this.descripCurso,
            this.idCurso,
            this.editCurso,
            this.deletCurso});
            this.gridCursos.Location = new System.Drawing.Point(217, 134);
            this.gridCursos.Name = "gridCursos";
            this.gridCursos.RowHeadersWidth = 100;
            this.gridCursos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridCursos.Size = new System.Drawing.Size(702, 345);
            this.gridCursos.TabIndex = 11;
            this.gridCursos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCursos_CellContentClick);
            // 
            // codCurso
            // 
            this.codCurso.Frozen = true;
            this.codCurso.HeaderText = "Código";
            this.codCurso.Name = "codCurso";
            this.codCurso.ReadOnly = true;
            // 
            // nombreCurso
            // 
            this.nombreCurso.Frozen = true;
            this.nombreCurso.HeaderText = "Nombre";
            this.nombreCurso.Name = "nombreCurso";
            this.nombreCurso.ReadOnly = true;
            // 
            // descripCurso
            // 
            this.descripCurso.Frozen = true;
            this.descripCurso.HeaderText = "Descripción";
            this.descripCurso.Name = "descripCurso";
            this.descripCurso.ReadOnly = true;
            // 
            // idCurso
            // 
            this.idCurso.Frozen = true;
            this.idCurso.HeaderText = "ID";
            this.idCurso.Name = "idCurso";
            this.idCurso.ReadOnly = true;
            // 
            // editCurso
            // 
            this.editCurso.Frozen = true;
            this.editCurso.HeaderText = "";
            this.editCurso.Name = "editCurso";
            this.editCurso.ReadOnly = true;
            this.editCurso.Text = "Editar";
            this.editCurso.UseColumnTextForButtonValue = true;
            // 
            // deletCurso
            // 
            this.deletCurso.Frozen = true;
            this.deletCurso.HeaderText = "";
            this.deletCurso.Name = "deletCurso";
            this.deletCurso.ReadOnly = true;
            this.deletCurso.Text = "Eliminar";
            this.deletCurso.UseColumnTextForButtonValue = true;
            // 
            // Mantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1176, 599);
            this.Controls.Add(this.tabControl);
            this.Name = "Mantenimiento";
            this.Text = "Inicio";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Mantenimiento_FormClosed);
            this.tabControl.ResumeLayout(false);
            this.tabEstud.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridEstud)).EndInit();
            this.tabProfes.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridProfes)).EndInit();
            this.tabCursos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCursos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabEstud;
        private System.Windows.Forms.DataGridView gridEstud;
        private System.Windows.Forms.TabPage tabProfes;
        private System.Windows.Forms.Button bnCrearEstd;
        private System.Windows.Forms.Button bnCrearProf;
        private System.Windows.Forms.DataGridView gridProfes;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedulaProf;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProf;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosProf;
        private System.Windows.Forms.DataGridViewTextBoxColumn userProf;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailProf;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_prof;
        private System.Windows.Forms.DataGridViewTextBoxColumn passProf;
        private System.Windows.Forms.DataGridViewButtonColumn editProf;
        private System.Windows.Forms.DataGridViewButtonColumn eliminProf;
        private System.Windows.Forms.DataGridViewTextBoxColumn cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_estud;
        private System.Windows.Forms.DataGridViewTextBoxColumn passEst;
        private System.Windows.Forms.DataGridViewButtonColumn editEstud;
        private System.Windows.Forms.DataGridViewButtonColumn elimEstud;
        private System.Windows.Forms.TabPage tabCursos;
        private System.Windows.Forms.Button bnCrearCurso;
        private System.Windows.Forms.DataGridView gridCursos;
        private System.Windows.Forms.DataGridViewTextBoxColumn codCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripCurso;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCurso;
        private System.Windows.Forms.DataGridViewButtonColumn editCurso;
        private System.Windows.Forms.DataGridViewButtonColumn deletCurso;
    }
}