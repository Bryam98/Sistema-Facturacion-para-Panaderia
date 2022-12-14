namespace SFPanaderia.Vistas
{
    partial class FClientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FClientes));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSalir = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditar = new DevExpress.XtraEditors.SimpleButton();
            this.btnEliminar = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rrInactivos = new System.Windows.Forms.RadioButton();
            this.rrActivo = new System.Windows.Forms.RadioButton();
            this.gridClientes = new DevExpress.XtraGrid.GridControl();
            this.xpClientes = new DevExpress.Xpo.XPCollection(this.components);
            this.sessionClientes = new DevExpress.Xpo.UnitOfWork(this.components);
            this.gridViewClientes = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCliente = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApellidos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSexo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDireccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCedula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefono = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaRegistro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ctTelefono = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ctCedula = new System.Windows.Forms.MaskedTextBox();
            this.searchLookEstado = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.xpEstado = new DevExpress.Xpo.XPCollection(this.components);
            this.searchLookUpEstado = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.btnNuevo = new DevExpress.XtraEditors.SimpleButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ctDireccion = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbSexo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ctApellidos = new System.Windows.Forms.TextBox();
            this.ctNombres = new System.Windows.Forms.TextBox();
            this.ctId = new System.Windows.Forms.TextBox();
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewClientes)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEstado)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 48);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(714, 433);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSalir);
            this.tabPage1.Controls.Add(this.btnEditar);
            this.tabPage1.Controls.Add(this.btnEliminar);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.gridClientes);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(706, 407);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado Clientes";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.ImageOptions.Image")));
            this.btnSalir.Location = new System.Drawing.Point(580, 356);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(120, 45);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.ImageOptions.Image")));
            this.btnEditar.Location = new System.Drawing.Point(454, 356);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(120, 45);
            this.btnEditar.TabIndex = 1;
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.ImageOptions.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(328, 356);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(120, 45);
            this.btnEliminar.TabIndex = 0;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rrInactivos);
            this.groupBox1.Controls.Add(this.rrActivo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(700, 36);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado Clientes";
            // 
            // rrInactivos
            // 
            this.rrInactivos.AutoSize = true;
            this.rrInactivos.Location = new System.Drawing.Point(194, 12);
            this.rrInactivos.Name = "rrInactivos";
            this.rrInactivos.Size = new System.Drawing.Size(77, 17);
            this.rrInactivos.TabIndex = 2;
            this.rrInactivos.Text = "Inactivos";
            this.rrInactivos.UseVisualStyleBackColor = true;
            this.rrInactivos.CheckedChanged += new System.EventHandler(this.rrInactivos_CheckedChanged);
            // 
            // rrActivo
            // 
            this.rrActivo.AutoSize = true;
            this.rrActivo.Checked = true;
            this.rrActivo.Location = new System.Drawing.Point(119, 12);
            this.rrActivo.Name = "rrActivo";
            this.rrActivo.Size = new System.Drawing.Size(67, 17);
            this.rrActivo.TabIndex = 1;
            this.rrActivo.TabStop = true;
            this.rrActivo.Text = "Activos";
            this.rrActivo.UseVisualStyleBackColor = true;
            this.rrActivo.CheckedChanged += new System.EventHandler(this.rrActivo_CheckedChanged);
            // 
            // gridClientes
            // 
            this.gridClientes.DataSource = this.xpClientes;
            this.gridClientes.Location = new System.Drawing.Point(3, 38);
            this.gridClientes.MainView = this.gridViewClientes;
            this.gridClientes.Name = "gridClientes";
            this.gridClientes.Size = new System.Drawing.Size(700, 312);
            this.gridClientes.TabIndex = 2;
            this.gridClientes.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewClientes});
            // 
            // xpClientes
            // 
            this.xpClientes.ObjectType = typeof(SFPanaderia.PanaderiaBD.Cliente);
            this.xpClientes.Session = this.sessionClientes;
            // 
            // sessionClientes
            // 
            this.sessionClientes.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.sessionClientes.TrackPropertiesModifications = false;
            // 
            // gridViewClientes
            // 
            this.gridViewClientes.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCliente,
            this.colNombres,
            this.colApellidos,
            this.colSexo,
            this.colDireccion,
            this.colCedula,
            this.colTelefono,
            this.colFechaRegistro,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3});
            this.gridViewClientes.GridControl = this.gridClientes;
            this.gridViewClientes.Name = "gridViewClientes";
            this.gridViewClientes.OptionsBehavior.Editable = false;
            this.gridViewClientes.OptionsFind.AlwaysVisible = true;
            this.gridViewClientes.OptionsFind.ShowFindButton = false;
            this.gridViewClientes.OptionsNavigation.UseTabKey = false;
            this.gridViewClientes.OptionsView.ColumnAutoWidth = false;
            this.gridViewClientes.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            // 
            // colIdCliente
            // 
            this.colIdCliente.Caption = "Codigo";
            this.colIdCliente.FieldName = "IdCliente";
            this.colIdCliente.Name = "colIdCliente";
            this.colIdCliente.Visible = true;
            this.colIdCliente.VisibleIndex = 0;
            this.colIdCliente.Width = 58;
            // 
            // colNombres
            // 
            this.colNombres.FieldName = "Nombres";
            this.colNombres.Name = "colNombres";
            this.colNombres.Visible = true;
            this.colNombres.VisibleIndex = 1;
            this.colNombres.Width = 152;
            // 
            // colApellidos
            // 
            this.colApellidos.FieldName = "Apellidos";
            this.colApellidos.Name = "colApellidos";
            this.colApellidos.Visible = true;
            this.colApellidos.VisibleIndex = 2;
            this.colApellidos.Width = 139;
            // 
            // colSexo
            // 
            this.colSexo.FieldName = "Sexo";
            this.colSexo.Name = "colSexo";
            this.colSexo.Visible = true;
            this.colSexo.VisibleIndex = 6;
            this.colSexo.Width = 41;
            // 
            // colDireccion
            // 
            this.colDireccion.FieldName = "Direccion";
            this.colDireccion.Name = "colDireccion";
            this.colDireccion.Visible = true;
            this.colDireccion.VisibleIndex = 5;
            this.colDireccion.Width = 191;
            // 
            // colCedula
            // 
            this.colCedula.FieldName = "Cedula";
            this.colCedula.Name = "colCedula";
            this.colCedula.Visible = true;
            this.colCedula.VisibleIndex = 3;
            this.colCedula.Width = 140;
            // 
            // colTelefono
            // 
            this.colTelefono.FieldName = "Telefono";
            this.colTelefono.Name = "colTelefono";
            this.colTelefono.Visible = true;
            this.colTelefono.VisibleIndex = 4;
            this.colTelefono.Width = 96;
            // 
            // colFechaRegistro
            // 
            this.colFechaRegistro.FieldName = "FechaRegistro";
            this.colFechaRegistro.Name = "colFechaRegistro";
            this.colFechaRegistro.Visible = true;
            this.colFechaRegistro.VisibleIndex = 7;
            this.colFechaRegistro.Width = 90;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "IdEstado!";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Width = 96;
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "IdEstado!Key";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Width = 92;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Estado";
            this.gridColumn3.FieldName = "IdEstado.Nombre";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 8;
            this.gridColumn3.Width = 97;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ctTelefono);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.ctCedula);
            this.tabPage2.Controls.Add(this.searchLookEstado);
            this.tabPage2.Controls.Add(this.btnCancelar);
            this.tabPage2.Controls.Add(this.btnGuardar);
            this.tabPage2.Controls.Add(this.btnNuevo);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.ctDireccion);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.cbSexo);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.ctApellidos);
            this.tabPage2.Controls.Add(this.ctNombres);
            this.tabPage2.Controls.Add(this.ctId);
            this.tabPage2.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(706, 407);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ctTelefono
            // 
            this.ctTelefono.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctTelefono.Location = new System.Drawing.Point(96, 194);
            this.ctTelefono.Mask = "0000-0000";
            this.ctTelefono.Name = "ctTelefono";
            this.ctTelefono.Size = new System.Drawing.Size(100, 22);
            this.ctTelefono.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(327, 199);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 24;
            this.label9.Text = "Estado: ";
            // 
            // ctCedula
            // 
            this.ctCedula.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctCedula.Location = new System.Drawing.Point(387, 115);
            this.ctCedula.Mask = "000-000000-0000>L";
            this.ctCedula.Name = "ctCedula";
            this.ctCedula.Size = new System.Drawing.Size(158, 22);
            this.ctCedula.TabIndex = 4;
            // 
            // searchLookEstado
            // 
            this.searchLookEstado.EditValue = 1;
            this.searchLookEstado.Enabled = false;
            this.searchLookEstado.Location = new System.Drawing.Point(387, 194);
            this.searchLookEstado.Name = "searchLookEstado";
            this.searchLookEstado.Properties.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLookEstado.Properties.Appearance.Options.UseFont = true;
            this.searchLookEstado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchLookEstado.Properties.DataSource = this.xpEstado;
            this.searchLookEstado.Properties.DisplayMember = "Nombre";
            this.searchLookEstado.Properties.PopupView = this.searchLookUpEstado;
            this.searchLookEstado.Properties.ValueMember = "IdEstado";
            this.searchLookEstado.Size = new System.Drawing.Size(134, 22);
            this.searchLookEstado.TabIndex = 7;
            // 
            // xpEstado
            // 
            this.xpEstado.ObjectType = typeof(SFPanaderia.PanaderiaBD.Estado);
            this.xpEstado.Session = this.sessionClientes;
            // 
            // searchLookUpEstado
            // 
            this.searchLookUpEstado.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEstado.Name = "searchLookUpEstado";
            this.searchLookUpEstado.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEstado.OptionsView.ShowGroupPanel = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Appearance.Options.UseFont = true;
            this.btnCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.ImageOptions.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(364, 259);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 41);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Appearance.Options.UseFont = true;
            this.btnGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.ImageOptions.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(231, 259);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 41);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Appearance.Options.UseFont = true;
            this.btnNuevo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.ImageOptions.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(96, 259);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(120, 41);
            this.btnNuevo.TabIndex = 16;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(25, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 14;
            this.label8.Text = "Telefono:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 15);
            this.label7.TabIndex = 13;
            this.label7.Text = "Direccion:";
            // 
            // ctDireccion
            // 
            this.ctDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ctDireccion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctDireccion.Location = new System.Drawing.Point(96, 155);
            this.ctDireccion.Name = "ctDireccion";
            this.ctDireccion.Size = new System.Drawing.Size(514, 22);
            this.ctDireccion.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(325, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Cedula:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "Codigo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(47, 115);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sexo:";
            // 
            // cbSexo
            // 
            this.cbSexo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "Femenino",
            "Masculino"});
            this.cbSexo.Location = new System.Drawing.Point(96, 115);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(86, 24);
            this.cbSexo.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(310, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Apellidos: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombres:";
            // 
            // ctApellidos
            // 
            this.ctApellidos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ctApellidos.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctApellidos.Location = new System.Drawing.Point(387, 76);
            this.ctApellidos.Name = "ctApellidos";
            this.ctApellidos.Size = new System.Drawing.Size(227, 22);
            this.ctApellidos.TabIndex = 2;
            this.ctApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ctApellidos_KeyPress);
            // 
            // ctNombres
            // 
            this.ctNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ctNombres.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctNombres.Location = new System.Drawing.Point(96, 77);
            this.ctNombres.Name = "ctNombres";
            this.ctNombres.Size = new System.Drawing.Size(192, 22);
            this.ctNombres.TabIndex = 1;
            this.ctNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ctNombres_KeyPress);
            // 
            // ctId
            // 
            this.ctId.Enabled = false;
            this.ctId.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctId.Location = new System.Drawing.Point(96, 39);
            this.ctId.Name = "ctId";
            this.ctId.Size = new System.Drawing.Size(100, 22);
            this.ctId.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Menu;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(714, 42);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Clientes";
            // 
            // FClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 481);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FClientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.FClientes_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewClientes)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpEstado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEstado)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraEditors.SimpleButton btnNuevo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ctDireccion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbSexo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ctApellidos;
        private System.Windows.Forms.TextBox ctNombres;
        private System.Windows.Forms.TextBox ctId;
        private DevExpress.Xpo.UnitOfWork sessionClientes;
        private DevExpress.Xpo.XPCollection xpClientes;
        private System.Windows.Forms.ToolTip ttMensaje;
        private DevExpress.XtraEditors.SimpleButton btnEliminar;
        private DevExpress.XtraEditors.SimpleButton btnEditar;
        private DevExpress.XtraEditors.SimpleButton btnSalir;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private DevExpress.Xpo.XPCollection xpEstado;
        private System.Windows.Forms.MaskedTextBox ctCedula;
        private DevExpress.XtraEditors.SearchLookUpEdit searchLookEstado;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEstado;
        private DevExpress.XtraGrid.GridControl gridClientes;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewClientes;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCliente;
        private DevExpress.XtraGrid.Columns.GridColumn colNombres;
        private DevExpress.XtraGrid.Columns.GridColumn colApellidos;
        private DevExpress.XtraGrid.Columns.GridColumn colSexo;
        private DevExpress.XtraGrid.Columns.GridColumn colDireccion;
        private DevExpress.XtraGrid.Columns.GridColumn colCedula;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefono;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaRegistro;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rrInactivos;
        private System.Windows.Forms.RadioButton rrActivo;
        private System.Windows.Forms.MaskedTextBox ctTelefono;
    }
}