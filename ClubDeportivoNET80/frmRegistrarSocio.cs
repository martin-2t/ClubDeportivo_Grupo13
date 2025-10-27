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
        public frmRegistrarSocio()
        {
            InitializeComponent();
        }

        private void frmRegistrarSocio_Load(object sender, EventArgs e)
        {
            txtNombre.PlaceholderText = "Nombre del cliente";
            txtApellido.PlaceholderText = "Apellido del cliente";
            txtEmail.PlaceholderText = "Email del cliente";
            txtTelefono.PlaceholderText = "Telefono del cliente";
            txtNumDoc.PlaceholderText = "Número del documento";
            lblMontoValor.Text = E_CuotaMensual.MontoFijo.ToString();

        }

        private void cboModoPago_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (cboModoPago.SelectedItem != null && cboModoPago.Text == "Tarjeta")
            {
                lblPromocion.Visible = true;
                cboPromocion.Visible = true;

            }
            else
            {
                lblPromocion.Visible = false;
                cboPromocion.Visible = false;
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {

            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            this.Close();

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {

            if (txtNombre.Text == "" ||
                txtApellido.Text == "" ||
                cboTipoDoc.Text == "" ||
                txtNumDoc.Text == "" ||
                txtTelefono.Text == "" ||
                txtEmail.Text == "" ||
                cboModoPago.Text == "" ||
                !chkAptoFisico.Checked
                )
            {
                MessageBox.Show("Debe completar datos requeridos (*) ",
                "AVISO DEL SISTEMA", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else
            {
                E_Socio socio = new E_Socio(txtNombre.Text,
                                             txtApellido.Text,
                                             txtEmail.Text,
                                             txtTelefono.Text,
                                             (cboTipoDoc.Text == "DNI") ? 1 : 2,
                                             txtNumDoc.Text,
                                             true
                                             );

                E_CuotaMensual cuotaMensual = new E_CuotaMensual();
                cuotaMensual.ModoPago = cboModoPago.Text;
                cuotaMensual.Promocion = cboPromocion.Text;

                string? respuesta = Clientes.RegistrarSocio(socio, cuotaMensual);

                procesarRespuestaRegistro(respuesta, socio);

            }

        }

        // Limpia los campos del form.
        private void limpiarCampos()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtEmail.Text = "";
            txtTelefono.Text = "";
            cboTipoDoc.SelectedIndex = -1;
            txtNumDoc.Text = "";
            chkAptoFisico.Checked = false;
            cboModoPago.SelectedIndex = -1;
            cboPromocion.SelectedIndex = -1;

        }

        private void procesarRespuestaRegistro(string? respuesta, E_Socio socio)
        {

            bool esNumero = int.TryParse(respuesta, out int idGenerado);

            if (esNumero)
            {
                if (idGenerado == -1)
                {
                    limpiarCampos();

                    MessageBox.Show("El cliente ya existe.", "Aviso del sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else if (idGenerado == -2)
                {
                    limpiarCampos();

                    MessageBox.Show("Falló el pago de la cuota. Socio no creado.", "Aviso del sistema",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);


                }
                else
                {
                    limpiarCampos();

                    MessageBox.Show(socio.ImprimirCarnet(),
                        "Registro exitoso",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            else
            {
                MessageBox.Show("Error al registrar al socio: " + respuesta,
                "Error del sistema",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



    }
}
