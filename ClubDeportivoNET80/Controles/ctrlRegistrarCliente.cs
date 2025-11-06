using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDeportivoNET80.Controles
{
    public partial class ctrlRegistrarCliente : UserControl
    {
        // Constructor
        public ctrlRegistrarCliente()
        {
            InitializeComponent();
        }
        private void ctrlRegistrarCliente_Load(object sender, EventArgs e)
        {
            // Placeholders para los inputs.
            txtNombre.PlaceholderText = "Nombre del cliente";
            txtApellido.PlaceholderText = "Apellido del cliente";
            txtEmail.PlaceholderText = "Email del cliente";
            txtTelefono.PlaceholderText = "Telefono del cliente";
            txtNumDoc.PlaceholderText = "Número del documento";

        }

        // Limpia los campos.
        public void LimpiarCampos()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtEmail.Text = "";
            txtTelefono.Text = "";
            cboTipoDoc.SelectedIndex = -1;
            txtNumDoc.Text = "";
            chkAptoFisico.Checked = false;

        }

        // Chequea si falta algun dato, si es así, devuelve true.
        public bool EstaVacio()
        {

            return (string.IsNullOrWhiteSpace(txtNombre.Text) ||
                     string.IsNullOrWhiteSpace(txtApellido.Text) ||
                     string.IsNullOrWhiteSpace(cboTipoDoc.Text) ||
                     string.IsNullOrWhiteSpace(txtNumDoc.Text) ||
                     string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                     string.IsNullOrWhiteSpace(txtEmail.Text) ||
                     !chkAptoFisico.Checked);

        }

        public bool EsValido()
        {
            // Verifica que el DNI tenga una longitud válida
            if (txtNumDoc.Text.Length < 6 || txtNumDoc.Text.Length > 8)
            {
                MensajeSistema.MostrarError("El número de documento no es válido");
                return false;
            }

            // Verifica que el teléfono sea numérico (permitiendo guiones)
            string telefonoSinGuiones = txtTelefono.Text.Replace("-", "");
            if (!long.TryParse(telefonoSinGuiones, out _))
            {
                MensajeSistema.MostrarError("El número de teléfono no es válido");
                return false;
            }

            // Verifica formato de email
            if (!EsEmailValido(txtEmail.Text))
            {
                MensajeSistema.MostrarError("El formato del email no es válido.");
                return false;
            }

            // Si todo está correcto
            return true;
        }

        // Método auxiliar para validar email
        private bool EsEmailValido(string email)
        {
            try
            {
                var mail = new System.Net.Mail.MailAddress(email);
                return mail.Address == email;
            }
            catch
            {
                return false;
            }
        }

        // Devuelven los valores de cada campo.

        public string ObtenerNombre()
        {
            return txtNombre.Text;
        }

        public string ObtenerApellido()
        {
            return txtApellido.Text;
        }

        public string ObtenerEmail()
        {
            return txtEmail.Text;
        }

        public string ObtenerTelefono()
        {
            return txtTelefono.Text;
        }

        public string ObtenerNumDoc()
        {
            return txtNumDoc.Text;
        }

        public int ObtenerTipoDoc()
        {
            return (cboTipoDoc.SelectedIndex.ToString() == "DNI") ? 1 : 2;
        }

        // Le prohibe al usuario escribir algo que no sea un número en ese input.
        private void txtNumDoc_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }


        // FIN
    }
}
