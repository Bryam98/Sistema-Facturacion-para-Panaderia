namespace SFPanaderia.Vistas
{
    partial class FEntrada
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FEntrada));
            this.xpDetalleEntrada = new DevExpress.Xpo.XPCollection(this.components);
            this.sessionEntrada = new DevExpress.Xpo.UnitOfWork(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnImprimir = new DevExpress.XtraEditors.SimpleButton();
            this.btnAnular = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlEntrada = new DevExpress.XtraGrid.GridControl();
            this.xpEntrada = new DevExpress.Xpo.XPCollection(this.components);
            this.gridViewEntrada = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.searchEstados = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.xpEstado = new DevExpress.Xpo.XPCollection(this.components);
            this.searchViewEstados = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.searchProductos = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.xpProductos = new DevExpress.Xpo.XPCollection(this.components);
            this.searchViewProductos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.ctCantidad = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEliminar = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.btnNuevo = new DevExpress.XtraEditors.SimpleButton();
            this.btnAgregar = new DevExpress.XtraEditors.SimpleButton();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fechaEntrada = new DevExpress.XtraEditors.DateEdit();
            this.ctIdEntrada = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.gridDetalleEntrada = new DevExpress.XtraGrid.GridControl();
            this.gridViewDetalleEntrada = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdDetalleEntrada = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.xpEmpleados = new DevExpress.Xpo.XPCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.xpDetalleEntrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionEntrada)).BeginInit();
            this.panel2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEntrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpEntrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEntrada)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchEstados.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchViewEstados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchProductos.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchViewProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechaEntrada.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechaEntrada.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalleEntrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetalleEntrada)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpEmpleados)).BeginInit();
            this.SuspendLayout();
            // 
            // xpDetalleEntrada
            // 
            this.xpDetalleEntrada.ObjectType = typeof(SFPanaderia.PanaderiaBD.DetalleEntrada);
            this.xpDetalleEntrada.Session = this.sessionEntrada;
            // 
            // sessionEntrada
            // 
            this.sessionEntrada.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.sessionEntrada.TrackPropertiesModifications = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Menu;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(614, 42);
            this.panel2.TabIndex = 1;
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
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 42);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(614, 439);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnImprimir);
            this.tabPage1.Controls.Add(this.btnAnular);
            this.tabPage1.Controls.Add(this.gridControlEntrada);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(606, 413);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Appearance.Options.UseFont = true;
            this.btnImprimir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnImprimir.ImageOptions.Image")));
            this.btnImprimir.Location = new System.Drawing.Point(446, 6);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(110, 35);
            this.btnImprimir.TabIndex = 6;
            this.btnImprimir.Text = "Imprimir";
            // 
            // btnAnular
            // 
            this.btnAnular.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnular.Appearance.Options.UseFont = true;
            this.btnAnular.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAnular.ImageOptions.Image")));
            this.btnAnular.Location = new System.Drawing.Point(330, 6);
            this.btnAnular.Name = "btnAnular";
            this.btnAnular.Size = new System.Drawing.Size(110, 35);
            this.btnAnular.TabIndex = 5;
            this.btnAnular.Text = "Anular";
            // 
            // gridControlEntrada
            // 
            this.gridControlEntrada.DataSource = this.xpEntrada;
            this.gridControlEntrada.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControlEntrada.Location = new System.Drawing.Point(3, 47);
            this.gridControlEntrada.MainView = this.gridViewEntrada;
            this.gridControlEntrada.Name = "gridControlEntrada";
            this.gridControlEntrada.Size = new System.Drawing.Size(600, 363);
            this.gridControlEntrada.TabIndex = 0;
            this.gridControlEntrada.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewEntrada});
            // 
            // xpEntrada
            // 
            this.xpEntrada.ObjectType = typeof(SFPanaderia.PanaderiaBD.Entrada);
            this.xpEntrada.Session = this.sessionEntrada;
            // 
            // gridViewEntrada
            // 
            this.gridViewEntrada.GridControl = this.gridControlEntrada;
            this.gridViewEntrada.Name = "gridViewEntrada";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(606, 413);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.searchEstados);
            this.groupBox1.Controls.Add(this.searchProductos);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.ctCantidad);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnGuardar);
            this.groupBox1.Controls.Add(this.btnNuevo);
            this.groupBox1.Controls.Add(this.btnAgregar);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.fechaEntrada);
            this.groupBox1.Controls.Add(this.ctIdEntrada);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.gridDetalleEntrada);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Location = new System.Drawing.Point(3, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(600, 404);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ingreso Productos";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(286, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 32;
            this.label6.Text = "Estado:";
            // 
            // searchEstados
            // 
            this.searchEstados.EditValue = 1;
            this.searchEstados.Location = new System.Drawing.Point(347, 67);
            this.searchEstados.Name = "searchEstados";
            this.searchEstados.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchEstados.Properties.DataSource = this.xpEstado;
            this.searchEstados.Properties.DisplayMember = "Nombre";
            this.searchEstados.Properties.PopupView = this.searchViewEstados;
            this.searchEstados.Properties.ValueMember = "IdEstado";
            this.searchEstados.Size = new System.Drawing.Size(110, 20);
            this.searchEstados.TabIndex = 31;
            // 
            // xpEstado
            // 
            this.xpEstado.ObjectType = typeof(SFPanaderia.PanaderiaBD.Estado);
            this.xpEstado.Session = this.sessionEntrada;
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
            this.searchProductos.Location = new System.Drawing.Point(79, 72);
            this.searchProductos.Name = "searchProductos";
            this.searchProductos.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchProductos.Properties.DataSource = this.xpProductos;
            this.searchProductos.Properties.DisplayMember = "Nombre";
            this.searchProductos.Properties.PopupView = this.searchViewProductos;
            this.searchProductos.Properties.ValueMember = "IdProducto";
            this.searchProductos.Size = new System.Drawing.Size(143, 20);
            this.searchProductos.TabIndex = 30;
            this.searchProductos.Popup += new System.EventHandler(this.searchProductos_Popup);
            this.searchProductos.EditValueChanged += new System.EventHandler(this.searchProductos_EditValueChanged);
            // 
            // xpProductos
            // 
            this.xpProductos.DisplayableProperties = "This;IdProducto;Nombre;IdPresentacion.Nombre;PrecioUnidad;Existencias;IdEstado.No" +
    "mbre;IdCategoria.Nombre";
            this.xpProductos.ObjectType = typeof(SFPanaderia.PanaderiaBD.Producto);
            this.xpProductos.Session = this.sessionEntrada;
            // 
            // searchViewProductos
            // 
            this.searchViewProductos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5,
            this.gridColumn11});
            this.searchViewProductos.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchViewProductos.Name = "searchViewProductos";
            this.searchViewProductos.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchViewProductos.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.searchViewProductos.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Id";
            this.gridColumn2.FieldName = "IdProducto";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 0;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Nombre";
            this.gridColumn3.FieldName = "Nombre";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Presentacion";
            this.gridColumn4.FieldName = "IdPresentacion.Nombre";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Precio";
            this.gridColumn5.FieldName = "PrecioUnidad";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
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
            this.label7.Location = new System.Drawing.Point(10, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 15);
            this.label7.TabIndex = 29;
            this.label7.Text = "Cantidad:";
            // 
            // ctCantidad
            // 
            this.ctCantidad.Location = new System.Drawing.Point(79, 112);
            this.ctCantidad.Name = "ctCantidad";
            this.ctCantidad.Size = new System.Drawing.Size(114, 20);
            this.ctCantidad.TabIndex = 28;
            this.ctCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ctCantidad_KeyPress);
            // 
            // txtTotal
            // 
            this.txtTotal.AutoSize = true;
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(126, 373);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(36, 16);
            this.txtTotal.TabIndex = 1;
            this.txtTotal.Text = "0.00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(10, 372);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 16);
            this.label5.TabIndex = 24;
            this.label5.Text = "Total Productos:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.ImageOptions.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(392, 98);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(40, 40);
            this.btnEliminar.TabIndex = 23;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Appearance.Options.UseFont = true;
            this.btnCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.ImageOptions.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(454, 360);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 41);
            this.btnCancelar.TabIndex = 22;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Appearance.Options.UseFont = true;
            this.btnGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.ImageOptions.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(338, 360);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(110, 41);
            this.btnGuardar.TabIndex = 21;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Appearance.Options.UseFont = true;
            this.btnNuevo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.ImageOptions.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(222, 360);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(110, 41);
            this.btnNuevo.TabIndex = 20;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.ImageOptions.Image")));
            this.btnAgregar.Location = new System.Drawing.Point(346, 99);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(40, 40);
            this.btnAgregar.TabIndex = 8;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 15);
            this.label4.TabIndex = 5;
            this.label4.Text = "Producto:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(237, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 15);
            this.label3.TabIndex = 4;
            this.label3.Text = "Fecha Entrada:";
            // 
            // fechaEntrada
            // 
            this.fechaEntrada.EditValue = new System.DateTime(2022, 9, 15, 0, 0, 0, 0);
            this.fechaEntrada.Enabled = false;
            this.fechaEntrada.Location = new System.Drawing.Point(347, 27);
            this.fechaEntrada.Name = "fechaEntrada";
            this.fechaEntrada.Properties.Appearance.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaEntrada.Properties.Appearance.Options.UseFont = true;
            this.fechaEntrada.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fechaEntrada.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fechaEntrada.Size = new System.Drawing.Size(85, 22);
            this.fechaEntrada.TabIndex = 3;
            // 
            // ctIdEntrada
            // 
            this.ctIdEntrada.Location = new System.Drawing.Point(79, 30);
            this.ctIdEntrada.Name = "ctIdEntrada";
            this.ctIdEntrada.ReadOnly = true;
            this.ctIdEntrada.Size = new System.Drawing.Size(100, 20);
            this.ctIdEntrada.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Codigo:";
            // 
            // gridDetalleEntrada
            // 
            this.gridDetalleEntrada.DataSource = this.xpDetalleEntrada;
            this.gridDetalleEntrada.Location = new System.Drawing.Point(-3, 144);
            this.gridDetalleEntrada.MainView = this.gridViewDetalleEntrada;
            this.gridDetalleEntrada.Name = "gridDetalleEntrada";
            this.gridDetalleEntrada.Size = new System.Drawing.Size(606, 210);
            this.gridDetalleEntrada.TabIndex = 0;
            this.gridDetalleEntrada.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDetalleEntrada});
            // 
            // gridViewDetalleEntrada
            // 
            this.gridViewDetalleEntrada.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewDetalleEntrada.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewDetalleEntrada.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdDetalleEntrada,
            this.gridColumn6,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.colCantidad,
            this.gridColumn10,
            this.gridColumn1});
            this.gridViewDetalleEntrada.GridControl = this.gridDetalleEntrada;
            this.gridViewDetalleEntrada.Name = "gridViewDetalleEntrada";
            this.gridViewDetalleEntrada.OptionsBehavior.Editable = false;
            this.gridViewDetalleEntrada.OptionsView.ColumnAutoWidth = false;
            // 
            // colIdDetalleEntrada
            // 
            this.colIdDetalleEntrada.Caption = "Codigo";
            this.colIdDetalleEntrada.FieldName = "IdDetalleEntrada";
            this.colIdDetalleEntrada.Name = "colIdDetalleEntrada";
            this.colIdDetalleEntrada.Width = 94;
            // 
            // gridColumn6
            // 
            this.gridColumn6.FieldName = "IdEntrada!";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Width = 109;
            // 
            // gridColumn7
            // 
            this.gridColumn7.FieldName = "IdEntrada!Key";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.Width = 63;
            // 
            // gridColumn8
            // 
            this.gridColumn8.Caption = "Codigo Producto";
            this.gridColumn8.FieldName = "IdProducto.IdProducto";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 0;
            this.gridColumn8.Width = 76;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "Producto";
            this.gridColumn9.FieldName = "IdProducto.Nombre";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 1;
            this.gridColumn9.Width = 167;
            // 
            // colCantidad
            // 
            this.colCantidad.Caption = "Stock";
            this.colCantidad.FieldName = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.Visible = true;
            this.colCantidad.VisibleIndex = 2;
            this.colCantidad.Width = 81;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Categoria";
            this.gridColumn10.FieldName = "IdProducto.IdCategoria.Nombre";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 3;
            this.gridColumn10.Width = 124;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Presentacion";
            this.gridColumn1.FieldName = "IdProducto.IdPresentacion.Nombre";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 4;
            this.gridColumn1.Width = 149;
            // 
            // xpEmpleados
            // 
            this.xpEmpleados.ObjectType = typeof(SFPanaderia.PanaderiaBD.Empleado);
            this.xpEmpleados.Session = this.sessionEntrada;
            // 
            // FEntrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(614, 481);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FEntrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FEntrada";
            this.Load += new System.EventHandler(this.FEntrada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xpDetalleEntrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionEntrada)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlEntrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpEntrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewEntrada)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchEstados.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpEstado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchViewEstados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchProductos.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchViewProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechaEntrada.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechaEntrada.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalleEntrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetalleEntrada)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpEmpleados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.Xpo.XPCollection xpDetalleEntrada;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private DevExpress.Xpo.XPCollection xpEntrada;
        private DevExpress.Xpo.UnitOfWork sessionEntrada;
        private DevExpress.XtraEditors.SimpleButton btnImprimir;
        private DevExpress.XtraEditors.SimpleButton btnAnular;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.DateEdit fechaEntrada;
        private System.Windows.Forms.TextBox ctIdEntrada;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraGrid.GridControl gridDetalleEntrada;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDetalleEntrada;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton btnAgregar;
        private DevExpress.XtraGrid.Columns.GridColumn colIdDetalleEntrada;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraEditors.SimpleButton btnNuevo;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton btnEliminar;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private System.Windows.Forms.Label txtTotal;
        private System.Windows.Forms.ToolTip ttMensaje;
        private DevExpress.XtraGrid.GridControl gridControlEntrada;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewEntrada;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ctCantidad;
        private DevExpress.Xpo.XPCollection xpProductos;
        private DevExpress.XtraEditors.SearchLookUpEdit searchProductos;
        private DevExpress.XtraGrid.Views.Grid.GridView searchViewProductos;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.SearchLookUpEdit searchEstados;
        private DevExpress.XtraGrid.Views.Grid.GridView searchViewEstados;
        private DevExpress.Xpo.XPCollection xpEstado;
        private DevExpress.Xpo.XPCollection xpEmpleados;
    }
}