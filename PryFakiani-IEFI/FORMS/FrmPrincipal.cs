using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryFakiani_IEFI
{
    public partial class FrmPrincipal : Form
    {

        string usuarioActual;
        public FrmPrincipal(string usuario)
        {
            InitializeComponent();
            usuarioActual = usuario;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            lblIngreso.Text = "Ingreso: " + DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            lblBienvenida.Text = "Bienvenido," + usuarioActual;
        }

        private void aUDITORIAToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmAuditoria auditoria = new FrmAuditoria(usuarioActual);
            auditoria.ShowDialog();
        }

        private void aUDITORIAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuarios usuarios = new FrmUsuarios();
            usuarios.ShowDialog(); // o usuarios.Show(); si querés que no sea modal
        }

    }
}
