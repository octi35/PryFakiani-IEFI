using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryFakiani_IEFI
{
    public partial class FrmUsuarios : Form
    {
        // Instancia de la clase de conexión
        clsConexion conexionBD = new clsConexion();

        public FrmUsuarios()
        {
            InitializeComponent();
        }

        clsUsuariosDatos usuariosDatos = new clsUsuariosDatos();
        ClsUsuarios usuarioSeleccionado = null;

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            CargarUsuarios();
        }
        private void CargarUsuarios()
        {
            dataUsuarios.DataSource = usuariosDatos.ObtenerUsuarios();
        }

        private void LimpiarCampos()
        {
            txtLogin.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
           
            txtContraseña.Clear();
            txtCelular.Clear();
            cmbArea.SelectedIndex = -1;
            dataNacimiento.Value = DateTime.Now;
            

            usuarioSeleccionado = null;
        }


        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDNI_TextChanged(object sender, EventArgs e)
        {

        }

        private void cmbArea_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCelular_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataNacimiento_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            
            ClsUsuarios nuevo = new ClsUsuarios
            {
                Login = txtLogin.Text,
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                FechaRegistro = DateTime.Now,
                Descripcion = "Registrado desde el sistema",
                area = cmbArea.Text,
                Contraseña = txtContraseña.Text,
                FechaNacimiento = dataNacimiento.Value,
                Celular = txtCelular.Text,
               

            };
            

            if (usuariosDatos.AgregarUsuario(nuevo))
            {
                MessageBox.Show("Usuario agregado correctamente");
                CargarUsuarios();
                LimpiarCampos();

            }
            else
            {
                MessageBox.Show("Error al agregar el usuario");
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (usuarioSeleccionado == null)
            {
                MessageBox.Show("Seleccione un usuario para actualizar.");
                return;
            }

            usuarioSeleccionado.Login = txtLogin.Text;
            usuarioSeleccionado.Nombre = txtNombre.Text;
            usuarioSeleccionado.Apellido = txtApellido.Text;
            usuarioSeleccionado.area = cmbArea.Text;
            usuarioSeleccionado.Contraseña = txtContraseña.Text;
            usuarioSeleccionado.FechaNacimiento = dataNacimiento.Value;
            usuarioSeleccionado.Celular = txtCelular.Text;
           

            if (usuariosDatos.ActualizarUsuario(usuarioSeleccionado))
            {
                MessageBox.Show("Usuario actualizado correctamente.");
                CargarUsuarios();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al actualizar el usuario.");
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (usuarioSeleccionado == null)
            {
                MessageBox.Show("Seleccione un usuario para eliminar.");
                return;
            }

            if (usuariosDatos.EliminarUsuario(usuarioSeleccionado.IdUsuarios))
            {
                MessageBox.Show("Usuario eliminado correctamente.");
                CargarUsuarios();
                LimpiarCampos();
            }
            else
            {
                MessageBox.Show("Error al eliminar el usuario.");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            dataUsuarios.DataSource = usuariosDatos.BuscarUsuarioPorLogin(login);
        }

        private void dataUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dataUsuarios.Rows[e.RowIndex];

                usuarioSeleccionado = new ClsUsuarios
                {
                    IdUsuarios = Convert.ToInt32(fila.Cells["IdUsuarios"].Value),
                    Login = fila.Cells["Login"].Value.ToString(),
                    Nombre = fila.Cells["Nombre"].Value.ToString(),
                    Apellido = fila.Cells["Apellido"].Value.ToString(),
                    Descripcion = fila.Cells["Descripcion"].Value.ToString(),
                    FechaRegistro = Convert.ToDateTime(fila.Cells["FechaRegistro"].Value),
                    area = fila.Cells["Area"].Value.ToString(),
                    Contraseña = fila.Cells["Contraseña"].Value.ToString(),
                    FechaNacimiento = Convert.ToDateTime(fila.Cells["FechaNacimiento"].Value),
                    Celular = fila.Cells["Celular"].Value.ToString(),
                    Nivel = Convert.ToInt32(fila.Cells["Nivel"].Value)
                };

                // Cargar los datos en los campos
                txtLogin.Text = usuarioSeleccionado.Login;
                txtNombre.Text = usuarioSeleccionado.Nombre;
                txtApellido.Text = usuarioSeleccionado.Apellido;
              
                cmbArea.Text = usuarioSeleccionado.area;
                txtContraseña.Text = usuarioSeleccionado.Contraseña;
                dataNacimiento.Value = usuarioSeleccionado.FechaNacimiento;
                txtCelular.Text = usuarioSeleccionado.Celular;
               
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {

        }
    }
}
