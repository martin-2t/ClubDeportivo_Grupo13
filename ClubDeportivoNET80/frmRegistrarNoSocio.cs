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
    public partial class frmRegistrarNoSocio : Form
    {
        private Form? frmInicial;
        public frmRegistrarNoSocio(Form i)
        {
            InitializeComponent();
            this.frmInicial = i;
        }

        private void frmRegistrarNoSocio_Load(object sender, EventArgs e)
        {

        }

        // Vuelve a mostrar el formulario que lo llamo y se cierra este.
        private void btnCancelar_Click(object sender, EventArgs e)
        {

            if (this.frmInicial != null) { this.frmInicial.Show(); }
            this.Close();

        }


        /*
         * Evento que se ejecuta al hacer click en el botón Registrar.
         * Verifica los datos ingresados al formulario, y si no estan vacios
         * crea un nuevo objeto E_NoSocio y llama a la clase de datos.
         */
        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (ctrlRegistrarClienteNoSocio.EstaVacio())
            {
                MensajeSistema.MostrarError("Debe completar datos requeridos (*)");

            } 
            else
            {
                // Se guarda la información en un objeto NoSocio.
                E_NoSocio noSocio = new E_NoSocio(ctrlRegistrarClienteNoSocio.ObtenerNombre(),
                                            ctrlRegistrarClienteNoSocio.ObtenerApellido(),
                                            ctrlRegistrarClienteNoSocio.ObtenerEmail(),
                                            ctrlRegistrarClienteNoSocio.ObtenerTelefono(),
                                            ctrlRegistrarClienteNoSocio.ObtenerTipoDoc(),
                                            ctrlRegistrarClienteNoSocio.ObtenerNumDoc(),
                                            true);

                // Se intenta registrar el no socio en la base de datos y se obtiene una respuesta.
                string? respuesta = Clientes.RegistrarNoSocio(noSocio);

                //Se procesa la respuesta del intento de registro.
                ProcesarRespuestaRegistro(respuesta, noSocio);

            }

        }

        /*
         * Procesa la respuesta obtenida después del intento de registrar a un no socio.
         *  Si el registro fue exitoso, devuelve el ID del no socio registrado.
         *  Si ya existía el cliente, devuelve un mensaje avisando que el cliente ya existe.
         *  Si hubo un error, se muestra un mensaje informando que un error a ocurrido.
         */
        private void ProcesarRespuestaRegistro(string? respuesta, E_NoSocio noSocio)
        {
            // Chequea si la respuesta en un número valido.
            bool esNumero = int.TryParse(respuesta, out int idGenerado);

            if (esNumero)
            {
                switch (idGenerado)
                {
                    case -1:
                        ctrlRegistrarClienteNoSocio.LimpiarCampos();
                        MensajeSistema.MostrarError("El cliente ya existe.");
                        break;
                    default:
                        ctrlRegistrarClienteNoSocio.LimpiarCampos();
                        MensajeSistema.MostrarInformacion(
                            $"{noSocio.Nombre} {noSocio.Apellido} registrado exitosamente con el ID {respuesta}"
                            );
                        break;
                }

            }
            else
            {
                // Si la respuesta no es númerica, se interpreta como un error.
                MensajeSistema.MostrarError("Error al registrar al no socio.");
            }
        }



        // FIN
    }
}
