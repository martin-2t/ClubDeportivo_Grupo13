using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ClubDeportivoNET80.Entidades
{
    internal class E_Socio : E_Cliente
    {

        private List<E_CuotaMensual>? cuotas;

        // Constructor usado por frm.RegistrarSocio
        public E_Socio(string nombre,
                        string apellido,
                        string email,
                        string telefono,
                        int tipoDocumento,
                        string numeroDocumento,
                        bool aptoFisico
                      )
                        : base(nombre, apellido, email, telefono,
                                tipoDocumento, numeroDocumento, aptoFisico)
        {
            EsSocio = true;
        }


        // Constructor usado por Datos.Clientes.ObtenerCliente()
        public E_Socio(int id,
            string nombre,
            string apellido,
            string estado
        ) : base(id, nombre, apellido)
        {
            EsSocio = true;
            Estado = estado;
        }

        // Constructor usado por Datos.Clientes.ObtenerSociosMorosos()
        public E_Socio(int id,
            string nombre,
            string apellido
        ) : base(id, nombre, apellido)
        {

        }



        //FIN
    }
}
