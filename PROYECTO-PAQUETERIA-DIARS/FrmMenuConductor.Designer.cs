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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnRegistrarChecklist = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnConfigLogin = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnRegistrarGastosDeViaje = new System.Windows.Forms.Button();
            this.btnRegistrarFichaDeEstadoVehicular = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(106)))), ((int)(((byte)(240)))), ((int)(((byte)(34)))));
            this.panel1.Controls.Add(this.btnRegistrarChecklist);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Controls.Add(this.btnConfigLogin);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnRegistrarGastosDeViaje);
            this.panel1.Controls.Add(this.btnRegistrarFichaDeEstadoVehicular);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(290, 636);
            this.panel1.TabIndex = 2;
            // 
            // btnRegistrarChecklist
            // 
            this.btnRegistrarChecklist.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarChecklist.Location = new System.Drawing.Point(23, 482);
            this.btnRegistrarChecklist.Name = "btnRegistrarChecklist";
            this.btnRegistrarChecklist.Size = new System.Drawing.Size(248, 52);
            this.btnRegistrarChecklist.TabIndex = 4;
            this.btnRegistrarChecklist.Text = "REGISTRAR CHECKLIST";
            this.btnRegistrarChecklist.UseVisualStyleBackColor = true;
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
            // btnRegistrarGastosDeViaje
            // 
            this.btnRegistrarGastosDeViaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarGastosDeViaje.Location = new System.Drawing.Point(23, 403);
            this.btnRegistrarGastosDeViaje.Name = "btnRegistrarGastosDeViaje";
            this.btnRegistrarGastosDeViaje.Size = new System.Drawing.Size(248, 52);
            this.btnRegistrarGastosDeViaje.TabIndex = 3;
            this.btnRegistrarGastosDeViaje.Text = "REGISTRAR GASTOS DE VIAJE";
            this.btnRegistrarGastosDeViaje.UseVisualStyleBackColor = true;
            // 
            // btnRegistrarFichaDeEstadoVehicular
            // 
            this.btnRegistrarFichaDeEstadoVehicular.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarFichaDeEstadoVehicular.Location = new System.Drawing.Point(23, 324);
            this.btnRegistrarFichaDeEstadoVehicular.Name = "btnRegistrarFichaDeEstadoVehicular";
            this.btnRegistrarFichaDeEstadoVehicular.Size = new System.Drawing.Size(248, 52);
            this.btnRegistrarFichaDeEstadoVehicular.TabIndex = 2;
            this.btnRegistrarFichaDeEstadoVehicular.Text = "REGISTRAR FICHA DE ESTADO VEHICULAR";
            this.btnRegistrarFichaDeEstadoVehicular.UseVisualStyleBackColor = true;
            // 
            // FrmMenuConductor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1089, 640);
            this.Controls.Add(this.panel1);
            this.Name = "FrmMenuConductor";
            this.Text = "FrmMenuConductor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRegistrarChecklist;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnConfigLogin;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnRegistrarGastosDeViaje;
        private System.Windows.Forms.Button btnRegistrarFichaDeEstadoVehicular;
    }
}