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
    public partial class frmRegistrarSocio : Form
    {
        private Form? frmInicial;

        // Constructor que recibe al form que lo llamo.
        public frmRegistrarSocio(Form i)
        {
            InitializeComponent();
            this.frmInicial = i;
        }

        private void frmRegistrarSocio_Load(object sender, EventArgs e)
        {
            // Carga el precio actual de la cuota mensual.
            ctrlMontoTotalSocio.CargarMonto(E_CuotaMensual.MontoFijo);

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            // vuelve a mostrar el form que lo llamo antes de cerrarse.
            if (this.frmInicial != null) { this.frmInicial.Show(); }

            this.Close();

        }


        // Al detectar que se hizo click en el boton registrar.
        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            if (ctrlModoPagoSocio.EstaVacio() ||
                ctrlRegistrarClienteSocio.EstaVacio()) 
            {
                MensajeSistema.MostrarError("Debe completar datos requeridos (*)");
            } 
            else
            {
                // Se guarda la información en un objeto socio.
                E_Socio socio = new E_Socio(ctrlRegistrarClienteSocio.ObtenerNombre(),
                                            ctrlRegistrarClienteSocio.ObtenerApellido(),
                                            ctrlRegistrarClienteSocio.ObtenerEmail(),
                                            ctrlRegistrarClienteSocio.ObtenerTelefono(),
                                            ctrlRegistrarClienteSocio.ObtenerTipoDoc(),
                                            ctrlRegistrarClienteSocio.ObtenerNumDoc(),
                                            true);

                //Llama a la clase que maneja la conexion con la bd.
                string? respuesta = Clientes.RegistrarSocio(
                                    socio,
                                    ctrlModoPagoSocio.ObtenerModoPago(),
                                    ctrlModoPagoSocio.ObtenerPromocion()
                                    );

                ProcesarRespuestaRegistro(respuesta, socio);

            }

        }

        private void ProcesarRespuestaRegistro(string? respuesta, E_Socio socio) 
        {
            bool esNumero = int.TryParse(respuesta, out int idGenerado);

            if (esNumero)
            {
                switch (idGenerado)
                {
                    case -1:
                        ctrlRegistrarClienteSocio.LimpiarCampos();
                        ctrlModoPagoSocio.LimpiarCampos();
                        MensajeSistema.MostrarError("El cliente ya existe.");
                        break;
                    case -2:
                        ctrlRegistrarClienteSocio.LimpiarCampos();
                        ctrlModoPagoSocio.LimpiarCampos();
                        MensajeSistema.MostrarError("Falló el pago de la cuota. Socio no creado.");
                        break;
                    default:
                        ctrlRegistrarClienteSocio.LimpiarCampos();
                        ctrlModoPagoSocio.LimpiarCampos();
                        frmCarnet frmC = new frmCarnet(socio);
                        frmC.ShowDialog();
                        break;
                }

            } else
            {
                MensajeSistema.MostrarError("Error al registrar al socio.");
            }
        }


        // FIN
    }
}
