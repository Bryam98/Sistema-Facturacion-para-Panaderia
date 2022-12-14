namespace SFPanaderia.Vistas
{
    partial class FUsuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FUsuario));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControlUsuarios = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rrInactivos = new System.Windows.Forms.RadioButton();
            this.rrActivo = new System.Windows.Forms.RadioButton();
            this.gridUsuarios = new DevExpress.XtraGrid.GridControl();
            this.xpUsuarios = new DevExpress.Xpo.XPCollection(this.components);
            this.sessionUsuarios = new DevExpress.Xpo.UnitOfWork(this.components);
            this.gridViewUsuarios = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdUsuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLogin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colClave = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaRegistro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEliminar = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditar = new DevExpress.XtraEditors.SimpleButton();
            this.btnSalir = new DevExpress.XtraEditors.SimpleButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.searchEmpleado = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.xpEmpleados = new DevExpress.Xpo.XPCollection(this.components);
            this.searchViewEmpleados = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CkMostrar = new System.Windows.Forms.CheckBox();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.btnNuevo = new DevExpress.XtraEditors.SimpleButton();
            this.label6 = new System.Windows.Forms.Label();
            this.ctClave = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ctCorfirmacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ctUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ctId = new System.Windows.Forms.TextBox();
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.tabControlUsuarios.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionUsuarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUsuarios)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchEmpleado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchViewEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(634, 48);
            this.panel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(68, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Usuarios";
            // 
            // tabControlUsuarios
            // 
            this.tabControlUsuarios.Controls.Add(this.tabPage1);
            this.tabControlUsuarios.Controls.Add(this.tabPage2);
            this.tabControlUsuarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlUsuarios.Location = new System.Drawing.Point(0, 48);
            this.tabControlUsuarios.Name = "tabControlUsuarios";
            this.tabControlUsuarios.SelectedIndex = 0;
            this.tabControlUsuarios.Size = new System.Drawing.Size(634, 403);
            this.tabControlUsuarios.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.gridUsuarios);
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(626, 377);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado de Usuarios";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rrInactivos);
            this.groupBox1.Controls.Add(this.rrActivo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(620, 33);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado Empleados";
            // 
            // rrInactivos
            // 
            this.rrInactivos.AutoSize = true;
            this.rrInactivos.Location = new System.Drawing.Point(194, 12);
            this.rrInactivos.Name = "rrInactivos";
            this.rrInactivos.Size = new System.Drawing.Size(77, 17);
            this.rrInactivos.TabIndex = 4;
            this.rrInactivos.TabStop = true;
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
            this.rrActivo.TabIndex = 3;
            this.rrActivo.TabStop = true;
            this.rrActivo.Text = "Activos";
            this.rrActivo.UseVisualStyleBackColor = true;
            this.rrActivo.CheckedChanged += new System.EventHandler(this.rrActivo_CheckedChanged);
            // 
            // gridUsuarios
            // 
            this.gridUsuarios.DataSource = this.xpUsuarios;
            this.gridUsuarios.Location = new System.Drawing.Point(3, 38);
            this.gridUsuarios.MainView = this.gridViewUsuarios;
            this.gridUsuarios.Name = "gridUsuarios";
            this.gridUsuarios.Size = new System.Drawing.Size(620, 283);
            this.gridUsuarios.TabIndex = 8;
            this.gridUsuarios.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewUsuarios});
            // 
            // xpUsuarios
            // 
            this.xpUsuarios.ObjectType = typeof(SFPanaderia.PanaderiaBD.Usuario);
            this.xpUsuarios.Session = this.sessionUsuarios;
            // 
            // sessionUsuarios
            // 
            this.sessionUsuarios.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.sessionUsuarios.TrackPropertiesModifications = false;
            // 
            // gridViewUsuarios
            // 
            this.gridViewUsuarios.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdUsuario,
            this.colLogin,
            this.colClave,
            this.colFechaRegistro,
            this.gridColumn1,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gridViewUsuarios.GridControl = this.gridUsuarios;
            this.gridViewUsuarios.Name = "gridViewUsuarios";
            this.gridViewUsuarios.OptionsBehavior.Editable = false;
            this.gridViewUsuarios.OptionsFind.AlwaysVisible = true;
            this.gridViewUsuarios.OptionsFind.ShowFindButton = false;
            this.gridViewUsuarios.OptionsNavigation.UseTabKey = false;
            this.gridViewUsuarios.OptionsView.ColumnAutoWidth = false;
            this.gridViewUsuarios.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            // 
            // colIdUsuario
            // 
            this.colIdUsuario.FieldName = "IdUsuario";
            this.colIdUsuario.Name = "colIdUsuario";
            this.colIdUsuario.Visible = true;
            this.colIdUsuario.VisibleIndex = 0;
            this.colIdUsuario.Width = 83;
            // 
            // colLogin
            // 
            this.colLogin.FieldName = "Login";
            this.colLogin.Name = "colLogin";
            this.colLogin.Visible = true;
            this.colLogin.VisibleIndex = 1;
            this.colLogin.Width = 122;
            // 
            // colClave
            // 
            this.colClave.FieldName = "Clave";
            this.colClave.Name = "colClave";
            this.colClave.Visible = true;
            this.colClave.VisibleIndex = 2;
            this.colClave.Width = 136;
            // 
            // colFechaRegistro
            // 
            this.colFechaRegistro.FieldName = "FechaRegistro";
            this.colFechaRegistro.Name = "colFechaRegistro";
            this.colFechaRegistro.Visible = true;
            this.colFechaRegistro.VisibleIndex = 3;
            this.colFechaRegistro.Width = 116;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "IdEmpleado!";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Width = 91;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Nombres";
            this.gridColumn3.FieldName = "IdEmpleado.Nombres";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 4;
            this.gridColumn3.Width = 136;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Apellidos";
            this.gridColumn4.FieldName = "IdEmpleado.Apellidos";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 5;
            this.gridColumn4.Width = 116;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Cargo";
            this.gridColumn5.FieldName = "IdEmpleado.IdCargo.Nombre";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 6;
            this.gridColumn5.Width = 100;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnEliminar);
            this.panel2.Controls.Add(this.btnEditar);
            this.panel2.Controls.Add(this.btnSalir);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 327);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(620, 47);
            this.panel2.TabIndex = 3;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Appearance.Options.UseFont = true;
            this.btnEliminar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEliminar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.ImageOptions.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(290, 0);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(110, 47);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Appearance.Options.UseFont = true;
            this.btnEditar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEditar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.ImageOptions.Image")));
            this.btnEditar.Location = new System.Drawing.Point(400, 0);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(110, 47);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Appearance.Options.UseFont = true;
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSalir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.ImageOptions.Image")));
            this.btnSalir.Location = new System.Drawing.Point(510, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(110, 47);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.searchEmpleado);
            this.tabPage2.Controls.Add(this.CkMostrar);
            this.tabPage2.Controls.Add(this.btnCancelar);
            this.tabPage2.Controls.Add(this.btnGuardar);
            this.tabPage2.Controls.Add(this.btnNuevo);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.ctClave);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.ctCorfirmacion);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.ctUsuario);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.ctId);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(626, 377);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // searchEmpleado
            // 
            this.searchEmpleado.Location = new System.Drawing.Point(104, 83);
            this.searchEmpleado.Name = "searchEmpleado";
            this.searchEmpleado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchEmpleado.Properties.DataSource = this.xpEmpleados;
            this.searchEmpleado.Properties.DisplayMember = "Nombres";
            this.searchEmpleado.Properties.PopupView = this.searchViewEmpleados;
            this.searchEmpleado.Properties.ValueMember = "IdEmpleado";
            this.searchEmpleado.Size = new System.Drawing.Size(187, 20);
            this.searchEmpleado.TabIndex = 10;
            this.searchEmpleado.Popup += new System.EventHandler(this.searchEmpleado_Popup);
            // 
            // xpEmpleados
            // 
            this.xpEmpleados.DisplayableProperties = "This;IdEmpleado;Nombres;Apellidos;Direccion;Telefono;IdCargo;Cedula;IdEstado.Nomb" +
    "re";
            this.xpEmpleados.ObjectType = typeof(SFPanaderia.PanaderiaBD.Empleado);
            this.xpEmpleados.Session = this.sessionUsuarios;
            // 
            // searchViewEmpleados
            // 
            this.searchViewEmpleados.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchViewEmpleados.Name = "searchViewEmpleados";
            this.searchViewEmpleados.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchViewEmpleados.OptionsView.ColumnAutoWidth = false;
            this.searchViewEmpleados.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.searchViewEmpleados.OptionsView.ShowGroupPanel = false;
            // 
            // CkMostrar
            // 
            this.CkMostrar.AutoSize = true;
            this.CkMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CkMostrar.Location = new System.Drawing.Point(101, 184);
            this.CkMostrar.Name = "CkMostrar";
            this.CkMostrar.Size = new System.Drawing.Size(152, 19);
            this.CkMostrar.TabIndex = 3;
            this.CkMostrar.Text = "Mostrar Contraseña";
            this.CkMostrar.UseVisualStyleBackColor = true;
            this.CkMostrar.CheckedChanged += new System.EventHandler(this.CkMostrar_CheckedChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Appearance.Options.UseFont = true;
            this.btnCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.ImageOptions.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(337, 287);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 46);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Appearance.Options.UseFont = true;
            this.btnGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.ImageOptions.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(219, 287);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(112, 46);
            this.btnGuardar.TabIndex = 7;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Appearance.Options.UseFont = true;
            this.btnNuevo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.ImageOptions.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(101, 287);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(112, 46);
            this.btnNuevo.TabIndex = 6;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(21, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(76, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Empleado:";
            // 
            // ctClave
            // 
            this.ctClave.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctClave.Location = new System.Drawing.Point(101, 158);
            this.ctClave.Name = "ctClave";
            this.ctClave.PasswordChar = '*';
            this.ctClave.Size = new System.Drawing.Size(205, 22);
            this.ctClave.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(22, 216);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Confirme: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "Clave:";
            // 
            // ctCorfirmacion
            // 
            this.ctCorfirmacion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctCorfirmacion.Location = new System.Drawing.Point(101, 216);
            this.ctCorfirmacion.Name = "ctCorfirmacion";
            this.ctCorfirmacion.PasswordChar = '*';
            this.ctCorfirmacion.Size = new System.Drawing.Size(205, 22);
            this.ctCorfirmacion.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Usuario:";
            // 
            // ctUsuario
            // 
            this.ctUsuario.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctUsuario.Location = new System.Drawing.Point(101, 119);
            this.ctUsuario.MaxLength = 12;
            this.ctUsuario.Name = "ctUsuario";
            this.ctUsuario.Size = new System.Drawing.Size(135, 22);
            this.ctUsuario.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Codigo: ";
            // 
            // ctId
            // 
            this.ctId.Enabled = false;
            this.ctId.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctId.Location = new System.Drawing.Point(102, 43);
            this.ctId.Name = "ctId";
            this.ctId.Size = new System.Drawing.Size(100, 22);
            this.ctId.TabIndex = 0;
            // 
            // FUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 451);
            this.Controls.Add(this.tabControlUsuarios);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FUsuario";
            this.Load += new System.EventHandler(this.FUsuario_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControlUsuarios.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionUsuarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewUsuarios)).EndInit();
            this.panel2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchEmpleado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchViewEmpleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControlUsuarios;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton btnEliminar;
        private DevExpress.XtraEditors.SimpleButton btnEditar;
        private DevExpress.XtraEditors.SimpleButton btnSalir;
        private DevExpress.Xpo.UnitOfWork sessionUsuarios;
        private System.Windows.Forms.ToolTip ttMensaje;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ctCorfirmacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ctUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ctId;
        private System.Windows.Forms.TextBox ctClave;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraEditors.SimpleButton btnNuevo;
        private System.Windows.Forms.CheckBox CkMostrar;
        private DevExpress.Xpo.XPCollection xpUsuarios;
        private DevExpress.XtraGrid.GridControl gridUsuarios;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewUsuarios;
        private DevExpress.XtraGrid.Columns.GridColumn colIdUsuario;
        private DevExpress.XtraGrid.Columns.GridColumn colLogin;
        private DevExpress.XtraGrid.Columns.GridColumn colClave;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaRegistro;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rrInactivos;
        private System.Windows.Forms.RadioButton rrActivo;
        private System.Windows.Forms.Label label6;
        private DevExpress.Xpo.XPCollection xpEmpleados;
        private DevExpress.XtraEditors.SearchLookUpEdit searchEmpleado;
        private DevExpress.XtraGrid.Views.Grid.GridView searchViewEmpleados;
    }
}