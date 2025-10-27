using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivoNET80.Entidades
{
    internal class E_Cliente
    {

        // Constructor minimo

        public E_Cliente(int id,
                            string nombre,
                            string apellido
        )
        {
            Id = id;
            Nombre = nombre;
            Apellido = apellido;
        }


        // Constructor detallado y completo.
        public E_Cliente(string nombre,
                            string apellido,
                            string email,
                            string telefono,
                            int tipoDocumento,
                            string numeroDocumento,
                            bool aptoFisico
        )
        {
            Nombre = nombre;
            Apellido = apellido;
            Email = email;
            Telefono = telefono;
            TipoDocumento = tipoDocumento;
            NumeroDocumento = numeroDocumento;
            AptoFisico = aptoFisico;
        }

        // Propiedades
        public int Id { get; set; }
        public DateTime? FechaAlta { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int? TipoDocumento { get; set; }
        public string? NumeroDocumento { get; set; }
        public string? Email { get; set; }
        public string? Telefono { get; set; }
        public bool EsSocio { get; set; }
        public bool? AptoFisico { get; set; }
        public string? Estado { get; set; }


    }
}
