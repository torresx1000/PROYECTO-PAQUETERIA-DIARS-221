namespace PROYECTO_PAQUETERIA_DIARS
{
    partial class FrmMenuAlmacenero
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
            this.btnManLote = new System.Windows.Forms.Button();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnConfigLogin);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnManLote);
            this.panel1.Location = new System.Drawing.Point(1, 78);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(308, 679);
            this.panel1.TabIndex = 2;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(183, 638);
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
            this.btnConfigLogin.Location = new System.Drawing.Point(43, 268);
            this.btnConfigLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfigLogin.Name = "btnConfigLogin";
            this.btnConfigLogin.Size = new System.Drawing.Size(248, 52);
            this.btnConfigLogin.TabIndex = 1;
            this.btnConfigLogin.Text = "CONFIGURAR LOGIN";
            this.btnConfigLogin.UseVisualStyleBackColor = true;
            this.btnConfigLogin.Click += new System.EventHandler(this.btnConfigLogin_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Location = new System.Drawing.Point(23, 12);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(268, 233);
            this.panel2.TabIndex = 1;
            // 
            // btnManLote
            // 
            this.btnManLote.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManLote.Location = new System.Drawing.Point(43, 358);
            this.btnManLote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnManLote.Name = "btnManLote";
            this.btnManLote.Size = new System.Drawing.Size(248, 52);
            this.btnManLote.TabIndex = 2;
            this.btnManLote.Text = "MANTENEDOR LOTE";
            this.btnManLote.UseVisualStyleBackColor = true;
            this.btnManLote.Click += new System.EventHandler(this.btnManLote_Click);
            // 
            // panelContenedor
            // 
            this.panelContenedor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContenedor.BackgroundImage = global::PROYECTO_PAQUETERIA_DIARS.Properties.Resources._5942b881_ae8b_426a_b707_772d10f7a15c__1_;
            this.panelContenedor.Location = new System.Drawing.Point(316, 78);
            this.panelContenedor.Margin = new System.Windows.Forms.Padding(4);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(944, 679);
            this.panelContenedor.TabIndex = 3;
            // 
            // FrmMenuAlmacenero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 778);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmMenuAlmacenero";
            this.Text = "FrmMenuAlmacenero";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnConfigLogin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnManLote;
        private System.Windows.Forms.Panel panelContenedor;
    }
}