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
                string? respuesta = Clientes.RegistrarNoSocio(noSocio);

                ProcesarRespuestaRegistro(respuesta, noSocio);

            }

        }

        private void ProcesarRespuestaRegistro(string? respuesta, E_NoSocio noSocio)
        {
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
                MensajeSistema.MostrarError("Error al registrar al no socio.");
            }
        }



        // FIN
    }
}
