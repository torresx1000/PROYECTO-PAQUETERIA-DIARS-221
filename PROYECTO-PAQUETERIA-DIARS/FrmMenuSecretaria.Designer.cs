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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnConfigLogin = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnManProgramSalida = new System.Windows.Forms.Button();
            this.btnManPedido = new System.Windows.Forms.Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panelContenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnConfigLogin);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnManProgramSalida);
            this.panel1.Controls.Add(this.btnManPedido);
            this.panel1.Location = new System.Drawing.Point(0, 79);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 686);
            this.panel1.TabIndex = 1;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(149, 798);
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
            this.btnConfigLogin.Location = new System.Drawing.Point(23, 250);
            this.btnConfigLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfigLogin.Name = "btnConfigLogin";
            this.btnConfigLogin.Size = new System.Drawing.Size(248, 52);
            this.btnConfigLogin.TabIndex = 1;
            this.btnConfigLogin.Text = "CONFIGURAR LOGIN";
            this.btnConfigLogin.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Location = new System.Drawing.Point(15, 16);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(256, 219);
            this.panel2.TabIndex = 1;
            // 
            // btnManProgramSalida
            // 
            this.btnManProgramSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManProgramSalida.Location = new System.Drawing.Point(23, 421);
            this.btnManProgramSalida.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnManProgramSalida.Name = "btnManProgramSalida";
            this.btnManProgramSalida.Size = new System.Drawing.Size(248, 52);
            this.btnManProgramSalida.TabIndex = 3;
            this.btnManProgramSalida.Text = "MANTENEDOR PROGRAMACION SALIDA";
            this.btnManProgramSalida.UseVisualStyleBackColor = true;
            this.btnManProgramSalida.Click += new System.EventHandler(this.btnManProgramSalida_Click);
            // 
            // btnManPedido
            // 
            this.btnManPedido.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManPedido.Location = new System.Drawing.Point(23, 324);
            this.btnManPedido.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnManPedido.Name = "btnManPedido";
            this.btnManPedido.Size = new System.Drawing.Size(248, 52);
            this.btnManPedido.TabIndex = 2;
            this.btnManPedido.Text = "MANTENEDOR PEDIDO";
            this.btnManPedido.UseVisualStyleBackColor = true;
            this.btnManPedido.Click += new System.EventHandler(this.btnManPedido_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContenedor.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelContenedor.Controls.Add(this.pictureBox1);
            this.panelContenedor.Location = new System.Drawing.Point(296, 81);
            this.panelContenedor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(951, 683);
            this.panelContenedor.TabIndex = 2;
            this.panelContenedor.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedor_Paint);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::PROYECTO_PAQUETERIA_DIARS.Properties.Resources._080eb9d6_5405_4974_b7b1_bcd83c5ab64c;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(945, 677);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // FrmMenuSecretaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 778);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmMenuSecretaria";
            this.Text = "FormMenuSecretaria";
            this.Load += new System.EventHandler(this.FrmMenuSecretaria_Load);
            this.panel1.ResumeLayout(false);
            this.panelContenedor.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnConfigLogin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnManProgramSalida;
        private System.Windows.Forms.Button btnManPedido;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}