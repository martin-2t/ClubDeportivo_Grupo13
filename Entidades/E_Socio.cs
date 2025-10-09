using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Entidades
{
    internal class E_Socio : E_Cliente
    {
        
        public string ImprimirCarnet()
        {
            StringBuilder carnet = new StringBuilder();

            carnet.AppendLine("***** CARNET DE SOCIO *****");
            carnet.AppendLine($"ID Socio: {id_cliente}");
            carnet.AppendLine($"Nombre: {nombre} {apellido}");
            carnet.AppendLine($"Documento: {(tipo_documento == 1 ? "DNI" : "Pasaporte")} - {numero_documento}");
            carnet.AppendLine($"Email: {email}");
            carnet.AppendLine($"Teléfono: {telefono}");
            carnet.AppendLine($"Fecha de Alta: {fecha_alta:dd/MM/yyyy}");
            carnet.AppendLine($"Apto físico: {(apto_fisico ? "Sí" : "No")}");
            //carnet.AppendLine($"Estado: {estado}");
            carnet.AppendLine("***************************");

            return carnet.ToString();
        }

    }
}
