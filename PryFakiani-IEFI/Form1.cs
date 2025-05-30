using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryFakiani_IEFI
{
    public partial class Form1 : Form
    {

        clsUsuario objUsuario;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            objUsuario = new clsUsuario();
            lblConexion.Text = objUsuario.estadoConexion;


        }

     

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            string login = txtUsuario.Text.Trim();
            string clave = txtClave.Text.Trim();

            string nombre = "Nuevo";     // Podés agregar TextBox para esto
            string apellido = "Usuario"; // o pedírselo luego
            string descripcion = "Registrado desde el sistema";

            clsUsuario objUsuario = new clsUsuario();
            if (objUsuario.RegistrarUsuario(login, nombre, apellido, descripcion, clave))
            {
                MessageBox.Show("Usuario registrado correctamente", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al registrar: " + objUsuario.estadoConexion, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIniciar_Click_1(object sender, EventArgs e)
        {
            string login = txtUsuario.Text.Trim();
            string password = txtClave.Text.Trim();

            if (login == "" || password == "")
            {
                MessageBox.Show("Debe ingresar el usuario y la contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            clsUsuario usuario = new clsUsuario();
            bool loginExitoso = usuario.ValidarLogin(login, password);

            if (loginExitoso)
            {
                MessageBox.Show("Inicio de sesión exitoso", "Bienvenido", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Ocultar el login
                this.Hide();

                // Mostrar el formulario principal y pasarle el login del usuario
                FrmPrincipal principal = new FrmPrincipal(login);
                principal.ShowDialog();

                // Cerrar completamente la app si se cierra FrmPrincipal
                this.Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Acceso denegado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
