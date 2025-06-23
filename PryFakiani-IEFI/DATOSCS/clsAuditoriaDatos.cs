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

        public bool RegistrarAuditoria(ClsAuditoria auditoria)
        {
            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                conexion.Open();

                // Primero, verificar si ya existe un registro para ese usuario en la misma fecha
                string consultaExistente = @"SELECT COUNT(*) FROM Auditoria 
                                     WHERE CONVERT(date, Fecha) = CONVERT(date, @Fecha) 
                                     AND IdUsuarios = @IdUsuarios";

                SqlCommand cmdExistencia = new SqlCommand(consultaExistente, conexion);
                cmdExistencia.Parameters.AddWithValue("@Fecha", auditoria.Fecha);
                cmdExistencia.Parameters.AddWithValue("@IdUsuarios", auditoria.IdUsuarios);

                int existe = (int)cmdExistencia.ExecuteScalar();

                if (existe > 0)
                {
                    // Si existe, actualizar el tiempo sumando
                    string update = @"UPDATE Auditoria 
                              SET TiempoDeUso = TiempoDeUso + @TiempoDeUso 
                              WHERE CONVERT(date, Fecha) = CONVERT(date, @Fecha) 
                              AND IdUsuarios = @IdUsuarios";

                    SqlCommand cmdUpdate = new SqlCommand(update, conexion);
                    cmdUpdate.Parameters.AddWithValue("@TiempoDeUso", auditoria.TiempoDeUso);
                    cmdUpdate.Parameters.AddWithValue("@Fecha", auditoria.Fecha);
                    cmdUpdate.Parameters.AddWithValue("@IdUsuarios", auditoria.IdUsuarios);

                    return cmdUpdate.ExecuteNonQuery() > 0;
                }
                else
                {
                    // Si no existe, insertar un nuevo registro
                    string insert = @"INSERT INTO Auditoria (Fecha, TiempoDeUso, IdUsuarios, NombreUsuario)
                              VALUES (@Fecha, @TiempoDeUso, @IdUsuarios, @NombreUsuario)";

                    SqlCommand cmdInsert = new SqlCommand(insert, conexion);
                    cmdInsert.Parameters.AddWithValue("@Fecha", auditoria.Fecha);
                    cmdInsert.Parameters.AddWithValue("@TiempoDeUso", auditoria.TiempoDeUso);
                    cmdInsert.Parameters.AddWithValue("@IdUsuarios", auditoria.IdUsuarios);
                    cmdInsert.Parameters.AddWithValue("@NombreUsuario", auditoria.NombreUsuario);

                    return cmdInsert.ExecuteNonQuery() > 0;
                }
            }
        }


    }

}
