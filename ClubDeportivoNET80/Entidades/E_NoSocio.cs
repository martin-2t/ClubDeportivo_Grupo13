using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDeportivoNET80.Entidades
{
    public class E_NoSocio : E_Cliente
    {

        // Constructor usado por frmRegistrarNoSocio
        public E_NoSocio(string nombre,
                   string apellido,
                   string email,
                   string telefono,
                   int tipoDocumento,
                   string numeroDocumento,
                   bool aptoFisico
                 )
                    : base(nombre, apellido, email, telefono, tipoDocumento,
                           numeroDocumento, aptoFisico)
        {
            EsSocio = false;
        }

        // Constructor usado por Datos.Clientes.ObtenerCliente()
        public E_NoSocio(int id,
            string nombre,
            string apellido
        ) : base(id, nombre, apellido)
        {
            EsSocio = false;

        }



        // FIN
    }
}
