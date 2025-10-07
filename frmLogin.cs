using ClubDeportivo.Datos;
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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //txtUsuarioLogin.PlaceholderText = "USUARIO";
            //txtPassLogin.PlaceholderText = "CONTRASEÑA";
            txtPassLogin.UseSystemPasswordChar = true;
        }

        private void btnIngresarLogin_Click(object sender, EventArgs e)
        {
            Usuarios dato = new Usuarios(); // variable que contiene todas las caracteristicas de la clase
            DataTable tablaLogin = dato.Log_Usu(txtUsuarioLogin.Text, txtPassLogin.Text); // es la que recibe los datos desde el formulario
            if (tablaLogin.Rows.Count > 0)
            {
                // quiere decir que el resultado tiene 1 fila por lo que el usuario EXISTE
                //MessageBox.Show("Ingreso exitoso");
                this.Hide();
                frmPrincipal frmPrincipal = new frmPrincipal();
                frmPrincipal.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario y/o password incorrecto");
            }
        }

    }
}
