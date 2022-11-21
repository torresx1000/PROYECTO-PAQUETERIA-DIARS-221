namespace PROYECTO_PAQUETERIA_DIARS
{
    partial class FrmMenuCajero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuCajero));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnConfigLogin = new System.Windows.Forms.Button();
            this.SalvaPantalla = new System.Windows.Forms.Panel();
            this.btnRegistrarPagoUtilidades = new System.Windows.Forms.Button();
            this.btnRegistrarPagoDeCotizacion = new System.Windows.Forms.Button();
            this.Panelcajero = new System.Windows.Forms.Panel();
            this.txthora = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.Cajero = new System.Windows.Forms.Panel();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCargo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SalvaPantalla.SuspendLayout();
            this.Panelcajero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txthora)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(160)))), ((int)(((byte)(160)))), ((int)(((byte)(160)))));
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnConfigLogin);
            this.panel1.Controls.Add(this.SalvaPantalla);
            this.panel1.Controls.Add(this.btnRegistrarPagoUtilidades);
            this.panel1.Controls.Add(this.btnRegistrarPagoDeCotizacion);
            this.panel1.Location = new System.Drawing.Point(0, 68);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 529);
            this.panel1.TabIndex = 2;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(112, 476);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(92, 32);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnConfigLogin
            // 
            this.btnConfigLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfigLogin.Location = new System.Drawing.Point(17, 203);
            this.btnConfigLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfigLogin.Name = "btnConfigLogin";
            this.btnConfigLogin.Size = new System.Drawing.Size(186, 42);
            this.btnConfigLogin.TabIndex = 1;
            this.btnConfigLogin.Text = "CONFIGURAR LOGIN";
            this.btnConfigLogin.UseVisualStyleBackColor = true;
            this.btnConfigLogin.Click += new System.EventHandler(this.btnConfigLogin_Click);
            // 
            // SalvaPantalla
            // 
            this.SalvaPantalla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.SalvaPantalla.Controls.Add(this.lblCargo);
            this.SalvaPantalla.Controls.Add(this.lblNombre);
            this.SalvaPantalla.Location = new System.Drawing.Point(11, 22);
            this.SalvaPantalla.Margin = new System.Windows.Forms.Padding(2);
            this.SalvaPantalla.Name = "SalvaPantalla";
            this.SalvaPantalla.Size = new System.Drawing.Size(191, 171);
            this.SalvaPantalla.TabIndex = 1;
            // 
            // btnRegistrarPagoUtilidades
            // 
            this.btnRegistrarPagoUtilidades.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarPagoUtilidades.Location = new System.Drawing.Point(17, 327);
            this.btnRegistrarPagoUtilidades.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrarPagoUtilidades.Name = "btnRegistrarPagoUtilidades";
            this.btnRegistrarPagoUtilidades.Size = new System.Drawing.Size(186, 42);
            this.btnRegistrarPagoUtilidades.TabIndex = 3;
            this.btnRegistrarPagoUtilidades.Text = "REGISTRAR PAGO DE UTILIDADES";
            this.btnRegistrarPagoUtilidades.UseVisualStyleBackColor = true;
            this.btnRegistrarPagoUtilidades.Click += new System.EventHandler(this.btnRegistrarPagoUtilidades_Click);
            // 
            // btnRegistrarPagoDeCotizacion
            // 
            this.btnRegistrarPagoDeCotizacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarPagoDeCotizacion.Location = new System.Drawing.Point(17, 263);
            this.btnRegistrarPagoDeCotizacion.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrarPagoDeCotizacion.Name = "btnRegistrarPagoDeCotizacion";
            this.btnRegistrarPagoDeCotizacion.Size = new System.Drawing.Size(186, 42);
            this.btnRegistrarPagoDeCotizacion.TabIndex = 2;
            this.btnRegistrarPagoDeCotizacion.Text = "REGISTRAR PAGO DE COTIZACION";
            this.btnRegistrarPagoDeCotizacion.UseVisualStyleBackColor = true;
            this.btnRegistrarPagoDeCotizacion.Click += new System.EventHandler(this.btnRegistrarPagoDeCotizacion_Click);
            // 
            // Panelcajero
            // 
            this.Panelcajero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.Panelcajero.Controls.Add(this.txthora);
            this.Panelcajero.Controls.Add(this.label1);
            this.Panelcajero.Controls.Add(this.lblFecha);
            this.Panelcajero.Controls.Add(this.lblHora);
            this.Panelcajero.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panelcajero.Location = new System.Drawing.Point(0, 0);
            this.Panelcajero.Name = "Panelcajero";
            this.Panelcajero.Size = new System.Drawing.Size(1117, 75);
            this.Panelcajero.TabIndex = 8;
            // 
            // txthora
            // 
            this.txthora.Image = global::PROYECTO_PAQUETERIA_DIARS.Properties.Resources._2413744;
            this.txthora.Location = new System.Drawing.Point(12, 22);
            this.txthora.Name = "txthora";
            this.txthora.Size = new System.Drawing.Size(61, 31);
            this.txthora.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.txthora.TabIndex = 8;
            this.txthora.TabStop = false;
            this.txthora.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(79, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "MENU CAJERO";
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.Location = new System.Drawing.Point(1007, 44);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(70, 21);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "FECHA";
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.White;
            this.lblHora.Location = new System.Drawing.Point(1054, 9);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(51, 18);
            this.lblHora.TabIndex = 5;
            this.lblHora.Text = "HORA";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Cajero
            // 
            this.Cajero.BackgroundImage = global::PROYECTO_PAQUETERIA_DIARS.Properties.Resources.Captura_de_pantalla_2022_11_20_155822;
            this.Cajero.Location = new System.Drawing.Point(220, 81);
            this.Cajero.Name = "Cajero";
            this.Cajero.Size = new System.Drawing.Size(889, 516);
            this.Cajero.TabIndex = 9;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.Location = new System.Drawing.Point(53, 110);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(85, 20);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "NOMBRE";
            // 
            // lblCargo
            // 
            this.lblCargo.AutoSize = true;
            this.lblCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCargo.Location = new System.Drawing.Point(32, 130);
            this.lblCargo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCargo.Name = "lblCargo";
            this.lblCargo.Size = new System.Drawing.Size(73, 20);
            this.lblCargo.TabIndex = 2;
            this.lblCargo.Text = "CARGO";
            // 
            // FrmMenuCajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1117, 600);
            this.Controls.Add(this.Cajero);
            this.Controls.Add(this.Panelcajero);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMenuCajero";
            this.Text = "FrmMenuCajero";
            this.panel1.ResumeLayout(false);
            this.SalvaPantalla.ResumeLayout(false);
            this.SalvaPantalla.PerformLayout();
            this.Panelcajero.ResumeLayout(false);
            this.Panelcajero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txthora)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnConfigLogin;
        private System.Windows.Forms.Panel SalvaPantalla;
        private System.Windows.Forms.Button btnRegistrarPagoUtilidades;
        private System.Windows.Forms.Button btnRegistrarPagoDeCotizacion;
        private System.Windows.Forms.Panel Panelcajero;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Panel Cajero;
        private System.Windows.Forms.PictureBox txthora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCargo;
    }
}