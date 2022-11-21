namespace PROYECTO_PAQUETERIA_DIARS
{
    partial class FrmMenuJefeDeOperaciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuJefeDeOperaciones));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnConfigLogin = new System.Windows.Forms.Button();
            this.PANTALLA = new System.Windows.Forms.Panel();
            this.btnManRuta = new System.Windows.Forms.Button();
            this.Panelcajero = new System.Windows.Forms.Panel();
            this.txthora = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.OPERACIONES = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.Panelcajero.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txthora)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnConfigLogin);
            this.panel1.Controls.Add(this.PANTALLA);
            this.panel1.Controls.Add(this.btnManRuta);
            this.panel1.Location = new System.Drawing.Point(0, 72);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 580);
            this.panel1.TabIndex = 3;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(112, 535);
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
            this.btnConfigLogin.Location = new System.Drawing.Point(18, 226);
            this.btnConfigLogin.Margin = new System.Windows.Forms.Padding(2);
            this.btnConfigLogin.Name = "btnConfigLogin";
            this.btnConfigLogin.Size = new System.Drawing.Size(186, 42);
            this.btnConfigLogin.TabIndex = 1;
            this.btnConfigLogin.Text = "CONFIGURAR LOGIN";
            this.btnConfigLogin.UseVisualStyleBackColor = true;
            this.btnConfigLogin.Click += new System.EventHandler(this.btnConfigLogin_Click);
            // 
            // PANTALLA
            // 
            this.PANTALLA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.PANTALLA.Location = new System.Drawing.Point(12, 18);
            this.PANTALLA.Margin = new System.Windows.Forms.Padding(2);
            this.PANTALLA.Name = "PANTALLA";
            this.PANTALLA.Size = new System.Drawing.Size(191, 171);
            this.PANTALLA.TabIndex = 1;
            // 
            // btnManRuta
            // 
            this.btnManRuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManRuta.Location = new System.Drawing.Point(18, 326);
            this.btnManRuta.Margin = new System.Windows.Forms.Padding(2);
            this.btnManRuta.Name = "btnManRuta";
            this.btnManRuta.Size = new System.Drawing.Size(186, 42);
            this.btnManRuta.TabIndex = 2;
            this.btnManRuta.Text = "ADMINISTRAR RUTA";
            this.btnManRuta.UseVisualStyleBackColor = true;
            this.btnManRuta.Click += new System.EventHandler(this.btnManRuta_Click);
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
            this.Panelcajero.Size = new System.Drawing.Size(1150, 75);
            this.Panelcajero.TabIndex = 10;
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
            this.txthora.Click += new System.EventHandler(this.txthora_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(107, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(333, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "MENU JEFE DE OPERCIONES";
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.Location = new System.Drawing.Point(1040, 44);
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
            this.lblHora.Location = new System.Drawing.Point(1087, 9);
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
            // OPERACIONES
            // 
            this.OPERACIONES.BackgroundImage = global::PROYECTO_PAQUETERIA_DIARS.Properties.Resources.e334394f_eff7_4963_90a6_fac908fcd589;
            this.OPERACIONES.Location = new System.Drawing.Point(220, 81);
            this.OPERACIONES.Name = "OPERACIONES";
            this.OPERACIONES.Size = new System.Drawing.Size(930, 571);
            this.OPERACIONES.TabIndex = 11;
            // 
            // FrmMenuJefeDeOperaciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1150, 650);
            this.Controls.Add(this.OPERACIONES);
            this.Controls.Add(this.Panelcajero);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMenuJefeDeOperaciones";
            this.Text = "FrmMenuJefeDeOperaciones";
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
        private System.Windows.Forms.Panel PANTALLA;
        private System.Windows.Forms.Button btnManRuta;
        private System.Windows.Forms.Panel Panelcajero;
        private System.Windows.Forms.PictureBox txthora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Panel OPERACIONES;
        private System.Windows.Forms.Timer timer1;
    }
}