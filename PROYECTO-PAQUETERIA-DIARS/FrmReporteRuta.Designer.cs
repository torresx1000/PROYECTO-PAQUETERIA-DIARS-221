namespace PROYECTO_PAQUETERIA_DIARS
{
    partial class FrmReporteRuta
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvRutas = new System.Windows.Forms.DataGridView();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRutas)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(220, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "RUTAS ";
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(74, 42);
            this.txtItem.Multiline = true;
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(352, 29);
            this.txtItem.TabIndex = 1;
            this.txtItem.TextChanged += new System.EventHandler(this.txtItem_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Item(IdRuta):";
            // 
            // dgvRutas
            // 
            this.dgvRutas.BackgroundColor = System.Drawing.Color.LightGreen;
            this.dgvRutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRutas.Location = new System.Drawing.Point(12, 271);
            this.dgvRutas.Name = "dgvRutas";
            this.dgvRutas.RowHeadersWidth = 51;
            this.dgvRutas.Size = new System.Drawing.Size(553, 201);
            this.dgvRutas.TabIndex = 3;
            this.dgvRutas.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRutas_CellClick);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Aqua;
            this.btnSalir.Location = new System.Drawing.Point(490, 478);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Regresar";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.Aqua;
            this.btnSeleccionar.Location = new System.Drawing.Point(432, 42);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(121, 29);
            this.btnSeleccionar.TabIndex = 5;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightGreen;
            this.groupBox1.Controls.Add(this.txtItem);
            this.groupBox1.Controls.Add(this.btnSeleccionar);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(12, 188);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(553, 77);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PROYECTO_PAQUETERIA_DIARS.Properties.Resources.png_clipart_technology_roadmap_business_road_map_internet_element_angle_text_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(111, -34);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 235);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // FrmReporteRuta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aquamarine;
            this.ClientSize = new System.Drawing.Size(572, 513);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvRutas);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmReporteRuta";
            this.Text = "FrmReporteRuta";
            this.Load += new System.EventHandler(this.FrmReporteRuta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRutas)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvRutas;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}