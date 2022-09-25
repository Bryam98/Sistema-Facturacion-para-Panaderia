namespace SFPanaderia.Vistas
{
    partial class FVentas
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FVentas));
            this.GroupProducto = new System.Windows.Forms.GroupBox();
            this.ctCantidad = new System.Windows.Forms.TextBox();
            this.searchProducto = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.xpProductos = new DevExpress.Xpo.XPCollection(this.components);
            this.sessionVentas = new DevExpress.Xpo.UnitOfWork(this.components);
            this.searchViewProducto = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label10 = new System.Windows.Forms.Label();
            this.ctPrecio = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ctStock = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ctIdProducto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.searchCliente = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.xpClientes = new DevExpress.Xpo.XPCollection(this.components);
            this.searchViewCliente = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.label4 = new System.Windows.Forms.Label();
            this.ctIdCliente = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ctCedula = new System.Windows.Forms.TextBox();
            this.xpDetalleVenta = new DevExpress.Xpo.XPCollection(this.components);
            this.xpVentas = new DevExpress.Xpo.XPCollection(this.components);
            this.xpEmpleados = new DevExpress.Xpo.XPCollection(this.components);
            this.xpEstados = new DevExpress.Xpo.XPCollection(this.components);
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.fechaVenta = new DevExpress.XtraEditors.DateEdit();
            this.gridDetalle = new DevExpress.XtraGrid.GridControl();
            this.gridViewDetalle = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdDetalle = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSubTotal = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnRegistrar = new DevExpress.XtraEditors.SimpleButton();
            this.btnEliminar = new DevExpress.XtraEditors.SimpleButton();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.ctSub = new System.Windows.Forms.TextBox();
            this.ctTotal = new System.Windows.Forms.TextBox();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.btnSalir = new DevExpress.XtraEditors.SimpleButton();
            this.ctDescuento = new System.Windows.Forms.TextBox();
            this.GroupProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchProducto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchViewProducto)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchCliente.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchViewCliente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpDetalleVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpVentas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpEmpleados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpEstados)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fechaVenta.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechaVenta.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupProducto
            // 
            this.GroupProducto.Controls.Add(this.ctCantidad);
            this.GroupProducto.Controls.Add(this.searchProducto);
            this.GroupProducto.Controls.Add(this.label10);
            this.GroupProducto.Controls.Add(this.ctPrecio);
            this.GroupProducto.Controls.Add(this.label9);
            this.GroupProducto.Controls.Add(this.ctStock);
            this.GroupProducto.Controls.Add(this.label8);
            this.GroupProducto.Controls.Add(this.label5);
            this.GroupProducto.Controls.Add(this.ctIdProducto);
            this.GroupProducto.Controls.Add(this.label6);
            this.GroupProducto.Controls.Add(this.label7);
            this.GroupProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupProducto.Location = new System.Drawing.Point(12, 114);
            this.GroupProducto.Name = "GroupProducto";
            this.GroupProducto.Size = new System.Drawing.Size(524, 98);
            this.GroupProducto.TabIndex = 3;
            this.GroupProducto.TabStop = false;
            this.GroupProducto.Text = "Producto";
            // 
            // ctCantidad
            // 
            this.ctCantidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctCantidad.Location = new System.Drawing.Point(357, 55);
            this.ctCantidad.Name = "ctCantidad";
            this.ctCantidad.Size = new System.Drawing.Size(82, 24);
            this.ctCantidad.TabIndex = 20;
            this.ctCantidad.TextChanged += new System.EventHandler(this.ctCantidad_TextChanged);
            // 
            // searchProducto
            // 
            this.searchProducto.Location = new System.Drawing.Point(111, 24);
            this.searchProducto.Name = "searchProducto";
            this.searchProducto.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchProducto.Properties.DataSource = this.xpProductos;
            this.searchProducto.Properties.DisplayMember = "Nombre";
            this.searchProducto.Properties.PopupView = this.searchViewProducto;
            this.searchProducto.Properties.ValueMember = "IdProducto";
            this.searchProducto.Properties.Popup += new System.EventHandler(this.searchProducto_Properties_Popup);
            this.searchProducto.Size = new System.Drawing.Size(215, 20);
            this.searchProducto.TabIndex = 19;
            this.searchProducto.EditValueChanged += new System.EventHandler(this.searchProducto_EditValueChanged);
            // 
            // xpProductos
            // 
            this.xpProductos.DisplayableProperties = "This;IdProducto;Nombre;PrecioUnidad;Existencias;IdCategoria;IdPresentacion;IdEsta" +
    "do;DetalleEntradas;DetalleVentas";
            this.xpProductos.ObjectType = typeof(SFPanaderia.PanaderiaBD.Producto);
            this.xpProductos.Session = this.sessionVentas;
            // 
            // sessionVentas
            // 
            this.sessionVentas.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.sessionVentas.TrackPropertiesModifications = false;
            // 
            // searchViewProducto
            // 
            this.searchViewProducto.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchViewProducto.Name = "searchViewProducto";
            this.searchViewProducto.OptionsBehavior.Editable = false;
            this.searchViewProducto.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchViewProducto.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.searchViewProducto.OptionsView.ShowGroupPanel = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(290, 58);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "Cantidad: ";
            // 
            // ctPrecio
            // 
            this.ctPrecio.Location = new System.Drawing.Point(204, 58);
            this.ctPrecio.Name = "ctPrecio";
            this.ctPrecio.ReadOnly = true;
            this.ctPrecio.Size = new System.Drawing.Size(79, 21);
            this.ctPrecio.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(156, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Precio: ";
            // 
            // ctStock
            // 
            this.ctStock.Location = new System.Drawing.Point(72, 58);
            this.ctStock.Name = "ctStock";
            this.ctStock.ReadOnly = true;
            this.ctStock.Size = new System.Drawing.Size(79, 21);
            this.ctStock.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(21, 58);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "Stock:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(343, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "ID:";
            // 
            // ctIdProducto
            // 
            this.ctIdProducto.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctIdProducto.Location = new System.Drawing.Point(373, 24);
            this.ctIdProducto.Name = "ctIdProducto";
            this.ctIdProducto.ReadOnly = true;
            this.ctIdProducto.Size = new System.Drawing.Size(52, 22);
            this.ctIdProducto.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(387, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 16);
            this.label6.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(39, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 16);
            this.label7.TabIndex = 9;
            this.label7.Text = "Producto:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(686, 330);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(101, 20);
            this.label15.TabIndex = 53;
            this.label15.Text = "Descuento:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.searchCliente);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ctIdCliente);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ctCedula);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(524, 86);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente:";
            // 
            // searchCliente
            // 
            this.searchCliente.Location = new System.Drawing.Point(215, 51);
            this.searchCliente.Name = "searchCliente";
            this.searchCliente.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchCliente.Properties.DataSource = this.xpClientes;
            this.searchCliente.Properties.DisplayMember = "Nombres";
            this.searchCliente.Properties.PopupView = this.searchViewCliente;
            this.searchCliente.Properties.ValueMember = "IdCliente";
            this.searchCliente.Properties.Popup += new System.EventHandler(this.searchCliente_Properties_Popup);
            this.searchCliente.Size = new System.Drawing.Size(274, 20);
            this.searchCliente.TabIndex = 16;
            this.searchCliente.EditValueChanged += new System.EventHandler(this.searchCliente_EditValueChanged_1);
            // 
            // xpClientes
            // 
            this.xpClientes.DisplayableProperties = "This;IdCliente;Nombres;Apellidos;Cedula;IdEstado;Ventas";
            this.xpClientes.ObjectType = typeof(SFPanaderia.PanaderiaBD.Cliente);
            this.xpClientes.Session = this.sessionVentas;
            // 
            // searchViewCliente
            // 
            this.searchViewCliente.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchViewCliente.Name = "searchViewCliente";
            this.searchViewCliente.OptionsBehavior.Editable = false;
            this.searchViewCliente.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchViewCliente.OptionsView.ShowFilterPanelMode = DevExpress.XtraGrid.Views.Base.ShowFilterPanelMode.Never;
            this.searchViewCliente.OptionsView.ShowGroupPanel = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(410, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "ID:";
            // 
            // ctIdCliente
            // 
            this.ctIdCliente.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctIdCliente.Location = new System.Drawing.Point(437, 20);
            this.ctIdCliente.Name = "ctIdCliente";
            this.ctIdCliente.ReadOnly = true;
            this.ctIdCliente.Size = new System.Drawing.Size(52, 22);
            this.ctIdCliente.TabIndex = 15;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(455, 16);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 16);
            this.label13.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(457, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(171, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sr (a): ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Documento de Identidad: ";
            // 
            // ctCedula
            // 
            this.ctCedula.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctCedula.Location = new System.Drawing.Point(215, 20);
            this.ctCedula.Name = "ctCedula";
            this.ctCedula.ReadOnly = true;
            this.ctCedula.Size = new System.Drawing.Size(188, 22);
            this.ctCedula.TabIndex = 0;
            // 
            // xpDetalleVenta
            // 
            this.xpDetalleVenta.ObjectType = typeof(SFPanaderia.PanaderiaBD.DetalleVenta);
            this.xpDetalleVenta.Session = this.sessionVentas;
            // 
            // xpVentas
            // 
            this.xpVentas.ObjectType = typeof(SFPanaderia.PanaderiaBD.Venta);
            this.xpVentas.Session = this.sessionVentas;
            // 
            // xpEmpleados
            // 
            this.xpEmpleados.ObjectType = typeof(SFPanaderia.PanaderiaBD.Empleado);
            this.xpEmpleados.Session = this.sessionVentas;
            // 
            // xpEstados
            // 
            this.xpEstados.ObjectType = typeof(SFPanaderia.PanaderiaBD.Estado);
            this.xpEstados.Session = this.sessionVentas;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.fechaVenta);
            this.groupBox3.Location = new System.Drawing.Point(542, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 55);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fecha Venta";
            // 
            // fechaVenta
            // 
            this.fechaVenta.EditValue = new System.DateTime(2022, 9, 24, 19, 24, 48, 0);
            this.fechaVenta.Location = new System.Drawing.Point(36, 19);
            this.fechaVenta.Name = "fechaVenta";
            this.fechaVenta.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fechaVenta.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.fechaVenta.Size = new System.Drawing.Size(129, 20);
            this.fechaVenta.TabIndex = 10;
            // 
            // gridDetalle
            // 
            this.gridDetalle.DataSource = this.xpDetalleVenta;
            gridLevelNode1.RelationName = "Level1";
            this.gridDetalle.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gridDetalle.Location = new System.Drawing.Point(12, 227);
            this.gridDetalle.MainView = this.gridViewDetalle;
            this.gridDetalle.Name = "gridDetalle";
            this.gridDetalle.Size = new System.Drawing.Size(666, 191);
            this.gridDetalle.TabIndex = 5;
            this.gridDetalle.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewDetalle});
            // 
            // gridViewDetalle
            // 
            this.gridViewDetalle.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdDetalle,
            this.gridColumn4,
            this.gridColumn3,
            this.gridColumn6,
            this.gridColumn5,
            this.colCantidad,
            this.colSubTotal,
            this.gridColumn1,
            this.gridColumn2});
            this.gridViewDetalle.GridControl = this.gridDetalle;
            this.gridViewDetalle.Name = "gridViewDetalle";
            // 
            // colIdDetalle
            // 
            this.colIdDetalle.FieldName = "IdDetalle";
            this.colIdDetalle.Name = "colIdDetalle";
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Codigo Producto";
            this.gridColumn4.FieldName = "IdProducto.IdProducto";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 0;
            this.gridColumn4.Width = 89;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Producto";
            this.gridColumn3.FieldName = "IdProducto.Nombre";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 1;
            this.gridColumn3.Width = 108;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "Presentacion ";
            this.gridColumn6.FieldName = "IdProducto.IdPresentacion.Nombre";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 2;
            this.gridColumn6.Width = 119;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "Categoria";
            this.gridColumn5.FieldName = "IdProducto.IdCategoria.Nombre";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 3;
            this.gridColumn5.Width = 108;
            // 
            // colCantidad
            // 
            this.colCantidad.Caption = "Cantidad";
            this.colCantidad.FieldName = "Cantidad";
            this.colCantidad.Name = "colCantidad";
            this.colCantidad.Visible = true;
            this.colCantidad.VisibleIndex = 4;
            this.colCantidad.Width = 108;
            // 
            // colSubTotal
            // 
            this.colSubTotal.Caption = "Sub Total";
            this.colSubTotal.FieldName = "SubTotal";
            this.colSubTotal.Name = "colSubTotal";
            this.colSubTotal.Visible = true;
            this.colSubTotal.VisibleIndex = 5;
            this.colSubTotal.Width = 108;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "IdVenta!";
            this.gridColumn1.Name = "gridColumn1";
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "IdVenta!Key";
            this.gridColumn2.Name = "gridColumn2";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Appearance.Options.UseFont = true;
            this.btnRegistrar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnRegistrar.ImageOptions.Image")));
            this.btnRegistrar.Location = new System.Drawing.Point(684, 227);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(110, 45);
            this.btnRegistrar.TabIndex = 6;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Appearance.Options.UseFont = true;
            this.btnEliminar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.ImageOptions.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(684, 278);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(110, 45);
            this.btnEliminar.TabIndex = 7;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(688, 402);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(101, 20);
            this.label11.TabIndex = 8;
            this.label11.Text = "TOTAL: C$.";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(551, 123);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(136, 20);
            this.label12.TabIndex = 10;
            this.label12.Text = "SUT TOTAL C$:";
            // 
            // ctSub
            // 
            this.ctSub.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctSub.Location = new System.Drawing.Point(568, 148);
            this.ctSub.Multiline = true;
            this.ctSub.Name = "ctSub";
            this.ctSub.ReadOnly = true;
            this.ctSub.Size = new System.Drawing.Size(100, 32);
            this.ctSub.TabIndex = 11;
            this.ctSub.Text = "0.00";
            this.ctSub.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ctTotal
            // 
            this.ctTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctTotal.Location = new System.Drawing.Point(687, 425);
            this.ctTotal.Multiline = true;
            this.ctTotal.Name = "ctTotal";
            this.ctTotal.ReadOnly = true;
            this.ctTotal.Size = new System.Drawing.Size(100, 40);
            this.ctTotal.TabIndex = 12;
            this.ctTotal.Text = "0.0";
            this.ctTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Appearance.Options.UseFont = true;
            this.btnCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.ImageOptions.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(452, 424);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(110, 41);
            this.btnCancelar.TabIndex = 52;
            this.btnCancelar.Text = "Cancelar";
            // 
            // btnGuardar
            // 
            this.btnGuardar.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Appearance.Options.UseFont = true;
            this.btnGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.ImageOptions.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(336, 424);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(110, 41);
            this.btnGuardar.TabIndex = 51;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Appearance.Options.UseFont = true;
            this.btnSalir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.ImageOptions.Image")));
            this.btnSalir.Location = new System.Drawing.Point(568, 424);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(110, 41);
            this.btnSalir.TabIndex = 55;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // ctDescuento
            // 
            this.ctDescuento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctDescuento.Location = new System.Drawing.Point(692, 353);
            this.ctDescuento.Multiline = true;
            this.ctDescuento.Name = "ctDescuento";
            this.ctDescuento.Size = new System.Drawing.Size(95, 31);
            this.ctDescuento.TabIndex = 56;
            this.ctDescuento.Text = "0.0";
            this.ctDescuento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FVentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(804, 471);
            this.Controls.Add(this.ctDescuento);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.ctTotal);
            this.Controls.Add(this.ctSub);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.gridDetalle);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.GroupProducto);
            this.Controls.Add(this.groupBox1);
            this.Name = "FVentas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "VENTAS DE LA PANADERIA SAN ISIDRO";
            this.Load += new System.EventHandler(this.FVentas_Load);
            this.GroupProducto.ResumeLayout(false);
            this.GroupProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchProducto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchViewProducto)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchCliente.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchViewCliente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpDetalleVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpVentas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpEmpleados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpEstados)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fechaVenta.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fechaVenta.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDetalle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewDetalle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GroupProducto;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ctPrecio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ctStock;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ctCedula;
        private DevExpress.Xpo.UnitOfWork sessionVentas;
        private DevExpress.Xpo.XPCollection xpDetalleVenta;
        private DevExpress.Xpo.XPCollection xpVentas;
        private DevExpress.Xpo.XPCollection xpProductos;
        private DevExpress.Xpo.XPCollection xpClientes;
        private DevExpress.Xpo.XPCollection xpEmpleados;
        private DevExpress.Xpo.XPCollection xpEstados;
        private System.Windows.Forms.ToolTip ttMensaje;
        private DevExpress.XtraEditors.SearchLookUpEdit searchProducto;
        private DevExpress.XtraGrid.Views.Grid.GridView searchViewProducto;
        private System.Windows.Forms.TextBox ctIdProducto;
        private DevExpress.XtraEditors.SearchLookUpEdit searchCliente;
        private DevExpress.XtraGrid.Views.Grid.GridView searchViewCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ctIdCliente;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox groupBox3;
        private DevExpress.XtraEditors.DateEdit fechaVenta;
        private DevExpress.XtraGrid.GridControl gridDetalle;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewDetalle;
        private DevExpress.XtraEditors.SimpleButton btnRegistrar;
        private DevExpress.XtraEditors.SimpleButton btnEliminar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox ctSub;
        private System.Windows.Forms.TextBox ctTotal;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private System.Windows.Forms.Label label15;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraGrid.Columns.GridColumn colIdDetalle;
        private DevExpress.XtraGrid.Columns.GridColumn colCantidad;
        private DevExpress.XtraGrid.Columns.GridColumn colSubTotal;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraEditors.SimpleButton btnSalir;
        private System.Windows.Forms.TextBox ctCantidad;
        private System.Windows.Forms.TextBox ctDescuento;
    }
}