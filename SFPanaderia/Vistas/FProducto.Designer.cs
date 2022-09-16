namespace SFPanaderia.Vistas
{
    partial class FProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FProducto));
            this.rrInactivos = new System.Windows.Forms.RadioButton();
            this.rrActivo = new System.Windows.Forms.RadioButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSalir = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditar = new DevExpress.XtraEditors.SimpleButton();
            this.btnEliminar = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gridProductos = new DevExpress.XtraGrid.GridControl();
            this.xpProductos = new DevExpress.Xpo.XPCollection(this.components);
            this.sessionProductos = new DevExpress.Xpo.UnitOfWork(this.components);
            this.gridViewProductos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecioUnidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExistencias = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaRegistro = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Estado = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label8 = new System.Windows.Forms.Label();
            this.dateFRegistro = new DevExpress.XtraEditors.DateEdit();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.btnNuevo = new DevExpress.XtraEditors.SimpleButton();
            this.searchEstado = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.xpEstado = new DevExpress.Xpo.XPCollection(this.components);
            this.searchEditEstado = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label7 = new System.Windows.Forms.Label();
            this.searchPresentacion = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.xpPresentacion = new DevExpress.Xpo.XPCollection(this.components);
            this.searchEditPresentacion = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ctPrecio = new System.Windows.Forms.TextBox();
            this.ctCantidad = new System.Windows.Forms.TextBox();
            this.searchCategoria = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.xpCategorias = new DevExpress.Xpo.XPCollection(this.components);
            this.searchEditCategoria = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ctId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ctNombre = new System.Windows.Forms.TextBox();
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProductos)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateFRegistro.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFRegistro.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchEditEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchPresentacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpPresentacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchEditPresentacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchCategoria.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCategorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchEditCategoria)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabControl1.Location = new System.Drawing.Point(0, 62);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(714, 429);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSalir);
            this.tabPage1.Controls.Add(this.btnEditar);
            this.tabPage1.Controls.Add(this.btnEliminar);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.gridProductos);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(706, 403);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado de Productos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSalir
            // 
            this.btnSalir.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Appearance.Options.UseFont = true;
            this.btnSalir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.ImageOptions.Image")));
            this.btnSalir.Location = new System.Drawing.Point(583, 352);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(120, 43);
            this.btnSalir.TabIndex = 6;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Appearance.Options.UseFont = true;
            this.btnEditar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.ImageOptions.Image")));
            this.btnEditar.Location = new System.Drawing.Point(457, 352);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(120, 43);
            this.btnEditar.TabIndex = 5;
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Appearance.Options.UseFont = true;
            this.btnEliminar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.ImageOptions.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(331, 352);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(120, 43);
            this.btnEliminar.TabIndex = 4;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rrInactivos);
            this.groupBox1.Controls.Add(this.rrActivo);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(700, 35);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Estado Productos";
            // 
            // gridProductos
            // 
            this.gridProductos.DataSource = this.xpProductos;
            this.gridProductos.Location = new System.Drawing.Point(3, 38);
            this.gridProductos.MainView = this.gridViewProductos;
            this.gridProductos.Name = "gridProductos";
            this.gridProductos.Size = new System.Drawing.Size(700, 308);
            this.gridProductos.TabIndex = 3;
            this.gridProductos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewProductos});
            // 
            // xpProductos
            // 
            this.xpProductos.ObjectType = typeof(SFPanaderia.PanaderiaBD.Producto);
            this.xpProductos.Session = this.sessionProductos;
            // 
            // sessionProductos
            // 
            this.sessionProductos.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.sessionProductos.TrackPropertiesModifications = false;
            // 
            // gridViewProductos
            // 
            this.gridViewProductos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdProducto,
            this.colNombre,
            this.colPrecioUnidad,
            this.colExistencias,
            this.colFechaRegistro,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.Estado});
            this.gridViewProductos.GridControl = this.gridProductos;
            this.gridViewProductos.Name = "gridViewProductos";
            this.gridViewProductos.OptionsBehavior.Editable = false;
            this.gridViewProductos.OptionsFind.AlwaysVisible = true;
            this.gridViewProductos.OptionsFind.ShowFindButton = false;
            this.gridViewProductos.OptionsNavigation.UseTabKey = false;
            this.gridViewProductos.OptionsView.ColumnAutoWidth = false;
            this.gridViewProductos.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            // 
            // colIdProducto
            // 
            this.colIdProducto.FieldName = "IdProducto";
            this.colIdProducto.Name = "colIdProducto";
            this.colIdProducto.Visible = true;
            this.colIdProducto.VisibleIndex = 0;
            this.colIdProducto.Width = 72;
            // 
            // colNombre
            // 
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 1;
            this.colNombre.Width = 153;
            // 
            // colPrecioUnidad
            // 
            this.colPrecioUnidad.FieldName = "PrecioUnidad";
            this.colPrecioUnidad.Name = "colPrecioUnidad";
            this.colPrecioUnidad.Visible = true;
            this.colPrecioUnidad.VisibleIndex = 3;
            // 
            // colExistencias
            // 
            this.colExistencias.FieldName = "Existencias";
            this.colExistencias.Name = "colExistencias";
            this.colExistencias.Visible = true;
            this.colExistencias.VisibleIndex = 5;
            this.colExistencias.Width = 74;
            // 
            // colFechaRegistro
            // 
            this.colFechaRegistro.FieldName = "FechaRegistro";
            this.colFechaRegistro.Name = "colFechaRegistro";
            this.colFechaRegistro.Visible = true;
            this.colFechaRegistro.VisibleIndex = 6;
            this.colFechaRegistro.Width = 78;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "IdCategoria!";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Categoria";
            this.gridColumn2.FieldName = "IdCategoria.Nombre";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 4;
            this.gridColumn2.Width = 89;
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "IdPresentacion!";
            this.gridColumn3.Name = "gridColumn3";
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Presentacion";
            this.gridColumn4.FieldName = "IdPresentacion.Nombre";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 95;
            // 
            // gridColumn5
            // 
            this.gridColumn5.FieldName = "IdEstado.Nombre";
            this.gridColumn5.Name = "gridColumn5";
            // 
            // Estado
            // 
            this.Estado.Caption = "Estado";
            this.Estado.FieldName = "IdEstado.Nombre";
            this.Estado.Name = "Estado";
            this.Estado.Visible = true;
            this.Estado.VisibleIndex = 7;
            this.Estado.Width = 85;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.dateFRegistro);
            this.tabPage2.Controls.Add(this.btnCancelar);
            this.tabPage2.Controls.Add(this.btnGuardar);
            this.tabPage2.Controls.Add(this.btnNuevo);
            this.tabPage2.Controls.Add(this.searchEstado);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.searchPresentacion);
            this.tabPage2.Controls.Add(this.ctPrecio);
            this.tabPage2.Controls.Add(this.ctCantidad);
            this.tabPage2.Controls.Add(this.searchCategoria);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.ctId);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.ctNombre);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(706, 403);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento Productos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(322, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 15);
            this.label8.TabIndex = 24;
            this.label8.Text = "Fecha Registro:";
            // 
            // dateFRegistro
            // 
            this.dateFRegistro.EditValue = null;
            this.dateFRegistro.Enabled = false;
            this.dateFRegistro.Location = new System.Drawing.Point(436, 88);
            this.dateFRegistro.Name = "dateFRegistro";
            this.dateFRegistro.Properties.Appearance.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFRegistro.Properties.Appearance.Options.UseFont = true;
            this.dateFRegistro.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateFRegistro.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateFRegistro.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.dateFRegistro.Size = new System.Drawing.Size(146, 22);
            this.dateFRegistro.TabIndex = 3;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Appearance.Options.UseFont = true;
            this.btnCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.ImageOptions.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(363, 284);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 41);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Appearance.Options.UseFont = true;
            this.btnGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.ImageOptions.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(230, 284);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(120, 41);
            this.btnGuardar.TabIndex = 8;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Appearance.Options.UseFont = true;
            this.btnNuevo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.ImageOptions.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(95, 284);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(120, 41);
            this.btnNuevo.TabIndex = 7;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // searchEstado
            // 
            this.searchEstado.Location = new System.Drawing.Point(436, 177);
            this.searchEstado.Name = "searchEstado";
            this.searchEstado.Properties.Appearance.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchEstado.Properties.Appearance.Options.UseFont = true;
            this.searchEstado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchEstado.Properties.DataSource = this.xpEstado;
            this.searchEstado.Properties.DisplayMember = "Nombre";
            this.searchEstado.Properties.PopupView = this.searchEditEstado;
            this.searchEstado.Properties.ValueMember = "IdEstado";
            this.searchEstado.Size = new System.Drawing.Size(146, 22);
            this.searchEstado.TabIndex = 7;
            // 
            // xpEstado
            // 
            this.xpEstado.ObjectType = typeof(SFPanaderia.PanaderiaBD.Estado);
            this.xpEstado.Session = this.sessionProductos;
            // 
            // searchEditEstado
            // 
            this.searchEditEstado.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchEditEstado.Name = "searchEditEstado";
            this.searchEditEstado.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchEditEstado.OptionsView.ShowGroupPanel = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(375, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 15);
            this.label7.TabIndex = 12;
            this.label7.Text = "Estado:";
            // 
            // searchPresentacion
            // 
            this.searchPresentacion.Location = new System.Drawing.Point(438, 130);
            this.searchPresentacion.Name = "searchPresentacion";
            this.searchPresentacion.Properties.Appearance.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchPresentacion.Properties.Appearance.Options.UseFont = true;
            this.searchPresentacion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchPresentacion.Properties.DataSource = this.xpPresentacion;
            this.searchPresentacion.Properties.DisplayMember = "Nombre";
            this.searchPresentacion.Properties.PopupView = this.searchEditPresentacion;
            this.searchPresentacion.Properties.ValueMember = "IdPresentacion";
            this.searchPresentacion.Size = new System.Drawing.Size(146, 22);
            this.searchPresentacion.TabIndex = 5;
            // 
            // xpPresentacion
            // 
            this.xpPresentacion.ObjectType = typeof(SFPanaderia.PanaderiaBD.Presentacion);
            this.xpPresentacion.Session = this.sessionProductos;
            // 
            // searchEditPresentacion
            // 
            this.searchEditPresentacion.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchEditPresentacion.Name = "searchEditPresentacion";
            this.searchEditPresentacion.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchEditPresentacion.OptionsView.ShowGroupPanel = false;
            // 
            // ctPrecio
            // 
            this.ctPrecio.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctPrecio.Location = new System.Drawing.Point(95, 172);
            this.ctPrecio.Name = "ctPrecio";
            this.ctPrecio.Size = new System.Drawing.Size(100, 22);
            this.ctPrecio.TabIndex = 6;
            // 
            // ctCantidad
            // 
            this.ctCantidad.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctCantidad.Location = new System.Drawing.Point(95, 213);
            this.ctCantidad.Name = "ctCantidad";
            this.ctCantidad.Size = new System.Drawing.Size(100, 22);
            this.ctCantidad.TabIndex = 8;
            // 
            // searchCategoria
            // 
            this.searchCategoria.Location = new System.Drawing.Point(95, 130);
            this.searchCategoria.Name = "searchCategoria";
            this.searchCategoria.Properties.Appearance.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchCategoria.Properties.Appearance.Options.UseFont = true;
            this.searchCategoria.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchCategoria.Properties.DataSource = this.xpCategorias;
            this.searchCategoria.Properties.DisplayMember = "Nombre";
            this.searchCategoria.Properties.PopupView = this.searchEditCategoria;
            this.searchCategoria.Properties.ValueMember = "IdCategoria";
            this.searchCategoria.Size = new System.Drawing.Size(133, 22);
            this.searchCategoria.TabIndex = 4;
            // 
            // xpCategorias
            // 
            this.xpCategorias.ObjectType = typeof(SFPanaderia.PanaderiaBD.Categoria);
            this.xpCategorias.Session = this.sessionProductos;
            // 
            // searchEditCategoria
            // 
            this.searchEditCategoria.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchEditCategoria.Name = "searchEditCategoria";
            this.searchEditCategoria.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchEditCategoria.OptionsView.ShowGroupPanel = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 131);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 15);
            this.label6.TabIndex = 7;
            this.label6.Text = "Categoria:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Precio:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(21, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Cantidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(337, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Presentacion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Codigo: ";
            // 
            // ctId
            // 
            this.ctId.Enabled = false;
            this.ctId.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctId.Location = new System.Drawing.Point(95, 44);
            this.ctId.Name = "ctId";
            this.ctId.Size = new System.Drawing.Size(100, 22);
            this.ctId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre:";
            // 
            // ctNombre
            // 
            this.ctNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ctNombre.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctNombre.Location = new System.Drawing.Point(95, 88);
            this.ctNombre.Name = "ctNombre";
            this.ctNombre.Size = new System.Drawing.Size(199, 22);
            this.ctNombre.TabIndex = 2;
            this.ctNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ctNombre_KeyPress);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(714, 41);
            this.panel1.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(66, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(118, 25);
            this.label9.TabIndex = 0;
            this.label9.Text = "Productos";
            // 
            // FProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 491);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Load += new System.EventHandler(this.FProducto_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProductos)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateFRegistro.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFRegistro.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpEstado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchEditEstado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchPresentacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpPresentacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchEditPresentacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchCategoria.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCategorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchEditCategoria)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private DevExpress.XtraGrid.GridControl gridProductos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewProductos;
        private DevExpress.Xpo.UnitOfWork sessionProductos;
        private DevExpress.Xpo.XPCollection xpProductos;
        private System.Windows.Forms.ToolTip ttMensaje;
        private DevExpress.Xpo.XPCollection xpCategorias;
        private DevExpress.Xpo.XPCollection xpPresentacion;
        private DevExpress.Xpo.XPCollection xpEstado;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecioUnidad;
        private DevExpress.XtraGrid.Columns.GridColumn colExistencias;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaRegistro;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn Estado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ctId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ctNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ctCantidad;
        private DevExpress.XtraEditors.SearchLookUpEdit searchCategoria;
        private DevExpress.XtraGrid.Views.Grid.GridView searchEditCategoria;
        private DevExpress.XtraEditors.SearchLookUpEdit searchEstado;
        private DevExpress.XtraGrid.Views.Grid.GridView searchEditEstado;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.SearchLookUpEdit searchPresentacion;
        private DevExpress.XtraGrid.Views.Grid.GridView searchEditPresentacion;
        private System.Windows.Forms.TextBox ctPrecio;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraEditors.SimpleButton btnNuevo;
        private DevExpress.XtraEditors.SimpleButton btnSalir;
        private DevExpress.XtraEditors.SimpleButton btnEliminar;
        private DevExpress.XtraEditors.SimpleButton btnEditar;
        private DevExpress.XtraEditors.DateEdit dateFRegistro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rrInactivos;
        private System.Windows.Forms.RadioButton rrActivo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
    }
}