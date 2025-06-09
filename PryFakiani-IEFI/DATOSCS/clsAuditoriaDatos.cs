using System;
using System.Data;
using System.Data.SqlClient;

namespace PryFakiani_IEFI
{
    public class ClsAuditoriaDatos
    {
        private readonly string cadenaConexion = "server=OCTI\\SQLEXPRESS; database=Negocio; integrated security=true";

        public DataTable ObtenerAuditoriasConUsuarios()
        {
            DataTable tabla = new DataTable();
            string consulta = @"
            SELECT 
                A.IdAuditoria, 
                A.IdUsuarios,
                U.Nombre + ' ' + U.Apellido AS NombreUsuario,
                A.Fecha, 
                A.TiempoDeUso
            FROM Auditoria A
            INNER JOIN Usuarios U ON A.IdUsuarios = U.IdUsuarios
            ORDER BY A.IdAuditoria";

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                try
                {
                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                    adaptador.Fill(tabla);
                }
                catch (Exception ex)
                {
                    throw new Exception("Error al obtener auditorías: " + ex.Message);
                }
            }

            return tabla;
        }
    }

}
