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
            this.fechaingresostatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.tiempousostatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTiempoUso = new System.Windows.Forms.StatusStrip();
            this.btnDescargar = new System.Windows.Forms.Button();
            this.radioASC = new System.Windows.Forms.RadioButton();
            this.RadioDesc = new System.Windows.Forms.RadioButton();
            this.chkFiltrarUsuario = new System.Windows.Forms.CheckBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.chkiId = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnActualizar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).BeginInit();
            this.lblFechaIngreso.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUsuarios
            // 
            this.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuarios.Location = new System.Drawing.Point(40, 144);
            this.dgvUsuarios.Name = "dgvUsuarios";
            this.dgvUsuarios.RowHeadersWidth = 51;
            this.dgvUsuarios.Size = new System.Drawing.Size(950, 321);
            this.dgvUsuarios.TabIndex = 0;
            this.dgvUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuarios_CellContentClick);
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.lblFechaIngreso.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fechaingresostatus,
            this.tiempousostatus});
            this.lblFechaIngreso.Location = new System.Drawing.Point(0, 563);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(1062, 26);
            this.lblFechaIngreso.TabIndex = 1;
            this.lblFechaIngreso.Text = "statusStrip1";
            // 
            // fechaingresostatus
            // 
            this.fechaingresostatus.Name = "fechaingresostatus";
            this.fechaingresostatus.Size = new System.Drawing.Size(151, 20);
            this.fechaingresostatus.Text = "toolStripStatusLabel1";
            // 
            // tiempousostatus
            // 
            this.tiempousostatus.Name = "tiempousostatus";
            this.tiempousostatus.Size = new System.Drawing.Size(151, 20);
            this.tiempousostatus.Text = "toolStripStatusLabel2";
            // 
            // lblTiempoUso
            // 
            this.lblTiempoUso.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.lblTiempoUso.Location = new System.Drawing.Point(0, 541);
            this.lblTiempoUso.Name = "lblTiempoUso";
            this.lblTiempoUso.Size = new System.Drawing.Size(1062, 22);
            this.lblTiempoUso.TabIndex = 2;
            this.lblTiempoUso.Text = "statusStrip2";
            // 
            // btnDescargar
            // 
            this.btnDescargar.Location = new System.Drawing.Point(783, 471);
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
            this.radioASC.Location = new System.Drawing.Point(17, 12);
            this.radioASC.Name = "radioASC";
            this.radioASC.Size = new System.Drawing.Size(123, 19);
            this.radioASC.TabIndex = 4;
            this.radioASC.TabStop = true;
            this.radioASC.Text = "FiltrarAscendente";
            this.radioASC.UseVisualStyleBackColor = true;
            this.radioASC.CheckedChanged += new System.EventHandler(this.radioASC_CheckedChanged);
            // 
            // RadioDesc
            // 
            this.RadioDesc.AutoSize = true;
            this.RadioDesc.Location = new System.Drawing.Point(17, 47);
            this.RadioDesc.Name = "RadioDesc";
            this.RadioDesc.Size = new System.Drawing.Size(128, 19);
            this.RadioDesc.TabIndex = 5;
            this.RadioDesc.Text = "FiltarDescendente";
            this.RadioDesc.UseVisualStyleBackColor = true;
            // 
            // chkFiltrarUsuario
            // 
            this.chkFiltrarUsuario.AutoSize = true;
            this.chkFiltrarUsuario.Location = new System.Drawing.Point(197, 12);
            this.chkFiltrarUsuario.Name = "chkFiltrarUsuario";
            this.chkFiltrarUsuario.Size = new System.Drawing.Size(122, 19);
            this.chkFiltrarUsuario.TabIndex = 6;
            this.chkFiltrarUsuario.Text = "FiltrarPorUsuario";
            this.chkFiltrarUsuario.UseVisualStyleBackColor = true;
            this.chkFiltrarUsuario.CheckedChanged += new System.EventHandler(this.chkFiltrarUsuario_CheckedChanged);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(197, 37);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(187, 20);
            this.txtUsuario.TabIndex = 7;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(447, 37);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(175, 20);
            this.txtDni.TabIndex = 8;
            // 
            // chkiId
            // 
            this.chkiId.AutoSize = true;
            this.chkiId.Location = new System.Drawing.Point(447, 12);
            this.chkiId.Name = "chkiId";
            this.chkiId.Size = new System.Drawing.Size(89, 19);
            this.chkiId.TabIndex = 9;
            this.chkiId.Text = "FiltrarPorId";
            this.chkiId.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 15);
            this.label1.TabIndex = 10;
            this.label1.Text = "AUDITORIAS";
            // 
            // BtnActualizar
            // 
            this.BtnActualizar.Location = new System.Drawing.Point(669, 26);
            this.BtnActualizar.Name = "BtnActualizar";
            this.BtnActualizar.Size = new System.Drawing.Size(152, 40);
            this.BtnActualizar.TabIndex = 11;
            this.BtnActualizar.Text = "Actualizar";
            this.BtnActualizar.UseVisualStyleBackColor = true;
            this.BtnActualizar.Click += new System.EventHandler(this.BtnActualizar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtnActualizar);
            this.groupBox1.Controls.Add(this.chkiId);
            this.groupBox1.Controls.Add(this.txtDni);
            this.groupBox1.Controls.Add(this.txtUsuario);
            this.groupBox1.Controls.Add(this.chkFiltrarUsuario);
            this.groupBox1.Controls.Add(this.RadioDesc);
            this.groupBox1.Controls.Add(this.radioASC);
            this.groupBox1.Location = new System.Drawing.Point(91, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(887, 104);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Panel de Filtros";
            // 
            // FrmAuditoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 589);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDescargar);
            this.Controls.Add(this.lblTiempoUso);
            this.Controls.Add(this.lblFechaIngreso);
            this.Controls.Add(this.dgvUsuarios);
            this.Name = "FrmAuditoria";
            this.Text = "FrmAuditoriacs";
            this.Load += new System.EventHandler(this.FrmAuditoria_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuarios)).EndInit();
            this.lblFechaIngreso.ResumeLayout(false);
            this.lblFechaIngreso.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUsuarios;
        private System.Windows.Forms.StatusStrip lblFechaIngreso;
        private System.Windows.Forms.StatusStrip lblTiempoUso;
        private System.Windows.Forms.ToolStripStatusLabel fechaingresostatus;
        private System.Windows.Forms.ToolStripStatusLabel tiempousostatus;
        private System.Windows.Forms.Button btnDescargar;
        private System.Windows.Forms.RadioButton radioASC;
        private System.Windows.Forms.RadioButton RadioDesc;
        private System.Windows.Forms.CheckBox chkFiltrarUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.CheckBox chkiId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnActualizar;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}