using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Entidades
{
    internal abstract class E_Cuota
    {
        public string ModoPago { get; set; }
        public string Promocion { get; set; }
        public virtual decimal Monto { get; }
    }
}
