﻿namespace PROYECTO_PAQUETERIA_DIARS
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConductores)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "Item(Nombres):";
            // 
            // dgvConductores
            // 
            this.dgvConductores.AllowUserToAddRows = false;
            this.dgvConductores.AllowUserToDeleteRows = false;
            this.dgvConductores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvConductores.Location = new System.Drawing.Point(9, 189);
            this.dgvConductores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvConductores.Name = "dgvConductores";
            this.dgvConductores.ReadOnly = true;
            this.dgvConductores.RowHeadersWidth = 51;
            this.dgvConductores.Size = new System.Drawing.Size(1116, 400);
            this.dgvConductores.TabIndex = 12;
            this.dgvConductores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConductores_CellClick);
            this.dgvConductores.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvConductores_CellEndEdit);
            // 
            // txtItem
            // 
            this.txtItem.Location = new System.Drawing.Point(164, 23);
            this.txtItem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtItem.Multiline = true;
            this.txtItem.Name = "txtItem";
            this.txtItem.Size = new System.Drawing.Size(483, 35);
            this.txtItem.TabIndex = 11;
            this.txtItem.TextChanged += new System.EventHandler(this.txtItem_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(0, -1);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(378, 52);
            this.label1.TabIndex = 10;
            this.label1.Text = "CONDUCTORES";
            // 
            // btnSeleccionarConductores
            // 
            this.btnSeleccionarConductores.BackColor = System.Drawing.Color.Aqua;
            this.btnSeleccionarConductores.Location = new System.Drawing.Point(713, 145);
            this.btnSeleccionarConductores.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSeleccionarConductores.Name = "btnSeleccionarConductores";
            this.btnSeleccionarConductores.Size = new System.Drawing.Size(259, 36);
            this.btnSeleccionarConductores.TabIndex = 14;
            this.btnSeleccionarConductores.Text = "Seleccionar";
            this.btnSeleccionarConductores.UseVisualStyleBackColor = false;
            this.btnSeleccionarConductores.Click += new System.EventHandler(this.btnSeleccionarConductores_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MediumAquamarine;
            this.groupBox1.Controls.Add(this.txtItem);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(303, 71);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(669, 66);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PROYECTO_PAQUETERIA_DIARS.Properties.Resources._2481723;
            this.pictureBox1.Location = new System.Drawing.Point(33, 50);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(241, 124);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // FrmListaConductores_Trabajadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ClientSize = new System.Drawing.Size(1141, 597);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSeleccionarConductores);
            this.Controls.Add(this.dgvConductores);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Location = new System.Drawing.Point(900, 900);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmListaConductores_Trabajadores";
            this.Text = "FrmListaConductores_Trabajadores";
            this.Load += new System.EventHandler(this.FrmListaConductores_Trabajadores_Load);
            this.DoubleClick += new System.EventHandler(this.FrmListaConductores_Trabajadores_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConductores)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvConductores;
        private System.Windows.Forms.TextBox txtItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSeleccionarConductores;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}