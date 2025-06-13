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
            this.btnDescargar = new System.Windows.Forms.Button();
            this.radioASC = new System.Windows.Forms.RadioButton();
            this.RadioDesc = new System.Windows.Forms.RadioButton();
            this.chkfiltrarAuditoriaId = new System.Windows.Forms.CheckBox();
            this.txtAuditoriaId = new System.Windows.Forms.TextBox();
            this.txtUsuarioId = new System.Windows.Forms.TextBox();
            this.chkiUsuarioId = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chkUsuarioNombre = new System.Windows.Forms.CheckBox();
            this.txtUsuarioNombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblTiempodeUso = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTiempouso = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUsuarioAuditoria = new System.Windows.Forms.ToolStripStatusLabel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(46, 158);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.RowHeadersWidth = 51;
            this.dgvUsuarios.Size = new System.Drawing.Size(950, 321);
            this.dgvUsuarios.TabIndex = 0;
            // 
            // btnDescargar
            // 
            this.btnDescargar.Location = new System.Drawing.Point(783, 485);
            this.btnDescargar.Name = "btnDescargar";
            this.btnDescargar.Size = new System.Drawing.Size(195, 40);
            this.btnDescargar.TabIndex = 3;
            this.btnDescargar.Text = "Descargar";
            this.btnDescargar.UseVisualStyleBackColor = true;
            this.btnDescargar.Click += new System.EventHandler(this.btnDescargar_Click);
            // 
            // radioASC
            // 
            this.radioASC.AutoSize = true;
            this.radioASC.Checked = true;
            this.radioASC.Location = new System.Drawing.Point(6, 36);
            this.radioASC.Name = "radioASC";
            this.radioASC.Size = new System.Drawing.Size(133, 20);
            this.radioASC.TabIndex = 4;
            this.radioASC.TabStop = true;
            this.radioASC.Text = "FiltrarAscendente";
            this.radioASC.UseVisualStyleBackColor = true;
            this.radioASC.CheckedChanged += new System.EventHandler(this.radioASC_CheckedChanged);
            // 
            // RadioDesc
            // 
            this.RadioDesc.AutoSize = true;
            this.RadioDesc.Location = new System.Drawing.Point(6, 69);
            this.RadioDesc.Name = "RadioDesc";
            this.RadioDesc.Size = new System.Drawing.Size(138, 20);
            this.RadioDesc.TabIndex = 5;
            this.RadioDesc.Text = "FiltarDescendente";
            this.RadioDesc.UseVisualStyleBackColor = true;
            this.RadioDesc.CheckedChanged += new System.EventHandler(this.RadioDesc_CheckedChanged);
            // 
            // chkfiltrarAuditoriaId
            // 
            this.chkfiltrarAuditoriaId.AutoSize = true;
            this.chkfiltrarAuditoriaId.Location = new System.Drawing.Point(177, 50);
            this.chkfiltrarAuditoriaId.Name = "chkfiltrarAuditoriaId";
            this.chkfiltrarAuditoriaId.Size = new System.Drawing.Size(150, 20);
            this.chkfiltrarAuditoriaId.TabIndex = 6;
            this.chkfiltrarAuditoriaId.Text = "FiltrarPorAuditoria Id";
            this.chkfiltrarAuditoriaId.UseVisualStyleBackColor = true;
            // 
            // txtAuditoriaId
            // 
            this.txtAuditoriaId.Location = new System.Drawing.Point(177, 76);
            this.txtAuditoriaId.Name = "txtAuditoriaId";
            this.txtAuditoriaId.Size = new System.Drawing.Size(178, 22);
            this.txtAuditoriaId.TabIndex = 7;
            // 
            // txtUsuarioId
            // 
            this.txtUsuarioId.Location = new System.Drawing.Point(391, 76);
            this.txtUsuarioId.Name = "txtUsuarioId";
            this.txtUsuarioId.Size = new System.Drawing.Size(175, 22);
            this.txtUsuarioId.TabIndex = 8;
            // 
            // chkiUsuarioId
            // 
            this.chkiUsuarioId.AutoSize = true;
            this.chkiUsuarioId.Location = new System.Drawing.Point(391, 50);
            this.chkiUsuarioId.Name = "chkiUsuarioId";
            this.chkiUsuarioId.Size = new System.Drawing.Size(144, 20);
            this.chkiUsuarioId.TabIndex = 9;
            this.chkiUsuarioId.Text = "FiltrarPorUsuario Id";
            this.chkiUsuarioId.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "AUDITORIAS";
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Location = new System.Drawing.Point(839, 58);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(152, 40);
            this.BtnActualizar.TabIndex = 11;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chkUsuarioNombre);
            this.groupBox1.Controls.Add(this.txtUsuarioNombre);
            this.groupBox1.Controls.Add(this.BtnActualizar);
            this.groupBox1.Controls.Add(this.chkiUsuarioId);
            this.groupBox1.Controls.Add(this.txtUsuarioId);
            this.groupBox1.Controls.Add(this.txtAuditoriaId);
            this.groupBox1.Controls.Add(this.chkfiltrarAuditoriaId);
            this.groupBox1.Controls.Add(this.RadioDesc);
            this.groupBox1.Controls.Add(this.radioASC);
            this.groupBox1.Location = new System.Drawing.Point(31, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1006, 104);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Panel de Filtros";
            // 
            // chkUsuarioNombre
            // 
            this.chkUsuarioNombre.AutoSize = true;
            this.chkUsuarioNombre.Location = new System.Drawing.Point(619, 50);
            this.chkUsuarioNombre.Name = "chkUsuarioNombre";
            this.chkUsuarioNombre.Size = new System.Drawing.Size(197, 20);
            this.chkUsuarioNombre.TabIndex = 13;
            this.chkUsuarioNombre.Text = "Buscar Por Nombre Usuario";
            this.chkUsuarioNombre.UseVisualStyleBackColor = true;
            this.chkUsuarioNombre.CheckedChanged += new System.EventHandler(this.chkUsuarioNombre_CheckedChanged);
            // 
            // txtUsuarioNombre
            // 
            this.txtUsuarioNombre.Location = new System.Drawing.Point(641, 76);
            this.txtUsuarioNombre.Name = "txtUsuarioNombre";
            this.txtUsuarioNombre.Size = new System.Drawing.Size(175, 22);
            this.txtUsuarioNombre.TabIndex = 12;
            this.txtUsuarioNombre.TextChanged += new System.EventHandler(this.txtUsuarioNombre_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(374, 567);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "label2";
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblTiempodeUso,
            this.lblTiempouso,
            this.lblUsuarioAuditoria});
            this.statusStrip1.Location = new System.Drawing.Point(0, 563);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1062, 26);
            this.statusStrip1.TabIndex = 14;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblTiempodeUso
            // 
            this.lblTiempodeUso.Name = "lblTiempodeUso";
            this.lblTiempodeUso.Size = new System.Drawing.Size(151, 20);
            this.lblTiempodeUso.Text = "toolStripStatusLabel1";
            // 
            // lblTiempouso
            // 
            this.lblTiempouso.Name = "lblTiempouso";
            this.lblTiempouso.Size = new System.Drawing.Size(0, 20);
            // 
            // lblUsuarioAuditoria
            // 
            this.lblUsuarioAuditoria.Name = "lblUsuarioAuditoria";
            this.lblUsuarioAuditoria.Size = new System.Drawing.Size(151, 20);
            this.lblUsuarioAuditoria.Text = "toolStripStatusLabel1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(582, 485);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(195, 40);
            this.button1.TabIndex = 15;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // FrmAuditoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(146)))), ((int)(((byte)(185)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(1062, 589);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDescargar);
            this.Controls.Add(this.dgvUsuarios);
            this.Name = "FrmAuditoria";
            this.Text = "FrmAuditoriacs";
            this.Load += new System.EventHandler(this.FrmAuditoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.Button btnDescargar;
        private System.Windows.Forms.RadioButton radioASC;
        private System.Windows.Forms.RadioButton RadioDesc;
        private System.Windows.Forms.CheckBox chkfiltrarAuditoriaId;
        private System.Windows.Forms.TextBox txtAuditoriaId;
        private System.Windows.Forms.TextBox txtUsuarioId;
        private System.Windows.Forms.CheckBox chkiUsuarioId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblTiempodeUso;
        private System.Windows.Forms.ToolStripStatusLabel lblTiempouso;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtUsuarioNombre;
        private System.Windows.Forms.CheckBox chkUsuarioNombre;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuarioAuditoria;
    }
}