namespace SistemaMetricas
{
    partial class frmReportes
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
            this.components = new System.ComponentModel.Container();
            this.btnPendientes = new System.Windows.Forms.Button();
            this.btnTermindos = new System.Windows.Forms.Button();
            this.btnEn_Curso = new System.Windows.Forms.Button();
            this.btnRechazados = new System.Windows.Forms.Button();
            this.grdDatos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPendientes
            // 
            this.btnPendientes.BackColor = System.Drawing.Color.Goldenrod;
            this.btnPendientes.ForeColor = System.Drawing.SystemColors.Control;
            this.btnPendientes.Location = new System.Drawing.Point(1, 51);
            this.btnPendientes.Name = "btnPendientes";
            this.btnPendientes.Size = new System.Drawing.Size(182, 84);
            this.btnPendientes.TabIndex = 0;
            this.btnPendientes.Text = "Pendientes";
            this.btnPendientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPendientes.UseVisualStyleBackColor = false;
            this.btnPendientes.Click += new System.EventHandler(this.btnPendientes_Click);
            // 
            // btnTermindos
            // 
            this.btnTermindos.BackColor = System.Drawing.Color.LawnGreen;
            this.btnTermindos.ForeColor = System.Drawing.SystemColors.Control;
            this.btnTermindos.Location = new System.Drawing.Point(187, 51);
            this.btnTermindos.Name = "btnTermindos";
            this.btnTermindos.Size = new System.Drawing.Size(188, 84);
            this.btnTermindos.TabIndex = 1;
            this.btnTermindos.Text = "Terminados";
            this.btnTermindos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTermindos.UseVisualStyleBackColor = false;
            this.btnTermindos.Click += new System.EventHandler(this.btnTermindos_Click);
            // 
            // btnEn_Curso
            // 
            this.btnEn_Curso.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnEn_Curso.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEn_Curso.Location = new System.Drawing.Point(584, 51);
            this.btnEn_Curso.Name = "btnEn_Curso";
            this.btnEn_Curso.Size = new System.Drawing.Size(213, 84);
            this.btnEn_Curso.TabIndex = 3;
            this.btnEn_Curso.Text = "En Curso";
            this.btnEn_Curso.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEn_Curso.UseVisualStyleBackColor = false;
            this.btnEn_Curso.Click += new System.EventHandler(this.btnEn_Curso_Click);
            // 
            // btnRechazados
            // 
            this.btnRechazados.BackColor = System.Drawing.Color.Red;
            this.btnRechazados.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRechazados.Location = new System.Drawing.Point(381, 51);
            this.btnRechazados.Name = "btnRechazados";
            this.btnRechazados.Size = new System.Drawing.Size(197, 84);
            this.btnRechazados.TabIndex = 2;
            this.btnRechazados.Text = "Rechazados";
            this.btnRechazados.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRechazados.UseVisualStyleBackColor = false;
            this.btnRechazados.Click += new System.EventHandler(this.btnRechazados_Click);
            // 
            // grdDatos
            // 
            this.grdDatos.AllowUserToAddRows = false;
            this.grdDatos.AllowUserToDeleteRows = false;
            this.grdDatos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdDatos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatos.ContextMenuStrip = this.contextMenuStrip1;
            this.grdDatos.Location = new System.Drawing.Point(1, 195);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.ReadOnly = true;
            this.grdDatos.Size = new System.Drawing.Size(798, 253);
            this.grdDatos.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Filtros";
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Items.AddRange(new object[] {
            "Todos",
            "Titulo",
            "Area",
            "Prioridad",
            "Tipos",
            "FechaAlta",
            "Estado"});
            this.cmbFiltro.Location = new System.Drawing.Point(13, 163);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(121, 21);
            this.cmbFiltro.TabIndex = 6;
            this.cmbFiltro.SelectedIndexChanged += new System.EventHandler(this.cmbFiltro_SelectedIndexChanged);
            // 
            // txtFiltro
            // 
            this.txtFiltro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtFiltro.Location = new System.Drawing.Point(140, 163);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(646, 20);
            this.txtFiltro.TabIndex = 7;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(10, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Reportes";
            // 
            // lblTotal
            // 
            this.lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(12, 35);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(37, 13);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "Total :";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "Exportar HTML";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.cmbFiltro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdDatos);
            this.Controls.Add(this.btnEn_Curso);
            this.Controls.Add(this.btnRechazados);
            this.Controls.Add(this.btnTermindos);
            this.Controls.Add(this.btnPendientes);
            this.Name = "frmReportes";
            this.Text = "frmReportes";
            this.Load += new System.EventHandler(this.frmReportes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPendientes;
        private System.Windows.Forms.Button btnTermindos;
        private System.Windows.Forms.Button btnEn_Curso;
        private System.Windows.Forms.Button btnRechazados;
        private System.Windows.Forms.DataGridView grdDatos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFiltro;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
    }
}