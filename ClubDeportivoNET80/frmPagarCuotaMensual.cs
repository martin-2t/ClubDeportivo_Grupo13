using ClubDeportivoNET80.Controles;
using ClubDeportivoNET80.Datos;
using ClubDeportivoNET80.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDeportivoNET80
{
    public partial class frmPagarCuotaMensual : Form
    {
        // Representa al socio que realizará un pago.
        private E_Socio socio;

        // Lista de cuotas pendientes del socio.
        private List<E_CuotaMensual> pendientes;
        
        // Constructor que recibe el socio cuyo pago se quiere registrar.
        public frmPagarCuotaMensual(E_Socio socio)
        {
            InitializeComponent();
            this.socio = socio;
            this.pendientes = new List<E_CuotaMensual>();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        /*
         * Carga la información del socio, obtiene sus cuotas pendientes
         * y muestra los datos por pantallla.
         */
        private void frmPagarCuotaMensual_Load(object sender, EventArgs e)
        {
            // Muestra el nombre completo del socio en mayuscula
            lblNombre.Text = $"{socio.Apellido.ToUpper()} {socio.Nombre.ToUpper()}";

            // Obtiene la lista de cuotas del socio.
            socio.ObtenerCuotas();

            // Llena la lista de cuotas pendientes.
            socio.ObtenerCuotasPendientes(this.pendientes);

            //Carga la cuotas pendientes en el datagridview.
            LlenarDataGridView(this.pendientes);
            
            //Muestra la fecha de la última cuota pagada.
            lblUltimaPagada.Text +=
                $"{socio.ObtenerUltimaPagada()?.FechaPago?.ToString("dd/MM/yy")}";

            //Calcula y muestra el monto total de las cuotas a pagar.
            ctrlMontoTotalMensual.CargarMonto(ObtenerMontoTotal(this.pendientes));

        }

        // Llena la lista con las cuotas pendientes del socio.
        private void LlenarDataGridView(List<E_CuotaMensual> pendientes)
        {
            dtgvCuotasMensuales.Rows.Clear();

            DataGridViewColumn colFecha = dtgvCuotasMensuales.Columns["colFechaVencimiento"];
            colFecha.ValueType = typeof(DateTime);
            colFecha.DefaultCellStyle.Format = "dd/MM/yy";


            foreach (E_CuotaMensual cuota in pendientes)
            {
                dtgvCuotasMensuales.Rows.Add(
                    cuota.Id,
                    cuota.Monto.ToString("N2"),
                    cuota.FechaVencimiento
                );

            }

        }

        // Calcula el monto total sumando el monto de todas las cuotas pendientes.
        private decimal ObtenerMontoTotal(List<E_CuotaMensual> pendientes)
        {

            return pendientes.Sum(c => c.Monto);

        }

        /*
         * Valida los campos, 
         * llama a la clase de datos Cuotas para procesar el pago
         * y llama a la clase de datos Clients para actualizar el estado del socio.
         */
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (ctrlModoPagoMensual.EstaVacio())
            {
                MensajeSistema.MostrarError("Debe completar datos requeridos (*)");
            }
            else
            {
                // Procesa el pago de todas las cuotas pendientes
                Cuotas.PagarCuotasMensuales(pendientes, 
                    ctrlModoPagoMensual.ObtenerModoPago(), 
                    ctrlModoPagoMensual.ObtenerPromocion());

                //Actualiza el estado del socio en la base de datos.
                Clientes.ActualizarEstadoCliente(socio.Id);

                MensajeSistema.MostrarInformacion("Procesamiento de pago exitoso");

                this.Close();
            }
        }



        // FIN
    }
}
