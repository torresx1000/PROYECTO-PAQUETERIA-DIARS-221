namespace PROYECTO_PAQUETERIA_DIARS
{
    partial class FrmReporteVehiculo
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.dgvVehiculo = new System.Windows.Forms.DataGridView();
            this.btnSeleccionarConductores = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculo)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 39);
            this.label1.TabIndex = 1;
            this.label1.Text = "VEHICULO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Item(Placa):";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(115, 14);
            this.txtItem.Multiline = true;
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(397, 27);
            this.txtItem.TabIndex = 3;
            this.txtItem.TextChanged += new System.EventHandler(this.txtItem_TextChanged);
            // 
            // dgvVehiculo
            // 
            this.dgvVehiculo.AllowUserToAddRows = false;
            this.dgvVehiculo.AllowUserToDeleteRows = false;
            this.dgvVehiculo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVehiculo.Location = new System.Drawing.Point(12, 178);
            this.dgvVehiculo.Name = "dgvVehiculo";
            this.dgvVehiculo.ReadOnly = true;
            this.dgvVehiculo.RowHeadersWidth = 51;
            this.dgvVehiculo.Size = new System.Drawing.Size(882, 252);
            this.dgvVehiculo.TabIndex = 5;
            this.dgvVehiculo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVehiculo_CellClick);
            // 
            // btnSeleccionarConductores
            // 
            this.btnSeleccionarConductores.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnSeleccionarConductores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSeleccionarConductores.Location = new System.Drawing.Point(747, 132);
            this.btnSeleccionarConductores.Name = "btnSeleccionarConductores";
            this.btnSeleccionarConductores.Size = new System.Drawing.Size(148, 40);
            this.btnSeleccionarConductores.TabIndex = 15;
            this.btnSeleccionarConductores.Text = "Seleccionar";
            this.btnSeleccionarConductores.UseVisualStyleBackColor = false;
            this.btnSeleccionarConductores.Click += new System.EventHandler(this.btnSeleccionarConductores_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Controls.Add(this.txtItem);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(239, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(541, 47);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PROYECTO_PAQUETERIA_DIARS.Properties.Resources._5040050;
            this.pictureBox1.Location = new System.Drawing.Point(12, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(221, 135);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // FrmReporteVehiculo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(907, 442);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSeleccionarConductores);
            this.Controls.Add(this.dgvVehiculo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Location = new System.Drawing.Point(900, 0);
            this.Name = "FrmReporteVehiculo";
            this.Text = "ReporteVehiculo";
            this.Load += new System.EventHandler(this.FrmReporteVehiculo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVehiculo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.DataGridView dgvVehiculo;
        private System.Windows.Forms.Button btnSeleccionarConductores;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}