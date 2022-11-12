namespace PROYECTO_PAQUETERIA_DIARS
{
    partial class FrmReporteProgramacionSalida
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
            this.btnSeleccionar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.dgvPS = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPS)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSeleccionar
            // 
            this.btnSeleccionar.BackColor = System.Drawing.Color.Gold;
            this.btnSeleccionar.Location = new System.Drawing.Point(471, 16);
            this.btnSeleccionar.Name = "btnSeleccionar";
            this.btnSeleccionar.Size = new System.Drawing.Size(113, 34);
            this.btnSeleccionar.TabIndex = 11;
            this.btnSeleccionar.Text = "Seleccionar";
            this.btnSeleccionar.UseVisualStyleBackColor = false;
            this.btnSeleccionar.Click += new System.EventHandler(this.btnSeleccionar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Gold;
            this.btnSalir.Location = new System.Drawing.Point(-2, 340);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(106, 29);
            this.btnSalir.TabIndex = 10;
            this.btnSalir.Text = "Regresar";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // dgvPS
            // 
            this.dgvPS.BackgroundColor = System.Drawing.Color.Wheat;
            this.dgvPS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPS.Location = new System.Drawing.Point(190, 130);
            this.dgvPS.Name = "dgvPS";
            this.dgvPS.RowHeadersWidth = 51;
            this.dgvPS.Size = new System.Drawing.Size(653, 228);
            this.dgvPS.TabIndex = 9;
            this.dgvPS.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPS_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Item(IdPS):";
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(106, 21);
            this.txtItem.Multiline = true;
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(359, 29);
            this.txtItem.TabIndex = 7;
            this.txtItem.TextChanged += new System.EventHandler(this.txtItem_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(515, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "PROGRAMACION DE SALIDA";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Wheat;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnSeleccionar);
            this.groupBox1.Controls.Add(this.txtItem);
            this.groupBox1.Location = new System.Drawing.Point(253, 45);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(590, 56);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PROYECTO_PAQUETERIA_DIARS.Properties.Resources.iconos_de_calendario_y_reloj_icono_aislado_ilustración_vectorial_194001239_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(-36, 45);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(266, 251);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // FrmReporteProgramacionSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.ClientSize = new System.Drawing.Size(867, 370);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.dgvPS);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmReporteProgramacionSalida";
            this.Text = "FrmReporteProgramacionSalida";
            ((System.ComponentModel.ISupportInitialize)(this.dgvPS)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSeleccionar;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.DataGridView dgvPS;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}