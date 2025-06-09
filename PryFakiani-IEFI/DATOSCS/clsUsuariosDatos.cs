using System;
using System.Data.SqlClient;
using PryFakiani_IEFI;
using static PryFakiani_IEFI.clsConexion;

namespace PryFakiani_IEFI
{
    public class clsUsuariosDatos
    {
        private readonly clsConexion conexion = new clsConexion();


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
