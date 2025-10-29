using ClubDeportivoNET80.Datos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace ClubDeportivoNET80.Entidades
{
    public class E_Socio : E_Cliente
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
            this.cuotas = new List<E_CuotaMensual>();
        }

        // Constructor usado por Datos.Clientes.ObtenerSociosMorosos()
        public E_Socio(int id,
            string nombre,
            string apellido
        ) : base(id, nombre, apellido)
        {

        }

        // Carga la lista cuotas del socio.
        public void ObtenerCuotas()
        {
            if (this.cuotas != null)
            {
                this.cuotas = Cuotas.ObtenerCuotas(this.Id, this.cuotas);
            }
            
        }

        // Llena la lista recivida solo con las cuotas pendientes/vencidas.
        public void ObtenerCuotasPendientes(List<E_CuotaMensual> pendientes)
        {
         
            if (this.cuotas != null)
            {
                pendientes.Clear();
                pendientes.AddRange(this.cuotas
                                    .Where(c => c.Estado == "pendiente" || 
                                           c.Estado == "vencida"));
                                    
            }

        }

        // devuelve la primer cuota pagada
        // (en este caso la única que es obtenida de la db)
        public E_CuotaMensual? ObtenerUltimaPagada()
        {

            return this.cuotas?.FirstOrDefault(c => c.Estado == "pagada");

        }



        //FIN
    }
}
