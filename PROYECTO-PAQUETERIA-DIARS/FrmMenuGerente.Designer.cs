namespace PROYECTO_PAQUETERIA_DIARS
{
    partial class FrmMenuGerente
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnAdminLogin = new System.Windows.Forms.Button();
            this.btnRegistroOrdenDeCompra = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.btnManVehiculo = new System.Windows.Forms.Button();
            this.btnManTrabajadores = new System.Windows.Forms.Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(240)))), ((int)(((byte)(34)))));
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnAdminLogin);
            this.panel1.Controls.Add(this.btnRegistroOrdenDeCompra);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnManVehiculo);
            this.panel1.Controls.Add(this.btnManTrabajadores);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 912);
            this.panel1.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(149, 724);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(122, 39);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnAdminLogin
            // 
            this.btnAdminLogin.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnAdminLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminLogin.Location = new System.Drawing.Point(23, 388);
            this.btnAdminLogin.Name = "btnAdminLogin";
            this.btnAdminLogin.Size = new System.Drawing.Size(248, 52);
            this.btnAdminLogin.TabIndex = 1;
            this.btnAdminLogin.Text = "ADMINISTRAR LOGIN";
            this.btnAdminLogin.UseVisualStyleBackColor = true;
            // 
            // btnRegistroOrdenDeCompra
            // 
            this.btnRegistroOrdenDeCompra.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnRegistroOrdenDeCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistroOrdenDeCompra.Location = new System.Drawing.Point(23, 619);
            this.btnRegistroOrdenDeCompra.Name = "btnRegistroOrdenDeCompra";
            this.btnRegistroOrdenDeCompra.Size = new System.Drawing.Size(248, 52);
            this.btnRegistroOrdenDeCompra.TabIndex = 4;
            this.btnRegistroOrdenDeCompra.Text = "REGISTRAR ORDEN DE COMPRA";
            this.btnRegistroOrdenDeCompra.UseVisualStyleBackColor = true;
            this.btnRegistroOrdenDeCompra.Click += new System.EventHandler(this.btnRegistroOrdenDeCompra_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.lblNombre);
            this.panel2.Controls.Add(this.lblCargo);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 241);
            this.panel2.TabIndex = 1;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(119, 163);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 16);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "label2";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Location = new System.Drawing.Point(119, 191);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(44, 16);
            this.lblCargo.TabIndex = 0;
            this.lblCargo.Text = "label1";
            // 
            // btnManVehiculo
            // 
            this.btnManVehiculo.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnManVehiculo.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManVehiculo.Location = new System.Drawing.Point(23, 541);
            this.btnManVehiculo.Name = "btnManVehiculo";
            this.btnManVehiculo.Size = new System.Drawing.Size(248, 52);
            this.btnManVehiculo.TabIndex = 3;
            this.btnManVehiculo.Text = "ADMINISTRAR VEHICULO";
            this.btnManVehiculo.UseVisualStyleBackColor = true;
            this.btnManVehiculo.Click += new System.EventHandler(this.btnManVehiculo_Click);
            // 
            // btnManTrabajadores
            // 
            this.btnManTrabajadores.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnManTrabajadores.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManTrabajadores.Location = new System.Drawing.Point(23, 462);
            this.btnManTrabajadores.Name = "btnManTrabajadores";
            this.btnManTrabajadores.Size = new System.Drawing.Size(248, 52);
            this.btnManTrabajadores.TabIndex = 2;
            this.btnManTrabajadores.Text = "ADMINISTRAR TRABAJADORES";
            this.btnManTrabajadores.UseVisualStyleBackColor = true;
            this.btnManTrabajadores.Click += new System.EventHandler(this.btnManTrabajadores_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContenedor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelContenedor.Location = new System.Drawing.Point(293, 3);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(967, 909);
            this.panelContenedor.TabIndex = 1;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            // 
            // FrmMenuGerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 913);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMenuGerente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenuGerente";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormMenuGerente_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnAdminLogin;
        private System.Windows.Forms.Button btnRegistroOrdenDeCompra;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnManVehiculo;
        private System.Windows.Forms.Button btnManTrabajadores;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCargo;
    }
}