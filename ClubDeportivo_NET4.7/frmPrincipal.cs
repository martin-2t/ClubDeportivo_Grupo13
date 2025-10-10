using ClubDeportivo.Datos;
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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        //internal string rol;
        //internal string usuario;

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
            frmRegistrarSocio registrarSocio = new frmRegistrarSocio();
            registrarSocio.Show();
            this.Hide();
        }

        private void btnRegistrarNoSocio_Click(object sender, EventArgs e)
        {
            frmRegistrarNoSocio registrarNoSocio = new frmRegistrarNoSocio();
            registrarNoSocio.Show();
            this.Hide();
        }

        private void btnPagarCuota_Click(object sender, EventArgs e)
        {
            frmPagarCuota pagarCuota = new frmPagarCuota();
            pagarCuota.Show();
            this.Hide();
        }

        private void btnGenerarListaMorosos_Click(object sender, EventArgs e)
        {
            frmListaMorosos listaMorosos = new frmListaMorosos();
            listaMorosos.Show();
            this.Hide();
        }
    }
}
