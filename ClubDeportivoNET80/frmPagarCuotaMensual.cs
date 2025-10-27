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
    public partial class frmPagarCuotaMensual : Form
    {
        private E_Socio socio;
        public frmPagarCuotaMensual(E_Socio socio)
        {
            InitializeComponent();
            this.socio = socio;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }





        // FIN
    }
}
