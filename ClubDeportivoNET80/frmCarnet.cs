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
    public partial class frmCarnet : Form
    {
        private E_Socio socio;

        // Constructor que recibe objeto socio cargado.
        public frmCarnet(E_Socio socio)
        {
            InitializeComponent();
            this.socio = socio;
        }

        private void frmCarnet_Load(object sender, EventArgs e)
        {
            lblNombre.Text = socio.Nombre;
            lblApellido.Text = socio.Apellido;
            lblNumSocio.Text = socio.Id.ToString();
            lblFechaValor.Text = socio.FechaAlta?.ToString("dd/MM/yy") ?? "";

        }
        
        private void pdCarnet_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            using Bitmap bmp = new Bitmap(pnlCarnet.Width, pnlCarnet.Height);
            pnlCarnet.DrawToBitmap(bmp, new Rectangle(0, 0, pnlCarnet.Width, pnlCarnet.Height));
            e.Graphics?.DrawImage(bmp, new PointF(0, 0));
        }

        // Cierra este formulario cuando termina de imprimir.
        private void pdCarnet_EndPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            this.Close();
        }

        // Llama a la ventana de opciones para imprimir e imprime si se da OK.
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (dlgImprimirCarnet.ShowDialog() == DialogResult.OK)
            {
                pdCarnet.Print();
            }
        }



        // FIN

    }
}
