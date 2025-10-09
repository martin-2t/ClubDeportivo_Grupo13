using ClubDeportivo.Datos;
using ClubDeportivo.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClubDeportivo
{
    public partial class frmRegistrarSocio : Form
    {
        public frmRegistrarSocio()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            this.Hide();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "" || 
                txtApellido.Text == "" ||
                cboTipoDoc.Text == "" ||
                txtNumDoc.Text == "" ||
                txtTelefono.Text == "" || 
                txtEmail.Text == "" ||
                cboModoPago.Text == "" ||
                !chkAptoFisico.Checked
                )
            {
                MessageBox.Show("Debe completar datos requeridos (*) ",
                "AVISO DEL SISTEMA", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else
            {
                E_Socio socio = new E_Socio();
                socio.es_socio = true;
                socio.nombre = txtNombre.Text;
                socio.apellido = txtApellido.Text;
                socio.numero_documento = txtNumDoc.Text;
                socio.telefono = txtTelefono.Text;
                socio.email = txtEmail.Text;
                socio.apto_fisico = true;
                socio.tipo_documento = (cboTipoDoc.Text == "DNI") ? 1 : 2;

                E_CuotaMensual cuotaMensual = new E_CuotaMensual();
                cuotaMensual.ModoPago = cboModoPago.Text;
                cuotaMensual.Promocion = cboPromocion.Text;

                Clientes dato = new Clientes();
                string respuesta = dato.Nuevo_Socio(socio,cuotaMensual);

                bool esNumero = int.TryParse(respuesta, out int idGenerado);

                if (esNumero) { 
                    if (idGenerado == -1)
                    {
                        limpiarCampos();

                        MessageBox.Show("El cliente ya existe.", "Aviso del sistema",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    } else if (idGenerado == -2)
                    {
                        limpiarCampos();

                        MessageBox.Show("Fallo el pago de la cuota. Socio no creado.", "Aviso del sistema",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);


                    }else
                    {
                        limpiarCampos();

                        MessageBox.Show(socio.ImprimirCarnet(),
                            "Registro exitoso",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                } else {
                    MessageBox.Show("Error al registrar al socio: " + respuesta,
                    "Error del sistema",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        // Limpia los campos del form.
        private void limpiarCampos()
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtEmail.Text = "";
            txtTelefono.Text = "";
            cboTipoDoc.SelectedIndex = -1;
            txtNumDoc.Text = "";
            chkAptoFisico.Checked = false;
            cboModoPago.SelectedIndex = -1;
            cboPromocion.SelectedIndex = -1;

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblAstTelefono_Click(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void lblTelefono_Click(object sender, EventArgs e)
        {

        }

        private void lblAstEmail_Click(object sender, EventArgs e)
        {

        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboModoPago.SelectedItem != null && cboModoPago.Text == "Tarjeta")
            {
                lblPromocion.Visible = true;
                cboPromocion.Visible = true;
               
            } else
            {
                lblPromocion.Visible = false;
                cboPromocion.Visible = false;
            }
        }

        private void frmRegistrarSocio_Load(object sender, EventArgs e)
        {
            lblMontoCuotaMensual.Text = Convert.ToString(E_CuotaMensual.monto);
        }

        private void lblAstPromocion_Click(object sender, EventArgs e)
        {

        }
    }
}
