using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDeportivo
{
    public partial class frmPagarCuota : Form
    {
        public frmPagarCuota()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            this.Hide();
        }

        private void btnContinuar_Click(object sender, EventArgs e)
        {
            if (txtNumeroCliente.Text == "" ||
                cboMetodoPago.Text == ""
                )
            {
                MessageBox.Show("Debe completar datos requeridos (*) ",
                "AVISO DEL SISTEMA", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else
            {
                // aca se podria crear un procedimiento para que busque si el cliente es socio o no
                // de acuerdo a su numero de cliente, y ahi bifurque a la cuota diaria o mensual
            }
        }
    }
}
