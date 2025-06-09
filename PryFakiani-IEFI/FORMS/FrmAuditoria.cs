using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace PryFakiani_IEFI
{
    public partial class FrmAuditoria : Form
    {
        private readonly ClsAuditoriaDatos auditoriaDatos = new ClsAuditoriaDatos();
        private DataTable tablaAuditoria;
        Stopwatch cronometro = new Stopwatch();
        Timer timerUso = new Timer();
        string loginUsuario;

        public FrmAuditoria(string login)
        {
            InitializeComponent();

            timerUso.Interval = 1000; // 1 segundo
            timerUso.Tick += TimerUso_Tick;
            loginUsuario = login;

        }

        private void FrmAuditoria_Load(object sender, EventArgs e)
        {
          
            CargarDatos();
            cronometro.Start();
            timerUso.Start();
            lblUsuarioAuditoria.Text = $"Usuario: {loginUsuario}";

        }

        private void TimerUso_Tick(object sender, EventArgs e)
        {
            TimeSpan tiempo = cronometro.Elapsed;
            lblTiempodeUso.Text = $"Tiempo de uso: {tiempo:hh\\:mm\\:ss}";
        }

        private void CargarDatos()
        {
            try
            {
                tablaAuditoria = auditoriaDatos.ObtenerAuditoriasConUsuarios();
                AplicarFiltros();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar auditorías: " + ex.Message);
            }
        }

        private void AplicarFiltros()
        {
            if (tablaAuditoria == null) return;

            string filtro = "";

            if (chkfiltrarAuditoriaId.Checked && !string.IsNullOrWhiteSpace(txtAuditoriaId.Text))
                filtro += $"Convert(IdAuditoria, 'System.String') LIKE '%{txtAuditoriaId.Text.Trim()}%'";

            if (chkiUsuarioId.Checked && !string.IsNullOrWhiteSpace(txtUsuarioId.Text))
            {
                if (!string.IsNullOrEmpty(filtro)) filtro += " AND ";
                filtro += $"Convert(IdUsuarios, 'System.String') LIKE '%{txtUsuarioId.Text.Trim()}%'";
            }

            if (chkUsuarioNombre.Checked && !string.IsNullOrWhiteSpace(txtUsuarioNombre.Text))
            {
                if (!string.IsNullOrEmpty(filtro)) filtro += " AND ";
                filtro += $"NombreUsuario LIKE '%{txtUsuarioNombre.Text.Trim()}%'";
            }

            DataView vista = tablaAuditoria.DefaultView;
            vista.RowFilter = filtro;

            string orden = radioASC.Checked ? "IdAuditoria ASC" : "IdAuditoria DESC";
            vista.Sort = orden;

            dgvUsuarios.DataSource = vista;
        }

        private void btnDescargar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar.");
                return;
            }

            using (SaveFileDialog saveDialog = new SaveFileDialog())
            {
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
                                if (i < dgvUsuarios.Columns.Count - 1) writer.Write("\t");
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
                                        if (i < dgvUsuarios.Columns.Count - 1) writer.Write("\t");
                                    }
                                    writer.WriteLine();
                                }
                            }
                        }

                        MessageBox.Show("Datos exportados correctamente.");
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al exportar: " + ex.Message);
                    }
                }
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void radioASC_CheckedChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void txtUsuarioNombre_TextChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void chkUsuarioNombre_CheckedChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }
        private void RadioDesc_CheckedChanged(object sender, EventArgs e)
        {
            AplicarFiltros();
        }
    }
}
