using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Entidades
{
    internal class E_Cliente
    {
        public int id_cliente { get; set; }
        public DateTime fecha_alta { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public int tipo_documento { get; set; }
        public string numero_documento { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }
        public bool es_socio { get; set; }
        public bool apto_fisico { get; set; }
        public string estado { get; set; }
    }
}
