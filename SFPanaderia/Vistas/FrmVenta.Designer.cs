namespace SFPanaderia.Vistas
{
    partial class FrmVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVenta));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ctId = new System.Windows.Forms.TextBox();
            this.btnCliente = new DevExpress.XtraEditors.SimpleButton();
            this.label3 = new System.Windows.Forms.Label();
            this.ctNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ctCedula = new System.Windows.Forms.TextBox();
            this.sessionVenta = new DevExpress.Xpo.UnitOfWork(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnProducto = new DevExpress.XtraEditors.SimpleButton();
            this.ctCantidad = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ctPrecio = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ctStock = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ctIdProducto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ctProducto = new System.Windows.Forms.TextBox();
            this.xpClientes = new DevExpress.Xpo.XPCollection(this.components);
            this.xpDetalleVenta = new DevExpress.Xpo.XPCollection(this.components);
            this.xpProductos = new DevExpress.Xpo.XPCollection(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sessionVenta)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xpClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpDetalleVenta)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpProductos)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ctId);
            this.groupBox1.Controls.Add(this.btnCliente);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.ctNombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ctCedula);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 88);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(406, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "ID:";
            // 
            // ctId
            // 
            this.ctId.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctId.Location = new System.Drawing.Point(436, 20);
            this.ctId.Name = "ctId";
            this.ctId.ReadOnly = true;
            this.ctId.Size = new System.Drawing.Size(71, 22);
            this.ctId.TabIndex = 7;
            // 
            // btnCliente
            // 
            this.btnCliente.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.Appearance.Options.UseFont = true;
            this.btnCliente.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnCliente.ImageOptions.Image")));
            this.btnCliente.Location = new System.Drawing.Point(554, 22);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(154, 53);
            this.btnCliente.TabIndex = 6;
            this.btnCliente.Text = "Agregar Cliente";
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(448, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 5;
            // 
            // ctNombre
            // 
            this.ctNombre.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctNombre.Location = new System.Drawing.Point(206, 50);
            this.ctNombre.Name = "ctNombre";
            this.ctNombre.ReadOnly = true;
            this.ctNombre.Size = new System.Drawing.Size(301, 22);
            this.ctNombre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(162, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sr (a): ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Documento de Identidad: ";
            // 
            // ctCedula
            // 
            this.ctCedula.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctCedula.Location = new System.Drawing.Point(206, 22);
            this.ctCedula.Name = "ctCedula";
            this.ctCedula.ReadOnly = true;
            this.ctCedula.Size = new System.Drawing.Size(188, 22);
            this.ctCedula.TabIndex = 0;
            // 
            // sessionVenta
            // 
            this.sessionVenta.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.sessionVenta.TrackPropertiesModifications = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnProducto);
            this.groupBox2.Controls.Add(this.ctCantidad);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.ctPrecio);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.ctStock);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.ctIdProducto);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.ctProducto);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(12, 136);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(760, 88);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Producto";
            // 
            // btnProducto
            // 
            this.btnProducto.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProducto.Appearance.Options.UseFont = true;
            this.btnProducto.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnProducto.ImageOptions.Image")));
            this.btnProducto.Location = new System.Drawing.Point(554, 24);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(154, 53);
            this.btnProducto.TabIndex = 8;
            this.btnProducto.Text = "Agregar Producto";
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // ctCantidad
            // 
            this.ctCantidad.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctCantidad.Location = new System.Drawing.Point(400, 57);
            this.ctCantidad.Name = "ctCantidad";
            this.ctCantidad.Size = new System.Drawing.Size(75, 22);
            this.ctCantidad.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(335, 62);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(68, 16);
            this.label10.TabIndex = 17;
            this.label10.Text = "Cantidad: ";
            // 
            // ctPrecio
            // 
            this.ctPrecio.Location = new System.Drawing.Point(247, 57);
            this.ctPrecio.Name = "ctPrecio";
            this.ctPrecio.ReadOnly = true;
            this.ctPrecio.Size = new System.Drawing.Size(79, 21);
            this.ctPrecio.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(200, 57);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 16);
            this.label9.TabIndex = 15;
            this.label9.Text = "Precio: ";
            // 
            // ctStock
            // 
            this.ctStock.Location = new System.Drawing.Point(112, 57);
            this.ctStock.Name = "ctStock";
            this.ctStock.ReadOnly = true;
            this.ctStock.Size = new System.Drawing.Size(79, 21);
            this.ctStock.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(61, 56);
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
            // ctProducto
            // 
            this.ctProducto.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctProducto.Location = new System.Drawing.Point(112, 24);
            this.ctProducto.Name = "ctProducto";
            this.ctProducto.ReadOnly = true;
            this.ctProducto.Size = new System.Drawing.Size(224, 22);
            this.ctProducto.TabIndex = 8;
            // 
            // xpClientes
            // 
            this.xpClientes.DisplayableProperties = "This;IdCliente;Nombres;Apellidos;Sexo;Direccion;Cedula;Telefono;FechaRegistro;IdE" +
    "stado!;IdEstado!Key;IdEstado.Nombre;Ventas";
            this.xpClientes.ObjectType = typeof(SFPanaderia.PanaderiaBD.Cliente);
            this.xpClientes.Session = this.sessionVenta;
            // 
            // xpDetalleVenta
            // 
            this.xpDetalleVenta.ObjectType = typeof(SFPanaderia.PanaderiaBD.DetalleVenta);
            this.xpDetalleVenta.Session = this.sessionVenta;
            // 
            // xpProductos
            // 
            this.xpProductos.ObjectType = typeof(SFPanaderia.PanaderiaBD.Producto);
            this.xpProductos.Session = this.sessionVenta;
            // 
            // FrmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FORMULARIO DE VENTAS";
            this.Load += new System.EventHandler(this.FrmVenta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sessionVenta)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xpClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpDetalleVenta)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xpProductos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ctNombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ctCedula;
        private DevExpress.Xpo.UnitOfWork sessionVenta;
        private DevExpress.Xpo.XPCollection xpDetalleVenta;
        private DevExpress.Xpo.XPCollection xpProductos;
        private DevExpress.Xpo.XPCollection xpClientes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ctId;
        private DevExpress.XtraEditors.SimpleButton btnCliente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox ctCantidad;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ctPrecio;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox ctStock;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ctIdProducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ctProducto;
        private DevExpress.XtraEditors.SimpleButton btnProducto;
    }
}