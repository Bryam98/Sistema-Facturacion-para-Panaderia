namespace SFPanaderia.Vistas
{
    partial class FrmProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProductos));
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new DevExpress.XtraEditors.SimpleButton();
            this.gridProductos = new DevExpress.XtraGrid.GridControl();
            this.xpProductos = new DevExpress.Xpo.XPCollection(this.components);
            this.sessionProductos = new DevExpress.Xpo.UnitOfWork(this.components);
            this.gridViewProductos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdProducto1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecioUnidad1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExistencias1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn8 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnNuevo = new DevExpress.XtraEditors.SimpleButton();
            this.searchEstado = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.xpEstados = new DevExpress.Xpo.XPCollection(this.components);
            this.searchLookUpEstado = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.searchPresentacion = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.xpPresentaciones = new DevExpress.Xpo.XPCollection(this.components);
            this.searchLookUpPresentacion = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.CtCantidad = new DevExpress.XtraEditors.TextEdit();
            this.CtPrecio = new DevExpress.XtraEditors.TextEdit();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.CtProducto = new DevExpress.XtraEditors.TextEdit();
            this.searchCategoria = new DevExpress.XtraEditors.SearchLookUpEdit();
            this.xpCategorias = new DevExpress.Xpo.XPCollection(this.components);
            this.searchLookUpCategoria = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.btnElimnar = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditar = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem13 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem11 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem12 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem10 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem14 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem8 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem9 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem6 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem15 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem7 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.colIdProducto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCodigo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colPrecioUnidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colExistencias = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchEstado.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpEstados)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEstado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchPresentacion.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpPresentaciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpPresentacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtCantidad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtPrecio.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtProducto.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchCategoria.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCategorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpCategoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.pictureBox1);
            this.layoutControl2.Controls.Add(this.label1);
            this.layoutControl2.Controls.Add(this.btnSalir);
            this.layoutControl2.Controls.Add(this.gridProductos);
            this.layoutControl2.Controls.Add(this.btnNuevo);
            this.layoutControl2.Controls.Add(this.searchEstado);
            this.layoutControl2.Controls.Add(this.searchPresentacion);
            this.layoutControl2.Controls.Add(this.CtCantidad);
            this.layoutControl2.Controls.Add(this.CtPrecio);
            this.layoutControl2.Controls.Add(this.btnGuardar);
            this.layoutControl2.Controls.Add(this.CtProducto);
            this.layoutControl2.Controls.Add(this.searchCategoria);
            this.layoutControl2.Controls.Add(this.btnElimnar);
            this.layoutControl2.Controls.Add(this.btnCancelar);
            this.layoutControl2.Controls.Add(this.btnEditar);
            this.layoutControl2.Dock = System.Windows.Forms.DockStyle.Right;
            this.layoutControl2.Location = new System.Drawing.Point(12, 0);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup2;
            this.layoutControl2.Size = new System.Drawing.Size(972, 611);
            this.layoutControl2.TabIndex = 2;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(748, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(212, 155);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(948, 26);
            this.label1.TabIndex = 15;
            this.label1.Text = "MANTENIMIENTO DE PRODUCTOS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSalir
            // 
            this.btnSalir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.ImageOptions.Image")));
            this.btnSalir.Location = new System.Drawing.Point(748, 411);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(212, 38);
            this.btnSalir.StyleController = this.layoutControl2;
            this.btnSalir.TabIndex = 14;
            this.btnSalir.Text = "Salir";
            // 
            // gridProductos
            // 
            this.gridProductos.DataSource = this.xpProductos;
            this.gridProductos.Location = new System.Drawing.Point(22, 201);
            this.gridProductos.MainView = this.gridViewProductos;
            this.gridProductos.Name = "gridProductos";
            this.gridProductos.Size = new System.Drawing.Size(712, 398);
            this.gridProductos.TabIndex = 12;
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
            this.colIdProducto1,
            this.colNombre1,
            this.colPrecioUnidad1,
            this.colExistencias1,
            this.gridColumn7,
            this.gridColumn8,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12});
            this.gridViewProductos.GridControl = this.gridProductos;
            this.gridViewProductos.Name = "gridViewProductos";
            this.gridViewProductos.OptionsBehavior.Editable = false;
            this.gridViewProductos.OptionsFind.AlwaysVisible = true;
            this.gridViewProductos.OptionsFind.ShowFindButton = false;
            // 
            // colIdProducto1
            // 
            this.colIdProducto1.FieldName = "IdProducto";
            this.colIdProducto1.Name = "colIdProducto1";
            this.colIdProducto1.Visible = true;
            this.colIdProducto1.VisibleIndex = 0;
            // 
            // colNombre1
            // 
            this.colNombre1.FieldName = "Nombre";
            this.colNombre1.Name = "colNombre1";
            this.colNombre1.Visible = true;
            this.colNombre1.VisibleIndex = 1;
            // 
            // colPrecioUnidad1
            // 
            this.colPrecioUnidad1.FieldName = "PrecioUnidad";
            this.colPrecioUnidad1.Name = "colPrecioUnidad1";
            this.colPrecioUnidad1.Visible = true;
            this.colPrecioUnidad1.VisibleIndex = 2;
            // 
            // colExistencias1
            // 
            this.colExistencias1.FieldName = "Existencias";
            this.colExistencias1.Name = "colExistencias1";
            this.colExistencias1.Visible = true;
            this.colExistencias1.VisibleIndex = 3;
            // 
            // gridColumn7
            // 
            this.gridColumn7.FieldName = "IdCategoria!";
            this.gridColumn7.Name = "gridColumn7";
            // 
            // gridColumn8
            // 
            this.gridColumn8.FieldName = "IdCategoria.Nombre";
            this.gridColumn8.Name = "gridColumn8";
            this.gridColumn8.Visible = true;
            this.gridColumn8.VisibleIndex = 4;
            // 
            // gridColumn9
            // 
            this.gridColumn9.FieldName = "IdPresentacion!";
            this.gridColumn9.Name = "gridColumn9";
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "Presentacion";
            this.gridColumn10.FieldName = "IdPresentacion.Nombre";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 5;
            // 
            // gridColumn11
            // 
            this.gridColumn11.FieldName = "IdEstado!";
            this.gridColumn11.Name = "gridColumn11";
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "Estado";
            this.gridColumn12.FieldName = "IdEstado.Nombre";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 6;
            // 
            // btnNuevo
            // 
            this.btnNuevo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.ImageOptions.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(748, 201);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(212, 38);
            this.btnNuevo.StyleController = this.layoutControl2;
            this.btnNuevo.TabIndex = 7;
            this.btnNuevo.Text = " Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // searchEstado
            // 
            this.searchEstado.Location = new System.Drawing.Point(102, 162);
            this.searchEstado.Name = "searchEstado";
            this.searchEstado.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchEstado.Properties.DataSource = this.xpEstados;
            this.searchEstado.Properties.DisplayMember = "Nombre";
            this.searchEstado.Properties.PopupView = this.searchLookUpEstado;
            this.searchEstado.Properties.ValueMember = "IdEstado";
            this.searchEstado.Size = new System.Drawing.Size(222, 20);
            this.searchEstado.StyleController = this.layoutControl2;
            this.searchEstado.TabIndex = 6;
            // 
            // xpEstados
            // 
            this.xpEstados.ObjectType = typeof(SFPanaderia.PanaderiaBD.Estado);
            this.xpEstados.Session = this.sessionProductos;
            // 
            // searchLookUpEstado
            // 
            this.searchLookUpEstado.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpEstado.Name = "searchLookUpEstado";
            this.searchLookUpEstado.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpEstado.OptionsView.ShowGroupPanel = false;
            // 
            // searchPresentacion
            // 
            this.searchPresentacion.Location = new System.Drawing.Point(102, 138);
            this.searchPresentacion.Name = "searchPresentacion";
            this.searchPresentacion.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchPresentacion.Properties.DataSource = this.xpPresentaciones;
            this.searchPresentacion.Properties.DisplayMember = "Nombre";
            this.searchPresentacion.Properties.PopupView = this.searchLookUpPresentacion;
            this.searchPresentacion.Properties.ValueMember = "IdPresentacion";
            this.searchPresentacion.Size = new System.Drawing.Size(222, 20);
            this.searchPresentacion.StyleController = this.layoutControl2;
            this.searchPresentacion.TabIndex = 5;
            // 
            // xpPresentaciones
            // 
            this.xpPresentaciones.ObjectType = typeof(SFPanaderia.PanaderiaBD.Presentacion);
            this.xpPresentaciones.Session = this.sessionProductos;
            // 
            // searchLookUpPresentacion
            // 
            this.searchLookUpPresentacion.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpPresentacion.Name = "searchLookUpPresentacion";
            this.searchLookUpPresentacion.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpPresentacion.OptionsView.ShowGroupPanel = false;
            // 
            // CtCantidad
            // 
            this.CtCantidad.EditValue = "";
            this.CtCantidad.Location = new System.Drawing.Point(102, 114);
            this.CtCantidad.Name = "CtCantidad";
            this.CtCantidad.Properties.Mask.EditMask = "n0";
            this.CtCantidad.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.CtCantidad.Size = new System.Drawing.Size(137, 20);
            this.CtCantidad.StyleController = this.layoutControl2;
            this.CtCantidad.TabIndex = 4;
            // 
            // CtPrecio
            // 
            this.CtPrecio.EditValue = "";
            this.CtPrecio.Location = new System.Drawing.Point(102, 90);
            this.CtPrecio.Name = "CtPrecio";
            this.CtPrecio.Properties.Mask.EditMask = "n";
            this.CtPrecio.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.CtPrecio.Size = new System.Drawing.Size(137, 20);
            this.CtPrecio.StyleController = this.layoutControl2;
            this.CtPrecio.TabIndex = 3;
            // 
            // btnGuardar
            // 
            this.btnGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.ImageOptions.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(748, 285);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(212, 38);
            this.btnGuardar.StyleController = this.layoutControl2;
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // CtProducto
            // 
            this.CtProducto.Location = new System.Drawing.Point(102, 66);
            this.CtProducto.Name = "CtProducto";
            this.CtProducto.Size = new System.Drawing.Size(290, 20);
            this.CtProducto.StyleController = this.layoutControl2;
            this.CtProducto.TabIndex = 2;
            // 
            // searchCategoria
            // 
            this.searchCategoria.EditValue = "Presentacion";
            this.searchCategoria.Location = new System.Drawing.Point(102, 42);
            this.searchCategoria.Name = "searchCategoria";
            this.searchCategoria.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.searchCategoria.Properties.DataSource = this.xpCategorias;
            this.searchCategoria.Properties.DisplayMember = "Nombre";
            this.searchCategoria.Properties.PopupView = this.searchLookUpCategoria;
            this.searchCategoria.Properties.ValueMember = "IdCategoria";
            this.searchCategoria.Size = new System.Drawing.Size(157, 20);
            this.searchCategoria.StyleController = this.layoutControl2;
            this.searchCategoria.TabIndex = 1;
            this.searchCategoria.Tag = "";
            // 
            // xpCategorias
            // 
            this.xpCategorias.ObjectType = typeof(SFPanaderia.PanaderiaBD.Presentacion);
            this.xpCategorias.Session = this.sessionProductos;
            // 
            // searchLookUpCategoria
            // 
            this.searchLookUpCategoria.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.searchLookUpCategoria.Name = "searchLookUpCategoria";
            this.searchLookUpCategoria.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.searchLookUpCategoria.OptionsView.ShowGroupPanel = false;
            // 
            // btnElimnar
            // 
            this.btnElimnar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnElimnar.ImageOptions.Image")));
            this.btnElimnar.Location = new System.Drawing.Point(748, 327);
            this.btnElimnar.Name = "btnElimnar";
            this.btnElimnar.Size = new System.Drawing.Size(212, 38);
            this.btnElimnar.StyleController = this.layoutControl2;
            this.btnElimnar.TabIndex = 11;
            this.btnElimnar.Text = "Eliminar";
            this.btnElimnar.Click += new System.EventHandler(this.btnElimnar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.ImageOptions.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(748, 369);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(212, 38);
            this.btnCancelar.StyleController = this.layoutControl2;
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.ImageOptions.Image")));
            this.btnEditar.Location = new System.Drawing.Point(748, 243);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(212, 38);
            this.btnEditar.StyleController = this.layoutControl2;
            this.btnEditar.TabIndex = 8;
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem4,
            this.layoutControlItem7,
            this.emptySpaceItem2,
            this.emptySpaceItem3,
            this.layoutControlItem1,
            this.layoutControlItem13,
            this.layoutControlItem9,
            this.layoutControlItem11,
            this.layoutControlItem12,
            this.layoutControlItem10,
            this.layoutControlItem14,
            this.emptySpaceItem4,
            this.layoutControlItem5,
            this.emptySpaceItem1,
            this.layoutControlItem3,
            this.emptySpaceItem8,
            this.emptySpaceItem5,
            this.layoutControlItem8,
            this.emptySpaceItem9,
            this.layoutControlItem6,
            this.emptySpaceItem6,
            this.layoutControlItem2,
            this.layoutControlItem15,
            this.emptySpaceItem7});
            this.layoutControlGroup2.Name = "Root";
            this.layoutControlGroup2.Size = new System.Drawing.Size(972, 611);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.searchCategoria;
            this.layoutControlItem4.Location = new System.Drawing.Point(10, 30);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(241, 24);
            this.layoutControlItem4.Text = "Presentacion:";
            this.layoutControlItem4.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem4.TextSize = new System.Drawing.Size(77, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.searchPresentacion;
            this.layoutControlItem7.Location = new System.Drawing.Point(10, 126);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(306, 24);
            this.layoutControlItem7.Text = "Presentacion:";
            this.layoutControlItem7.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem7.TextSize = new System.Drawing.Size(77, 13);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(736, 441);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(216, 150);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(251, 30);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(475, 24);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.gridProductos;
            this.layoutControlItem1.Location = new System.Drawing.Point(10, 189);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(716, 402);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem13
            // 
            this.layoutControlItem13.Control = this.btnNuevo;
            this.layoutControlItem13.Location = new System.Drawing.Point(736, 189);
            this.layoutControlItem13.Name = "layoutControlItem13";
            this.layoutControlItem13.Size = new System.Drawing.Size(216, 42);
            this.layoutControlItem13.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem13.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.btnEditar;
            this.layoutControlItem9.Location = new System.Drawing.Point(736, 231);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(216, 42);
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // layoutControlItem11
            // 
            this.layoutControlItem11.Control = this.btnGuardar;
            this.layoutControlItem11.Location = new System.Drawing.Point(736, 273);
            this.layoutControlItem11.Name = "layoutControlItem11";
            this.layoutControlItem11.Size = new System.Drawing.Size(216, 42);
            this.layoutControlItem11.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem11.TextVisible = false;
            // 
            // layoutControlItem12
            // 
            this.layoutControlItem12.Control = this.btnElimnar;
            this.layoutControlItem12.Location = new System.Drawing.Point(736, 315);
            this.layoutControlItem12.Name = "layoutControlItem12";
            this.layoutControlItem12.Size = new System.Drawing.Size(216, 42);
            this.layoutControlItem12.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem12.TextVisible = false;
            // 
            // layoutControlItem10
            // 
            this.layoutControlItem10.Control = this.btnCancelar;
            this.layoutControlItem10.Location = new System.Drawing.Point(736, 357);
            this.layoutControlItem10.Name = "layoutControlItem10";
            this.layoutControlItem10.Size = new System.Drawing.Size(216, 42);
            this.layoutControlItem10.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem10.TextVisible = false;
            // 
            // layoutControlItem14
            // 
            this.layoutControlItem14.Control = this.btnSalir;
            this.layoutControlItem14.Location = new System.Drawing.Point(736, 399);
            this.layoutControlItem14.Name = "layoutControlItem14";
            this.layoutControlItem14.Size = new System.Drawing.Size(216, 42);
            this.layoutControlItem14.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem14.TextVisible = false;
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(726, 30);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(10, 561);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.CtProducto;
            this.layoutControlItem5.Location = new System.Drawing.Point(10, 54);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(374, 24);
            this.layoutControlItem5.Text = "Producto: ";
            this.layoutControlItem5.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem5.TextSize = new System.Drawing.Size(77, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(384, 54);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(342, 24);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.CtPrecio;
            this.layoutControlItem3.Location = new System.Drawing.Point(10, 78);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(221, 24);
            this.layoutControlItem3.Text = "Precio Unitario: ";
            this.layoutControlItem3.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem3.TextSize = new System.Drawing.Size(77, 13);
            // 
            // emptySpaceItem8
            // 
            this.emptySpaceItem8.AllowHotTrack = false;
            this.emptySpaceItem8.Location = new System.Drawing.Point(231, 78);
            this.emptySpaceItem8.Name = "emptySpaceItem8";
            this.emptySpaceItem8.Size = new System.Drawing.Size(495, 48);
            this.emptySpaceItem8.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.AllowHotTrack = false;
            this.emptySpaceItem5.Location = new System.Drawing.Point(316, 126);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(410, 24);
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.searchEstado;
            this.layoutControlItem8.Location = new System.Drawing.Point(10, 150);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(306, 24);
            this.layoutControlItem8.Text = "Estado: ";
            this.layoutControlItem8.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem8.TextSize = new System.Drawing.Size(77, 13);
            // 
            // emptySpaceItem9
            // 
            this.emptySpaceItem9.AllowHotTrack = false;
            this.emptySpaceItem9.Location = new System.Drawing.Point(316, 150);
            this.emptySpaceItem9.Name = "emptySpaceItem9";
            this.emptySpaceItem9.Size = new System.Drawing.Size(410, 24);
            this.emptySpaceItem9.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.CtCantidad;
            this.layoutControlItem6.Location = new System.Drawing.Point(10, 102);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(221, 24);
            this.layoutControlItem6.Text = "Cantidad Inicial:";
            this.layoutControlItem6.TextLocation = DevExpress.Utils.Locations.Left;
            this.layoutControlItem6.TextSize = new System.Drawing.Size(77, 13);
            // 
            // emptySpaceItem6
            // 
            this.emptySpaceItem6.AllowHotTrack = false;
            this.emptySpaceItem6.Location = new System.Drawing.Point(0, 30);
            this.emptySpaceItem6.Name = "emptySpaceItem6";
            this.emptySpaceItem6.Size = new System.Drawing.Size(10, 561);
            this.emptySpaceItem6.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.label1;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(952, 30);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem15
            // 
            this.layoutControlItem15.Control = this.pictureBox1;
            this.layoutControlItem15.Location = new System.Drawing.Point(736, 30);
            this.layoutControlItem15.Name = "layoutControlItem15";
            this.layoutControlItem15.Size = new System.Drawing.Size(216, 159);
            this.layoutControlItem15.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem15.TextVisible = false;
            // 
            // emptySpaceItem7
            // 
            this.emptySpaceItem7.AllowHotTrack = false;
            this.emptySpaceItem7.Location = new System.Drawing.Point(10, 174);
            this.emptySpaceItem7.Name = "emptySpaceItem7";
            this.emptySpaceItem7.Size = new System.Drawing.Size(716, 15);
            this.emptySpaceItem7.TextSize = new System.Drawing.Size(0, 0);
            // 
            // colIdProducto
            // 
            this.colIdProducto.FieldName = "IdProducto";
            this.colIdProducto.Name = "colIdProducto";
            this.colIdProducto.Visible = true;
            this.colIdProducto.VisibleIndex = 0;
            // 
            // colCodigo
            // 
            this.colCodigo.FieldName = "Codigo";
            this.colCodigo.Name = "colCodigo";
            this.colCodigo.Visible = true;
            this.colCodigo.VisibleIndex = 1;
            // 
            // colNombre
            // 
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 2;
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
            this.colExistencias.VisibleIndex = 4;
            // 
            // gridColumn1
            // 
            this.gridColumn1.FieldName = "IdCategoria!";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 5;
            // 
            // gridColumn2
            // 
            this.gridColumn2.FieldName = "IdCategoria!Key";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 6;
            // 
            // gridColumn3
            // 
            this.gridColumn3.FieldName = "IdPresentacion!";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 7;
            // 
            // gridColumn4
            // 
            this.gridColumn4.FieldName = "IdPresentacion!Key";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 8;
            // 
            // gridColumn5
            // 
            this.gridColumn5.FieldName = "IdEstado!";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 9;
            // 
            // gridColumn6
            // 
            this.gridColumn6.FieldName = "IdEstado!Key";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 10;
            // 
            // FrmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 611);
            this.Controls.Add(this.layoutControl2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmProductos";
            this.Text = "Registro Productos";
            this.Load += new System.EventHandler(this.FrmProductos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchEstado.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpEstados)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpEstado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchPresentacion.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpPresentaciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpPresentacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtCantidad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtPrecio.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CtProducto.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchCategoria.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCategorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchLookUpCategoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem15)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraEditors.SimpleButton btnElimnar;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnEditar;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem10;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem12;
        private DevExpress.XtraEditors.SearchLookUpEdit searchEstado;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpEstado;
        private DevExpress.XtraEditors.SearchLookUpEdit searchPresentacion;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpPresentacion;
        private DevExpress.XtraEditors.TextEdit CtCantidad;
        private DevExpress.XtraEditors.TextEdit CtPrecio;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraEditors.TextEdit CtProducto;
        private DevExpress.XtraEditors.SearchLookUpEdit searchCategoria;
        private DevExpress.XtraGrid.Views.Grid.GridView searchLookUpCategoria;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem11;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.SimpleButton btnNuevo;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem13;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.Xpo.UnitOfWork sessionProductos;
        private DevExpress.Xpo.XPCollection xpProductos;
        private DevExpress.Xpo.XPCollection xpCategorias;
        private DevExpress.Xpo.XPCollection xpPresentaciones;
        private DevExpress.Xpo.XPCollection xpEstados;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProducto;
        private DevExpress.XtraGrid.Columns.GridColumn colCodigo;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecioUnidad;
        private DevExpress.XtraGrid.Columns.GridColumn colExistencias;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.GridControl gridProductos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewProductos;
        private DevExpress.XtraGrid.Columns.GridColumn colIdProducto1;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre1;
        private DevExpress.XtraGrid.Columns.GridColumn colPrecioUnidad1;
        private DevExpress.XtraGrid.Columns.GridColumn colExistencias1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn8;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
        private DevExpress.XtraEditors.SimpleButton btnSalir;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem14;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem8;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem9;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem6;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem15;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem7;
    }
}