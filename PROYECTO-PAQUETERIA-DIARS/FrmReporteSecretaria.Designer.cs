namespace PROYECTO_PAQUETERIA_DIARS
{
    partial class FrmReporteSecretaria
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSeleccionarConductores = new System.Windows.Forms.Button();
            this.dgvConductores = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtId = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConductores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.PaleVioletRed;
            this.groupBox1.Controls.Add(this.txtItem);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(253, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 54);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(123, 19);
            this.txtItem.Multiline = true;
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(363, 29);
            this.txtItem.TabIndex = 11;
            this.txtItem.TextChanged += new System.EventHandler(this.txtItem_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Item(Nombres):";
            // 
            // btnSeleccionarConductores
            // 
            this.btnSeleccionarConductores.BackColor = System.Drawing.Color.Cyan;
            this.btnSeleccionarConductores.Location = new System.Drawing.Point(560, 150);
            this.btnSeleccionarConductores.Name = "btnSeleccionarConductores";
            this.btnSeleccionarConductores.Size = new System.Drawing.Size(194, 29);
            this.btnSeleccionarConductores.TabIndex = 21;
            this.btnSeleccionarConductores.Text = "Seleccionar";
            this.btnSeleccionarConductores.UseVisualStyleBackColor = false;
            this.btnSeleccionarConductores.Click += new System.EventHandler(this.btnSeleccionarConductores_Click);
            // 
            // dgvConductores
            // 
            this.dgvConductores.AllowUserToAddRows = false;
            this.dgvConductores.AllowUserToDeleteRows = false;
            this.dgvConductores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConductores.Location = new System.Drawing.Point(32, 184);
            this.dgvConductores.Name = "dgvConductores";
            this.dgvConductores.ReadOnly = true;
            this.dgvConductores.RowHeadersWidth = 51;
            this.dgvConductores.Size = new System.Drawing.Size(837, 325);
            this.dgvConductores.TabIndex = 20;
            this.dgvConductores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConductores_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(284, 39);
            this.label1.TabIndex = 19;
            this.label1.Text = "SECRETARI@S";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(538, 214);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 23;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(352, 236);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 24;
            this.txtNombre.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PROYECTO_PAQUETERIA_DIARS.Properties.Resources._360473;
            this.pictureBox1.Location = new System.Drawing.Point(50, 72);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(181, 101);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            // 
            // FrmReporteSecretaria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(892, 530);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSeleccionarConductores);
            this.Controls.Add(this.dgvConductores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmReporteSecretaria";
            this.Text = "FrmReporteSecretaria";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConductores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSeleccionarConductores;
        private System.Windows.Forms.DataGridView dgvConductores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}