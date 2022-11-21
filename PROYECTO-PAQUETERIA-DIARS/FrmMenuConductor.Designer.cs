namespace PROYECTO_PAQUETERIA_DIARS
{
    partial class FrmMenuConductor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuConductor));
            this.panel1 = new System.Windows.Forms.Panel();
            this.materialRaisedButton1 = new MaterialSkin.Controls.MaterialRaisedButton();
            this.bgtnSalir = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnEstado = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnCheck = new MaterialSkin.Controls.MaterialRaisedButton();
            this.btnGastos = new MaterialSkin.Controls.MaterialRaisedButton();
            this.Panelima = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblHora = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelConductor = new System.Windows.Forms.Panel();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelCargo = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.panel1.BackColor = System.Drawing.SystemColors.Menu;
            this.panel1.Controls.Add(this.materialRaisedButton1);
            this.panel1.Controls.Add(this.bgtnSalir);
            this.panel1.Controls.Add(this.btnEstado);
            this.panel1.Controls.Add(this.btnCheck);
            this.panel1.Controls.Add(this.btnGastos);
            this.panel1.Controls.Add(this.Panelima);
            this.panel1.Location = new System.Drawing.Point(-1, 80);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(291, 639);
            this.panel1.TabIndex = 2;
            // 
            // materialRaisedButton1
            // 
            this.materialRaisedButton1.Depth = 0;
            this.materialRaisedButton1.Location = new System.Drawing.Point(23, 247);
            this.materialRaisedButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.materialRaisedButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialRaisedButton1.Name = "materialRaisedButton1";
            this.materialRaisedButton1.Primary = true;
            this.materialRaisedButton1.Size = new System.Drawing.Size(248, 65);
            this.materialRaisedButton1.TabIndex = 0;
            this.materialRaisedButton1.Text = "CONFIGURAR LOGIN";
            this.materialRaisedButton1.UseVisualStyleBackColor = true;
            this.materialRaisedButton1.Click += new System.EventHandler(this.materialRaisedButton1_Click_3);
            // 
            // bgtnSalir
            // 
            this.bgtnSalir.Depth = 0;
            this.bgtnSalir.Location = new System.Drawing.Point(148, 601);
            this.bgtnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bgtnSalir.MouseState = MaterialSkin.MouseState.HOVER;
            this.bgtnSalir.Name = "bgtnSalir";
            this.bgtnSalir.Primary = true;
            this.bgtnSalir.Size = new System.Drawing.Size(123, 36);
            this.bgtnSalir.TabIndex = 0;
            this.bgtnSalir.Text = "SALIR";
            this.bgtnSalir.UseVisualStyleBackColor = true;
            this.bgtnSalir.Click += new System.EventHandler(this.bgtnSalir_Click);
            // 
            // btnEstado
            // 
            this.btnEstado.Depth = 0;
            this.btnEstado.Location = new System.Drawing.Point(23, 341);
            this.btnEstado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEstado.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnEstado.Name = "btnEstado";
            this.btnEstado.Primary = true;
            this.btnEstado.Size = new System.Drawing.Size(248, 65);
            this.btnEstado.TabIndex = 0;
            this.btnEstado.Text = "REGISTRAR FICHA DE ESTADO VEHICULAR";
            this.btnEstado.UseVisualStyleBackColor = true;
            this.btnEstado.Click += new System.EventHandler(this.materialRaisedButton1_Click_2);
            // 
            // btnCheck
            // 
            this.btnCheck.Depth = 0;
            this.btnCheck.Location = new System.Drawing.Point(23, 524);
            this.btnCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCheck.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Primary = true;
            this.btnCheck.Size = new System.Drawing.Size(248, 53);
            this.btnCheck.TabIndex = 0;
            this.btnCheck.Text = "REGISTRAR CHECKLIST";
            this.btnCheck.UseVisualStyleBackColor = true;
            this.btnCheck.Click += new System.EventHandler(this.materialRaisedButton1_Click_1);
            // 
            // btnGastos
            // 
            this.btnGastos.Depth = 0;
            this.btnGastos.Location = new System.Drawing.Point(23, 426);
            this.btnGastos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGastos.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnGastos.Name = "btnGastos";
            this.btnGastos.Primary = true;
            this.btnGastos.Size = new System.Drawing.Size(248, 70);
            this.btnGastos.TabIndex = 0;
            this.btnGastos.Text = "REGISTRO DE GASTOS DE VIAJE";
            this.btnGastos.UseVisualStyleBackColor = true;
            this.btnGastos.Click += new System.EventHandler(this.materialRaisedButton1_Click);
            // 
            // Panelima
            // 
            this.Panelima.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Panelima.Location = new System.Drawing.Point(16, 14);
            this.Panelima.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Panelima.Name = "Panelima";
            this.Panelima.Size = new System.Drawing.Size(255, 210);
            this.Panelima.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.Location = new System.Drawing.Point(1152, 31);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(72, 24);
            this.lblFecha.TabIndex = 6;
            this.lblFecha.Text = "FECHA";
            // 
            // lblHora
            // 
            this.lblHora.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHora.AutoSize = true;
            this.lblHora.BackColor = System.Drawing.Color.Transparent;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.White;
            this.lblHora.Location = new System.Drawing.Point(1187, 11);
            this.lblHora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(58, 20);
            this.lblHora.TabIndex = 5;
            this.lblHora.Text = "HORA";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.panel2.Controls.Add(this.labelNombre);
            this.panel2.Controls.Add(this.labelCargo);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.lblFecha);
            this.panel2.Controls.Add(this.lblHora);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1296, 75);
            this.panel2.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PROYECTO_PAQUETERIA_DIARS.Properties.Resources._2413744;
            this.pictureBox1.Location = new System.Drawing.Point(0, 15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(76, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 36);
            this.label1.TabIndex = 7;
            this.label1.Text = "MENU CONDUCTOR";
            // 
            // PanelConductor
            // 
            this.PanelConductor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PanelConductor.AutoSize = true;
            this.PanelConductor.BackColor = System.Drawing.Color.Gray;
            this.PanelConductor.BackgroundImage = global::PROYECTO_PAQUETERIA_DIARS.Properties.Resources.Trasportes_torres_ima1;
            this.PanelConductor.Location = new System.Drawing.Point(296, 80);
            this.PanelConductor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PanelConductor.Name = "PanelConductor";
            this.PanelConductor.Size = new System.Drawing.Size(1036, 735);
            this.PanelConductor.TabIndex = 3;
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.BackColor = System.Drawing.Color.Transparent;
            this.labelNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNombre.ForeColor = System.Drawing.Color.White;
            this.labelNombre.Location = new System.Drawing.Point(963, 9);
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
            this.labelCargo.Location = new System.Drawing.Point(990, 38);
            this.labelCargo.Name = "labelCargo";
            this.labelCargo.Size = new System.Drawing.Size(81, 22);
            this.labelCargo.TabIndex = 11;
            this.labelCargo.Text = "CARGO";
            // 
            // FrmMenuConductor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(1296, 727);
            this.Controls.Add(this.PanelConductor);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmMenuConductor";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENU DE CONDUCTOR";
            this.Load += new System.EventHandler(this.FrmMenuConductor_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel Panelima;
        private System.Windows.Forms.Panel PanelConductor;
        private MaterialSkin.Controls.MaterialRaisedButton btnGastos;
        private MaterialSkin.Controls.MaterialRaisedButton btnCheck;
        private MaterialSkin.Controls.MaterialRaisedButton btnEstado;
        private MaterialSkin.Controls.MaterialRaisedButton materialRaisedButton1;
        private MaterialSkin.Controls.MaterialRaisedButton bgtnSalir;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelCargo;
    }
}