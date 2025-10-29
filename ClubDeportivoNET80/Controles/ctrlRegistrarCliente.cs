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

            return ( string.IsNullOrWhiteSpace(txtNombre.Text)   ||
                     string.IsNullOrWhiteSpace(txtApellido.Text) ||
                     string.IsNullOrWhiteSpace(cboTipoDoc.Text)  ||
                     string.IsNullOrWhiteSpace(txtNumDoc.Text)   ||
                     string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                     string.IsNullOrWhiteSpace(txtEmail.Text)    ||
                     !chkAptoFisico.Checked);

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


        // FIN
    }
}
