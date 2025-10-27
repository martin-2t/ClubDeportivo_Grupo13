using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivoNET80.Entidades
{
    internal class E_CuotaMensual : E_Cuota
    {

        // Contrusctor usado por Datos.Cuotas
        public E_CuotaMensual(int id,
            decimal monto,
            DateTime fechaVencimiento,
            DateTime? fechaPago,
            string estado
        ) : base()
        {
            this.Id = id;
            this.Monto = monto;
            this.FechaVencimiento = fechaVencimiento;
            this.FechaPago = fechaPago;
            this.Estado = estado;

        }


        // Propiedades
        public DateTime? FechaVencimiento { get; set; }

        public DateTime? FechaEmision { get; set; }

        public string? Estado { get; set; }

        public static decimal MontoFijo => 20000;


    }
}
