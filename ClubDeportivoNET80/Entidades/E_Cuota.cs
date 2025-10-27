using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivoNET80.Entidades
{
    public abstract class E_Cuota
    {
        
        // Propiedades
        public int? Id { get; set; }
        public string? ModoPago { get; set; }
        public string? Promocion { get; set; }
        public DateTime? FechaPago { get; set; }
        public virtual decimal Monto { get; set; }



    }
}
