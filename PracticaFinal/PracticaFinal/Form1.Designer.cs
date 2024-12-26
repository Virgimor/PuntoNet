namespace PracticaFinal
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.alumnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.evaluacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.listarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.notasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvAlumno = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.apellidosDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nIFDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bajaDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.alumnosBS = new System.Windows.Forms.BindingSource(this.components);
            this.practicaDataSet = new PracticaFinal.practicaDataSet();
            this.alumnosTableAdapter = new PracticaFinal.practicaDataSetTableAdapters.AlumnosTableAdapter();
            this.btnGuardarAltaAlumno = new System.Windows.Forms.Button();
            this.btnGuardarModifiAlum = new System.Windows.Forms.Button();
            this.btnEliminarAlumno = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelApellidos = new System.Windows.Forms.Label();
            this.labelNif = new System.Windows.Forms.Label();
            this.checkBaja = new System.Windows.Forms.CheckBox();
            this.txtNif = new System.Windows.Forms.TextBox();
            this.panelMod_ElimAlumno = new System.Windows.Forms.Panel();
            this.paEvaAlta = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.labelEvaluacion = new System.Windows.Forms.Label();
            this.btnGuarAltaEva = new System.Windows.Forms.Button();
            this.txtEvaluaciones = new System.Windows.Forms.TextBox();
            this.panelEvaList = new System.Windows.Forms.Panel();
            this.evaluacionesBS = new System.Windows.Forms.BindingSource(this.components);
            this.panelEvaModif = new System.Windows.Forms.Panel();
            this.pictureBoxBorrar = new System.Windows.Forms.PictureBox();
            this.labelBorrarEva = new System.Windows.Forms.Label();
            this.pictureBoxModificar = new System.Windows.Forms.PictureBox();
            this.labelModificarEva = new System.Windows.Forms.Label();
            this.btnEvaBorrar = new System.Windows.Forms.Button();
            this.btnEvaGuarModifi = new System.Windows.Forms.Button();
            this.txtEvaModifi = new System.Windows.Forms.TextBox();
            this.cbxModificacines = new System.Windows.Forms.ComboBox();
            this.evaluacionesTableAdapter = new PracticaFinal.practicaDataSetTableAdapters.EvaluacionesTableAdapter();
            this.notasTableAdapter = new PracticaFinal.practicaDataSetTableAdapters.NotasTableAdapter();
            this.panelAltaAlumno = new System.Windows.Forms.Panel();
            this.pictureBoxAltaAlum = new System.Windows.Forms.PictureBox();
            this.panelNotas = new System.Windows.Forms.Panel();
            this.btnCrearNotas = new System.Windows.Forms.Button();
            this.listBoxNotas = new System.Windows.Forms.ListBox();
            this.btnGuardarNotas = new System.Windows.Forms.Button();
            this.btnEliminarNotas = new System.Windows.Forms.Button();
            this.btnModificarNotas = new System.Windows.Forms.Button();
            this.btnListarNotas = new System.Windows.Forms.Button();
            this.dgvNotas = new System.Windows.Forms.DataGridView();
            this.idAlumnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idEvaluacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dIDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pMDMDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notasBS = new System.Windows.Forms.BindingSource(this.components);
            this.cbxNotas = new System.Windows.Forms.ComboBox();
            this.checkNotas = new System.Windows.Forms.CheckBox();
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.alumnosTableAdapter1 = new PracticaFinal.practicaDataSetTableAdapters.AlumnosTableAdapter();
            this.dgvEvaluacion = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.evaluacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumno)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.practicaDataSet)).BeginInit();
            this.panelMod_ElimAlumno.SuspendLayout();
            this.paEvaAlta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelEvaList.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.evaluacionesBS)).BeginInit();
            this.panelEvaModif.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBorrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxModificar)).BeginInit();
            this.panelAltaAlumno.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAltaAlum)).BeginInit();
            this.panelNotas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasBS)).BeginInit();
            this.panelPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvaluacion)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Highlight;
            this.menuStrip1.Font = new System.Drawing.Font("Yu Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.alumnosToolStripMenuItem,
            this.evaluacionesToolStripMenuItem,
            this.notasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1200, 39);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // alumnosToolStripMenuItem
            // 
            this.alumnosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaToolStripMenuItem,
            this.listarToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.eliminarToolStripMenuItem});
            this.alumnosToolStripMenuItem.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alumnosToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.alumnosToolStripMenuItem.Name = "alumnosToolStripMenuItem";
            this.alumnosToolStripMenuItem.Size = new System.Drawing.Size(133, 35);
            this.alumnosToolStripMenuItem.Text = "Alumnos";
            // 
            // altaToolStripMenuItem
            // 
            this.altaToolStripMenuItem.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altaToolStripMenuItem.Name = "altaToolStripMenuItem";
            this.altaToolStripMenuItem.Size = new System.Drawing.Size(222, 40);
            this.altaToolStripMenuItem.Text = "Alta";
            this.altaToolStripMenuItem.Click += new System.EventHandler(this.altaToolStripMenuItem_Click);
            // 
            // listarToolStripMenuItem
            // 
            this.listarToolStripMenuItem.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listarToolStripMenuItem.Name = "listarToolStripMenuItem";
            this.listarToolStripMenuItem.Size = new System.Drawing.Size(222, 40);
            this.listarToolStripMenuItem.Text = "Listar";
            this.listarToolStripMenuItem.Click += new System.EventHandler(this.listarToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(222, 40);
            this.modificarToolStripMenuItem.Text = "Modificar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // eliminarToolStripMenuItem
            // 
            this.eliminarToolStripMenuItem.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            this.eliminarToolStripMenuItem.Size = new System.Drawing.Size(222, 40);
            this.eliminarToolStripMenuItem.Text = "Eliminar";
            this.eliminarToolStripMenuItem.Click += new System.EventHandler(this.eliminarToolStripMenuItem_Click);
            // 
            // evaluacionesToolStripMenuItem
            // 
            this.evaluacionesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaToolStripMenuItem1,
            this.listarToolStripMenuItem1,
            this.modificarToolStripMenuItem1,
            this.eliminarToolStripMenuItem1});
            this.evaluacionesToolStripMenuItem.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.evaluacionesToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.evaluacionesToolStripMenuItem.Name = "evaluacionesToolStripMenuItem";
            this.evaluacionesToolStripMenuItem.Size = new System.Drawing.Size(185, 35);
            this.evaluacionesToolStripMenuItem.Text = "Evaluaciones";
            // 
            // altaToolStripMenuItem1
            // 
            this.altaToolStripMenuItem1.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altaToolStripMenuItem1.Name = "altaToolStripMenuItem1";
            this.altaToolStripMenuItem1.Size = new System.Drawing.Size(222, 40);
            this.altaToolStripMenuItem1.Text = "Alta";
            this.altaToolStripMenuItem1.Click += new System.EventHandler(this.altaToolStripMenuItem1_Click);
            // 
            // listarToolStripMenuItem1
            // 
            this.listarToolStripMenuItem1.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listarToolStripMenuItem1.Name = "listarToolStripMenuItem1";
            this.listarToolStripMenuItem1.Size = new System.Drawing.Size(222, 40);
            this.listarToolStripMenuItem1.Text = "Listar";
            this.listarToolStripMenuItem1.Click += new System.EventHandler(this.listarToolStripMenuItem1_Click);
            // 
            // modificarToolStripMenuItem1
            // 
            this.modificarToolStripMenuItem1.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modificarToolStripMenuItem1.Name = "modificarToolStripMenuItem1";
            this.modificarToolStripMenuItem1.Size = new System.Drawing.Size(222, 40);
            this.modificarToolStripMenuItem1.Text = "Modificar";
            this.modificarToolStripMenuItem1.Click += new System.EventHandler(this.modificarToolStripMenuItem1_Click);
            // 
            // eliminarToolStripMenuItem1
            // 
            this.eliminarToolStripMenuItem1.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eliminarToolStripMenuItem1.Name = "eliminarToolStripMenuItem1";
            this.eliminarToolStripMenuItem1.Size = new System.Drawing.Size(222, 40);
            this.eliminarToolStripMenuItem1.Text = "Eliminar";
            this.eliminarToolStripMenuItem1.Click += new System.EventHandler(this.eliminarToolStripMenuItem1_Click);
            // 
            // notasToolStripMenuItem
            // 
            this.notasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consularToolStripMenuItem});
            this.notasToolStripMenuItem.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.notasToolStripMenuItem.Name = "notasToolStripMenuItem";
            this.notasToolStripMenuItem.Size = new System.Drawing.Size(99, 35);
            this.notasToolStripMenuItem.Text = "Notas";
            // 
            // consularToolStripMenuItem
            // 
            this.consularToolStripMenuItem.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.consularToolStripMenuItem.Name = "consularToolStripMenuItem";
            this.consularToolStripMenuItem.Size = new System.Drawing.Size(215, 40);
            this.consularToolStripMenuItem.Text = "Consular";
            this.consularToolStripMenuItem.Click += new System.EventHandler(this.consularToolStripMenuItem_Click);
            // 
            // dgvAlumno
            // 
            this.dgvAlumno.AutoGenerateColumns = false;
            this.dgvAlumno.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvAlumno.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvAlumno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAlumno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.apellidosDataGridViewTextBoxColumn,
            this.nIFDataGridViewTextBoxColumn,
            this.bajaDataGridViewCheckBoxColumn});
            this.dgvAlumno.DataSource = this.alumnosBS;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvAlumno.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvAlumno.Location = new System.Drawing.Point(0, 40);
            this.dgvAlumno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvAlumno.Name = "dgvAlumno";
            this.dgvAlumno.RowHeadersWidth = 62;
            this.dgvAlumno.Size = new System.Drawing.Size(1200, 482);
            this.dgvAlumno.TabIndex = 1;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 120;
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            this.nombreDataGridViewTextBoxColumn.Width = 150;
            // 
            // apellidosDataGridViewTextBoxColumn
            // 
            this.apellidosDataGridViewTextBoxColumn.DataPropertyName = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.HeaderText = "Apellidos";
            this.apellidosDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.apellidosDataGridViewTextBoxColumn.Name = "apellidosDataGridViewTextBoxColumn";
            this.apellidosDataGridViewTextBoxColumn.Width = 150;
            // 
            // nIFDataGridViewTextBoxColumn
            // 
            this.nIFDataGridViewTextBoxColumn.DataPropertyName = "NIF";
            this.nIFDataGridViewTextBoxColumn.HeaderText = "NIF";
            this.nIFDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.nIFDataGridViewTextBoxColumn.Name = "nIFDataGridViewTextBoxColumn";
            this.nIFDataGridViewTextBoxColumn.Width = 150;
            // 
            // bajaDataGridViewCheckBoxColumn
            // 
            this.bajaDataGridViewCheckBoxColumn.DataPropertyName = "baja";
            this.bajaDataGridViewCheckBoxColumn.HeaderText = "baja";
            this.bajaDataGridViewCheckBoxColumn.MinimumWidth = 8;
            this.bajaDataGridViewCheckBoxColumn.Name = "bajaDataGridViewCheckBoxColumn";
            this.bajaDataGridViewCheckBoxColumn.Width = 150;
            // 
            // alumnosBS
            // 
            this.alumnosBS.DataMember = "Alumnos";
            this.alumnosBS.DataSource = this.practicaDataSet;
            // 
            // practicaDataSet
            // 
            this.practicaDataSet.DataSetName = "practicaDataSet";
            this.practicaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // alumnosTableAdapter
            // 
            this.alumnosTableAdapter.ClearBeforeFill = true;
            // 
            // btnGuardarAltaAlumno
            // 
            this.btnGuardarAltaAlumno.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnGuardarAltaAlumno.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarAltaAlumno.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarAltaAlumno.Location = new System.Drawing.Point(264, 575);
            this.btnGuardarAltaAlumno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardarAltaAlumno.Name = "btnGuardarAltaAlumno";
            this.btnGuardarAltaAlumno.Size = new System.Drawing.Size(180, 60);
            this.btnGuardarAltaAlumno.TabIndex = 2;
            this.btnGuardarAltaAlumno.Text = "Guardar";
            this.btnGuardarAltaAlumno.UseVisualStyleBackColor = false;
            this.btnGuardarAltaAlumno.Click += new System.EventHandler(this.buttonGuardarAltaAlumno_Click);
            // 
            // btnGuardarModifiAlum
            // 
            this.btnGuardarModifiAlum.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnGuardarModifiAlum.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarModifiAlum.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarModifiAlum.Location = new System.Drawing.Point(79, 575);
            this.btnGuardarModifiAlum.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardarModifiAlum.Name = "btnGuardarModifiAlum";
            this.btnGuardarModifiAlum.Size = new System.Drawing.Size(186, 58);
            this.btnGuardarModifiAlum.TabIndex = 3;
            this.btnGuardarModifiAlum.Text = "Guardar";
            this.btnGuardarModifiAlum.UseVisualStyleBackColor = false;
            this.btnGuardarModifiAlum.Click += new System.EventHandler(this.buttonGuardarModifiAlum_Click);
            // 
            // btnEliminarAlumno
            // 
            this.btnEliminarAlumno.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEliminarAlumno.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarAlumno.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarAlumno.Location = new System.Drawing.Point(79, 575);
            this.btnEliminarAlumno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminarAlumno.Name = "btnEliminarAlumno";
            this.btnEliminarAlumno.Size = new System.Drawing.Size(186, 60);
            this.btnEliminarAlumno.TabIndex = 4;
            this.btnEliminarAlumno.Text = "Eliminar";
            this.btnEliminarAlumno.UseVisualStyleBackColor = false;
            this.btnEliminarAlumno.Click += new System.EventHandler(this.buttonEliminarAlumno_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Yu Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(372, 156);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(325, 52);
            this.txtNombre.TabIndex = 5;
            // 
            // txtApellido
            // 
            this.txtApellido.Font = new System.Drawing.Font("Yu Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(372, 240);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(325, 52);
            this.txtApellido.TabIndex = 6;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Font = new System.Drawing.Font("Yu Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.Location = new System.Drawing.Point(123, 172);
            this.labelNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(126, 36);
            this.labelNombre.TabIndex = 7;
            this.labelNombre.Text = "Nombre:";
            // 
            // labelApellidos
            // 
            this.labelApellidos.AutoSize = true;
            this.labelApellidos.Font = new System.Drawing.Font("Yu Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelApellidos.Location = new System.Drawing.Point(123, 249);
            this.labelApellidos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelApellidos.Name = "labelApellidos";
            this.labelApellidos.Size = new System.Drawing.Size(140, 36);
            this.labelApellidos.TabIndex = 8;
            this.labelApellidos.Text = "Apellidos:";
            // 
            // labelNif
            // 
            this.labelNif.AutoSize = true;
            this.labelNif.Font = new System.Drawing.Font("Yu Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNif.Location = new System.Drawing.Point(123, 334);
            this.labelNif.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNif.Name = "labelNif";
            this.labelNif.Size = new System.Drawing.Size(61, 36);
            this.labelNif.TabIndex = 9;
            this.labelNif.Text = "Nif:";
            // 
            // checkBaja
            // 
            this.checkBaja.AutoSize = true;
            this.checkBaja.Font = new System.Drawing.Font("Yu Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBaja.Location = new System.Drawing.Point(129, 430);
            this.checkBaja.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBaja.Name = "checkBaja";
            this.checkBaja.Size = new System.Drawing.Size(214, 40);
            this.checkBaja.TabIndex = 10;
            this.checkBaja.Text = "Dado de baja";
            this.checkBaja.UseVisualStyleBackColor = true;
            // 
            // txtNif
            // 
            this.txtNif.Font = new System.Drawing.Font("Yu Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNif.Location = new System.Drawing.Point(372, 326);
            this.txtNif.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNif.Name = "txtNif";
            this.txtNif.Size = new System.Drawing.Size(325, 52);
            this.txtNif.TabIndex = 11;
            // 
            // panelMod_ElimAlumno
            // 
            this.panelMod_ElimAlumno.Controls.Add(this.btnGuardarModifiAlum);
            this.panelMod_ElimAlumno.Controls.Add(this.btnEliminarAlumno);
            this.panelMod_ElimAlumno.Controls.Add(this.dgvAlumno);
            this.panelMod_ElimAlumno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMod_ElimAlumno.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelMod_ElimAlumno.Location = new System.Drawing.Point(0, 0);
            this.panelMod_ElimAlumno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMod_ElimAlumno.Name = "panelMod_ElimAlumno";
            this.panelMod_ElimAlumno.Size = new System.Drawing.Size(1200, 692);
            this.panelMod_ElimAlumno.TabIndex = 12;
            // 
            // paEvaAlta
            // 
            this.paEvaAlta.Controls.Add(this.pictureBox2);
            this.paEvaAlta.Controls.Add(this.labelEvaluacion);
            this.paEvaAlta.Controls.Add(this.btnGuarAltaEva);
            this.paEvaAlta.Controls.Add(this.txtEvaluaciones);
            this.paEvaAlta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paEvaAlta.Location = new System.Drawing.Point(0, 0);
            this.paEvaAlta.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.paEvaAlta.Name = "paEvaAlta";
            this.paEvaAlta.Size = new System.Drawing.Size(1200, 692);
            this.paEvaAlta.TabIndex = 12;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::PracticaFinal.Properties.Resources.formulario;
            this.pictureBox2.Location = new System.Drawing.Point(628, 316);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(390, 299);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // labelEvaluacion
            // 
            this.labelEvaluacion.AutoSize = true;
            this.labelEvaluacion.Font = new System.Drawing.Font("Yu Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEvaluacion.Location = new System.Drawing.Point(132, 190);
            this.labelEvaluacion.Name = "labelEvaluacion";
            this.labelEvaluacion.Size = new System.Drawing.Size(335, 36);
            this.labelEvaluacion.TabIndex = 2;
            this.labelEvaluacion.Text = "Nombre de la evaluación";
            // 
            // btnGuarAltaEva
            // 
            this.btnGuarAltaEva.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnGuarAltaEva.Font = new System.Drawing.Font("Yu Gothic Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuarAltaEva.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuarAltaEva.Location = new System.Drawing.Point(200, 515);
            this.btnGuarAltaEva.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuarAltaEva.Name = "btnGuarAltaEva";
            this.btnGuarAltaEva.Size = new System.Drawing.Size(201, 66);
            this.btnGuarAltaEva.TabIndex = 1;
            this.btnGuarAltaEva.Text = "Guardar";
            this.btnGuarAltaEva.UseVisualStyleBackColor = false;
            this.btnGuarAltaEva.Click += new System.EventHandler(this.btnGuarAltaEva_Click);
            // 
            // txtEvaluaciones
            // 
            this.txtEvaluaciones.Font = new System.Drawing.Font("Yu Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEvaluaciones.Location = new System.Drawing.Point(592, 172);
            this.txtEvaluaciones.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEvaluaciones.Multiline = true;
            this.txtEvaluaciones.Name = "txtEvaluaciones";
            this.txtEvaluaciones.Size = new System.Drawing.Size(492, 62);
            this.txtEvaluaciones.TabIndex = 0;
            // 
            // panelEvaList
            // 
            this.panelEvaList.Controls.Add(this.dgvEvaluacion);
            this.panelEvaList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEvaList.Location = new System.Drawing.Point(0, 0);
            this.panelEvaList.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelEvaList.Name = "panelEvaList";
            this.panelEvaList.Size = new System.Drawing.Size(1200, 692);
            this.panelEvaList.TabIndex = 2;
            // 
            // evaluacionesBS
            // 
            this.evaluacionesBS.DataMember = "Evaluaciones";
            this.evaluacionesBS.DataSource = this.practicaDataSet;
            // 
            // panelEvaModif
            // 
            this.panelEvaModif.Controls.Add(this.pictureBoxBorrar);
            this.panelEvaModif.Controls.Add(this.labelBorrarEva);
            this.panelEvaModif.Controls.Add(this.pictureBoxModificar);
            this.panelEvaModif.Controls.Add(this.labelModificarEva);
            this.panelEvaModif.Controls.Add(this.btnEvaBorrar);
            this.panelEvaModif.Controls.Add(this.btnEvaGuarModifi);
            this.panelEvaModif.Controls.Add(this.txtEvaModifi);
            this.panelEvaModif.Controls.Add(this.cbxModificacines);
            this.panelEvaModif.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEvaModif.Location = new System.Drawing.Point(0, 0);
            this.panelEvaModif.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelEvaModif.Name = "panelEvaModif";
            this.panelEvaModif.Size = new System.Drawing.Size(1200, 692);
            this.panelEvaModif.TabIndex = 1;
            // 
            // pictureBoxBorrar
            // 
            this.pictureBoxBorrar.Image = global::PracticaFinal.Properties.Resources.borrar;
            this.pictureBoxBorrar.Location = new System.Drawing.Point(763, 228);
            this.pictureBoxBorrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxBorrar.Name = "pictureBoxBorrar";
            this.pictureBoxBorrar.Size = new System.Drawing.Size(321, 295);
            this.pictureBoxBorrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxBorrar.TabIndex = 6;
            this.pictureBoxBorrar.TabStop = false;
            // 
            // labelBorrarEva
            // 
            this.labelBorrarEva.AutoSize = true;
            this.labelBorrarEva.Font = new System.Drawing.Font("Yu Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBorrarEva.Location = new System.Drawing.Point(102, 118);
            this.labelBorrarEva.Name = "labelBorrarEva";
            this.labelBorrarEva.Size = new System.Drawing.Size(496, 36);
            this.labelBorrarEva.TabIndex = 5;
            this.labelBorrarEva.Text = "Elige la evaluación que deseas borrar";
            // 
            // pictureBoxModificar
            // 
            this.pictureBoxModificar.Image = global::PracticaFinal.Properties.Resources.editar;
            this.pictureBoxModificar.Location = new System.Drawing.Point(763, 228);
            this.pictureBoxModificar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxModificar.Name = "pictureBoxModificar";
            this.pictureBoxModificar.Size = new System.Drawing.Size(321, 295);
            this.pictureBoxModificar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxModificar.TabIndex = 4;
            this.pictureBoxModificar.TabStop = false;
            // 
            // labelModificarEva
            // 
            this.labelModificarEva.AutoSize = true;
            this.labelModificarEva.Font = new System.Drawing.Font("Yu Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelModificarEva.Location = new System.Drawing.Point(102, 118);
            this.labelModificarEva.Name = "labelModificarEva";
            this.labelModificarEva.Size = new System.Drawing.Size(538, 36);
            this.labelModificarEva.TabIndex = 3;
            this.labelModificarEva.Text = "Elige la evaluación que deseas modificar";
            // 
            // btnEvaBorrar
            // 
            this.btnEvaBorrar.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEvaBorrar.Font = new System.Drawing.Font("Yu Gothic Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvaBorrar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEvaBorrar.Location = new System.Drawing.Point(256, 506);
            this.btnEvaBorrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEvaBorrar.Name = "btnEvaBorrar";
            this.btnEvaBorrar.Size = new System.Drawing.Size(188, 62);
            this.btnEvaBorrar.TabIndex = 1;
            this.btnEvaBorrar.Text = "Borrar";
            this.btnEvaBorrar.UseVisualStyleBackColor = false;
            this.btnEvaBorrar.Click += new System.EventHandler(this.btnEvaBorrar_Click);
            // 
            // btnEvaGuarModifi
            // 
            this.btnEvaGuarModifi.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEvaGuarModifi.Font = new System.Drawing.Font("Yu Gothic Medium", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEvaGuarModifi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEvaGuarModifi.Location = new System.Drawing.Point(256, 506);
            this.btnEvaGuarModifi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEvaGuarModifi.Name = "btnEvaGuarModifi";
            this.btnEvaGuarModifi.Size = new System.Drawing.Size(183, 61);
            this.btnEvaGuarModifi.TabIndex = 2;
            this.btnEvaGuarModifi.Text = "Guardar";
            this.btnEvaGuarModifi.UseVisualStyleBackColor = false;
            this.btnEvaGuarModifi.Click += new System.EventHandler(this.btnEvaGuarModifi_Click);
            // 
            // txtEvaModifi
            // 
            this.txtEvaModifi.Font = new System.Drawing.Font("Yu Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEvaModifi.Location = new System.Drawing.Point(155, 379);
            this.txtEvaModifi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEvaModifi.Multiline = true;
            this.txtEvaModifi.Name = "txtEvaModifi";
            this.txtEvaModifi.Size = new System.Drawing.Size(390, 44);
            this.txtEvaModifi.TabIndex = 1;
            // 
            // cbxModificacines
            // 
            this.cbxModificacines.DataSource = this.evaluacionesBS;
            this.cbxModificacines.DisplayMember = "Evaluacion";
            this.cbxModificacines.Font = new System.Drawing.Font("Yu Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxModificacines.FormattingEnabled = true;
            this.cbxModificacines.Location = new System.Drawing.Point(155, 268);
            this.cbxModificacines.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxModificacines.Name = "cbxModificacines";
            this.cbxModificacines.Size = new System.Drawing.Size(390, 44);
            this.cbxModificacines.TabIndex = 0;
            this.cbxModificacines.ValueMember = "Id";
            this.cbxModificacines.SelectedIndexChanged += new System.EventHandler(this.cbxModificacines_SelectedIndexChanged);
            // 
            // evaluacionesTableAdapter
            // 
            this.evaluacionesTableAdapter.ClearBeforeFill = true;
            // 
            // notasTableAdapter
            // 
            this.notasTableAdapter.ClearBeforeFill = true;
            // 
            // panelAltaAlumno
            // 
            this.panelAltaAlumno.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelAltaAlumno.Controls.Add(this.pictureBoxAltaAlum);
            this.panelAltaAlumno.Controls.Add(this.labelNombre);
            this.panelAltaAlumno.Controls.Add(this.labelNif);
            this.panelAltaAlumno.Controls.Add(this.labelApellidos);
            this.panelAltaAlumno.Controls.Add(this.txtNombre);
            this.panelAltaAlumno.Controls.Add(this.txtApellido);
            this.panelAltaAlumno.Controls.Add(this.txtNif);
            this.panelAltaAlumno.Controls.Add(this.checkBaja);
            this.panelAltaAlumno.Controls.Add(this.btnGuardarAltaAlumno);
            this.panelAltaAlumno.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelAltaAlumno.Location = new System.Drawing.Point(0, 0);
            this.panelAltaAlumno.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelAltaAlumno.Name = "panelAltaAlumno";
            this.panelAltaAlumno.Size = new System.Drawing.Size(1200, 692);
            this.panelAltaAlumno.TabIndex = 3;
            // 
            // pictureBoxAltaAlum
            // 
            this.pictureBoxAltaAlum.Image = global::PracticaFinal.Properties.Resources.formulario;
            this.pictureBoxAltaAlum.Location = new System.Drawing.Point(803, 138);
            this.pictureBoxAltaAlum.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxAltaAlum.Name = "pictureBoxAltaAlum";
            this.pictureBoxAltaAlum.Size = new System.Drawing.Size(281, 325);
            this.pictureBoxAltaAlum.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAltaAlum.TabIndex = 12;
            this.pictureBoxAltaAlum.TabStop = false;
            // 
            // panelNotas
            // 
            this.panelNotas.Controls.Add(this.btnCrearNotas);
            this.panelNotas.Controls.Add(this.listBoxNotas);
            this.panelNotas.Controls.Add(this.btnGuardarNotas);
            this.panelNotas.Controls.Add(this.btnEliminarNotas);
            this.panelNotas.Controls.Add(this.btnModificarNotas);
            this.panelNotas.Controls.Add(this.btnListarNotas);
            this.panelNotas.Controls.Add(this.dgvNotas);
            this.panelNotas.Controls.Add(this.cbxNotas);
            this.panelNotas.Controls.Add(this.checkNotas);
            this.panelNotas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelNotas.Location = new System.Drawing.Point(0, 0);
            this.panelNotas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelNotas.Name = "panelNotas";
            this.panelNotas.Size = new System.Drawing.Size(1200, 692);
            this.panelNotas.TabIndex = 3;
            // 
            // btnCrearNotas
            // 
            this.btnCrearNotas.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnCrearNotas.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearNotas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCrearNotas.Location = new System.Drawing.Point(706, 338);
            this.btnCrearNotas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCrearNotas.Name = "btnCrearNotas";
            this.btnCrearNotas.Size = new System.Drawing.Size(116, 52);
            this.btnCrearNotas.TabIndex = 9;
            this.btnCrearNotas.Text = "Crear";
            this.btnCrearNotas.UseVisualStyleBackColor = false;
            this.btnCrearNotas.Click += new System.EventHandler(this.btnCrearNotas_Click);
            // 
            // listBoxNotas
            // 
            this.listBoxNotas.DataSource = this.alumnosBS;
            this.listBoxNotas.DisplayMember = "Nombre";
            this.listBoxNotas.Font = new System.Drawing.Font("Yu Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxNotas.FormattingEnabled = true;
            this.listBoxNotas.ItemHeight = 36;
            this.listBoxNotas.Location = new System.Drawing.Point(58, 59);
            this.listBoxNotas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listBoxNotas.Name = "listBoxNotas";
            this.listBoxNotas.Size = new System.Drawing.Size(638, 220);
            this.listBoxNotas.TabIndex = 8;
            this.listBoxNotas.ValueMember = "Id";
            // 
            // btnGuardarNotas
            // 
            this.btnGuardarNotas.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnGuardarNotas.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarNotas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardarNotas.Location = new System.Drawing.Point(534, 338);
            this.btnGuardarNotas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGuardarNotas.Name = "btnGuardarNotas";
            this.btnGuardarNotas.Size = new System.Drawing.Size(140, 52);
            this.btnGuardarNotas.TabIndex = 7;
            this.btnGuardarNotas.Text = "Guardar";
            this.btnGuardarNotas.UseVisualStyleBackColor = false;
            this.btnGuardarNotas.Click += new System.EventHandler(this.btnGuardarNotas_Click);
            // 
            // btnEliminarNotas
            // 
            this.btnEliminarNotas.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEliminarNotas.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarNotas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEliminarNotas.Location = new System.Drawing.Point(362, 338);
            this.btnEliminarNotas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEliminarNotas.Name = "btnEliminarNotas";
            this.btnEliminarNotas.Size = new System.Drawing.Size(136, 52);
            this.btnEliminarNotas.TabIndex = 6;
            this.btnEliminarNotas.Text = "Eliminar";
            this.btnEliminarNotas.UseVisualStyleBackColor = false;
            this.btnEliminarNotas.Click += new System.EventHandler(this.btnEliminarNotas_Click);
            // 
            // btnModificarNotas
            // 
            this.btnModificarNotas.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnModificarNotas.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificarNotas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnModificarNotas.Location = new System.Drawing.Point(200, 338);
            this.btnModificarNotas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnModificarNotas.Name = "btnModificarNotas";
            this.btnModificarNotas.Size = new System.Drawing.Size(136, 52);
            this.btnModificarNotas.TabIndex = 5;
            this.btnModificarNotas.Text = "Modificar";
            this.btnModificarNotas.UseVisualStyleBackColor = false;
            this.btnModificarNotas.Click += new System.EventHandler(this.btnModificarNotas_Click);
            // 
            // btnListarNotas
            // 
            this.btnListarNotas.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnListarNotas.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListarNotas.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnListarNotas.Location = new System.Drawing.Point(45, 338);
            this.btnListarNotas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnListarNotas.Name = "btnListarNotas";
            this.btnListarNotas.Size = new System.Drawing.Size(136, 49);
            this.btnListarNotas.TabIndex = 4;
            this.btnListarNotas.Text = "Listar";
            this.btnListarNotas.UseVisualStyleBackColor = false;
            this.btnListarNotas.Click += new System.EventHandler(this.btnListarNotas_Click);
            // 
            // dgvNotas
            // 
            this.dgvNotas.AutoGenerateColumns = false;
            this.dgvNotas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Yu Gothic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvNotas.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvNotas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNotas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idAlumnoDataGridViewTextBoxColumn,
            this.idEvaluacionDataGridViewTextBoxColumn,
            this.dIDataGridViewTextBoxColumn,
            this.pMDMDataGridViewTextBoxColumn,
            this.aDDataGridViewTextBoxColumn});
            this.dgvNotas.DataSource = this.notasBS;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Yu Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvNotas.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvNotas.Location = new System.Drawing.Point(0, 414);
            this.dgvNotas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvNotas.Name = "dgvNotas";
            this.dgvNotas.ReadOnly = true;
            this.dgvNotas.RowHeadersWidth = 62;
            this.dgvNotas.RowTemplate.Height = 28;
            this.dgvNotas.Size = new System.Drawing.Size(1200, 278);
            this.dgvNotas.TabIndex = 3;
            // 
            // idAlumnoDataGridViewTextBoxColumn
            // 
            this.idAlumnoDataGridViewTextBoxColumn.DataPropertyName = "Id_Alumno";
            this.idAlumnoDataGridViewTextBoxColumn.HeaderText = "Id_Alumno";
            this.idAlumnoDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idAlumnoDataGridViewTextBoxColumn.Name = "idAlumnoDataGridViewTextBoxColumn";
            this.idAlumnoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idAlumnoDataGridViewTextBoxColumn.Width = 130;
            // 
            // idEvaluacionDataGridViewTextBoxColumn
            // 
            this.idEvaluacionDataGridViewTextBoxColumn.DataPropertyName = "Id_Evaluacion";
            this.idEvaluacionDataGridViewTextBoxColumn.HeaderText = "Id_Evaluacion";
            this.idEvaluacionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.idEvaluacionDataGridViewTextBoxColumn.Name = "idEvaluacionDataGridViewTextBoxColumn";
            this.idEvaluacionDataGridViewTextBoxColumn.ReadOnly = true;
            this.idEvaluacionDataGridViewTextBoxColumn.Width = 130;
            // 
            // dIDataGridViewTextBoxColumn
            // 
            this.dIDataGridViewTextBoxColumn.DataPropertyName = "DI";
            this.dIDataGridViewTextBoxColumn.HeaderText = "DI";
            this.dIDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.dIDataGridViewTextBoxColumn.Name = "dIDataGridViewTextBoxColumn";
            this.dIDataGridViewTextBoxColumn.ReadOnly = true;
            this.dIDataGridViewTextBoxColumn.Width = 130;
            // 
            // pMDMDataGridViewTextBoxColumn
            // 
            this.pMDMDataGridViewTextBoxColumn.DataPropertyName = "PMDM";
            this.pMDMDataGridViewTextBoxColumn.HeaderText = "PMDM";
            this.pMDMDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.pMDMDataGridViewTextBoxColumn.Name = "pMDMDataGridViewTextBoxColumn";
            this.pMDMDataGridViewTextBoxColumn.ReadOnly = true;
            this.pMDMDataGridViewTextBoxColumn.Width = 130;
            // 
            // aDDataGridViewTextBoxColumn
            // 
            this.aDDataGridViewTextBoxColumn.DataPropertyName = "AD";
            this.aDDataGridViewTextBoxColumn.HeaderText = "AD";
            this.aDDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.aDDataGridViewTextBoxColumn.Name = "aDDataGridViewTextBoxColumn";
            this.aDDataGridViewTextBoxColumn.ReadOnly = true;
            this.aDDataGridViewTextBoxColumn.Width = 130;
            // 
            // notasBS
            // 
            this.notasBS.DataMember = "Notas";
            this.notasBS.DataSource = this.practicaDataSet;
            // 
            // cbxNotas
            // 
            this.cbxNotas.DataSource = this.evaluacionesBS;
            this.cbxNotas.DisplayMember = "Evaluacion";
            this.cbxNotas.Font = new System.Drawing.Font("Yu Gothic", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNotas.FormattingEnabled = true;
            this.cbxNotas.Location = new System.Drawing.Point(776, 79);
            this.cbxNotas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbxNotas.Name = "cbxNotas";
            this.cbxNotas.Size = new System.Drawing.Size(370, 42);
            this.cbxNotas.TabIndex = 2;
            this.cbxNotas.ValueMember = "Id";
            // 
            // checkNotas
            // 
            this.checkNotas.AutoSize = true;
            this.checkNotas.Font = new System.Drawing.Font("Yu Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkNotas.Location = new System.Drawing.Point(776, 184);
            this.checkNotas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.checkNotas.Name = "checkNotas";
            this.checkNotas.Size = new System.Drawing.Size(118, 40);
            this.checkNotas.TabIndex = 1;
            this.checkNotas.Text = "Todos";
            this.checkNotas.UseVisualStyleBackColor = true;
            this.checkNotas.CheckedChanged += new System.EventHandler(this.checkNotas_CheckedChanged);
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.Controls.Add(this.pictureBox3);
            this.panelPrincipal.Controls.Add(this.label1);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(1200, 692);
            this.panelPrincipal.TabIndex = 10;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::PracticaFinal.Properties.Resources.Microsoft_dotNET;
            this.pictureBox3.Location = new System.Drawing.Point(264, 316);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(645, 229);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(377, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(396, 77);
            this.label1.TabIndex = 0;
            this.label1.Text = "Practica final";
            // 
            // alumnosTableAdapter1
            // 
            this.alumnosTableAdapter1.ClearBeforeFill = true;
            // 
            // dgvEvaluacion
            // 
            this.dgvEvaluacion.AutoGenerateColumns = false;
            this.dgvEvaluacion.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Yu Gothic", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvEvaluacion.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvEvaluacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEvaluacion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn2,
            this.evaluacionDataGridViewTextBoxColumn});
            this.dgvEvaluacion.DataSource = this.evaluacionesBS;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Yu Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvEvaluacion.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvEvaluacion.Location = new System.Drawing.Point(0, 40);
            this.dgvEvaluacion.Name = "dgvEvaluacion";
            this.dgvEvaluacion.RowHeadersWidth = 62;
            this.dgvEvaluacion.RowTemplate.Height = 28;
            this.dgvEvaluacion.Size = new System.Drawing.Size(1200, 652);
            this.dgvEvaluacion.TabIndex = 2;
            // 
            // idDataGridViewTextBoxColumn2
            // 
            this.idDataGridViewTextBoxColumn2.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn2.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.idDataGridViewTextBoxColumn2.Name = "idDataGridViewTextBoxColumn2";
            this.idDataGridViewTextBoxColumn2.Width = 130;
            // 
            // evaluacionDataGridViewTextBoxColumn
            // 
            this.evaluacionDataGridViewTextBoxColumn.DataPropertyName = "Evaluacion";
            this.evaluacionDataGridViewTextBoxColumn.HeaderText = "Evaluacion";
            this.evaluacionDataGridViewTextBoxColumn.MinimumWidth = 8;
            this.evaluacionDataGridViewTextBoxColumn.Name = "evaluacionDataGridViewTextBoxColumn";
            this.evaluacionDataGridViewTextBoxColumn.Width = 200;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panelEvaList);
            this.Controls.Add(this.paEvaAlta);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.panelAltaAlumno);
            this.Controls.Add(this.panelMod_ElimAlumno);
            this.Controls.Add(this.panelEvaModif);
            this.Controls.Add(this.panelNotas);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAlumno)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.alumnosBS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.practicaDataSet)).EndInit();
            this.panelMod_ElimAlumno.ResumeLayout(false);
            this.paEvaAlta.ResumeLayout(false);
            this.paEvaAlta.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelEvaList.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.evaluacionesBS)).EndInit();
            this.panelEvaModif.ResumeLayout(false);
            this.panelEvaModif.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBorrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxModificar)).EndInit();
            this.panelAltaAlumno.ResumeLayout(false);
            this.panelAltaAlumno.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAltaAlum)).EndInit();
            this.panelNotas.ResumeLayout(false);
            this.panelNotas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNotas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notasBS)).EndInit();
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEvaluacion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem alumnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem evaluacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem listarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem eliminarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem notasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consularToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvAlumno;
        private practicaDataSet practicaDataSet;
        private System.Windows.Forms.BindingSource alumnosBS;
        private practicaDataSetTableAdapters.AlumnosTableAdapter alumnosTableAdapter;
        private System.Windows.Forms.Button btnGuardarAltaAlumno;
        private System.Windows.Forms.Button btnGuardarModifiAlum;
        private System.Windows.Forms.Button btnEliminarAlumno;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelApellidos;
        private System.Windows.Forms.Label labelNif;
        private System.Windows.Forms.CheckBox checkBaja;
        private System.Windows.Forms.TextBox txtNif;
        private System.Windows.Forms.Panel panelMod_ElimAlumno;
        private System.Windows.Forms.Panel paEvaAlta;
        private System.Windows.Forms.Button btnGuarAltaEva;
        private System.Windows.Forms.TextBox txtEvaluaciones;
        private System.Windows.Forms.Panel panelEvaList;
        private System.Windows.Forms.Panel panelEvaModif;
        private System.Windows.Forms.Button btnEvaGuarModifi;
        private System.Windows.Forms.TextBox txtEvaModifi;
        private System.Windows.Forms.ComboBox cbxModificacines;
        private System.Windows.Forms.BindingSource evaluacionesBS;
        private practicaDataSetTableAdapters.EvaluacionesTableAdapter evaluacionesTableAdapter;
        private System.Windows.Forms.Button btnEvaBorrar;
        private practicaDataSetTableAdapters.NotasTableAdapter notasTableAdapter;
        private System.Windows.Forms.Panel panelAltaAlumno;
        private System.Windows.Forms.Panel panelNotas;
        private System.Windows.Forms.Button btnEliminarNotas;
        private System.Windows.Forms.Button btnModificarNotas;
        private System.Windows.Forms.Button btnListarNotas;
        private System.Windows.Forms.DataGridView dgvNotas;
        private System.Windows.Forms.CheckBox checkNotas;
        private System.Windows.Forms.ComboBox cbxNotas;
        private System.Windows.Forms.Button btnGuardarNotas;
        private System.Windows.Forms.ListBox listBoxNotas;
        private System.Windows.Forms.BindingSource notasBS;
        private System.Windows.Forms.PictureBox pictureBoxAltaAlum;
        private System.Windows.Forms.Label labelEvaluacion;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btnCrearNotas;
        private System.Windows.Forms.Panel panelPrincipal;
        private practicaDataSetTableAdapters.AlumnosTableAdapter alumnosTableAdapter1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label labelModificarEva;
        private System.Windows.Forms.PictureBox pictureBoxModificar;
        private System.Windows.Forms.PictureBox pictureBoxBorrar;
        private System.Windows.Forms.Label labelBorrarEva;
        private System.Windows.Forms.DataGridViewTextBoxColumn idAlumnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idEvaluacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dIDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pMDMDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn apellidosDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nIFDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn bajaDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridView dgvEvaluacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn evaluacionDataGridViewTextBoxColumn;
    }
}

