using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Entidades
{
    internal class E_CuotaMensual
    {
        private string modoPago;
        private string promocion;

        public static readonly decimal monto = 15000;

        public decimal Monto { get { return monto; } }

        public string ModoPago { get; set; }
        public string Promocion { get; set; }


    }
}
