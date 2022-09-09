namespace SFPanaderia.Vistas
{
    partial class FCargos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FCargos));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEliminar = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditar = new DevExpress.XtraEditors.SimpleButton();
            this.btnSalir = new DevExpress.XtraEditors.SimpleButton();
            this.gridCargos = new DevExpress.XtraGrid.GridControl();
            this.xpCargos = new DevExpress.Xpo.XPCollection(this.components);
            this.sessionCargos = new DevExpress.Xpo.UnitOfWork(this.components);
            this.gridViewCargos = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdCargo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnCancelar = new DevExpress.XtraEditors.SimpleButton();
            this.btnGuardar = new DevExpress.XtraEditors.SimpleButton();
            this.btnNuevo = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ctDescripcion = new System.Windows.Forms.TextBox();
            this.ctNombre = new System.Windows.Forms.TextBox();
            this.ctId = new System.Windows.Forms.TextBox();
            this.ttMensaje = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridCargos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCargos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionCargos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCargos)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(549, 48);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(68, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Cargos";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 48);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(549, 380);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.gridCargos);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(541, 354);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Listado Cargos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnEliminar);
            this.panel2.Controls.Add(this.btnEditar);
            this.panel2.Controls.Add(this.btnSalir);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(3, 304);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(535, 47);
            this.panel2.TabIndex = 2;
            // 
            // btnEliminar
            // 
            this.btnEliminar.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Appearance.Options.UseFont = true;
            this.btnEliminar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEliminar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.ImageOptions.Image")));
            this.btnEliminar.Location = new System.Drawing.Point(205, 0);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(110, 47);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Appearance.Options.UseFont = true;
            this.btnEditar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnEditar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnEditar.ImageOptions.Image")));
            this.btnEditar.Location = new System.Drawing.Point(315, 0);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(110, 47);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Appearance.Options.UseFont = true;
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSalir.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.ImageOptions.Image")));
            this.btnSalir.Location = new System.Drawing.Point(425, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(110, 47);
            this.btnSalir.TabIndex = 0;
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // gridCargos
            // 
            this.gridCargos.DataSource = this.xpCargos;
            this.gridCargos.Dock = System.Windows.Forms.DockStyle.Top;
            this.gridCargos.Location = new System.Drawing.Point(3, 3);
            this.gridCargos.MainView = this.gridViewCargos;
            this.gridCargos.Name = "gridCargos";
            this.gridCargos.Size = new System.Drawing.Size(535, 295);
            this.gridCargos.TabIndex = 0;
            this.gridCargos.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCargos});
            // 
            // xpCargos
            // 
            this.xpCargos.ObjectType = typeof(SFPanaderia.PanaderiaBD.Cargo);
            this.xpCargos.Session = this.sessionCargos;
            // 
            // sessionCargos
            // 
            this.sessionCargos.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.sessionCargos.TrackPropertiesModifications = false;
            // 
            // gridViewCargos
            // 
            this.gridViewCargos.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdCargo,
            this.colNombre,
            this.colDescripcion});
            this.gridViewCargos.GridControl = this.gridCargos;
            this.gridViewCargos.Name = "gridViewCargos";
            this.gridViewCargos.OptionsBehavior.Editable = false;
            this.gridViewCargos.OptionsFind.AlwaysVisible = true;
            this.gridViewCargos.OptionsFind.ShowFindButton = false;
            // 
            // colIdCargo
            // 
            this.colIdCargo.FieldName = "IdCargo";
            this.colIdCargo.Name = "colIdCargo";
            this.colIdCargo.Visible = true;
            this.colIdCargo.VisibleIndex = 0;
            // 
            // colNombre
            // 
            this.colNombre.FieldName = "Nombre";
            this.colNombre.Name = "colNombre";
            this.colNombre.Visible = true;
            this.colNombre.VisibleIndex = 1;
            // 
            // colDescripcion
            // 
            this.colDescripcion.FieldName = "Descripcion";
            this.colDescripcion.Name = "colDescripcion";
            this.colDescripcion.Visible = true;
            this.colDescripcion.VisibleIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnCancelar);
            this.tabPage2.Controls.Add(this.btnGuardar);
            this.tabPage2.Controls.Add(this.btnNuevo);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.ctDescripcion);
            this.tabPage2.Controls.Add(this.ctNombre);
            this.tabPage2.Controls.Add(this.ctId);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(541, 354);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mantenimiento Cargos";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Appearance.Options.UseFont = true;
            this.btnCancelar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.ImageOptions.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(342, 247);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(112, 46);
            this.btnCancelar.TabIndex = 17;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.Appearance.Options.UseFont = true;
            this.btnGuardar.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnGuardar.ImageOptions.Image")));
            this.btnGuardar.Location = new System.Drawing.Point(224, 247);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(112, 46);
            this.btnGuardar.TabIndex = 16;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Appearance.Options.UseFont = true;
            this.btnNuevo.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnNuevo.ImageOptions.Image")));
            this.btnNuevo.Location = new System.Drawing.Point(106, 247);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(112, 46);
            this.btnNuevo.TabIndex = 15;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Descripcion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(35, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Nombre:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 15);
            this.label1.TabIndex = 12;
            this.label1.Text = "Codigo:";
            // 
            // ctDescripcion
            // 
            this.ctDescripcion.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctDescripcion.Location = new System.Drawing.Point(106, 141);
            this.ctDescripcion.Multiline = true;
            this.ctDescripcion.Name = "ctDescripcion";
            this.ctDescripcion.Size = new System.Drawing.Size(348, 75);
            this.ctDescripcion.TabIndex = 11;
            // 
            // ctNombre
            // 
            this.ctNombre.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctNombre.Location = new System.Drawing.Point(106, 92);
            this.ctNombre.Name = "ctNombre";
            this.ctNombre.Size = new System.Drawing.Size(200, 21);
            this.ctNombre.TabIndex = 10;
            // 
            // ctId
            // 
            this.ctId.Enabled = false;
            this.ctId.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctId.Location = new System.Drawing.Point(106, 48);
            this.ctId.Name = "ctId";
            this.ctId.Size = new System.Drawing.Size(82, 21);
            this.ctId.TabIndex = 9;
            // 
            // FCargos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(549, 428);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Name = "FCargos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FCargos";
            this.Load += new System.EventHandler(this.FCargos_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridCargos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpCargos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionCargos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCargos)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private DevExpress.XtraGrid.GridControl gridCargos;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCargos;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraEditors.SimpleButton btnEliminar;
        private DevExpress.XtraEditors.SimpleButton btnEditar;
        private DevExpress.XtraEditors.SimpleButton btnSalir;
        private DevExpress.Xpo.UnitOfWork sessionCargos;
        private DevExpress.Xpo.XPCollection xpCargos;
        private System.Windows.Forms.ToolTip ttMensaje;
        private DevExpress.XtraGrid.Columns.GridColumn colIdCargo;
        private DevExpress.XtraGrid.Columns.GridColumn colNombre;
        private DevExpress.XtraGrid.Columns.GridColumn colDescripcion;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.SimpleButton btnCancelar;
        private DevExpress.XtraEditors.SimpleButton btnGuardar;
        private DevExpress.XtraEditors.SimpleButton btnNuevo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ctDescripcion;
        private System.Windows.Forms.TextBox ctNombre;
        private System.Windows.Forms.TextBox ctId;
    }
}