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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblIngreso.Text = "USUARIO: " + Session.Usuario + " " + "(" + Session.Rol + ")";
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Seguro desea salir?", "Salir",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnRegistrarSocio_Click(object sender, EventArgs e)
        {
            frmRegistrarSocio registrarSocio = new frmRegistrarSocio(this);
            registrarSocio.Show();
            this.Hide();

        }

        private void btnRegistrarNoSocio_Click(object sender, EventArgs e)
        {
            frmRegistrarNoSocio registrarNoSocio = new frmRegistrarNoSocio(this);
            registrarNoSocio.Show();
            this.Hide();

        }

        private void btnPagarCuota_Click(object sender, EventArgs e)
        {
            frmPagarCuota pagarCuota = new frmPagarCuota(this);
            pagarCuota.Show();
            this.Hide();

        }

        private void btnGenerarListaMorosos_Click(object sender, EventArgs e)
        {

            List<E_Socio> sociosMorosos = Clientes.ObtenerSociosMorosos();

            if (sociosMorosos.Count > 0)
            {
                frmListaMorosos listaMorosos = new frmListaMorosos(sociosMorosos);
                listaMorosos.ShowDialog();

            }
            else
            {
                MensajeSistema.MostrarInformacion("No hay socios morosos.");
            }

        }
    }
}
