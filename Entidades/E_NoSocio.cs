using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivo.Entidades
{
    internal class E_NoSocio : E_Cliente
    {
        public E_NoSocio( string nombre,
                   string apellido,
                   string email,
                   string telefono,
                   int tipoDocumento,
                   string numeroDocumento,
                   bool aptoFisico
                 )
                    :base (nombre, apellido, email, telefono, tipoDocumento,
                           numeroDocumento, aptoFisico)
        {
            EsSocio = false;
        }
    
    }
}
