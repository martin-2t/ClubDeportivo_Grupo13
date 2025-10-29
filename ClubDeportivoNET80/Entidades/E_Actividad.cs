using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivoNET80.Entidades
{
    internal class E_Actividad
    {

        // Constructor
        public E_Actividad(int id, decimal monto, string nombre)
        {
            Id = id;
            Monto = monto;
            Nombre = nombre;

        }


        // Propiedades
        public int Id { get; set; }
        public decimal Monto { get; set; }
        public string Nombre { get; set; }


    }
}
