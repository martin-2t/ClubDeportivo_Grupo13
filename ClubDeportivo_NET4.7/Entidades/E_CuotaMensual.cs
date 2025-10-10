using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Entidades
{
    internal class E_CuotaMensual : E_Cuota
    {
        public static decimal MontoFijo => 20000;

        public override decimal Monto => MontoFijo;



    }
}
