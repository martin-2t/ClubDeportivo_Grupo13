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
    public partial class frmListaMorosos : Form
    {
        List<E_Socio> sociosMorosos;
        public frmListaMorosos(List<E_Socio> sociosMorosos)
        {
            InitializeComponent();
            this.sociosMorosos = sociosMorosos;
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void LlenarDataGridView(List<E_Socio> sociosMorosos)
        {
            dtgvMorosos.Rows.Clear();

            foreach (E_Socio socio in sociosMorosos)
            {
                dtgvMorosos.Rows.Add(
                    socio.Id,
                    socio.Apellido,
                    socio.Nombre
                );

            }

        }

        private void frmListaMorosos_Load(object sender, EventArgs e)
        {
            LlenarDataGridView(this.sociosMorosos);
        }


        // FIN
    }
}
