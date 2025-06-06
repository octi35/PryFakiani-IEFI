using System;
using System.Data.SqlClient;
using PryFakiani_IEFI;
using static PryFakiani_IEFI.clsConexion;

namespace PryFakiani_IEFI
{
    public class clsUsuariosDatos
    {
        private readonly clsConexion conexion = new clsConexion();

        public string estadoConexion { get; private set; } = ""; // <-- AÑADÍ ESTA PROPIEDAD

        public bool ValidarUsuario(string login, string contraseña)
        {
            bool existe = false;
            estadoConexion = "";

            try
            {
                using (SqlConnection conn = conexion.ObtenerConexion())
                {
                    conn.Open();
                    string sql = "SELECT COUNT(*) FROM Usuarios WHERE Login = @login AND Contraseña = @clave";
                    SqlCommand comando = new SqlCommand(sql, conn);
                    comando.Parameters.AddWithValue("@login", login);
                    comando.Parameters.AddWithValue("@clave", contraseña);

                    int cantidad = (int)comando.ExecuteScalar();
                    existe = cantidad > 0;
                    estadoConexion = "Usuario validado correctamente.";
                }
            }
            catch (Exception ex)
            {
                estadoConexion = "Error: " + ex.Message;
            }

            return existe;
        }


        public bool RegistrarUsuario(string login, string nombre, string apellido, string descripcion, string clave, out string estadoConexion)
        {
            bool exito = false;
            estadoConexion = "";

            try
            {
                using (SqlConnection conn = conexion.ObtenerConexion())
                {
                    conn.Open();

                    string sql = "INSERT INTO Usuarios (Login, Nombre, Apellido, Descripcion, Contraseña) VALUES (@login, @nombre, @apellido, @descripcion, @clave)";
                    SqlCommand cmd = new SqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@login", login);
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.Parameters.AddWithValue("@apellido", apellido);
                    cmd.Parameters.AddWithValue("@descripcion", descripcion);
                    cmd.Parameters.AddWithValue("@clave", clave);

                    cmd.ExecuteNonQuery();
                    exito = true;
                    estadoConexion = "Usuario registrado correctamente.";
                }
            }
            catch (Exception ex)
            {
                estadoConexion = "Error al registrar usuario: " + ex.Message;
            }

            return exito;
        }


        public bool ValidarLogin(string login, string password)
        {
            bool resultado = false;

            using (SqlConnection conn = conexion.ObtenerConexion())
            {
                conn.Open();
                string consulta = "SELECT COUNT(*) FROM Usuarios WHERE Login = @login AND Contraseña = @password";
                SqlCommand cmd = new SqlCommand(consulta, conn);
                cmd.Parameters.AddWithValue("@login", login);
                cmd.Parameters.AddWithValue("@password", password);

                int count = (int)cmd.ExecuteScalar();
                resultado = count > 0;
            }

            return resultado;
        }
    }
}
