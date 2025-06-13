using System;
using System.Data;
using System.Data.SqlClient;

namespace PryFakiani_IEFI
{
    public class clsUsuariosDatos
    {
        private readonly clsConexion conexionBD = new clsConexion();

        public bool AgregarUsuario(ClsUsuarios usuario)
        {
            using (SqlConnection conexion = conexionBD.ObtenerConexion())
            {
                string query = @"INSERT INTO Usuarios 
                                (Login, Nombre, Apellido, Descripcion, FechaRegistro, Area, Contraseña, FechaNacimiento, Celular, Nivel)
                                 VALUES 
                                (@Login, @Nombre, @Apellido, @Descripcion, @FechaRegistro, @Area, @Contraseña, @FechaNacimiento, @Celular, @Nivel)";

                SqlCommand cmd = new SqlCommand(query, conexion);

                cmd.Parameters.AddWithValue("@Login", usuario.Login);
                cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", usuario.Apellido);
                cmd.Parameters.AddWithValue("@Descripcion", usuario.Descripcion);
                cmd.Parameters.AddWithValue("@FechaRegistro", usuario.FechaRegistro);
                cmd.Parameters.AddWithValue("@Area", usuario.area);
                cmd.Parameters.AddWithValue("@Contraseña", usuario.Contraseña);
                cmd.Parameters.AddWithValue("@FechaNacimiento", usuario.FechaNacimiento);
                cmd.Parameters.AddWithValue("@Celular", usuario.Celular);
                cmd.Parameters.AddWithValue("@Nivel", usuario.Nivel);

                conexion.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public DataTable ObtenerUsuarios()
        {
            using (SqlConnection conexion = conexionBD.ObtenerConexion())
            {
                string query = "SELECT * FROM Usuarios";
                SqlDataAdapter adaptador = new SqlDataAdapter(query, conexion);
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                return tabla;
            }
        }

        public DataTable BuscarUsuarioPorLogin(string login)
        {
            using (SqlConnection conexion = conexionBD.ObtenerConexion())
            {
                string query = "SELECT * FROM Usuarios WHERE Login LIKE @Login";
                SqlDataAdapter adaptador = new SqlDataAdapter(query, conexion);
                adaptador.SelectCommand.Parameters.AddWithValue("@Login", $"%{login}%");
                DataTable tabla = new DataTable();
                adaptador.Fill(tabla);
                return tabla;
            }
        }

        public bool ActualizarUsuario(ClsUsuarios usuario)
        {
            using (SqlConnection conexion = conexionBD.ObtenerConexion())
            {
                string query = @"UPDATE Usuarios SET 
                                 Login = @Login,
                                 Nombre = @Nombre,
                                 Apellido = @Apellido,
                                 Descripcion = @Descripcion,
                                 FechaRegistro = @FechaRegistro,
                                 Area = @Area,
                                 Contraseña = @Contraseña,
                                 FechaNacimiento = @FechaNacimiento,
                                 Celular = @Celular,
                                 Nivel = @Nivel
                                 WHERE IdUsuarios = @IdUsuarios";

                SqlCommand cmd = new SqlCommand(query, conexion);

                cmd.Parameters.AddWithValue("@Login", usuario.Login);
                cmd.Parameters.AddWithValue("@Nombre", usuario.Nombre);
                cmd.Parameters.AddWithValue("@Apellido", usuario.Apellido);
                cmd.Parameters.AddWithValue("@Descripcion", usuario.Descripcion);
                cmd.Parameters.AddWithValue("@FechaRegistro", usuario.FechaRegistro);
                cmd.Parameters.AddWithValue("@Area", usuario.area);
                cmd.Parameters.AddWithValue("@Contraseña", usuario.Contraseña);
                cmd.Parameters.AddWithValue("@FechaNacimiento", usuario.FechaNacimiento);
                cmd.Parameters.AddWithValue("@Celular", usuario.Celular);
                cmd.Parameters.AddWithValue("@Nivel", usuario.Nivel);
                cmd.Parameters.AddWithValue("@IdUsuarios", usuario.IdUsuarios);

                conexion.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool EliminarUsuario(int idUsuario)
        {
            using (SqlConnection conexion = conexionBD.ObtenerConexion())
            {
                string query = "DELETE FROM Usuarios WHERE IdUsuarios = @IdUsuarios";
                SqlCommand cmd = new SqlCommand(query, conexion);
                cmd.Parameters.AddWithValue("@IdUsuarios", idUsuario);

                conexion.Open();
                return cmd.ExecuteNonQuery() > 0;
            }
        }

        public bool ValidarLogin(string login, string password)
        {
            using (SqlConnection conexion = conexionBD.ObtenerConexion())
            {
                conexion.Open();
                string consulta = "SELECT COUNT(*) FROM Usuarios WHERE Login = @login AND Contraseña = @password";
                SqlCommand cmd = new SqlCommand(consulta, conexion);
                cmd.Parameters.AddWithValue("@login", login);
                cmd.Parameters.AddWithValue("@password", password);

                int count = (int)cmd.ExecuteScalar();
                return count > 0;
            }
        }
    }
}
