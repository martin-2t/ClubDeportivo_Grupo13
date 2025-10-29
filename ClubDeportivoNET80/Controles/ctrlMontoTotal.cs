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
    public partial class ctrlMontoTotal : UserControl
    {
        // Constructor.
        public ctrlMontoTotal()
        {
            InitializeComponent();
        }

        // Recibe un decimal, lo redondea a 2 decimales
        // y lo carga a la propiedad texto de la etiqueta Monto.
        public void CargarMonto(decimal monto) 
        {
            lblMonto.Text = decimal.Round(monto,2).ToString("N2");
        }



    // FIN
    }
}
