using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivoNET80
{
    internal static class MensajeSistema
    {

        // Muestra dialogo de información
        public static void MostrarInformacion(string texto, 
            string titulo = "AVISO DEL SISTEMA")
        {
            MessageBox.Show( texto, titulo,
                            MessageBoxButtons.OK, 
                            MessageBoxIcon.Information);

        }

        // Muestra dialogo de error.
        public static void MostrarError( string texto, 
            string titulo = "AVISO DEL SISTEMA")
        {
            MessageBox.Show(texto, titulo,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);

        }



        // FIN
    }
}
