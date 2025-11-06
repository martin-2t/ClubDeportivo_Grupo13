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

        public static DialogResult MostrarPregunta(string texto, string titulo = "AVISO DEL SISTEMA")
        {
          return MessageBox.Show(texto, titulo,
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question);

        }

        public static string ObtenerIngreso(string texto, string titulo = "AVISO DEL SISTEMA")
        {
            return Microsoft.VisualBasic.Interaction.InputBox(texto, titulo);
        }



        // FIN
    }
}
