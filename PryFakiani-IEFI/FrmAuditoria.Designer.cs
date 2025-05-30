namespace PryFakiani_IEFI
{
    partial class FrmAuditoria
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvUsuarios = new System.Windows.Forms.DataGridView();
            this.lblFechaIngreso = new System.Windows.Forms.StatusStrip();
            this.lblTiempoUso = new System.Windows.Forms.StatusStrip();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(43, 42);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.RowHeadersWidth = 51;
            this.dgvUsuarios.Size = new System.Drawing.Size(694, 336);
            this.dgvUsuarios.TabIndex = 0;
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.lblFechaIngreso.Location = new System.Drawing.Point(0, 428);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(800, 22);
            this.lblFechaIngreso.TabIndex = 1;
            this.lblFechaIngreso.Text = "statusStrip1";
            // 
            // lblTiempoUso
            // 
            this.lblTiempoUso.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.lblTiempoUso.Location = new System.Drawing.Point(0, 404);
            this.lblTiempoUso.Name = "lblTiempoUso";
            this.lblTiempoUso.Size = new System.Drawing.Size(800, 24);
            this.lblTiempoUso.TabIndex = 2;
            this.lblTiempoUso.Text = "statusStrip2";
            // 
            // FrmAuditoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTiempoUso);
            this.Controls.Add(this.lblFechaIngreso);
            this.Controls.Add(this.dgvUsuarios);
            this.Name = "FrmAuditoria";
            this.Text = "FrmAuditoriacs";
            this.Load += new System.EventHandler(this.FrmAuditoria_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.StatusStrip lblFechaIngreso;
        private System.Windows.Forms.StatusStrip lblTiempoUso;
    }
}