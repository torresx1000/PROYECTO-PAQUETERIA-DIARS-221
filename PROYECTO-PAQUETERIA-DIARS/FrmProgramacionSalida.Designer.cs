namespace PROYECTO_PAQUETERIA_DIARS
{
    partial class FrmProgramacionSalida
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmProgramacionSalida));
            this.dataGridViewProgramacion = new System.Windows.Forms.DataGridView();
            this.PanelBotones = new System.Windows.Forms.Panel();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdProgramacion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.dtFechaFin = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.selrut = new System.Windows.Forms.Button();
            this.selcon = new System.Windows.Forms.Button();
            this.selplaca = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtVehiculo = new System.Windows.Forms.TextBox();
            this.txtConductor = new System.Windows.Forms.TextBox();
            this.txtRuta = new System.Windows.Forms.TextBox();
            this.SalirVentana = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProgramacion)).BeginInit();
            this.PanelBotones.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalirVentana)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewProgramacion
            // 
            this.dataGridViewProgramacion.AllowUserToAddRows = false;
            this.dataGridViewProgramacion.AllowUserToDeleteRows = false;
            this.dataGridViewProgramacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProgramacion.Location = new System.Drawing.Point(43, 337);
            this.dataGridViewProgramacion.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewProgramacion.Name = "dataGridViewProgramacion";
            this.dataGridViewProgramacion.ReadOnly = true;
            this.dataGridViewProgramacion.RowHeadersWidth = 51;
            this.dataGridViewProgramacion.RowTemplate.Height = 24;
            this.dataGridViewProgramacion.Size = new System.Drawing.Size(770, 225);
            this.dataGridViewProgramacion.TabIndex = 2;
            this.dataGridViewProgramacion.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProgramacion_CellClick);
            // 
            // PanelBotones
            // 
            this.PanelBotones.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.PanelBotones.Controls.Add(this.btnEditar);
            this.PanelBotones.Controls.Add(this.btnLimpiar);
            this.PanelBotones.Controls.Add(this.btnNuevo);
            this.PanelBotones.Controls.Add(this.btnEliminar);
            this.PanelBotones.Controls.Add(this.btnBuscar);
            this.PanelBotones.Controls.Add(this.btnRegistrar);
            this.PanelBotones.Location = new System.Drawing.Point(687, 30);
            this.PanelBotones.Name = "PanelBotones";
            this.PanelBotones.Size = new System.Drawing.Size(209, 294);
            this.PanelBotones.TabIndex = 3;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.GreenYellow;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(23, 101);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(164, 39);
            this.btnEditar.TabIndex = 44;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = false;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.GreenYellow;
            this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.Location = new System.Drawing.Point(21, 240);
            this.btnLimpiar.Margin = new System.Windows.Forms.Padding(2);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(164, 39);
            this.btnLimpiar.TabIndex = 47;
            this.btnLimpiar.Text = "LIMPIAR";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnNuevo
            // 
            this.btnNuevo.BackColor = System.Drawing.Color.GreenYellow;
            this.btnNuevo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNuevo.Location = new System.Drawing.Point(23, 8);
            this.btnNuevo.Margin = new System.Windows.Forms.Padding(2);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(164, 39);
            this.btnNuevo.TabIndex = 46;
            this.btnNuevo.Text = "NUEVO";
            this.btnNuevo.UseVisualStyleBackColor = false;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.GreenYellow;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(22, 195);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(164, 39);
            this.btnEliminar.TabIndex = 45;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.GreenYellow;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(21, 146);
            this.btnBuscar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(164, 39);
            this.btnBuscar.TabIndex = 44;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.GreenYellow;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(22, 53);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(164, 39);
            this.btnRegistrar.TabIndex = 41;
            this.btnRegistrar.Text = "REGISTRAR";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.BackColor = System.Drawing.Color.GreenYellow;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(340, 267);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(129, 29);
            this.btnActualizar.TabIndex = 43;
            this.btnActualizar.Text = "ACTUALIZAR";
            this.btnActualizar.UseVisualStyleBackColor = false;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID PROGRAMACIÓN:";
            // 
            // txtIdProgramacion
            // 
            this.txtIdProgramacion.Location = new System.Drawing.Point(191, 22);
            this.txtIdProgramacion.Margin = new System.Windows.Forms.Padding(2);
            this.txtIdProgramacion.Multiline = true;
            this.txtIdProgramacion.Name = "txtIdProgramacion";
            this.txtIdProgramacion.Size = new System.Drawing.Size(257, 27);
            this.txtIdProgramacion.TabIndex = 1;
            this.txtIdProgramacion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdProgramacion_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(39, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "FECHA DE INICIO:";
            // 
            // dtFechaInicio
            // 
            this.dtFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaInicio.Location = new System.Drawing.Point(191, 72);
            this.dtFechaInicio.Margin = new System.Windows.Forms.Padding(2);
            this.dtFechaInicio.Name = "dtFechaInicio";
            this.dtFechaInicio.Size = new System.Drawing.Size(257, 23);
            this.dtFechaInicio.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(89, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "FECHA FIN:";
            // 
            // dtFechaFin
            // 
            this.dtFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFechaFin.Location = new System.Drawing.Point(191, 113);
            this.dtFechaFin.Margin = new System.Windows.Forms.Padding(2);
            this.dtFechaFin.Name = "dtFechaFin";
            this.dtFechaFin.Size = new System.Drawing.Size(257, 23);
            this.dtFechaFin.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(129, 159);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "RUTA:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(72, 200);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "CONDUCTOR:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(8, 242);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(179, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "PLACA DE VEHICULO:";
            // 
            // selrut
            // 
            this.selrut.Location = new System.Drawing.Point(362, 158);
            this.selrut.Name = "selrut";
            this.selrut.Size = new System.Drawing.Size(75, 23);
            this.selrut.TabIndex = 12;
            this.selrut.Text = "Seleccionar";
            this.selrut.UseVisualStyleBackColor = true;
            this.selrut.Click += new System.EventHandler(this.button4_Click);
            // 
            // selcon
            // 
            this.selcon.Location = new System.Drawing.Point(362, 200);
            this.selcon.Name = "selcon";
            this.selcon.Size = new System.Drawing.Size(75, 23);
            this.selcon.TabIndex = 13;
            this.selcon.Text = "Seleccionar";
            this.selcon.UseVisualStyleBackColor = true;
            this.selcon.Click += new System.EventHandler(this.button5_Click);
            // 
            // selplaca
            // 
            this.selplaca.Location = new System.Drawing.Point(362, 239);
            this.selplaca.Name = "selplaca";
            this.selplaca.Size = new System.Drawing.Size(75, 23);
            this.selplaca.TabIndex = 14;
            this.selplaca.Text = "Seleccionar";
            this.selplaca.UseVisualStyleBackColor = true;
            this.selplaca.Click += new System.EventHandler(this.button9_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.panel1.Controls.Add(this.txtVehiculo);
            this.panel1.Controls.Add(this.txtConductor);
            this.panel1.Controls.Add(this.txtRuta);
            this.panel1.Controls.Add(this.selplaca);
            this.panel1.Controls.Add(this.btnActualizar);
            this.panel1.Controls.Add(this.selcon);
            this.panel1.Controls.Add(this.selrut);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.dtFechaFin);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.dtFechaInicio);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtIdProgramacion);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(160, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(503, 303);
            this.panel1.TabIndex = 1;
            // 
            // txtVehiculo
            // 
            this.txtVehiculo.Location = new System.Drawing.Point(191, 242);
            this.txtVehiculo.Name = "txtVehiculo";
            this.txtVehiculo.Size = new System.Drawing.Size(165, 20);
            this.txtVehiculo.TabIndex = 17;
            // 
            // txtConductor
            // 
            this.txtConductor.Location = new System.Drawing.Point(191, 203);
            this.txtConductor.Name = "txtConductor";
            this.txtConductor.Size = new System.Drawing.Size(165, 20);
            this.txtConductor.TabIndex = 16;
            // 
            // txtRuta
            // 
            this.txtRuta.Location = new System.Drawing.Point(191, 161);
            this.txtRuta.Name = "txtRuta";
            this.txtRuta.Size = new System.Drawing.Size(165, 20);
            this.txtRuta.TabIndex = 15;
            // 
            // SalirVentana
            // 
            this.SalirVentana.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.SalirVentana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.SalirVentana.Image = ((System.Drawing.Image)(resources.GetObject("SalirVentana.Image")));
            this.SalirVentana.ImageActive = null;
            this.SalirVentana.Location = new System.Drawing.Point(901, 11);
            this.SalirVentana.Margin = new System.Windows.Forms.Padding(2);
            this.SalirVentana.Name = "SalirVentana";
            this.SalirVentana.Size = new System.Drawing.Size(61, 45);
            this.SalirVentana.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.SalirVentana.TabIndex = 9;
            this.SalirVentana.TabStop = false;
            this.SalirVentana.Zoom = 10;
            this.SalirVentana.Click += new System.EventHandler(this.SalirVentana_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PROYECTO_PAQUETERIA_DIARS.Properties.Resources.iconos_de_calendario_y_reloj_icono_aislado_ilustración_vectorial_194001239_removebg_preview;
            this.pictureBox1.Location = new System.Drawing.Point(-44, 82);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(238, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(-2, 1);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(359, 29);
            this.label7.TabIndex = 15;
            this.label7.Text = "PROGRAMACION DE SALIDA";
            // 
            // FrmProgramacionSalida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SandyBrown;
            this.ClientSize = new System.Drawing.Size(973, 542);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SalirVentana);
            this.Controls.Add(this.PanelBotones);
            this.Controls.Add(this.dataGridViewProgramacion);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmProgramacionSalida";
            this.Text = "FrmProgramacionSalida";
            this.Load += new System.EventHandler(this.FrmProgramacionSalida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProgramacion)).EndInit();
            this.PanelBotones.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalirVentana)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridViewProgramacion;
        private System.Windows.Forms.Panel PanelBotones;
        private System.Windows.Forms.Button btnNuevo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdProgramacion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtFechaInicio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtFechaFin;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button selrut;
        private System.Windows.Forms.Button selcon;
        private System.Windows.Forms.Button selplaca;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtVehiculo;
        private System.Windows.Forms.TextBox txtConductor;
        private System.Windows.Forms.TextBox txtRuta;
        private Bunifu.Framework.UI.BunifuImageButton SalirVentana;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label7;
    }
}