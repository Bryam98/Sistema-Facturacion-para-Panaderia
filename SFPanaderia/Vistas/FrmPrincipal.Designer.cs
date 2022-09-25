namespace SFPanaderia.Vistas
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.barCategorias = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.n = new DevExpress.XtraBars.BarButtonItem();
            this.AgregarProductos = new DevExpress.XtraBars.BarButtonItem();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.barSubItem2 = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.btnProductos = new DevExpress.XtraBars.BarButtonItem();
            this.btnCategorias = new DevExpress.XtraBars.BarButtonItem();
            this.btnPresentacion = new DevExpress.XtraBars.BarButtonItem();
            this.barProducto = new DevExpress.XtraBars.BarButtonItem();
            this.barCategoria = new DevExpress.XtraBars.BarButtonItem();
            this.LabelDate = new DevExpress.XtraBars.BarStaticItem();
            this.barStaticItem1 = new DevExpress.XtraBars.BarStaticItem();
            this.labelUsuario = new DevExpress.XtraBars.BarStaticItem();
            this.ctUserActivo = new DevExpress.XtraBars.BarStaticItem();
            this.barIngreso = new DevExpress.XtraBars.BarButtonItem();
            this.barCargos = new DevExpress.XtraBars.BarButtonItem();
            this.barEmpleados = new DevExpress.XtraBars.BarButtonItem();
            this.barUsuarios = new DevExpress.XtraBars.BarButtonItem();
            this.barVentas = new DevExpress.XtraBars.BarButtonItem();
            this.barClientes = new DevExpress.XtraBars.BarButtonItem();
            this.barIngresos = new DevExpress.XtraBars.BarButtonItem();
            this.barListItem1 = new DevExpress.XtraBars.BarListItem();
            this.barPresentacion = new DevExpress.XtraBars.BarButtonItem();
            this.PageMantenimiento = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.GestionUsuarios = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.GestionCargos = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.GestionEmpleados = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.PageAlmacen = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.GestionIngresos = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.GestionProductos = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.GestionCategorias = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.GestionPresentacion = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.PageVentas = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.GestionVentas = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.GestionClientes = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.PageReportes = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.PageSalir = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.repositoryItemHypertextLabel1 = new DevExpress.XtraEditors.Repository.RepositoryItemHypertextLabel();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHypertextLabel1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.barButtonItem1,
            this.barButtonItem2,
            this.barCategorias,
            this.barButtonItem3,
            this.n,
            this.AgregarProductos,
            this.barSubItem1,
            this.barSubItem2,
            this.barButtonItem4,
            this.btnProductos,
            this.btnCategorias,
            this.btnPresentacion,
            this.barProducto,
            this.barCategoria,
            this.LabelDate,
            this.barStaticItem1,
            this.labelUsuario,
            this.ctUserActivo,
            this.barIngreso,
            this.barCargos,
            this.barEmpleados,
            this.barUsuarios,
            this.barVentas,
            this.barClientes,
            this.barIngresos,
            this.barListItem1,
            this.barPresentacion});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 42;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.PageMantenimiento,
            this.PageAlmacen,
            this.PageVentas,
            this.PageReportes,
            this.PageSalir});
            this.ribbon.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemHypertextLabel1});
            this.ribbon.Size = new System.Drawing.Size(1090, 162);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Click += new System.EventHandler(this.ribbon_Click);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "barButtonItem1";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "barButtonItem2";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.Name = "barButtonItem2";
            // 
            // barCategorias
            // 
            this.barCategorias.Caption = "Agregar Categorias";
            this.barCategorias.Id = 3;
            this.barCategorias.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barCategorias.ImageOptions.Image")));
            this.barCategorias.Name = "barCategorias";
            this.barCategorias.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "barButtonItem3";
            this.barButtonItem3.Id = 4;
            this.barButtonItem3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem3.ImageOptions.Image")));
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // n
            // 
            this.n.Caption = "barButtonItem4";
            this.n.Id = 5;
            this.n.Name = "n";
            // 
            // AgregarProductos
            // 
            this.AgregarProductos.Caption = "Productos";
            this.AgregarProductos.Id = 6;
            this.AgregarProductos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("AgregarProductos.ImageOptions.Image")));
            this.AgregarProductos.Name = "AgregarProductos";
            this.AgregarProductos.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "barSubItem1";
            this.barSubItem1.Id = 7;
            this.barSubItem1.Name = "barSubItem1";
            // 
            // barSubItem2
            // 
            this.barSubItem2.Caption = "barSubItem2";
            this.barSubItem2.Id = 8;
            this.barSubItem2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem4)});
            this.barSubItem2.Name = "barSubItem2";
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "barButtonItem4";
            this.barButtonItem4.Id = 9;
            this.barButtonItem4.Name = "barButtonItem4";
            // 
            // btnProductos
            // 
            this.btnProductos.Caption = "Productos";
            this.btnProductos.Id = 12;
            this.btnProductos.Name = "btnProductos";
            // 
            // btnCategorias
            // 
            this.btnCategorias.Caption = "Categorias";
            this.btnCategorias.Id = 13;
            this.btnCategorias.Name = "btnCategorias";
            // 
            // btnPresentacion
            // 
            this.btnPresentacion.Caption = "Presentacion";
            this.btnPresentacion.Id = 14;
            this.btnPresentacion.Name = "btnPresentacion";
            // 
            // barProducto
            // 
            this.barProducto.Caption = "Productos";
            this.barProducto.Id = 18;
            this.barProducto.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barProducto.ImageOptions.Image")));
            this.barProducto.Name = "barProducto";
            this.barProducto.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barProducto.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barProducto_ItemClick);
            // 
            // barCategoria
            // 
            this.barCategoria.Caption = "Categorias";
            this.barCategoria.Id = 19;
            this.barCategoria.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barCategoria.ImageOptions.Image")));
            this.barCategoria.Name = "barCategoria";
            this.barCategoria.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barCategoria.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barCategoria_ItemClick);
            // 
            // LabelDate
            // 
            this.LabelDate.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.LabelDate.Caption = "Hora y Fecha";
            this.LabelDate.Id = 24;
            this.LabelDate.Name = "LabelDate";
            // 
            // barStaticItem1
            // 
            this.barStaticItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.barStaticItem1.Caption = "...:...";
            this.barStaticItem1.Id = 25;
            this.barStaticItem1.Name = "barStaticItem1";
            // 
            // labelUsuario
            // 
            this.labelUsuario.Caption = "Usuario: ";
            this.labelUsuario.Id = 29;
            this.labelUsuario.ItemAppearance.Disabled.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUsuario.ItemAppearance.Disabled.Options.UseFont = true;
            this.labelUsuario.Name = "labelUsuario";
            // 
            // ctUserActivo
            // 
            this.ctUserActivo.Caption = ".:.";
            this.ctUserActivo.Id = 30;
            this.ctUserActivo.Name = "ctUserActivo";
            // 
            // barIngreso
            // 
            this.barIngreso.Caption = "Ingreso Productos";
            this.barIngreso.Id = 31;
            this.barIngreso.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barIngreso.ImageOptions.Image")));
            this.barIngreso.Name = "barIngreso";
            this.barIngreso.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            // 
            // barCargos
            // 
            this.barCargos.Caption = "Cargos";
            this.barCargos.Id = 32;
            this.barCargos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barCargos.ImageOptions.Image")));
            this.barCargos.Name = "barCargos";
            this.barCargos.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barCargos.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barCargos_ItemClick);
            // 
            // barEmpleados
            // 
            this.barEmpleados.Caption = "Empleados";
            this.barEmpleados.Id = 33;
            this.barEmpleados.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barEmpleados.ImageOptions.Image")));
            this.barEmpleados.Name = "barEmpleados";
            this.barEmpleados.RibbonStyle = ((DevExpress.XtraBars.Ribbon.RibbonItemStyles)(((DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithText) 
            | DevExpress.XtraBars.Ribbon.RibbonItemStyles.SmallWithoutText)));
            this.barEmpleados.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barEmpleados_ItemClick);
            // 
            // barUsuarios
            // 
            this.barUsuarios.Caption = "Usuarios";
            this.barUsuarios.Id = 35;
            this.barUsuarios.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barUsuarios.ImageOptions.Image")));
            this.barUsuarios.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barUsuarios.ImageOptions.LargeImage")));
            this.barUsuarios.Name = "barUsuarios";
            this.barUsuarios.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barUsuarios.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barUsuarios_ItemClick);
            // 
            // barVentas
            // 
            this.barVentas.Caption = "Ventas";
            this.barVentas.Id = 36;
            this.barVentas.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barVentas.ImageOptions.Image")));
            this.barVentas.Name = "barVentas";
            this.barVentas.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barVentas.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barVentas_ItemClick);
            // 
            // barClientes
            // 
            this.barClientes.Caption = "Clientes";
            this.barClientes.Id = 37;
            this.barClientes.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barClientes.ImageOptions.Image")));
            this.barClientes.Name = "barClientes";
            this.barClientes.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barClientes.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barClientes_ItemClick);
            // 
            // barIngresos
            // 
            this.barIngresos.Caption = "Ingreso  Productos";
            this.barIngresos.Id = 38;
            this.barIngresos.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barIngresos.ImageOptions.Image")));
            this.barIngresos.Name = "barIngresos";
            this.barIngresos.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barIngresos.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barIngresos_ItemClick);
            // 
            // barListItem1
            // 
            this.barListItem1.Caption = "barListItem1";
            this.barListItem1.Id = 39;
            this.barListItem1.Name = "barListItem1";
            // 
            // barPresentacion
            // 
            this.barPresentacion.Caption = "Presentacion";
            this.barPresentacion.Id = 40;
            this.barPresentacion.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barPresentacion.ImageOptions.Image")));
            this.barPresentacion.Name = "barPresentacion";
            this.barPresentacion.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            this.barPresentacion.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barPresentacion_ItemClick);
            // 
            // PageMantenimiento
            // 
            this.PageMantenimiento.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageMantenimiento.Appearance.Options.UseFont = true;
            this.PageMantenimiento.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.GestionUsuarios,
            this.GestionCargos,
            this.GestionEmpleados});
            this.PageMantenimiento.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("PageMantenimiento.ImageOptions.Image")));
            this.PageMantenimiento.Name = "PageMantenimiento";
            this.PageMantenimiento.Text = "  Mantenimiento";
            // 
            // GestionUsuarios
            // 
            this.GestionUsuarios.ItemLinks.Add(this.barUsuarios);
            this.GestionUsuarios.Name = "GestionUsuarios";
            this.GestionUsuarios.Text = "Gestion de Usuarios";
            // 
            // GestionCargos
            // 
            this.GestionCargos.ItemLinks.Add(this.barCargos);
            this.GestionCargos.Name = "GestionCargos";
            this.GestionCargos.Text = "Gestion de Cargos";
            // 
            // GestionEmpleados
            // 
            this.GestionEmpleados.ItemLinks.Add(this.barEmpleados);
            this.GestionEmpleados.Name = "GestionEmpleados";
            this.GestionEmpleados.Text = "Gestion de Empleados";
            // 
            // PageAlmacen
            // 
            this.PageAlmacen.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageAlmacen.Appearance.Options.UseFont = true;
            this.PageAlmacen.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.GestionIngresos,
            this.GestionProductos,
            this.GestionCategorias,
            this.GestionPresentacion});
            this.PageAlmacen.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("PageAlmacen.ImageOptions.Image")));
            this.PageAlmacen.Name = "PageAlmacen";
            this.PageAlmacen.Text = "  Almacen";
            // 
            // GestionIngresos
            // 
            this.GestionIngresos.ItemLinks.Add(this.barIngresos);
            this.GestionIngresos.Name = "GestionIngresos";
            this.GestionIngresos.Text = "Gestion de Ingresos";
            // 
            // GestionProductos
            // 
            this.GestionProductos.ItemLinks.Add(this.barProducto);
            this.GestionProductos.Name = "GestionProductos";
            this.GestionProductos.Text = "Gestion Productos";
            // 
            // GestionCategorias
            // 
            this.GestionCategorias.ItemLinks.Add(this.barCategoria);
            this.GestionCategorias.Name = "GestionCategorias";
            this.GestionCategorias.Text = "Gestion Categorias";
            // 
            // GestionPresentacion
            // 
            this.GestionPresentacion.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("GestionPresentacion.ImageOptions.Image")));
            this.GestionPresentacion.ItemLinks.Add(this.barPresentacion);
            this.GestionPresentacion.Name = "GestionPresentacion";
            this.GestionPresentacion.Text = "Gestion Presentacion";
            // 
            // PageVentas
            // 
            this.PageVentas.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageVentas.Appearance.Options.UseFont = true;
            this.PageVentas.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.GestionVentas,
            this.GestionClientes});
            this.PageVentas.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("PageVentas.ImageOptions.Image")));
            this.PageVentas.Name = "PageVentas";
            this.PageVentas.Text = "  Ventas";
            // 
            // GestionVentas
            // 
            this.GestionVentas.ItemLinks.Add(this.barVentas);
            this.GestionVentas.Name = "GestionVentas";
            this.GestionVentas.Text = "Gestion de Ventas";
            // 
            // GestionClientes
            // 
            this.GestionClientes.ItemLinks.Add(this.barClientes);
            this.GestionClientes.Name = "GestionClientes";
            this.GestionClientes.Text = "Gestion de Clientes";
            // 
            // PageReportes
            // 
            this.PageReportes.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageReportes.Appearance.Options.UseFont = true;
            this.PageReportes.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("PageReportes.ImageOptions.Image")));
            this.PageReportes.Name = "PageReportes";
            this.PageReportes.Text = "  Reportes";
            // 
            // PageSalir
            // 
            this.PageSalir.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PageSalir.Appearance.Options.UseFont = true;
            this.PageSalir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("PageSalir.ImageOptions.Image")));
            this.PageSalir.Name = "PageSalir";
            this.PageSalir.Text = "   Salir";
            // 
            // repositoryItemHypertextLabel1
            // 
            this.repositoryItemHypertextLabel1.Name = "repositoryItemHypertextLabel1";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.LabelDate);
            this.ribbonStatusBar.ItemLinks.Add(this.barStaticItem1);
            this.ribbonStatusBar.ItemLinks.Add(this.labelUsuario);
            this.ribbonStatusBar.ItemLinks.Add(this.ctUserActivo);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 668);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(1090, 31);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "ribbonPage2";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FrmPrincipal
            // 
            this.Appearance.Options.UseFont = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1090, 699);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Name = "FrmPrincipal";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "SISTEMA PANADERIA SAN ISIDRO";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemHypertextLabel1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarButtonItem barCategorias;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem n;
        private DevExpress.XtraBars.BarButtonItem AgregarProductos;
        private DevExpress.XtraBars.Ribbon.RibbonPage PageAlmacen;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarSubItem barSubItem2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPage PageReportes;
        private DevExpress.XtraBars.BarButtonItem btnProductos;
        private DevExpress.XtraBars.BarButtonItem btnCategorias;
        private DevExpress.XtraBars.BarButtonItem btnPresentacion;
        private DevExpress.XtraBars.Ribbon.RibbonPage PageMantenimiento;
        private DevExpress.XtraBars.Ribbon.RibbonPage PageVentas;
        private DevExpress.XtraBars.BarButtonItem barProducto;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup GestionProductos;
        private DevExpress.XtraBars.BarButtonItem barCategoria;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup GestionCategorias;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup GestionPresentacion;
        private DevExpress.XtraEditors.Repository.RepositoryItemHypertextLabel repositoryItemHypertextLabel1;
        private DevExpress.XtraBars.BarStaticItem LabelDate;
        private DevExpress.XtraBars.BarStaticItem barStaticItem1;
        private DevExpress.XtraBars.BarStaticItem labelUsuario;
        private DevExpress.XtraBars.BarStaticItem ctUserActivo;
        private DevExpress.XtraBars.BarButtonItem barIngreso;
        private DevExpress.XtraBars.BarButtonItem barCargos;
        private DevExpress.XtraBars.BarButtonItem barEmpleados;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup GestionCargos;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup GestionEmpleados;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup GestionUsuarios;
        private DevExpress.XtraBars.BarButtonItem barUsuarios;
        private DevExpress.XtraBars.Ribbon.RibbonPage PageSalir;
        private DevExpress.XtraBars.BarButtonItem barVentas;
        private DevExpress.XtraBars.BarButtonItem barClientes;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup GestionVentas;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup GestionClientes;
        private DevExpress.XtraBars.BarButtonItem barIngresos;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup GestionIngresos;
        private DevExpress.XtraBars.BarListItem barListItem1;
        private DevExpress.XtraBars.BarButtonItem barPresentacion;
        private System.Windows.Forms.Timer timer1;
    }
}