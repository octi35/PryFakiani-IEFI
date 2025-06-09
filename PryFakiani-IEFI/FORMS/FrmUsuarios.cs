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

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void LimpiarCampos()
        {
            txtDNI.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            cmbArea.SelectedIndex = -1;
            txtNacimiento.Clear();
            txtCelular.Clear();
            txtLogin.Clear();
            txtContraseña.Clear();
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conexion = conexionBD.ObtenerConexion())
            {
                try
                {
                    conexion.Open();
                    string query = "INSERT INTO Usuarios (DNI, Nombre, Apellido, Area, FechaNacimiento, Celular, Login, Contraseña) " +
                                   "VALUES (@DNI, @Nombre, @Apellido, @Area, @FechaNacimiento, @Celular, @Login, @Contraseña)";
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@DNI", txtDNI.Text);
                        cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                        cmd.Parameters.AddWithValue("@Apellido", txtApellido.Text);
                        cmd.Parameters.AddWithValue("@Area", cmbArea.Text);
                        cmd.Parameters.AddWithValue("@FechaNacimiento", DateTime.Parse(txtNacimiento.Text));
                        cmd.Parameters.AddWithValue("@Celular", txtCelular.Text);
                        cmd.Parameters.AddWithValue("@Login", txtLogin.Text);
                        cmd.Parameters.AddWithValue("@Contraseña", txtContraseña.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Usuario registrado exitosamente.");
                        LimpiarCampos();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al registrar: " + ex.Message);
                }
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            using (SqlConnection conexion = conexionBD.ObtenerConexion())
            {
                try
                {
                    conexion.Open();
                    string query = "UPDATE Usuarios SET Nombre=@Nombre, Apellido=@Apellido, Area=@Area, FechaNacimiento=@FechaNacimiento, " +
                                   "Celular=@Celular, Login=@Login, Contraseña=@Contraseña WHERE DNI=@DNI";
                    using (SqlCommand cmd = new SqlCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text);
                        cmd.Parameters.AddWithValue("@Apellido", txtApellido.Text);
                        cmd.Parameters.AddWithValue("@Area", cmbArea.Text);
                        cmd.Parameters.AddWithValue("@FechaNacimiento", DateTime.Parse(txtNacimiento.Text));
                        cmd.Parameters.AddWithValue("@Celular", txtCelular.Text);
                        cmd.Parameters.AddWithValue("@Login", txtLogin.Text);
                        cmd.Parameters.AddWithValue("@Contraseña", txtContraseña.Text);
                        cmd.Parameters.AddWithValue("@DNI", txtDNI.Text);

                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Usuario actualizado.");
                        LimpiarCampos();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar: " + ex.Message);
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
    }
}
