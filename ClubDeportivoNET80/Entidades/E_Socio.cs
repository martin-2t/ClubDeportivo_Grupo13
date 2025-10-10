using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ClubDeportivoNET80.Entidades
{
    internal class E_Socio : E_Cliente
    {
        // Constructor
        public E_Socio(string nombre,
                        string apellido,
                        string email,
                        string telefono,
                        int tipoDocumento,
                        string numeroDocumento,
                        bool aptoFisico
                      )
                        : base(nombre, apellido, email, telefono,
                                tipoDocumento, numeroDocumento, aptoFisico)
        {
            EsSocio = true;
        }

        // Método imprimir carnet.
        public string ImprimirCarnet()
        {
            StringBuilder carnet = new StringBuilder();

            carnet.AppendLine("***** CARNET DE SOCIO *****");
            carnet.AppendLine($"ID Socio: {Id}");
            carnet.AppendLine($"Nombre: {Nombre} {Apellido}");
            carnet.AppendLine($"Documento: {(TipoDocumento == 1 ? "DNI" : "Pasaporte")} - {NumeroDocumento}");
            carnet.AppendLine($"Email: {Email}");
            carnet.AppendLine($"Teléfono: {Telefono}");
            carnet.AppendLine($"Fecha de Alta: {FechaAlta:dd/MM/yyyy}");
            carnet.AppendLine($"Apto físico: {(AptoFisico ? "Sí" : "No")}");
            carnet.AppendLine("***************************");

            return carnet.ToString();
        }



    }
}
