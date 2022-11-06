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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelContenedor1 = new System.Windows.Forms.Panel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnConfigLogin = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRegistrarDiagnostico = new System.Windows.Forms.Button();
            this.panelContenedor2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(240)))), ((int)(((byte)(34)))));
            this.panel1.Controls.Add(this.panelContenedor1);
            this.panel1.Controls.Add(this.panelContenedor);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnConfigLogin);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnRegistrarDiagnostico);
            this.panel1.Location = new System.Drawing.Point(-1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 636);
            this.panel1.TabIndex = 2;
            // 
            // panelContenedor1
            // 
            this.panelContenedor1.Location = new System.Drawing.Point(293, 3);
            this.panelContenedor1.Name = "panelContenedor1";
            this.panelContenedor1.Size = new System.Drawing.Size(766, 633);
            this.panelContenedor1.TabIndex = 3;
            // 
            // panelContenedor
            // 
            this.panelContenedor.Location = new System.Drawing.Point(293, 3);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(733, 528);
            this.panelContenedor.TabIndex = 3;
            // 
            // btnSalir
            // 
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(149, 586);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(122, 39);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "SALIR";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnConfigLogin
            // 
            this.btnConfigLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfigLogin.Location = new System.Drawing.Point(23, 250);
            this.btnConfigLogin.Name = "btnConfigLogin";
            this.btnConfigLogin.Size = new System.Drawing.Size(248, 52);
            this.btnConfigLogin.TabIndex = 1;
            this.btnConfigLogin.Text = "CONFIGURAR LOGIN";
            this.btnConfigLogin.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(284, 241);
            this.panel2.TabIndex = 1;
            // 
            // btnRegistrarDiagnostico
            // 
            this.btnRegistrarDiagnostico.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarDiagnostico.Location = new System.Drawing.Point(23, 324);
            this.btnRegistrarDiagnostico.Name = "btnRegistrarDiagnostico";
            this.btnRegistrarDiagnostico.Size = new System.Drawing.Size(248, 52);
            this.btnRegistrarDiagnostico.TabIndex = 2;
            this.btnRegistrarDiagnostico.Text = "REGISTRAR DIAGNOSTICO";
            this.btnRegistrarDiagnostico.UseVisualStyleBackColor = true;
            this.btnRegistrarDiagnostico.Click += new System.EventHandler(this.btnRegistrarDiagnostico_Click);
            // 
            // panelContenedor2
            // 
            this.panelContenedor2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelContenedor2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelContenedor2.Location = new System.Drawing.Point(304, 12);
            this.panelContenedor2.Name = "panelContenedor2";
            this.panelContenedor2.Size = new System.Drawing.Size(743, 614);
            this.panelContenedor2.TabIndex = 3;
            // 
            // FrmMenuJefeDeMantenimiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1059, 638);
            this.Controls.Add(this.panelContenedor2);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMenuJefeDeMantenimiento";
            this.Text = "FrmMenuJefeDeMantenimiento";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnConfigLogin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRegistrarDiagnostico;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Panel panelContenedor1;
        private System.Windows.Forms.Panel panelContenedor2;
    }
}