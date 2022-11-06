namespace PROYECTO_PAQUETERIA_DIARS
{
    partial class FrmListaConductores_Trabajadores
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
            this.label2 = new System.Windows.Forms.Label();
            this.dgvConductores = new System.Windows.Forms.DataGridView();
            this.txtItem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSeleccionarConductores = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnRegresar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConductores)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "Item(Nombres):";
            // 
            // dgvConductores
            // 
            this.dgvConductores.AllowUserToAddRows = false;
            this.dgvConductores.AllowUserToDeleteRows = false;
            this.dgvConductores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConductores.Location = new System.Drawing.Point(12, 120);
            this.dgvConductores.Name = "dgvConductores";
            this.dgvConductores.ReadOnly = true;
            this.dgvConductores.RowHeadersWidth = 51;
            this.dgvConductores.Size = new System.Drawing.Size(837, 358);
            this.dgvConductores.TabIndex = 12;
            this.dgvConductores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConductores_CellClick);
            this.dgvConductores.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConductores_CellEndEdit);
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(181, 88);
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(463, 20);
            this.txtItem.TabIndex = 11;
            this.txtItem.TextChanged += new System.EventHandler(this.txtItem_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 39);
            this.label1.TabIndex = 10;
            this.label1.Text = "CONDUCTORES";
            // 
            // btnSeleccionarConductores
            // 
            this.btnSeleccionarConductores.Location = new System.Drawing.Point(650, 85);
            this.btnSeleccionarConductores.Name = "btnSeleccionarConductores";
            this.btnSeleccionarConductores.Size = new System.Drawing.Size(194, 29);
            this.btnSeleccionarConductores.TabIndex = 14;
            this.btnSeleccionarConductores.Text = "Seleccionar";
            this.btnSeleccionarConductores.UseVisualStyleBackColor = true;
            this.btnSeleccionarConductores.Click += new System.EventHandler(this.btnSeleccionarConductores_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(327, 205);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 16;
            this.txtNombre.Visible = false;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(512, 183);
            this.txtId.Multiline = true;
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 15;
            // 
            // btnRegresar
            // 
            this.btnRegresar.Location = new System.Drawing.Point(769, 484);
            this.btnRegresar.Name = "btnRegresar";
            this.btnRegresar.Size = new System.Drawing.Size(75, 23);
            this.btnRegresar.TabIndex = 17;
            this.btnRegresar.Text = "Regresar";
            this.btnRegresar.UseVisualStyleBackColor = true;
            this.btnRegresar.Click += new System.EventHandler(this.btnRegresar_Click);
            // 
            // FrmListaConductores_Trabajadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 517);
            this.Controls.Add(this.btnRegresar);
            this.Controls.Add(this.btnSeleccionarConductores);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvConductores);
            this.Controls.Add(this.txtItem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtNombre);
            this.Name = "FrmListaConductores_Trabajadores";
            this.Text = "FrmListaConductores_Trabajadores";
            this.DoubleClick += new System.EventHandler(this.FrmListaConductores_Trabajadores_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConductores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvConductores;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSeleccionarConductores;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnRegresar;
    }
}