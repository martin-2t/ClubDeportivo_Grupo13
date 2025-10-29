using ClubDeportivoNET80.Datos;
using ClubDeportivoNET80.Entidades;
using MySqlX.XDevAPI;

namespace ClubDeportivoNET80
{
    public partial class frmPagarCuota : Form
    {
        Form frmInicial;

        public frmPagarCuota(Form i)
        {
            InitializeComponent();
            this.frmInicial = i;
        }

        private void frmPagarCuota_Load(object sender, EventArgs e)
        {
            txtNumeroCliente.PlaceholderText = "Ingresar el ID del cliente";

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (this.frmInicial != null) { this.frmInicial.Show(); }
            this.Close();
        }

        // Valida que no se haya ingresado un input valido.
        // Si el cliente no existe, avisa.
        // Si el cliente existe, llama a ProcesarCliente()
        // Cuando vuelve de este, muestra el form que lo llamo
        // y cierra el formulario actual.
        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            if (txtNumeroCliente.Text == "")
            {
                MensajeSistema.MostrarError("Debe completar datos requeridos (*)");
            }
            else if (!uint.TryParse(txtNumeroCliente.Text, out uint id))
            {
                MensajeSistema.MostrarError(
                    $"El campo < {lblNumeroCliente.Text} > debe ser un número valido positivo.");

            } else 
            {

                E_Cliente? cliente = Clientes.ObtenerCliente((int)id);

                if ( cliente == null)
                {
                    MensajeSistema.MostrarError("El cliente con ese ID no existe");

                } 
                else
                {
                    ProcesarCliente(cliente);

                    // Cuando vuelve a este formulario, lo cierra.
                    if (this.frmInicial != null) { this.frmInicial.Show(); }
                    this.Close();
                }
            }
        }

        // Si el cliente es socio llama a ProcesarSocio()
        // Sino, llama a frmPagarCuotaDiaria.
        private void ProcesarCliente(E_Cliente cliente)
        {
            if (cliente.EsSocio) 
            {
                ProcesarSocio((E_Socio)cliente);
            } 
            else 
            {
                frmPagarCuotaDiaria cuota = new frmPagarCuotaDiaria((E_NoSocio)cliente);
                cuota.ShowDialog();

            }

        }

        // Controla si el socio tiene cuotas pendientes, si no las tiene, avisa.
        // Si tiene cuotas pendientes, abre frmPagarCuotaMensual.
        // Manda error si no es ninguno de estos dos casos, con un codigo de error personalizado.
        private void ProcesarSocio(E_Socio socio)
        {
            int rtaCuotasPendientes = Cuotas.TieneCuotasPendientes(socio.Id);

            switch (rtaCuotasPendientes)
            {
                case 0:
                    MensajeSistema.MostrarInformacion("No tiene cuotas por pagar.");
                    break;
                case 1:
                    frmPagarCuotaMensual cuota = new frmPagarCuotaMensual(socio);
                    cuota.ShowDialog();
                    break;
                default:
                    MensajeSistema.MostrarError($"Codigo de error < {rtaCuotasPendientes} >");
                    break;  
            }

        }


        // FIN
    }
}
