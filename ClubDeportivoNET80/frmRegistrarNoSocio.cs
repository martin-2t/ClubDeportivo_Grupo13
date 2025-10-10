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
        public frmRegistrarNoSocio()
        {
            InitializeComponent();
        }

        private void frmRegistrarNoSocio_Load(object sender, EventArgs e)
        {

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
                txtTelefono.Text == "" ||
                txtEmail.Text == "" ||
                !chkAptoFisico.Checked
                )
            {
                MessageBox.Show("Debe completar datos requeridos (*) ",
                "AVISO DEL SISTEMA", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else
            {

            }

        }
    }
}
