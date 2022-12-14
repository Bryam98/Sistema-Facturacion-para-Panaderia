namespace SFPanaderia.Vistas
{
    partial class FEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FEmpleados));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabEmpleados = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rrInactivos = new System.Windows.Forms.RadioButton();
            this.rrActivo = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnEliminar = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditar = new DevExpress.XtraEditors.SimpleButton();
            this.btnSalir = new DevExpress.XtraEditors.SimpleButton();
            this.gridEmpleados = new DevExpress.XtraGrid.GridControl();
            this.xpEmpleados = new DevExpress.Xpo.XPCollection(this.components);
            this.sessionEmpleados = new DevExpress.Xpo.UnitOfWork(this.components);
            this.gridViewEmpleados = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEmpleado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombres = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colApellidos = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSexo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaNacimiento = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCedula = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDireccion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTelefono = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaRegistro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dateFNacimiento = new DevExpress.XtraEditors.TextEdit();
            this.ctTelefono = new System.Windows.Forms.MaskedTextBox();
            this.searchEstado = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.xpEstado = new DevExpress.Xpo.XPCollection(this.components);
            this.searchLookUpEstado = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.searchCargo = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.xpCargos = new DevExpress.Xpo.XPCollection(this.components);
            this.searchLookUpCargo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ctCedula = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
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
            this.tMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2.SuspendLayout();
            this.tabEmpleados.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmpleados)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateFNacimiento.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchCargo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCargos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpCargo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Menu;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(714, 48);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(84, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Empleados";
            // 
            // tabEmpleados
            // 
            this.tabEmpleados.Controls.Add(this.tabPage1);
            this.tabEmpleados.Controls.Add(this.tabPage2);
            this.tabEmpleados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabEmpleados.Location = new System.Drawing.Point(0, 48);
            this.tabEmpleados.Name = "tabEmpleados";
            this.tabEmpleados.SelectedIndex = 0;
            this.tabEmpleados.Size = new System.Drawing.Size(714, 413);
            this.tabEmpleados.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.gridEmpleados);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(706, 387);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado de Empleados";
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
            this.groupBox1.Size = new System.Drawing.Size(700, 36);
            this.groupBox1.TabIndex = 1;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.btnEliminar);
            this.panel1.Controls.Add(this.btnEditar);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(3, 339);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(700, 45);
            this.panel1.TabIndex = 2;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEliminar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.ImageOptions.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(340, 0);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(120, 45);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEditar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.ImageOptions.Image")));
            this.btnEditar.Location = new System.Drawing.Point(460, 0);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(120, 45);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSalir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.ImageOptions.Image")));
            this.btnSalir.Location = new System.Drawing.Point(580, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(120, 45);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // gridEmpleados
            // 
            this.gridEmpleados.DataSource = this.xpEmpleados;
            this.gridEmpleados.Location = new System.Drawing.Point(3, 39);
            this.gridEmpleados.MainView = this.gridViewEmpleados;
            this.gridEmpleados.Name = "gridEmpleados";
            this.gridEmpleados.Size = new System.Drawing.Size(700, 294);
            this.gridEmpleados.TabIndex = 8;
            this.gridEmpleados.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewEmpleados});
            // 
            // xpEmpleados
            // 
            this.xpEmpleados.ObjectType = typeof(SFPanaderia.PanaderiaBD.Empleado);
            this.xpEmpleados.Session = this.sessionEmpleados;
            // 
            // sessionEmpleados
            // 
            this.sessionEmpleados.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.sessionEmpleados.TrackPropertiesModifications = false;
            // 
            // gridViewEmpleados
            // 
            this.gridViewEmpleados.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEmpleado,
            this.colNombres,
            this.colApellidos,
            this.colSexo,
            this.colFechaNacimiento,
            this.colCedula,
            this.colDireccion,
            this.colTelefono,
            this.colFechaRegistro,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gridViewEmpleados.GridControl = this.gridEmpleados;
            this.gridViewEmpleados.Name = "gridViewEmpleados";
            this.gridViewEmpleados.OptionsBehavior.Editable = false;
            this.gridViewEmpleados.OptionsFind.AlwaysVisible = true;
            this.gridViewEmpleados.OptionsFind.ShowFindButton = false;
            this.gridViewEmpleados.OptionsNavigation.UseTabKey = false;
            this.gridViewEmpleados.OptionsView.ColumnAutoWidth = false;
            this.gridViewEmpleados.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            // 
            // colIdEmpleado
            // 
            this.colIdEmpleado.FieldName = "IdEmpleado";
            this.colIdEmpleado.Name = "colIdEmpleado";
            this.colIdEmpleado.Visible = true;
            this.colIdEmpleado.VisibleIndex = 0;
            // 
            // colNombres
            // 
            this.colNombres.FieldName = "Nombres";
            this.colNombres.Name = "colNombres";
            this.colNombres.Visible = true;
            this.colNombres.VisibleIndex = 1;
            this.colNombres.Width = 104;
            // 
            // colApellidos
            // 
            this.colApellidos.FieldName = "Apellidos";
            this.colApellidos.Name = "colApellidos";
            this.colApellidos.Visible = true;
            this.colApellidos.VisibleIndex = 2;
            this.colApellidos.Width = 102;
            // 
            // colSexo
            // 
            this.colSexo.FieldName = "Sexo";
            this.colSexo.Name = "colSexo";
            this.colSexo.Visible = true;
            this.colSexo.VisibleIndex = 3;
            this.colSexo.Width = 36;
            // 
            // colFechaNacimiento
            // 
            this.colFechaNacimiento.FieldName = "FechaNacimiento";
            this.colFechaNacimiento.Name = "colFechaNacimiento";
            this.colFechaNacimiento.Visible = true;
            this.colFechaNacimiento.VisibleIndex = 5;
            // 
            // colCedula
            // 
            this.colCedula.FieldName = "Cedula";
            this.colCedula.Name = "colCedula";
            this.colCedula.Visible = true;
            this.colCedula.VisibleIndex = 6;
            this.colCedula.Width = 117;
            // 
            // colDireccion
            // 
            this.colDireccion.FieldName = "Direccion";
            this.colDireccion.Name = "colDireccion";
            this.colDireccion.Visible = true;
            this.colDireccion.VisibleIndex = 7;
            this.colDireccion.Width = 162;
            // 
            // colTelefono
            // 
            this.colTelefono.FieldName = "Telefono";
            this.colTelefono.Name = "colTelefono";
            this.colTelefono.Visible = true;
            this.colTelefono.VisibleIndex = 8;
            // 
            // colFechaRegistro
            // 
            this.colFechaRegistro.FieldName = "FechaRegistro";
            this.colFechaRegistro.Name = "colFechaRegistro";
            this.colFechaRegistro.Visible = true;
            this.colFechaRegistro.VisibleIndex = 10;
            this.colFechaRegistro.Width = 90;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "IdCargo!";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Cargo";
            this.gridColumn2.FieldName = "IdCargo.Nombre";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 4;
            this.gridColumn2.Width = 84;
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "IdEstado!";
            this.gridColumn3.Name = "gridColumn3";
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Estado";
            this.gridColumn4.FieldName = "IdEstado.Nombre";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 9;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dateFNacimiento);
            this.tabPage2.Controls.Add(this.ctTelefono);
            this.tabPage2.Controls.Add(this.searchEstado);
            this.tabPage2.Controls.Add(this.searchCargo);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.ctCedula);
            this.tabPage2.Controls.Add(this.label9);
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
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(706, 387);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento de Empleados";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dateFNacimiento
            // 
            this.dateFNacimiento.Location = new System.Drawing.Point(393, 155);
            this.dateFNacimiento.Name = "dateFNacimiento";
            this.dateFNacimiento.Properties.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFNacimiento.Properties.Appearance.Options.UseFont = true;
            this.dateFNacimiento.Properties.Mask.EditMask = "d";
            this.dateFNacimiento.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.dateFNacimiento.Size = new System.Drawing.Size(71, 22);
            this.dateFNacimiento.TabIndex = 7;
            // 
            // ctTelefono
            // 
            this.ctTelefono.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctTelefono.Location = new System.Drawing.Point(100, 238);
            this.ctTelefono.Mask = "0000-0000";
            this.ctTelefono.Name = "ctTelefono";
            this.ctTelefono.Size = new System.Drawing.Size(116, 22);
            this.ctTelefono.TabIndex = 9;
            // 
            // searchEstado
            // 
            this.searchEstado.Enabled = false;
            this.searchEstado.Location = new System.Drawing.Point(393, 238);
            this.searchEstado.Name = "searchEstado";
            this.searchEstado.Properties.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchEstado.Properties.Appearance.Options.UseFont = true;
            this.searchEstado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchEstado.Properties.DataSource = this.xpEstado;
            this.searchEstado.Properties.DisplayMember = "Nombre";
            this.searchEstado.Properties.PopupView = this.searchLookUpEstado;
            this.searchEstado.Properties.ValueMember = "IdEstado";
            this.searchEstado.Size = new System.Drawing.Size(107, 22);
            this.searchEstado.TabIndex = 10;
            // 
            // xpEstado
            // 
            this.xpEstado.ObjectType = typeof(SFPanaderia.PanaderiaBD.Estado);
            this.xpEstado.Session = this.sessionEmpleados;
            // 
            // searchLookUpEstado
            // 
            this.searchLookUpEstado.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEstado.Name = "searchLookUpEstado";
            this.searchLookUpEstado.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEstado.OptionsView.ShowGroupPanel = false;
            // 
            // searchCargo
            // 
            this.searchCargo.Location = new System.Drawing.Point(96, 156);
            this.searchCargo.Name = "searchCargo";
            this.searchCargo.Properties.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchCargo.Properties.Appearance.Options.UseFont = true;
            this.searchCargo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchCargo.Properties.DataSource = this.xpCargos;
            this.searchCargo.Properties.DisplayMember = "Nombre";
            this.searchCargo.Properties.PopupView = this.searchLookUpCargo;
            this.searchCargo.Properties.ValueMember = "IdCargo";
            this.searchCargo.Size = new System.Drawing.Size(144, 22);
            this.searchCargo.TabIndex = 6;
            // 
            // xpCargos
            // 
            this.xpCargos.ObjectType = typeof(SFPanaderia.PanaderiaBD.Cargo);
            this.xpCargos.Session = this.sessionEmpleados;
            // 
            // searchLookUpCargo
            // 
            this.searchLookUpCargo.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpCargo.Name = "searchLookUpCargo";
            this.searchLookUpCargo.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpCargo.OptionsView.ShowGroupPanel = false;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(41, 158);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 15);
            this.label11.TabIndex = 44;
            this.label11.Text = "Cargo:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(266, 157);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 15);
            this.label10.TabIndex = 43;
            this.label10.Text = "Fecha Nacimiento:";
            // 
            // ctCedula
            // 
            this.ctCedula.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctCedula.Location = new System.Drawing.Point(393, 116);
            this.ctCedula.Mask = "000-000000-0000>L";
            this.ctCedula.Name = "ctCedula";
            this.ctCedula.Size = new System.Drawing.Size(164, 22);
            this.ctCedula.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(332, 241);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 15);
            this.label9.TabIndex = 40;
            this.label9.Text = "Estado:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Appearance.Options.UseFont = true;
            this.btnCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.ImageOptions.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(364, 307);
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
            this.btnGuardar.Location = new System.Drawing.Point(231, 307);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 41);
            this.btnGuardar.TabIndex = 18;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Appearance.Options.UseFont = true;
            this.btnNuevo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.ImageOptions.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(96, 307);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(120, 41);
            this.btnNuevo.TabIndex = 17;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 241);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 15);
            this.label8.TabIndex = 35;
            this.label8.Text = "Telefono:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 15);
            this.label7.TabIndex = 34;
            this.label7.Text = "Direccion:";
            // 
            // ctDireccion
            // 
            this.ctDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ctDireccion.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctDireccion.Location = new System.Drawing.Point(96, 192);
            this.ctDireccion.Name = "ctDireccion";
            this.ctDireccion.Size = new System.Drawing.Size(514, 22);
            this.ctDireccion.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(327, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 15);
            this.label6.TabIndex = 32;
            this.label6.Text = "Cedula:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 31;
            this.label2.Text = "Codigo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 15);
            this.label5.TabIndex = 30;
            this.label5.Text = "Sexo:";
            // 
            // cbSexo
            // 
            this.cbSexo.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSexo.FormattingEnabled = true;
            this.cbSexo.Items.AddRange(new object[] {
            "FEMENINO",
            "MASCULINO"});
            this.cbSexo.Location = new System.Drawing.Point(96, 116);
            this.cbSexo.Name = "cbSexo";
            this.cbSexo.Size = new System.Drawing.Size(86, 24);
            this.cbSexo.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(313, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 15);
            this.label4.TabIndex = 28;
            this.label4.Text = "Apellidos: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(23, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 15);
            this.label3.TabIndex = 27;
            this.label3.Text = "Nombres:";
            // 
            // ctApellidos
            // 
            this.ctApellidos.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ctApellidos.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctApellidos.Location = new System.Drawing.Point(393, 78);
            this.ctApellidos.Name = "ctApellidos";
            this.ctApellidos.Size = new System.Drawing.Size(239, 22);
            this.ctApellidos.TabIndex = 3;
            this.ctApellidos.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ctApellidos_KeyPress);
            // 
            // ctNombres
            // 
            this.ctNombres.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ctNombres.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctNombres.Location = new System.Drawing.Point(96, 78);
            this.ctNombres.Name = "ctNombres";
            this.ctNombres.Size = new System.Drawing.Size(192, 22);
            this.ctNombres.TabIndex = 2;
            this.ctNombres.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ctNombres_KeyPress);
            // 
            // ctId
            // 
            this.ctId.Enabled = false;
            this.ctId.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctId.Location = new System.Drawing.Point(96, 42);
            this.ctId.Name = "ctId";
            this.ctId.Size = new System.Drawing.Size(100, 22);
            this.ctId.TabIndex = 1;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // FEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 461);
            this.Controls.Add(this.tabEmpleados);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FEmpleados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FEmpleado";
            this.Load += new System.EventHandler(this.FEmpleado_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabEmpleados.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEmpleados)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateFNacimiento.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpEstado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEstado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchCargo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCargos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpCargo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabEmpleados;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private DevExpress.XtraGrid.GridControl gridEmpleados;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewEmpleados;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnEliminar;
        private DevExpress.XtraEditors.SimpleButton btnEditar;
        private DevExpress.XtraEditors.SimpleButton btnSalir;
        private System.Windows.Forms.MaskedTextBox ctCedula;
        private System.Windows.Forms.Label label9;
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
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private DevExpress.Xpo.UnitOfWork sessionEmpleados;
        private DevExpress.Xpo.XPCollection xpEmpleados;
        private DevExpress.Xpo.XPCollection xpEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEmpleado;
        private DevExpress.XtraGrid.Columns.GridColumn colNombres;
        private DevExpress.XtraGrid.Columns.GridColumn colApellidos;
        private DevExpress.XtraGrid.Columns.GridColumn colSexo;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaNacimiento;
        private DevExpress.XtraGrid.Columns.GridColumn colCedula;
        private DevExpress.XtraGrid.Columns.GridColumn colDireccion;
        private DevExpress.XtraGrid.Columns.GridColumn colTelefono;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaRegistro;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.SearchLookUpEdit searchCargo;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpCargo;
        private System.Windows.Forms.ToolTip tMensaje;
        private DevExpress.XtraEditors.SearchLookUpEdit searchEstado;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEstado;
        private DevExpress.Xpo.XPCollection xpCargos;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rrInactivos;
        private System.Windows.Forms.RadioButton rrActivo;
        private System.Windows.Forms.MaskedTextBox ctTelefono;
        private DevExpress.XtraEditors.TextEdit dateFNacimiento;
    }
}