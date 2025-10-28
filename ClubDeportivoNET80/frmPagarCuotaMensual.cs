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
        private E_Socio socio;
        private List<E_CuotaMensual> pendientes;
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

        private void frmPagarCuotaMensual_Load(object sender, EventArgs e)
        {
            lblNombre.Text = $"{socio.Apellido.ToUpper()} {socio.Nombre.ToUpper()}";

            socio.ObtenerCuotas();

            socio.ObtenerCuotasPendientes(this.pendientes);

            LlenarDataGridView(this.pendientes);

            lblUltimaPagada.Text +=
                $"{socio.ObtenerUltimaPagada()?.FechaPago?.ToString("dd/MM/yy")}";

            ctrlMontoTotalMensual.CargarMonto(ObtenerMontoTotal(this.pendientes));

        }

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

        private decimal ObtenerMontoTotal(List<E_CuotaMensual> pendientes)
        {

            return pendientes.Sum(c => c.Monto);

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (ctrlModoPagoMensual.EstaVacio())
            {
                MensajeSistema.MostrarError("Debe completar datos requeridos (*)");
            }
            else
            {
                Cuotas.PagarCuotasMensuales(pendientes, ctrlModoPagoMensual.ObtenerModoPago(), ctrlModoPagoMensual.ObtenerPromocion());
                Clientes.ActualizarEstadoCliente(socio.Id);

                MensajeSistema.MostrarInformacion("Procesamiento de pago exitoso");

                this.Close();
            }
        }



        // FIN
    }
}
