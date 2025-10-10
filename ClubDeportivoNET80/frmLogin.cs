using ClubDeportivoNET80.Datos;
using System.Data;

namespace ClubDeportivoNET80
{
    public partial class frmLogin : Form
    {

        // Constructor del formulario Login
        // Inicializa los componente visuales del formulario.
        public frmLogin()
        {
            InitializeComponent();
        }

        // Método que se ejecuta al cargar el formulario.
        private void frmLogin_Load(object sender, EventArgs e)
        {
            txtUsuarioLogin.PlaceholderText = "Nombre del usuario";
            txtPassLogin.PlaceholderText = "Ingresar contraseña";
            txtPassLogin.UseSystemPasswordChar = true;
        }

        // Método que se ejecuta al hacer click en el boton IngresarLogin
        private void btnIngresarLogin_Click(object sender, EventArgs e)
        {
            // Creamos un objeto de la clase Usuarios para acceder a sus metodos.
            Usuarios dato = new Usuarios();

            // Llamamos al método Log_Usu pasando usuario y clave.
            // Retorna una DataTable con el tipo de rol de unsuario si pasa la verificación.
            DataTable tablaLogin = dato.Log_Usu(txtUsuarioLogin.Text, txtPassLogin.Text);

            // Si hay al menos una fila, significa que el usuario ingresado existe.
            if (tablaLogin.Rows.Count > 0)
            {

                // Creamos una instancia del formulario Principal.
                frmPrincipal frmPrincipal = new frmPrincipal();

                // Guardamos los datos del usuario en la clase estática Session.
                // Mientras dure la sesion, cualquier formulario podra acceder a estos datos.
                Session.Usuario = Convert.ToString(txtUsuarioLogin.Text);
                Session.Rol = Convert.ToString(tablaLogin.Rows[0][0]);

                // Mostramos el formulario principal y ocultamos el Login.
                frmPrincipal.Show();
                this.Hide();
            }
            else
            {
                // Si no hay coincidencia, es decir, no hay filas, mostramos mensaje de error.
                MessageBox.Show("Usuario y/o password incorrecto");
            }
        }

    }
}
