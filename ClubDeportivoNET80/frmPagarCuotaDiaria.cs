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
    public partial class frmPagarCuotaDiaria : Form
    {
        E_NoSocio noSocio;
        public frmPagarCuotaDiaria(E_NoSocio noSocio)
        {
            InitializeComponent();
            this.noSocio = noSocio;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        // FIN
    }
}
