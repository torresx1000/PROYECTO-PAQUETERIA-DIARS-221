namespace PROYECTO_PAQUETERIA_DIARS
{
    partial class FrmReporteTrabajadores
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
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvTrabajadores = new System.Windows.Forms.DataGridView();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrabajadores)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Pink;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(760, 440);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(87, 30);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Regresar";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvTrabajadores
            // 
            this.dgvTrabajadores.BackgroundColor = System.Drawing.Color.BurlyWood;
            this.dgvTrabajadores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTrabajadores.Location = new System.Drawing.Point(10, 192);
            this.dgvTrabajadores.Name = "dgvTrabajadores";
            this.dgvTrabajadores.RowHeadersWidth = 51;
            this.dgvTrabajadores.Size = new System.Drawing.Size(837, 242);
            this.dgvTrabajadores.TabIndex = 7;
            this.dgvTrabajadores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTrabajadores_CellClick);
            // 
            // txtItem
            // 
            this.txtItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItem.Location = new System.Drawing.Point(132, 18);
            this.txtItem.Multiline = true;
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(357, 34);
            this.txtItem.TabIndex = 6;
            this.txtItem.TextChanged += new System.EventHandler(this.txtItem_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-7, -3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(308, 39);
            this.label1.TabIndex = 5;
            this.label1.Text = "TRABAJADORES";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(7, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Item(Nombres):";
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.Pink;
            this.btnSeleccionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionar.Location = new System.Drawing.Point(748, 144);
            this.btnSeleccionar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(97, 38);
            this.btnSeleccionar.TabIndex = 10;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PapayaWhip;
            this.groupBox1.Controls.Add(this.txtItem);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(245, 72);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(520, 67);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PROYECTO_PAQUETERIA_DIARS.Properties.Resources._554795;
            this.pictureBox1.Location = new System.Drawing.Point(12, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 160);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // FrmReporteTrabajadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(856, 485);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSeleccionar);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvTrabajadores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmReporteTrabajadores";
            this.Text = "FrmReporteTrabajadores";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTrabajadores)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvTrabajadores;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}