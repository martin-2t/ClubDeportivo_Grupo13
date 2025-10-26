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

        // Chequea si falta algun dato, si es así, manda mensaje.
        public void EstaVacio()
        {
            if ( string.IsNullOrWhiteSpace(txtNombre.Text)   ||
                 string.IsNullOrWhiteSpace(txtApellido.Text) ||
                 string.IsNullOrWhiteSpace(cboTipoDoc.Text)  ||
                 string.IsNullOrWhiteSpace(txtNumDoc.Text)   ||
                 string.IsNullOrWhiteSpace(txtTelefono.Text) ||
                 string.IsNullOrWhiteSpace(txtEmail.Text)    ||
                 !chkAptoFisico.Checked
                )
            {
                MessageBox.Show(
                                "Debe completar datos requeridos (*) ",
                                "AVISO DEL SISTEMA", 
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                );
            }
        }






        // FIN
    }
}
