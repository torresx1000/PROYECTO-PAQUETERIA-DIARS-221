using CAPAENTIDAD;
using CAPALOGICA;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PROYECTO_PAQUETERIA_DIARS
{
    public partial class FrmGastosDeViaje : Form
    {
        public FrmGastosDeViaje()
        {
            InitializeComponent();
            ListarGastosViaje();
            Inabilitar();
        }
        private void Limpiar()
        {
            txtcombustible.Clear();
            txtidgastosdeviaje.Clear();
            txtidprogramaciondesalida.Clear();
            txtotros.Clear();
            txtprecioscombustible.Clear();
            txtpreciosotros.Clear();
            txtpreciostotal.Clear();
            txtpreciosviaticos.Clear();
            txtviaticos.Clear();
            

        }
        private void Inabilitar()
        {
            //BOTONES
            btnBuscar.Enabled = true;
            btnlimpiar.Enabled = true;
            btnregistrar.Enabled = false;
            btnquitar.Enabled = true;
            btncalcular.Enabled = false;
            btnseleccionar.Enabled = false;
            btnNUEVO.Enabled=true;
            //TXT
            txtcombustible.Enabled = false;
           
            txtidgastosdeviaje.Enabled=true;
            txtidprogramaciondesalida.Enabled = false;
            txtotros.Enabled = false;
            txtprecioscombustible.Enabled = false;
            txtpreciosotros.Enabled = false;
            txtpreciostotal.Enabled = false;
            txtpreciosviaticos.Enabled = false;
            txtviaticos.Enabled = false;
            dtpfecha.Enabled=true;
            txtpreciostotal.Enabled = false;
        }
        private void txtpreciosviaticos_TextChanged(object sender, EventArgs e)
        {
           
        }
        public void ListarGastosViaje() {
            dgvdatosgastosdeviaje.DataSource = LogGastosDeViaje.Instancia.ListarGastosDeViajes();
        }
        private void btnseleccionar_Click(object sender, EventArgs e)
        {
            FrmReporteProgramacionSalida FrmReporteProgramacionSalida = new FrmReporteProgramacionSalida();
            FrmReporteProgramacionSalida.ShowDialog();
            txtidprogramaciondesalida.Text = FrmReporteProgramacionSalida.IdPS;
        }

        private void btnregistrar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmReporteProgramacionSalida FrmReporteProgramacionSalida = new FrmReporteProgramacionSalida();
                EntGastosDeViaje gas = new EntGastosDeViaje();
                if (txtidgastosdeviaje.Text != "")
                {
                    MessageBox.Show("El id lo gestiona el sistema");

                    txtidgastosdeviaje.Clear();

                }
                gas.IdProgramaciondesalida = Convert.ToInt32(FrmReporteProgramacionSalida.IdPS.Trim());
                gas.Fecha = dtpfecha.Value;
                gas.preciosviaticos = Convert.ToDouble(txtpreciosviaticos.Text.Trim());
                gas.precioscombustible = Convert.ToDouble(txtprecioscombustible.Text.Trim());
                gas.preciosotros = Convert.ToDouble(txtpreciosotros.Text.Trim());
                gas.Total = Convert.ToDouble(txtpreciostotal.Text.Trim());
                if (txtviaticos.Text == "" || txtcombustible.Text == "" || txtotros.Text == "")
                {
                    txtviaticos.Text = "Sin especificación";
                    txtcombustible.Text = "Sin especificación";
                    txtotros.Text = "Sin especificación";
                }
                gas.Viaticos = txtviaticos.Text.Trim();
                gas.Combustible = txtcombustible.Text.Trim();
                gas.Otros = txtotros.Text.Trim();
                LogGastosDeViaje.Instancia.InsertaGastosDeViaje(gas);
                factura();
                Inabilitar();
                Limpiar();
                ListarGastosViaje();
            }
            catch (Exception)
            {
                MessageBox.Show("Llene todos los campos", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }
        public void Habilitar()
        {
            //BOTONES
            btnBuscar.Enabled = false;
            btnlimpiar.Enabled = true;
            btnregistrar.Enabled = true;    
            btnquitar.Enabled = false;
            btncalcular.Enabled = true;
            btnseleccionar.Enabled = true;
            btnNUEVO.Enabled = false;
            //TXT
            txtidgastosdeviaje.Enabled = false;
            txtidprogramaciondesalida.Enabled = false;
            txtcombustible.Enabled = true;
            txtotros.Enabled = true;
            txtprecioscombustible.Enabled = true;
            txtpreciosotros.Enabled = true;
            txtpreciostotal.Enabled = true;
            txtpreciosviaticos.Enabled = true;
            txtviaticos.Enabled = true;
            txtpreciostotal.Enabled=false;

        }
        private void txtpreciosotros_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtpreciostotal_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnbuscar_Click(object sender, EventArgs e)
        {
            try
            {
                txtidgastosdeviaje.Focus();
                EntGastosDeViaje D = new EntGastosDeViaje();

                D.IdGastosdeViaje = Convert.ToInt32(txtidgastosdeviaje.Text.Trim());

                DataTable dt = new DataTable();

                dt = LogGastosDeViaje.Instancia.BuscarGastosDeVaije(D.IdGastosdeViaje);
                if (txtidgastosdeviaje.Text != "")
                {
                    dgvdatosgastosdeviaje.DataSource = dt;
                }
                else
                {

                    dgvdatosgastosdeviaje.DataSource = LogDiagnostico.Instancia.ListarDiagnostico();
                }
                Inabilitar();
                
            }
            catch (Exception)    
            {
                MessageBox.Show("Ingrese un dato correcto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                ListarGastosViaje();
               
            }
        }

        private void btnquitar_Click(object sender, EventArgs e)
        {
            
                try
                {

                    EntGastosDeViaje gas = new EntGastosDeViaje();
                    //Veh.IdVehiculo=Convert.ToInt32(txtIdVehiculo.Text.Trim());
                    gas.IdGastosdeViaje = Convert.ToInt32(txtidgastosdeviaje.Text.Trim());


                    LogGastosDeViaje.Instancia.Elimminar(gas);

                }
                catch (Exception)
                {
                MessageBox.Show("Ingresa ID valido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtidgastosdeviaje.Clear();
                 }
                Inabilitar();
                Limpiar();
                ListarGastosViaje();
          
            }

        private void btnlimpiar_Click(object sender, EventArgs e)
        {
            Inabilitar();
            Limpiar();
        }

        private void txtprecioscombustible_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double suma, a = 0, b = 0, c = 0;
            if (txtpreciosviaticos.Text == "" || txtprecioscombustible.Text == "" || txtpreciosotros.Text == "")
            {
               
                suma = (a + b + c);
                txtpreciostotal.Text = suma.ToString();
            }
            else
            {
                a = Convert.ToDouble(txtpreciosviaticos.Text.Trim());
                b = Convert.ToDouble(txtprecioscombustible.Text.Trim());
                c = Convert.ToDouble(txtpreciosotros.Text.Trim());
                suma = (a + b + c);
                txtpreciostotal.Text = suma.ToString();
            }
        }

        private void btnNUEVO_Click(object sender, EventArgs e)
        {
            Limpiar();
            Habilitar();    
        }

        private void dgvdatosgastosdeviaje_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try { 
            string id = dgvdatosgastosdeviaje.Rows[e.RowIndex].Cells["IdGastosdeViaje"].Value.ToString();
            txtidgastosdeviaje.Text = id;
            }
            catch (Exception)
            {
                MessageBox.Show("No permitido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
}

        private void factura()
        {
            clsFactura.CreaTicket Ticket1 = new clsFactura.CreaTicket();

            Ticket1.TextoCentro("EMPRESA DE TRASPORTES TORRES "); //imprime una linea de descripcion
            Ticket1.TextoCentro("**********************************");

            Ticket1.TextoIzquierda("");
           
            Ticket1.TextoCentro("INFORMDE DE GASTOS"); //imprime una linea de descripcion
            Ticket1.TextoCentro("**********************************");

            Ticket1.TextoIzquierda("Fecha: "+dtpfecha.Text);
            Ticket1.TextoIzquierda("");

            Ticket1.TextoIzquierda("Codigo Programacion Salida : "+txtidprogramaciondesalida.Text);
            Ticket1.TextoIzquierda("");

            clsFactura.CreaTicket.LineasGuion();
            Ticket1.TextoIzquierda("|VIATICOS       | "+txtviaticos.Text);
            clsFactura.CreaTicket.LineasGuion();
            Ticket1.TextoIzquierda("|PRECIO | S/ " + txtpreciosviaticos.Text);
            Ticket1.TextoIzquierda("");

            clsFactura.CreaTicket.LineasGuion();
            Ticket1.TextoIzquierda("|COMBUSTIBLE    | " +txtcombustible.Text);
            Ticket1.TextoIzquierda("|PRECIO | S/ " + txtprecioscombustible.Text);
            Ticket1.TextoIzquierda("");

            clsFactura.CreaTicket.LineasGuion();
            Ticket1.TextoIzquierda("|OTROS          | " +txtotros.Text);
            Ticket1.TextoIzquierda("|PRECIO | S/ " + txtpreciosotros.Text);
            Ticket1.TextoIzquierda("");
            clsFactura.CreaTicket.LineasGuion();
            
           

            Ticket1.TextoIzquierda(" ");
            Ticket1.AgregaTotales("Total", double.Parse(txtpreciostotal.Text)); // imprime linea con total
            Ticket1.TextoIzquierda(" ");
           


            // Ticket1.LineasTotales(); // imprime linea 

            Ticket1.TextoIzquierda(" ");
      
            Ticket1.TextoIzquierda(" ");
            string impresora = "Microsoft XPS Document Writer";
            Ticket1.ImprimirTiket(impresora);

            MessageBox.Show("REGISTRADO");

            
        }

        private void SalirVentana_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtidgastosdeviaje_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 45 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Numeros Y un (.)permitidos ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtpreciosviaticos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 45 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Numeros Y un (.)permitidos ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void txtprecioscombustible_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 43) || (e.KeyChar >= 45 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Numeros Y un (.)permitidos ", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }

        }

        private void txtpreciosotros_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void txtpreciostotal_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
