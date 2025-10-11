namespace ClubDeportivoNET80
{
    public partial class frmPagarCuota : Form
    {
        public frmPagarCuota()
        {
            InitializeComponent();
        }

        private void frmPagarCuota_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal();
            principal.Show();
            this.Close();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {

            if (txtNumeroCliente.Text == "" ||
                cboModoPago.Text == ""
                )
            {
                MessageBox.Show("Debe completar datos requeridos (*) ",
                "AVISO DEL SISTEMA", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else
            {
                // aca se podria crear un procedimiento para que busque si el cliente es socio o no
                // de acuerdo a su numero de cliente, y ahi bifurque a la cuota diaria o mensual
            }

        }

    }
}
