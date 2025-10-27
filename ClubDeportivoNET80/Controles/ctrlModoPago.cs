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
    public partial class ctrlModoPago : UserControl
    {
        public ctrlModoPago()
        {
            InitializeComponent();
        }

        // Devuelve un string con el nombre del item seleccionado.
        public string ObtenerModoPago()
        {
            return this.cboModoPago.Text;
        }

        // Devuelve un string con el nombre del item seleccionado.
        public string ObtenerPromocion()
        {
            return this.cboPromocion.SelectedItem?.ToString() ?? "";
        }

        // Si detecta que el item seleccionado cambió,
        // si no es nulo y el texto es 'Tarjeta' hace visible los controles del campo promocion,
        // de lo contrario lo oculta.
        private void cboModoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboModoPago.SelectedItem != null
                && cboModoPago.Text == "Tarjeta")
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

        // Limpia los controles.
        public void LimpiarCampos()
        {
            cboModoPago.SelectedIndex = -1;
            cboPromocion.SelectedIndex = -1;
        }

        // Chequea si falta algun dato, si es así, devuelve true.
        public bool EstaVacio()
        {

            return string.IsNullOrWhiteSpace(cboModoPago.Text);

        }


        // FIN
    }
}
