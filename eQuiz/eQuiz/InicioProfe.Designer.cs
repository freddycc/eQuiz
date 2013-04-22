namespace eQuiz
{
    partial class InicioProfe
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.usuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabNotif = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bnBuscarAct = new System.Windows.Forms.Button();
            this.cbxCurs = new System.Windows.Forms.ComboBox();
            this.lblcbxCurs = new System.Windows.Forms.Label();
            this.gridPruebActivas = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabCursos = new System.Windows.Forms.TabPage();
            this.bnBuscar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridPruebas = new System.Windows.Forms.DataGridView();
            this.txNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txDuracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txComentario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txCreado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txIdPrueba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bnNueva = new System.Windows.Forms.Button();
            this.lblCurso = new System.Windows.Forms.Label();
            this.cbxCurso = new System.Windows.Forms.ComboBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gridPruebCalif = new System.Windows.Forms.DataGridView();
            this.columnNombrePrueba = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnComentario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnNombreEst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnCed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnIdResp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnIdPrub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.columnRespuestas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bnBusRespuestas = new System.Windows.Forms.Button();
            this.lblCursoResp = new System.Windows.Forms.Label();
            this.cbxCursoResp = new System.Windows.Forms.ComboBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabNotif.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPruebActivas)).BeginInit();
            this.tabCursos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPruebas)).BeginInit();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPruebCalif)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1319, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // usuarioToolStripMenuItem
            // 
            this.usuarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesiónToolStripMenuItem});
            this.usuarioToolStripMenuItem.Name = "usuarioToolStripMenuItem";
            this.usuarioToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.usuarioToolStripMenuItem.Text = "Usuario";
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(165, 24);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabNotif);
            this.tabControl1.Controls.Add(this.tabCursos);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(25, 43);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1269, 602);
            this.tabControl1.TabIndex = 1;
            // 
            // tabNotif
            // 
            this.tabNotif.Controls.Add(this.groupBox2);
            this.tabNotif.Location = new System.Drawing.Point(4, 27);
            this.tabNotif.Name = "tabNotif";
            this.tabNotif.Padding = new System.Windows.Forms.Padding(3);
            this.tabNotif.Size = new System.Drawing.Size(1261, 571);
            this.tabNotif.TabIndex = 0;
            this.tabNotif.Text = "Notificaciones";
            this.tabNotif.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bnBuscarAct);
            this.groupBox2.Controls.Add(this.cbxCurs);
            this.groupBox2.Controls.Add(this.lblcbxCurs);
            this.groupBox2.Controls.Add(this.gridPruebActivas);
            this.groupBox2.Location = new System.Drawing.Point(25, 11);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1196, 519);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Pruebas Inactivas";
            // 
            // bnBuscarAct
            // 
            this.bnBuscarAct.Location = new System.Drawing.Point(376, 39);
            this.bnBuscarAct.Name = "bnBuscarAct";
            this.bnBuscarAct.Size = new System.Drawing.Size(121, 27);
            this.bnBuscarAct.TabIndex = 10;
            this.bnBuscarAct.Text = "Buscar";
            this.bnBuscarAct.UseVisualStyleBackColor = true;
            this.bnBuscarAct.Click += new System.EventHandler(this.bnBuscarAct_Click);
            // 
            // cbxCurs
            // 
            this.cbxCurs.FormattingEnabled = true;
            this.cbxCurs.Location = new System.Drawing.Point(164, 39);
            this.cbxCurs.Name = "cbxCurs";
            this.cbxCurs.Size = new System.Drawing.Size(182, 26);
            this.cbxCurs.TabIndex = 9;
            // 
            // lblcbxCurs
            // 
            this.lblcbxCurs.AutoSize = true;
            this.lblcbxCurs.Location = new System.Drawing.Point(17, 42);
            this.lblcbxCurs.Name = "lblcbxCurs";
            this.lblcbxCurs.Size = new System.Drawing.Size(126, 18);
            this.lblcbxCurs.TabIndex = 8;
            this.lblcbxCurs.Text = "Seleccione Curso";
            // 
            // gridPruebActivas
            // 
            this.gridPruebActivas.ColumnHeadersHeight = 30;
            this.gridPruebActivas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridPruebActivas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.gridPruebActivas.Location = new System.Drawing.Point(97, 88);
            this.gridPruebActivas.Name = "gridPruebActivas";
            this.gridPruebActivas.RowHeadersVisible = false;
            this.gridPruebActivas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.gridPruebActivas.Size = new System.Drawing.Size(989, 399);
            this.gridPruebActivas.TabIndex = 4;
            this.gridPruebActivas.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPruebActivas_CellDoubleClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.Frozen = true;
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn1.Width = 180;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.Frozen = true;
            this.dataGridViewTextBoxColumn2.HeaderText = "Estado";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.Frozen = true;
            this.dataGridViewTextBoxColumn3.HeaderText = "Duración";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 160;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.Frozen = true;
            this.dataGridViewTextBoxColumn4.HeaderText = "Comentario";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 250;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.Frozen = true;
            this.dataGridViewTextBoxColumn5.HeaderText = "Creado el día";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 250;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.Frozen = true;
            this.dataGridViewTextBoxColumn6.HeaderText = "";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Visible = false;
            // 
            // tabCursos
            // 
            this.tabCursos.Controls.Add(this.bnBuscar);
            this.tabCursos.Controls.Add(this.groupBox1);
            this.tabCursos.Controls.Add(this.lblCurso);
            this.tabCursos.Controls.Add(this.cbxCurso);
            this.tabCursos.Location = new System.Drawing.Point(4, 27);
            this.tabCursos.Name = "tabCursos";
            this.tabCursos.Padding = new System.Windows.Forms.Padding(3);
            this.tabCursos.Size = new System.Drawing.Size(1261, 571);
            this.tabCursos.TabIndex = 1;
            this.tabCursos.Text = "Cursos";
            this.tabCursos.UseVisualStyleBackColor = true;
            // 
            // bnBuscar
            // 
            this.bnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnBuscar.Location = new System.Drawing.Point(409, 26);
            this.bnBuscar.Name = "bnBuscar";
            this.bnBuscar.Size = new System.Drawing.Size(126, 36);
            this.bnBuscar.TabIndex = 6;
            this.bnBuscar.Text = "Buscar Pruebas";
            this.bnBuscar.UseVisualStyleBackColor = true;
            this.bnBuscar.Click += new System.EventHandler(this.bnBuscar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.gridPruebas);
            this.groupBox1.Controls.Add(this.bnNueva);
            this.groupBox1.Location = new System.Drawing.Point(24, 99);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1212, 453);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pruebas del Curso";
            // 
            // gridPruebas
            // 
            this.gridPruebas.ColumnHeadersHeight = 30;
            this.gridPruebas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.gridPruebas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.txNombre,
            this.txEstado,
            this.txDuracion,
            this.txComentario,
            this.txCreado,
            this.txIdPrueba});
            this.gridPruebas.Location = new System.Drawing.Point(39, 76);
            this.gridPruebas.Name = "gridPruebas";
            this.gridPruebas.RowHeadersVisible = false;
            this.gridPruebas.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.gridPruebas.Size = new System.Drawing.Size(992, 355);
            this.gridPruebas.TabIndex = 3;
            // 
            // txNombre
            // 
            this.txNombre.Frozen = true;
            this.txNombre.HeaderText = "Nombre";
            this.txNombre.Name = "txNombre";
            this.txNombre.ReadOnly = true;
            this.txNombre.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.txNombre.Width = 180;
            // 
            // txEstado
            // 
            this.txEstado.Frozen = true;
            this.txEstado.HeaderText = "Estado";
            this.txEstado.Name = "txEstado";
            this.txEstado.ReadOnly = true;
            this.txEstado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.txEstado.Width = 150;
            // 
            // txDuracion
            // 
            this.txDuracion.Frozen = true;
            this.txDuracion.HeaderText = "Duración";
            this.txDuracion.Name = "txDuracion";
            this.txDuracion.ReadOnly = true;
            this.txDuracion.Width = 160;
            // 
            // txComentario
            // 
            this.txComentario.Frozen = true;
            this.txComentario.HeaderText = "Comentario";
            this.txComentario.Name = "txComentario";
            this.txComentario.ReadOnly = true;
            this.txComentario.Width = 250;
            // 
            // txCreado
            // 
            this.txCreado.Frozen = true;
            this.txCreado.HeaderText = "Creado el día";
            this.txCreado.Name = "txCreado";
            this.txCreado.ReadOnly = true;
            this.txCreado.Width = 250;
            // 
            // txIdPrueba
            // 
            this.txIdPrueba.Frozen = true;
            this.txIdPrueba.HeaderText = "";
            this.txIdPrueba.Name = "txIdPrueba";
            this.txIdPrueba.ReadOnly = true;
            this.txIdPrueba.Visible = false;
            // 
            // bnNueva
            // 
            this.bnNueva.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnNueva.Location = new System.Drawing.Point(39, 34);
            this.bnNueva.Name = "bnNueva";
            this.bnNueva.Size = new System.Drawing.Size(126, 36);
            this.bnNueva.TabIndex = 2;
            this.bnNueva.Text = "Nueva Prueva";
            this.bnNueva.UseVisualStyleBackColor = true;
            this.bnNueva.Click += new System.EventHandler(this.bnNueva_Click);
            // 
            // lblCurso
            // 
            this.lblCurso.AutoSize = true;
            this.lblCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCurso.Location = new System.Drawing.Point(72, 39);
            this.lblCurso.Name = "lblCurso";
            this.lblCurso.Size = new System.Drawing.Size(53, 18);
            this.lblCurso.TabIndex = 1;
            this.lblCurso.Text = "Curso:";
            // 
            // cbxCurso
            // 
            this.cbxCurso.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCurso.FormattingEnabled = true;
            this.cbxCurso.Location = new System.Drawing.Point(214, 31);
            this.cbxCurso.Name = "cbxCurso";
            this.cbxCurso.Size = new System.Drawing.Size(167, 26);
            this.cbxCurso.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.bnBusRespuestas);
            this.tabPage1.Controls.Add(this.lblCursoResp);
            this.tabPage1.Controls.Add(this.cbxCursoResp);
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1261, 571);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Calificar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gridPruebCalif
            // 
            this.gridPruebCalif.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPruebCalif.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.columnNombrePrueba,
            this.columnComentario,
            this.columnNombreEst,
            this.columnCed,
            this.columnEmail,
            this.columnIdResp,
            this.columnIdPrub,
            this.columnRespuestas});
            this.gridPruebCalif.Location = new System.Drawing.Point(106, 56);
            this.gridPruebCalif.Name = "gridPruebCalif";
            this.gridPruebCalif.RowHeadersVisible = false;
            this.gridPruebCalif.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridPruebCalif.Size = new System.Drawing.Size(833, 356);
            this.gridPruebCalif.TabIndex = 10;
            this.gridPruebCalif.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPruebCalif_CellContentDoubleClick);
            // 
            // columnNombrePrueba
            // 
            this.columnNombrePrueba.Frozen = true;
            this.columnNombrePrueba.HeaderText = "Nombre Prueba";
            this.columnNombrePrueba.Name = "columnNombrePrueba";
            this.columnNombrePrueba.ReadOnly = true;
            this.columnNombrePrueba.Width = 160;
            // 
            // columnComentario
            // 
            this.columnComentario.Frozen = true;
            this.columnComentario.HeaderText = "Comentarios";
            this.columnComentario.Name = "columnComentario";
            this.columnComentario.ReadOnly = true;
            this.columnComentario.Width = 200;
            // 
            // columnNombreEst
            // 
            this.columnNombreEst.Frozen = true;
            this.columnNombreEst.HeaderText = "Nombre Estudiante";
            this.columnNombreEst.Name = "columnNombreEst";
            this.columnNombreEst.ReadOnly = true;
            this.columnNombreEst.Width = 160;
            // 
            // columnCed
            // 
            this.columnCed.Frozen = true;
            this.columnCed.HeaderText = "Cédula";
            this.columnCed.Name = "columnCed";
            this.columnCed.ReadOnly = true;
            this.columnCed.Width = 150;
            // 
            // columnEmail
            // 
            this.columnEmail.Frozen = true;
            this.columnEmail.HeaderText = "Email";
            this.columnEmail.Name = "columnEmail";
            this.columnEmail.ReadOnly = true;
            this.columnEmail.Width = 160;
            // 
            // columnIdResp
            // 
            this.columnIdResp.Frozen = true;
            this.columnIdResp.HeaderText = "";
            this.columnIdResp.Name = "columnIdResp";
            this.columnIdResp.ReadOnly = true;
            this.columnIdResp.Visible = false;
            // 
            // columnIdPrub
            // 
            this.columnIdPrub.Frozen = true;
            this.columnIdPrub.HeaderText = "";
            this.columnIdPrub.Name = "columnIdPrub";
            this.columnIdPrub.ReadOnly = true;
            this.columnIdPrub.Visible = false;
            // 
            // columnRespuestas
            // 
            this.columnRespuestas.Frozen = true;
            this.columnRespuestas.HeaderText = "";
            this.columnRespuestas.Name = "columnRespuestas";
            this.columnRespuestas.ReadOnly = true;
            this.columnRespuestas.Visible = false;
            // 
            // bnBusRespuestas
            // 
            this.bnBusRespuestas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bnBusRespuestas.Location = new System.Drawing.Point(407, 24);
            this.bnBusRespuestas.Name = "bnBusRespuestas";
            this.bnBusRespuestas.Size = new System.Drawing.Size(126, 36);
            this.bnBusRespuestas.TabIndex = 9;
            this.bnBusRespuestas.Text = "Buscar Pruebas";
            this.bnBusRespuestas.UseVisualStyleBackColor = true;
            this.bnBusRespuestas.Click += new System.EventHandler(this.bnBusRespuestas_Click);
            // 
            // lblCursoResp
            // 
            this.lblCursoResp.AutoSize = true;
            this.lblCursoResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCursoResp.Location = new System.Drawing.Point(76, 32);
            this.lblCursoResp.Name = "lblCursoResp";
            this.lblCursoResp.Size = new System.Drawing.Size(130, 18);
            this.lblCursoResp.TabIndex = 8;
            this.lblCursoResp.Text = "Seleccione Curso:";
            // 
            // cbxCursoResp
            // 
            this.cbxCursoResp.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxCursoResp.FormattingEnabled = true;
            this.cbxCursoResp.Location = new System.Drawing.Point(212, 29);
            this.cbxCursoResp.Name = "cbxCursoResp";
            this.cbxCursoResp.Size = new System.Drawing.Size(167, 26);
            this.cbxCursoResp.TabIndex = 7;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.gridPruebCalif);
            this.groupBox3.Location = new System.Drawing.Point(49, 82);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1087, 449);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pruebas sin calificar";
            // 
            // InicioProfe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 657);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "InicioProfe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "eQuiz - Profesor";
            this.Activated += new System.EventHandler(this.InicioProfe_Activated);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabNotif.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPruebActivas)).EndInit();
            this.tabCursos.ResumeLayout(false);
            this.tabCursos.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridPruebas)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridPruebCalif)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem usuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabNotif;
        private System.Windows.Forms.TabPage tabCursos;
        private System.Windows.Forms.ComboBox cbxCurso;
        private System.Windows.Forms.Label lblCurso;
        private System.Windows.Forms.Button bnNueva;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView gridPruebas;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bnBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn txNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn txEstado;
        private System.Windows.Forms.DataGridViewTextBoxColumn txDuracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn txComentario;
        private System.Windows.Forms.DataGridViewTextBoxColumn txCreado;
        private System.Windows.Forms.DataGridViewTextBoxColumn txIdPrueba;
        private System.Windows.Forms.DataGridView gridPruebActivas;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button bnBuscarAct;
        private System.Windows.Forms.ComboBox cbxCurs;
        private System.Windows.Forms.Label lblcbxCurs;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView gridPruebCalif;
        private System.Windows.Forms.Button bnBusRespuestas;
        private System.Windows.Forms.Label lblCursoResp;
        private System.Windows.Forms.ComboBox cbxCursoResp;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNombrePrueba;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnComentario;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnNombreEst;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnCed;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIdResp;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnIdPrub;
        private System.Windows.Forms.DataGridViewTextBoxColumn columnRespuestas;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}