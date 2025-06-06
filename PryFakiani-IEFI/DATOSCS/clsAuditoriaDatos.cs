using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PryFakiani_IEFI
{
    internal class clsAuditoriaDatos
    {
        private readonly clsConexion conexion = new clsConexion();

        public void RegistroLogInicioSesion(string login)
        {
            try
            {
                using (SqlConnection conn = conexion.ObtenerConexion())
                {
                    conn.Open();
                    string sql = "INSERT INTO Auditoria (Login, FechaHoraInicio) VALUES (@login, GETDATE())";
                    SqlCommand comando = new SqlCommand(sql, conn);
                    comando.Parameters.AddWithValue("@login", login);
                    comando.ExecuteNonQuery();
                }
            }
            catch
            {
                // Manejo de errores silencioso por ahora
            }
        }
    }
}
