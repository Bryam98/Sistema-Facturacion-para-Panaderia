namespace SFPanaderia.Vistas
{
    partial class FEntradas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FEntradas));
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabEntradas = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.gridEntradas = new DevExpress.XtraGrid.GridControl();
            this.xpEntradas = new DevExpress.Xpo.XPCollection(this.components);
            this.sessionEntrada = new DevExpress.Xpo.UnitOfWork(this.components);
            this.gridViewEntradas = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdEntrada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFechaEntrada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnImprimir = new DevExpress.XtraEditors.SimpleButton();
            this.btnAnular = new DevExpress.XtraEditors.SimpleButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.btnNuevo = new DevExpress.XtraEditors.SimpleButton();
            this.gridDetalleEntrada = new DevExpress.XtraGrid.GridControl();
            this.xpDetalleEntradas = new DevExpress.Xpo.XPCollection(this.components);
            this.gridViewDetalleEntrada = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdDetalleEntrada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn13 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn14 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.searchEstados = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.xpEstados = new DevExpress.Xpo.XPCollection(this.components);
            this.searchViewEstados = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.searchProductos = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.xpProductos = new DevExpress.Xpo.XPCollection(this.components);
            this.searchViewProductos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.ctCantidad = new System.Windows.Forms.TextBox();
            this.btnEliminar = new DevExpress.XtraEditors.SimpleButton();
            this.btnAgregar = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fechaEntrada = new DevExpress.XtraEditors.DateEdit();
            this.ctIdEntrada = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.xpEmpleados = new DevExpress.Xpo.XPCollection(this.components);
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.panel2.SuspendLayout();
            this.tabEntradas.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridEntradas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpEntradas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionEntrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEntradas)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalleEntrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpDetalleEntradas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetalleEntrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchEstados.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpEstados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchViewEstados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchProductos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchViewProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechaEntrada.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechaEntrada.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Menu;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(614, 42);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresos Productos";
            // 
            // tabEntradas
            // 
            this.tabEntradas.Controls.Add(this.tabPage1);
            this.tabEntradas.Controls.Add(this.tabPage2);
            this.tabEntradas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabEntradas.Location = new System.Drawing.Point(0, 42);
            this.tabEntradas.Name = "tabEntradas";
            this.tabEntradas.SelectedIndex = 0;
            this.tabEntradas.Size = new System.Drawing.Size(614, 439);
            this.tabEntradas.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.gridEntradas);
            this.tabPage1.Controls.Add(this.btnImprimir);
            this.tabPage1.Controls.Add(this.btnAnular);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(606, 413);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Entradas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // gridEntradas
            // 
            this.gridEntradas.DataSource = this.xpEntradas;
            this.gridEntradas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridEntradas.Location = new System.Drawing.Point(3, 47);
            this.gridEntradas.MainView = this.gridViewEntradas;
            this.gridEntradas.Name = "gridEntradas";
            this.gridEntradas.Size = new System.Drawing.Size(600, 363);
            this.gridEntradas.TabIndex = 15;
            this.gridEntradas.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewEntradas});
            // 
            // xpEntradas
            // 
            this.xpEntradas.ObjectType = typeof(SFPanaderia.PanaderiaBD.Entrada);
            this.xpEntradas.Session = this.sessionEntrada;
            // 
            // sessionEntrada
            // 
            this.sessionEntrada.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.sessionEntrada.TrackPropertiesModifications = false;
            // 
            // gridViewEntradas
            // 
            this.gridViewEntradas.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdEntrada,
            this.colFechaEntrada,
            this.colTotal,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gridViewEntradas.GridControl = this.gridEntradas;
            this.gridViewEntradas.Name = "gridViewEntradas";
            this.gridViewEntradas.OptionsBehavior.Editable = false;
            this.gridViewEntradas.OptionsFind.AlwaysVisible = true;
            this.gridViewEntradas.OptionsFind.ShowFindButton = false;
            this.gridViewEntradas.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            // 
            // colIdEntrada
            // 
            this.colIdEntrada.Caption = "Codigo Entrada";
            this.colIdEntrada.FieldName = "IdEntrada";
            this.colIdEntrada.Name = "colIdEntrada";
            this.colIdEntrada.Visible = true;
            this.colIdEntrada.VisibleIndex = 0;
            this.colIdEntrada.Width = 82;
            // 
            // colFechaEntrada
            // 
            this.colFechaEntrada.Caption = "Fecha Entrada";
            this.colFechaEntrada.FieldName = "FechaEntrada";
            this.colFechaEntrada.Name = "colFechaEntrada";
            this.colFechaEntrada.Visible = true;
            this.colFechaEntrada.VisibleIndex = 1;
            this.colFechaEntrada.Width = 85;
            // 
            // colTotal
            // 
            this.colTotal.Caption = "Total Productos ";
            this.colTotal.FieldName = "Total";
            this.colTotal.Name = "colTotal";
            this.colTotal.Visible = true;
            this.colTotal.VisibleIndex = 2;
            this.colTotal.Width = 91;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "IdEstado!";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Estado ";
            this.gridColumn2.FieldName = "IdEstado.Nombre";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 3;
            this.gridColumn2.Width = 74;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Nombre Empleado";
            this.gridColumn3.FieldName = "IdEmpleado.Nombres";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 4;
            this.gridColumn3.Width = 126;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Apellidos Empleado";
            this.gridColumn4.FieldName = "IdEmpleado.Apellidos";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 5;
            this.gridColumn4.Width = 124;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Appearance.Options.UseFont = true;
            this.btnImprimir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.ImageOptions.Image")));
            this.btnImprimir.Location = new System.Drawing.Point(479, 6);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(110, 35);
            this.btnImprimir.TabIndex = 14;
            this.btnImprimir.Text = "Imprimir";
            // 
            // btnAnular
            // 
            this.btnAnular.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnular.Appearance.Options.UseFont = true;
            this.btnAnular.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAnular.ImageOptions.Image")));
            this.btnAnular.Location = new System.Drawing.Point(363, 6);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(110, 35);
            this.btnAnular.TabIndex = 13;
            this.btnAnular.Text = "Anular";
            this.btnAnular.Click += new System.EventHandler(this.btnAnular_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(606, 413);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Registros de Entradas";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.btnNuevo);
            this.groupBox1.Controls.Add(this.gridDetalleEntrada);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.searchEstados);
            this.groupBox1.Controls.Add(this.searchProductos);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.ctCantidad);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.fechaEntrada);
            this.groupBox1.Controls.Add(this.ctIdEntrada);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 407);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingreso de Productos";
            // 
            // txtTotal
            // 
            this.txtTotal.AutoSize = true;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(149, 376);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(36, 16);
            this.txtTotal.TabIndex = 46;
            this.txtTotal.Text = "0.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 16);
            this.label5.TabIndex = 50;
            this.label5.Text = "Total Productos:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Appearance.Options.UseFont = true;
            this.btnCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.ImageOptions.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(484, 363);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 41);
            this.btnCancelar.TabIndex = 49;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Appearance.Options.UseFont = true;
            this.btnGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.ImageOptions.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(368, 364);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(110, 41);
            this.btnGuardar.TabIndex = 48;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Appearance.Options.UseFont = true;
            this.btnNuevo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.ImageOptions.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(252, 364);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(110, 41);
            this.btnNuevo.TabIndex = 47;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // gridDetalleEntrada
            // 
            this.gridDetalleEntrada.DataSource = this.xpDetalleEntradas;
            this.gridDetalleEntrada.Location = new System.Drawing.Point(-3, 141);
            this.gridDetalleEntrada.MainView = this.gridViewDetalleEntrada;
            this.gridDetalleEntrada.Name = "gridDetalleEntrada";
            this.gridDetalleEntrada.Size = new System.Drawing.Size(606, 217);
            this.gridDetalleEntrada.TabIndex = 45;
            this.gridDetalleEntrada.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDetalleEntrada});
            // 
            // xpDetalleEntradas
            // 
            this.xpDetalleEntradas.ObjectType = typeof(SFPanaderia.PanaderiaBD.DetalleEntrada);
            this.xpDetalleEntradas.Session = this.sessionEntrada;
            // 
            // gridViewDetalleEntrada
            // 
            this.gridViewDetalleEntrada.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdDetalleEntrada,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn12,
            this.gridColumn13,
            this.colCantidad,
            this.gridColumn14});
            this.gridViewDetalleEntrada.GridControl = this.gridDetalleEntrada;
            this.gridViewDetalleEntrada.Name = "gridViewDetalleEntrada";
            // 
            // colIdDetalleEntrada
            // 
            this.colIdDetalleEntrada.FieldName = "IdDetalleEntrada";
            this.colIdDetalleEntrada.Name = "colIdDetalleEntrada";
            // 
            // gridColumn9
            // 
            this.gridColumn9.FieldName = "IdEntrada!";
            this.gridColumn9.Name = "gridColumn9";
            // 
            // gridColumn10
            // 
            this.gridColumn10.FieldName = "IdEntrada!Key";
            this.gridColumn10.Name = "gridColumn10";
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Codigo Producto";
            this.gridColumn12.FieldName = "IdProducto";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 0;
            this.gridColumn12.Width = 102;
            // 
            // gridColumn13
            // 
            this.gridColumn13.Caption = "Nombre Producto";
            this.gridColumn13.FieldName = "IdProducto.Nombre";
            this.gridColumn13.Name = "gridColumn13";
            this.gridColumn13.Visible = true;
            this.gridColumn13.VisibleIndex = 1;
            this.gridColumn13.Width = 169;
            // 
            // colCantidad
            // 
            this.colCantidad.Caption = "Stock";
            this.colCantidad.FieldName = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.Visible = true;
            this.colCantidad.VisibleIndex = 2;
            this.colCantidad.Width = 130;
            // 
            // gridColumn14
            // 
            this.gridColumn14.Caption = "Presentacion";
            this.gridColumn14.FieldName = "IdProducto.IdPresentacion.Nombre";
            this.gridColumn14.Name = "gridColumn14";
            this.gridColumn14.Visible = true;
            this.gridColumn14.VisibleIndex = 3;
            this.gridColumn14.Width = 187;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(285, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 44;
            this.label6.Text = "Estado:";
            // 
            // searchEstados
            // 
            this.searchEstados.EditValue = 1;
            this.searchEstados.Location = new System.Drawing.Point(346, 63);
            this.searchEstados.Name = "searchEstados";
            this.searchEstados.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchEstados.Properties.DataSource = this.xpEstados;
            this.searchEstados.Properties.DisplayMember = "Nombre";
            this.searchEstados.Properties.PopupView = this.searchViewEstados;
            this.searchEstados.Properties.ValueMember = "IdEstado";
            this.searchEstados.Size = new System.Drawing.Size(110, 20);
            this.searchEstados.TabIndex = 43;
            // 
            // xpEstados
            // 
            this.xpEstados.ObjectType = typeof(SFPanaderia.PanaderiaBD.Estado);
            this.xpEstados.Session = this.sessionEntrada;
            // 
            // searchViewEstados
            // 
            this.searchViewEstados.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchViewEstados.Name = "searchViewEstados";
            this.searchViewEstados.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchViewEstados.OptionsView.ShowGroupPanel = false;
            // 
            // searchProductos
            // 
            this.searchProductos.Location = new System.Drawing.Point(78, 68);
            this.searchProductos.Name = "searchProductos";
            this.searchProductos.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchProductos.Properties.DataSource = this.xpProductos;
            this.searchProductos.Properties.DisplayMember = "Nombre";
            this.searchProductos.Properties.PopupView = this.searchViewProductos;
            this.searchProductos.Properties.ValueMember = "IdProducto";
            this.searchProductos.Properties.Popup += new System.EventHandler(this.searchProductos_Properties_Popup);
            this.searchProductos.Size = new System.Drawing.Size(143, 20);
            this.searchProductos.TabIndex = 42;
            // 
            // xpProductos
            // 
            this.xpProductos.DisplayableProperties = "This;IdProducto;Nombre;IdPresentacion.Nombre;PrecioUnidad;Existencias;IdCategoria" +
    ".Nombre;IdEstado.Nombre;DetalleVentas;DetalleEntradas";
            this.xpProductos.ObjectType = typeof(SFPanaderia.PanaderiaBD.Producto);
            this.xpProductos.Session = this.sessionEntrada;
            // 
            // searchViewProductos
            // 
            this.searchViewProductos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn5,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn11});
            this.searchViewProductos.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchViewProductos.Name = "searchViewProductos";
            this.searchViewProductos.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchViewProductos.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.searchViewProductos.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Id";
            this.gridColumn5.FieldName = "IdProducto";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 0;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Nombre";
            this.gridColumn6.FieldName = "Nombre";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 1;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "Presentacion";
            this.gridColumn7.FieldName = "IdPresentacion.Nombre";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 2;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Precio";
            this.gridColumn8.FieldName = "PrecioUnidad";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 3;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "Categoria";
            this.gridColumn11.FieldName = "IdCategoria.Nombre";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 15);
            this.label7.TabIndex = 41;
            this.label7.Text = "Cantidad:";
            // 
            // ctCantidad
            // 
            this.ctCantidad.Location = new System.Drawing.Point(78, 108);
            this.ctCantidad.Name = "ctCantidad";
            this.ctCantidad.Size = new System.Drawing.Size(114, 20);
            this.ctCantidad.TabIndex = 40;
            this.ctCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ctCantidad_KeyPress);
            // 
            // btnEliminar
            // 
            this.btnEliminar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.ImageOptions.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(391, 95);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(40, 40);
            this.btnEliminar.TabIndex = 39;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.ImageOptions.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(345, 95);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(40, 40);
            this.btnAgregar.TabIndex = 38;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 37;
            this.label4.Text = "Producto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(236, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 15);
            this.label3.TabIndex = 36;
            this.label3.Text = "Fecha Entrada:";
            // 
            // fechaEntrada
            // 
            this.fechaEntrada.EditValue = new System.DateTime(2022, 9, 15, 0, 0, 0, 0);
            this.fechaEntrada.Enabled = false;
            this.fechaEntrada.Location = new System.Drawing.Point(346, 23);
            this.fechaEntrada.Name = "fechaEntrada";
            this.fechaEntrada.Properties.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaEntrada.Properties.Appearance.Options.UseFont = true;
            this.fechaEntrada.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fechaEntrada.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fechaEntrada.Size = new System.Drawing.Size(85, 22);
            this.fechaEntrada.TabIndex = 35;
            // 
            // ctIdEntrada
            // 
            this.ctIdEntrada.Location = new System.Drawing.Point(78, 26);
            this.ctIdEntrada.Name = "ctIdEntrada";
            this.ctIdEntrada.ReadOnly = true;
            this.ctIdEntrada.Size = new System.Drawing.Size(100, 20);
            this.ctIdEntrada.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 33;
            this.label2.Text = "Codigo:";
            // 
            // xpEmpleados
            // 
            this.xpEmpleados.ObjectType = typeof(SFPanaderia.PanaderiaBD.Empleado);
            this.xpEmpleados.Session = this.sessionEntrada;
            // 
            // FEntradas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 481);
            this.Controls.Add(this.tabEntradas);
            this.Controls.Add(this.panel2);
            this.Name = "FEntradas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FEntradas";
            this.Load += new System.EventHandler(this.FEntradas_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabEntradas.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridEntradas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpEntradas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionEntrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEntradas)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalleEntrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpDetalleEntradas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetalleEntrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchEstados.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpEstados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchViewEstados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchProductos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchViewProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechaEntrada.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechaEntrada.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpEmpleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabEntradas;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private DevExpress.Xpo.UnitOfWork sessionEntrada;
        private DevExpress.Xpo.XPCollection xpEntradas;
        private DevExpress.Xpo.XPCollection xpDetalleEntradas;
        private DevExpress.Xpo.XPCollection xpProductos;
        private DevExpress.Xpo.XPCollection xpEmpleados;
        private DevExpress.Xpo.XPCollection xpEstados;
        private System.Windows.Forms.ToolTip ttMensaje;
        private DevExpress.XtraGrid.GridControl gridEntradas;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewEntradas;
        private DevExpress.XtraGrid.Columns.GridColumn colIdEntrada;
        private DevExpress.XtraGrid.Columns.GridColumn colFechaEntrada;
        private DevExpress.XtraGrid.Columns.GridColumn colTotal;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.SimpleButton btnImprimir;
        private DevExpress.XtraEditors.SimpleButton btnAnular;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SearchLookUpEdit searchEstados;
        private DevExpress.XtraGrid.Views.Grid.GridView searchViewEstados;
        private DevExpress.XtraEditors.SearchLookUpEdit searchProductos;
        private DevExpress.XtraGrid.Views.Grid.GridView searchViewProductos;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ctCantidad;
        private DevExpress.XtraEditors.SimpleButton btnEliminar;
        private DevExpress.XtraEditors.SimpleButton btnAgregar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.DateEdit fechaEntrada;
        private System.Windows.Forms.TextBox ctIdEntrada;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.GridControl gridDetalleEntrada;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDetalleEntrada;
        private System.Windows.Forms.Label txtTotal;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraEditors.SimpleButton btnNuevo;
        private DevExpress.XtraGrid.Columns.GridColumn colIdDetalleEntrada;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn13;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn14;
    }
}