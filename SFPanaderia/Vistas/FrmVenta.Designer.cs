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
            this.label3 = new System.Windows.Forms.Label();
            this.xpClientes = new DevExpress.Xpo.XPCollection(this.components);
            this.sessionVenta = new DevExpress.Xpo.UnitOfWork(this.components);
            this.ctNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ctCedula = new System.Windows.Forms.TextBox();
            this.xpDetalleVenta = new DevExpress.Xpo.XPCollection(this.components);
            this.xpProductos = new DevExpress.Xpo.XPCollection(this.components);
            this.btnCliente = new DevExpress.XtraEditors.SimpleButton();
            this.ctId = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xpClientes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionVenta)).BeginInit();
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
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(760, 88);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(463, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 16);
            this.label3.TabIndex = 5;
            // 
            // xpClientes
            // 
            this.xpClientes.DisplayableProperties = "This;IdCliente;Nombres;Apellidos;Sexo;Direccion;Cedula;Telefono;FechaRegistro;IdE" +
    "stado!;IdEstado!Key;IdEstado.Nombre;Ventas";
            this.xpClientes.ObjectType = typeof(SFPanaderia.PanaderiaBD.Cliente);
            this.xpClientes.Session = this.sessionVenta;
            // 
            // sessionVenta
            // 
            this.sessionVenta.IsObjectModifiedOnNonPersistentPropertyChange = null;
            this.sessionVenta.TrackPropertiesModifications = false;
            // 
            // ctNombre
            // 
            this.ctNombre.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctNombre.Location = new System.Drawing.Point(228, 50);
            this.ctNombre.Name = "ctNombre";
            this.ctNombre.Size = new System.Drawing.Size(301, 22);
            this.ctNombre.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(168, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sr (a): ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(185, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Documento de Identidad: ";
            // 
            // ctCedula
            // 
            this.ctCedula.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctCedula.Location = new System.Drawing.Point(228, 22);
            this.ctCedula.Name = "ctCedula";
            this.ctCedula.Size = new System.Drawing.Size(188, 22);
            this.ctCedula.TabIndex = 0;
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
            // btnCliente
            // 
            this.btnCliente.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCliente.Appearance.Options.UseFont = true;
            this.btnCliente.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnCliente.Location = new System.Drawing.Point(554, 22);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(154, 53);
            this.btnCliente.TabIndex = 6;
            this.btnCliente.Text = "Agregar Cliente";
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // ctId
            // 
            this.ctId.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctId.Location = new System.Drawing.Point(454, 22);
            this.ctId.Name = "ctId";
            this.ctId.Size = new System.Drawing.Size(52, 22);
            this.ctId.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(421, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "ID:";
            // 
            // FrmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FORMULARIO DE VENTAS";
            this.Load += new System.EventHandler(this.FrmVenta_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.xpClientes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sessionVenta)).EndInit();
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
    }
}