using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Entidades
{
    internal class E_Cliente
    {
        // Dejadas por las dudas que en un futuro se necesiten.

        //private int id;
        //private string nombre;
        //private string apellido;
        //private string email;
        //private string telefono;
        //private string estado;
        //private int tipoDocumento;
        //private string numeroDocumento;
        //private DateTime fechaAlta;
        //private bool esSocio;
        //private bool aptoFisico;

        // Constructor
        public E_Cliente(   string nombre, 
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
        public DateTime FechaAlta { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int TipoDocumento { get; set; }
        public string NumeroDocumento { get; set; }
        public string Email { get; set; }
        public string Telefono { get; set; }
        public bool EsSocio { get; set; }
        public bool AptoFisico { get; set; }
        public string Estado { get; set; }
    }
}
