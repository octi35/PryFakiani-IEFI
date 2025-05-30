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
            lblBienvenida.Text = "Bienvenido, " + usuario;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }



        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void aUDITORIAToolStripMenuItem_Click(object sender, EventArgs e)
        {


            FrmAuditoria auditoria = new FrmAuditoria();
            auditoria.ShowDialog();


        }




    }
}
