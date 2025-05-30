using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Windows.Forms;

namespace PryFakiani_IEFI
{
    public partial class FrmAuditoria : Form
    {

        DateTime fechaIngreso;
        Stopwatch cronometro;
        public FrmAuditoria()
        {
            InitializeComponent();
            fechaIngreso = DateTime.Now;
            cronometro = new Stopwatch();
        }

        private void FrmAuditoria_Load_1(object sender, EventArgs e)
        {
            lblFechaIngreso.Text = "Ingreso: " + fechaIngreso.ToString("dd/MM/yyyy HH:mm:ss");
            // Iniciar cronómetro
            cronometro.Start();

            // Iniciar timer


            string cadenaConexion = "server=OCTI\\SQLEXPRESS; database=Negocio; integrated security=true";
            string consulta = "SELECT * FROM Usuarios";

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                try
                {
                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    dgvUsuarios.DataSource = tabla;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener datos: " + ex.Message);
                }
            }
        }

    }
}

