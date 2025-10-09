using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Entidades
{
    internal class E_Socio : E_Cliente
    {
        public E_Socio( string nombre,
                        string apellido,
                        string email,
                        string telefono,
                        int tipoDocumento,
                        string numeroDocuento,
                        bool aptoFisico
                      ) 
                        : base ( nombre, apellido, email, telefono, 
                                tipoDocumento, numeroDocuento, aptoFisico)
        {
            EsSocio = true;
        }
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
            //carnet.AppendLine($"Estado: {estado}");
            carnet.AppendLine("***************************");

            return carnet.ToString();
        }

    }
}
