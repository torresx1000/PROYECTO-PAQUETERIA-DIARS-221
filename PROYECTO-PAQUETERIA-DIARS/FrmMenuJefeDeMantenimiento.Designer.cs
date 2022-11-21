namespace PROYECTO_PAQUETERIA_DIARS
{
    partial class FrmMenuJefeDeMantenimiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuJefeDeMantenimiento));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnConfigLogin = new System.Windows.Forms.Button();
            this.pantalla = new System.Windows.Forms.Panel();
            this.btnRegistrarDiagnostico = new System.Windows.Forms.Button();
            this.Panelcajero = new System.Windows.Forms.Panel();
            this.txthora = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.mantenimietopanel = new System.Windows.Forms.Panel();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelCargo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.Panelcajero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txthora)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnConfigLogin);
            this.panel1.Controls.Add(this.pantalla);
            this.panel1.Controls.Add(this.btnRegistrarDiagnostico);
            this.panel1.Location = new System.Drawing.Point(8, 94);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(304, 793);
            this.panel1.TabIndex = 2;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(169, 741);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(123, 39);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnConfigLogin
            // 
            this.btnConfigLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfigLogin.Location = new System.Drawing.Point(23, 297);
            this.btnConfigLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfigLogin.Name = "btnConfigLogin";
            this.btnConfigLogin.Size = new System.Drawing.Size(248, 52);
            this.btnConfigLogin.TabIndex = 1;
            this.btnConfigLogin.Text = "CONFIGURAR LOGIN";
            this.btnConfigLogin.UseVisualStyleBackColor = true;
            this.btnConfigLogin.Click += new System.EventHandler(this.btnConfigLogin_Click);
            // 
            // pantalla
            // 
            this.pantalla.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pantalla.Location = new System.Drawing.Point(23, 20);
            this.pantalla.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pantalla.Name = "pantalla";
            this.pantalla.Size = new System.Drawing.Size(255, 210);
            this.pantalla.TabIndex = 1;
            // 
            // btnRegistrarDiagnostico
            // 
            this.btnRegistrarDiagnostico.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarDiagnostico.Location = new System.Drawing.Point(23, 379);
            this.btnRegistrarDiagnostico.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRegistrarDiagnostico.Name = "btnRegistrarDiagnostico";
            this.btnRegistrarDiagnostico.Size = new System.Drawing.Size(248, 52);
            this.btnRegistrarDiagnostico.TabIndex = 2;
            this.btnRegistrarDiagnostico.Text = "REGISTRAR DIAGNOSTICO";
            this.btnRegistrarDiagnostico.UseVisualStyleBackColor = true;
            this.btnRegistrarDiagnostico.Click += new System.EventHandler(this.btnRegistrarDiagnostico_Click);
            // 
            // Panelcajero
            // 
            this.Panelcajero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.Panelcajero.Controls.Add(this.labelNombre);
            this.Panelcajero.Controls.Add(this.labelCargo);
            this.Panelcajero.Controls.Add(this.txthora);
            this.Panelcajero.Controls.Add(this.label1);
            this.Panelcajero.Controls.Add(this.lblFecha);
            this.Panelcajero.Controls.Add(this.lblHora);
            this.Panelcajero.Dock = System.Windows.Forms.DockStyle.Top;
            this.Panelcajero.Location = new System.Drawing.Point(0, 0);
            this.Panelcajero.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Panelcajero.Name = "Panelcajero";
            this.Panelcajero.Size = new System.Drawing.Size(1405, 92);
            this.Panelcajero.TabIndex = 9;
            // 
            // txthora
            // 
            this.txthora.Image = global::PROYECTO_PAQUETERIA_DIARS.Properties.Resources._2413744;
            this.txthora.Location = new System.Drawing.Point(16, 27);
            this.txthora.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txthora.Name = "txthora";
            this.txthora.Size = new System.Drawing.Size(81, 38);
            this.txthora.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.txthora.TabIndex = 8;
            this.txthora.TabStop = false;
            this.txthora.Click += new System.EventHandler(this.txthora_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(105, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(491, 36);
            this.label1.TabIndex = 7;
            this.label1.Text = "MENU JEFE DE MANTENIMIENTO";
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.Location = new System.Drawing.Point(1259, 54);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(87, 28);
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
            this.lblHora.Location = new System.Drawing.Point(1321, 11);
            this.lblHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(65, 24);
            this.lblHora.TabIndex = 5;
            this.lblHora.Text = "HORA";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // mantenimietopanel
            // 
            this.mantenimietopanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mantenimietopanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.mantenimietopanel.BackgroundImage = global::PROYECTO_PAQUETERIA_DIARS.Properties.Resources.nada;
            this.mantenimietopanel.Location = new System.Drawing.Point(317, 98);
            this.mantenimietopanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mantenimietopanel.Name = "mantenimietopanel";
            this.mantenimietopanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mantenimietopanel.Size = new System.Drawing.Size(1073, 788);
            this.mantenimietopanel.TabIndex = 3;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.BackColor = System.Drawing.Color.Transparent;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.Color.White;
            this.labelNombre.Location = new System.Drawing.Point(1011, 13);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(107, 22);
            this.labelNombre.TabIndex = 10;
            this.labelNombre.Text = "NOMBRES";
            // 
            // labelCargo
            // 
            this.labelCargo.AutoSize = true;
            this.labelCargo.BackColor = System.Drawing.Color.Transparent;
            this.labelCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCargo.ForeColor = System.Drawing.Color.White;
            this.labelCargo.Location = new System.Drawing.Point(1045, 50);
            this.labelCargo.Name = "labelCargo";
            this.labelCargo.Size = new System.Drawing.Size(81, 22);
            this.labelCargo.TabIndex = 11;
            this.labelCargo.Text = "CARGO";
            // 
            // FrmMenuJefeDeMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1405, 887);
            this.Controls.Add(this.Panelcajero);
            this.Controls.Add(this.mantenimietopanel);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmMenuJefeDeMantenimiento";
            this.Text = "FrmMenuJefeDeMantenimiento";
            this.panel1.ResumeLayout(false);
            this.Panelcajero.ResumeLayout(false);
            this.Panelcajero.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txthora)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnConfigLogin;
        private System.Windows.Forms.Panel pantalla;
        private System.Windows.Forms.Button btnRegistrarDiagnostico;
        private System.Windows.Forms.Panel mantenimietopanel;
        private System.Windows.Forms.Panel Panelcajero;
        private System.Windows.Forms.PictureBox txthora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelCargo;
    }
}