using ClubDeportivoNET80.Controles;
using ClubDeportivoNET80.Datos;
using ClubDeportivoNET80.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDeportivoNET80
{
    public partial class frmPagarCuotaDiaria : Form
    {
        E_NoSocio noSocio;
        private List<int> idActividades;
        private decimal montoTotal;
        public frmPagarCuotaDiaria(E_NoSocio noSocio)
        {
            InitializeComponent();
            this.noSocio = noSocio;
            this.idActividades = new List<int>();
            this.montoTotal = 0;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmPagarCuotaDiaria_Load(object sender, EventArgs e)
        {
            lblNoSocioNombre.Text = $"{noSocio.Apellido.ToUpper()} {noSocio.Nombre.ToUpper()}";

            LlenarDataGridView(Actividades.ObtenerActividades());

            ctrlMontoTotalDiario.CargarMonto(this.montoTotal);

        }

        // Llena la gid con las actividades obtenidas desde la bd.
        private void LlenarDataGridView(List<E_Actividad> actividades)
        {
            dtgvActividades.Rows.Clear();
            dtgvActividades.Columns["colMonto"].DefaultCellStyle.Format = "N2";

            foreach (E_Actividad actividad in actividades)
            {
                dtgvActividades.Rows.Add(
                    false,
                    actividad.Id,
                    actividad.Nombre,
                    actividad.Monto
                );

            }

        }

        // Chequea si se seleccionó un checkbox
        // si es asi, manda a actualizar su valor.
        private void dtgvActividades_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dtgvActividades.IsCurrentCellDirty)
            {
                dtgvActividades.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        private void dtgvActividades_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dtgvActividades.Columns["colSeleccionar"].Index)
            {

                DataGridViewRow fila = dtgvActividades.Rows[e.RowIndex];

                int id = Convert.ToInt32(fila.Cells["colNum"].Value);
                decimal monto = Convert.ToDecimal(fila.Cells["colMonto"].Value);
                bool seleccionado = Convert.ToBoolean(fila.Cells["colSeleccionar"].Value);

                ProcesarSeleccion(id, monto, seleccionado);

                ctrlMontoTotalDiario.CargarMonto(this.montoTotal);
            }
        }

        // Actualiza el monto total y la lista de idActividades
        // según se selecciona o se deselecciona una actividad.
        private void ProcesarSeleccion(int id, decimal monto, bool seleccionado)
        {
            bool tiene = this.idActividades.Contains(id);

            if (seleccionado && !tiene)
            {
                this.idActividades.Add(id);
                this.montoTotal += monto;

            }
            else if (!seleccionado && tiene)
            {
                this.idActividades.Remove(id);
                this.montoTotal -= monto;
            }

        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (this.idActividades.Count == 0)
            {
                MensajeSistema.MostrarError("No hay actividades seleccionadas.");

            }
            else if (ctrlModoPagoDiario.EstaVacio())
            {
                MensajeSistema.MostrarError("Llenar los campos requeridos (*)");

            }
            else
            {
                Cuotas.PagarCuotaDiaria(this.idActividades,
                                        ctrlModoPagoDiario.ObtenerModoPago(),
                                        ctrlModoPagoDiario.ObtenerPromocion(),
                                        this.noSocio.Id);

                MensajeSistema.MostrarInformacion($"Se registro la cuota diaria exitosamente");

                this.Close();

            }
        }



        // FIN
    }
}
