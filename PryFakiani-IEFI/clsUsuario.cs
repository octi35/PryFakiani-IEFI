using System;
using System.Data.SqlClient;

namespace PryFakiani_IEFI
{
    internal class clsUsuario
    {
        private SqlConnection conexion = new SqlConnection("server=OCTI\\SQLEXPRESS; database=Negocio; integrated security=true");
        public string estadoConexion = "";

        public bool ValidarUsuario(string login, string contraseña)
        {
            bool existe = false;

            try
            {
                conexion.Open();
                string sql = "SELECT COUNT(*) FROM Usuarios WHERE Login = @login AND Contraseña = @clave";
                SqlCommand comando = new SqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@login", login);
                comando.Parameters.AddWithValue("@clave", contraseña);

                int cantidad = (int)comando.ExecuteScalar();
                existe = cantidad > 0;
                estadoConexion = "Usuario validado correctamente.";
            }
            catch (Exception ex)
            {
                estadoConexion = "Error: " + ex.Message;
            }
            finally
            {
                conexion.Close();
            }

            return existe;
        }

        public bool RegistrarUsuario(string login, string nombre, string apellido, string descripcion, string clave)
        {
            try
            {
                conexion.Open();
                string sql = @"INSERT INTO Usuarios (Login, Nombre, Apellido, Descripcion, FechaRegistro, TiempoUsoMinutos, Contraseña)
                               VALUES (@login, @nombre, @apellido, @desc, GETDATE(), 0, @clave)";
                SqlCommand comando = new SqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@login", login);
                comando.Parameters.AddWithValue("@nombre", nombre);
                comando.Parameters.AddWithValue("@apellido", apellido);
                comando.Parameters.AddWithValue("@desc", descripcion);
                comando.Parameters.AddWithValue("@clave", clave);

                comando.ExecuteNonQuery();
                estadoConexion = "Usuario registrado correctamente.";
                return true;
            }
            catch (Exception ex)
            {
                estadoConexion = "Error: " + ex.Message;
                return false;
            }
            finally
            {
                conexion.Close();
            }
        }

        public void RegistroLogInicioSesion(string login)
        {
            try
            {
                conexion.Open();
                string sql = "INSERT INTO Auditoria (Login, FechaHoraInicio) VALUES (@login, GETDATE())";
                SqlCommand comando = new SqlCommand(sql, conexion);
                comando.Parameters.AddWithValue("@login", login);
                comando.ExecuteNonQuery();
            }
            catch { }
            finally
            {
                conexion.Close();
            }
        }

        public bool ValidarLogin(string login, string password)
        {
            bool resultado = false;
            string cadena = "server=OCTI\\SQLEXPRESS; database=Negocio; integrated security=true";

            using (SqlConnection conexion = new SqlConnection(cadena))
            {
                conexion.Open();
                string consulta = "SELECT COUNT(*) FROM Usuarios WHERE Login = @login AND Contraseña = @password";
                SqlCommand cmd = new SqlCommand(consulta, conexion);
                cmd.Parameters.AddWithValue("@login", login);
                cmd.Parameters.AddWithValue("@password", password);

                int count = (int)cmd.ExecuteScalar();
                resultado = count > 0;
            }

            return resultado;
        }

    }
}
