namespace PROYECTO_PAQUETERIA_DIARS
{
    partial class FrmMenuSecretaria
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
            this.Panelcajero = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btnManPedido = new System.Windows.Forms.Button();
            this.btnManProgramSalida = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnConfigLogin = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.txthora = new System.Windows.Forms.PictureBox();
            this.Panelcajero.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txthora)).BeginInit();
            this.SuspendLayout();
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
            this.Panelcajero.Size = new System.Drawing.Size(1199, 85);
            this.Panelcajero.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(79, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 28);
            this.label1.TabIndex = 7;
            this.label1.Text = "MENU SECRETARIO(A)";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Gadugi", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.Location = new System.Drawing.Point(1089, 44);
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
            this.lblHora.Location = new System.Drawing.Point(1136, 9);
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
            // btnManPedido
            // 
            this.btnManPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManPedido.Location = new System.Drawing.Point(17, 263);
            this.btnManPedido.Margin = new System.Windows.Forms.Padding(2);
            this.btnManPedido.Name = "btnManPedido";
            this.btnManPedido.Size = new System.Drawing.Size(186, 42);
            this.btnManPedido.TabIndex = 2;
            this.btnManPedido.Text = "MANTENEDOR PEDIDO";
            this.btnManPedido.UseVisualStyleBackColor = true;
            this.btnManPedido.Click += new System.EventHandler(this.btnManPedido_Click);
            // 
            // btnManProgramSalida
            // 
            this.btnManProgramSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManProgramSalida.Location = new System.Drawing.Point(17, 342);
            this.btnManProgramSalida.Margin = new System.Windows.Forms.Padding(2);
            this.btnManProgramSalida.Name = "btnManProgramSalida";
            this.btnManProgramSalida.Size = new System.Drawing.Size(186, 42);
            this.btnManProgramSalida.TabIndex = 3;
            this.btnManProgramSalida.Text = "MANTENEDOR PROGRAMACION SALIDA";
            this.btnManProgramSalida.UseVisualStyleBackColor = true;
            this.btnManProgramSalida.Click += new System.EventHandler(this.btnManProgramSalida_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Location = new System.Drawing.Point(11, 13);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(192, 178);
            this.panel2.TabIndex = 1;
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
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(112, 648);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(2);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(92, 32);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnConfigLogin);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnManProgramSalida);
            this.panel1.Controls.Add(this.btnManPedido);
            this.panel1.Location = new System.Drawing.Point(2, 77);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(217, 560);
            this.panel1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(91, 495);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 31);
            this.button1.TabIndex = 6;
            this.button1.Text = "SALIR";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContenedor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelContenedor.BackgroundImage = global::PROYECTO_PAQUETERIA_DIARS.Properties.Resources._90282_Trujillo_Plaza_De_Armas;
            this.panelContenedor.Location = new System.Drawing.Point(223, 90);
            this.panelContenedor.Margin = new System.Windows.Forms.Padding(2);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(973, 542);
            this.panelContenedor.TabIndex = 12;
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
            // FrmMenuSecretaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1199, 614);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.Panelcajero);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmMenuSecretaria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMenuSecretaria";
            this.Load += new System.EventHandler(this.FrmMenuSecretaria_Load);
            this.Panelcajero.ResumeLayout(false);
            this.Panelcajero.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txthora)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Panelcajero;
        private System.Windows.Forms.PictureBox txthora;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnManPedido;
        private System.Windows.Forms.Button btnManProgramSalida;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnConfigLogin;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Button button1;
    }
}