using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace PryFakiani_IEFI
{
    public partial class FrmAuditoria : Form
    {
        DateTime fechaIngreso;
        Stopwatch cronometro;
        DataTable tablaUsuarios;

        public FrmAuditoria()
        {
            InitializeComponent();
            fechaIngreso = DateTime.Now;
            cronometro = new Stopwatch();
        }

        private void FrmAuditoria_Load_1(object sender, EventArgs e)
        {
            lblFechaIngreso.Text = "Ingreso: " + fechaIngreso.ToString("dd/MM/yyyy HH:mm:ss");
            cronometro.Start();
            CargarDatos();
        }

        private void CargarDatos()
        {
            string cadenaConexion = "server=OCTI\\SQLEXPRESS; database=Negocio; integrated security=true";
            string consulta = "SELECT IdUsuarios, Nombre, FechaRegistro, TiempoUsoMinutos FROM Usuarios";

            using (SqlConnection conexion = new SqlConnection(cadenaConexion))
            {
                try
                {
                    SqlDataAdapter adaptador = new SqlDataAdapter(consulta, conexion);
                    tablaUsuarios = new DataTable();
                    adaptador.Fill(tablaUsuarios);
                    AplicarFiltros();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al obtener datos: " + ex.Message);
                }
            }
        }

        private void AplicarFiltros()
        {
            if (tablaUsuarios == null) return;

            string filtro = "";
            if (chkFiltrarUsuario.Checked && !string.IsNullOrWhiteSpace(txtUsuario.Text))
            {
                filtro += $"Nombre LIKE '%{txtUsuario.Text.Trim()}%'";
            }

            if (chkiId.Checked && !string.IsNullOrWhiteSpace(txtDni.Text))
            {
                if (!string.IsNullOrEmpty(filtro)) filtro += " AND ";
                filtro += $"IdUsuarios = {txtDni.Text.Trim()}";
            }

            DataView vista = tablaUsuarios.DefaultView;
            vista.RowFilter = filtro;

            string orden = "IdUsuarios ASC";
            if (radioASC.Checked)
                orden = "IdUsuarios ASC";
            else if (RadioDesc.Checked)
                orden = "IdUsuarios DESC";

            vista.Sort = orden;
            dgvUsuarios.DataSource = vista;
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void radioASC_CheckedChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void radioDesc_CheckedChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void chkFiltrarUsuario_CheckedChanged(object sender, EventArgs e)
        {
            txtUsuario.Enabled = chkFiltrarUsuario.Checked;
        }

        private void chkFiltrarDni_CheckedChanged(object sender, EventArgs e)
        {
            txtDni.Enabled = chkiId.Checked;
        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.");
                return;
            }

            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "Archivo de texto (*.txt)|*.txt";
            saveDialog.FileName = "Auditoria_Exportada.txt";

            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter writer = new StreamWriter(saveDialog.FileName))
                    {
                        // Escribir encabezados
                        for (int i = 0; i < dgvUsuarios.Columns.Count; i++)
                        {
                            writer.Write(dgvUsuarios.Columns[i].HeaderText);
                            if (i < dgvUsuarios.Columns.Count - 1)
                                writer.Write("\t"); // Tabulador entre columnas
                        }
                        writer.WriteLine();

                        // Escribir filas
                        foreach (DataGridViewRow fila in dgvUsuarios.Rows)
                        {
                            if (!fila.IsNewRow)
                            {
                                for (int i = 0; i < dgvUsuarios.Columns.Count; i++)
                                {
                                    var valor = fila.Cells[i].Value?.ToString().Replace("\t", " ");
                                    writer.Write(valor);
                                    if (i < dgvUsuarios.Columns.Count - 1)
                                        writer.Write("\t");
                                }
                                writer.WriteLine();
                            }
                        }
                    }

                    MessageBox.Show("Datos exportados correctamente a TXT.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al exportar: " + ex.Message);
                }
            }
        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
