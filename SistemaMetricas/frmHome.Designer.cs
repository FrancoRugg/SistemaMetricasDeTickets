namespace SistemaMetricas
{
    partial class frmHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHome));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbAreas = new System.Windows.Forms.ToolStripButton();
            this.tsbTipos = new System.Windows.Forms.ToolStripButton();
            this.tsbNuevoTicket = new System.Windows.Forms.ToolStripButton();
            this.tsbTickets = new System.Windows.Forms.ToolStripButton();
            this.tsbUsuarios = new System.Windows.Forms.ToolStripButton();
            this.tsbDashboard = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.lblRol = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbAreas,
            this.tsbTipos,
            this.tsbNuevoTicket,
            this.tsbTickets,
            this.tsbUsuarios,
            this.tsbDashboard});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(797, 31);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbAreas
            // 
            this.tsbAreas.Image = ((System.Drawing.Image)(resources.GetObject("tsbAreas.Image")));
            this.tsbAreas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbAreas.Name = "tsbAreas";
            this.tsbAreas.Size = new System.Drawing.Size(159, 28);
            this.tsbAreas.Text = "Configuración de Áreas";
            this.tsbAreas.Click += new System.EventHandler(this.tsbAreas_Click);
            // 
            // tsbTipos
            // 
            this.tsbTipos.Image = ((System.Drawing.Image)(resources.GetObject("tsbTipos.Image")));
            this.tsbTipos.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTipos.Name = "tsbTipos";
            this.tsbTipos.Size = new System.Drawing.Size(158, 28);
            this.tsbTipos.Text = "Configuración de Tipos";
            this.tsbTipos.ToolTipText = "Configuración de Tipos";
            this.tsbTipos.Click += new System.EventHandler(this.tsbTipos_Click);
            // 
            // tsbNuevoTicket
            // 
            this.tsbNuevoTicket.Image = global::SistemaMetricas.Properties.Resources.productos;
            this.tsbNuevoTicket.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNuevoTicket.Name = "tsbNuevoTicket";
            this.tsbNuevoTicket.Size = new System.Drawing.Size(101, 28);
            this.tsbNuevoTicket.Text = "NuevoTicket";
            this.tsbNuevoTicket.ToolTipText = "Nuevo Ticket";
            this.tsbNuevoTicket.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // tsbTickets
            // 
            this.tsbTickets.Image = global::SistemaMetricas.Properties.Resources.historial;
            this.tsbTickets.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbTickets.Name = "tsbTickets";
            this.tsbTickets.Size = new System.Drawing.Size(85, 28);
            this.tsbTickets.Text = "Tickets(0)";
            this.tsbTickets.Click += new System.EventHandler(this.tsbTickets_Click);
            // 
            // tsbUsuarios
            // 
            this.tsbUsuarios.Image = global::SistemaMetricas.Properties.Resources._0__5_;
            this.tsbUsuarios.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbUsuarios.Name = "tsbUsuarios";
            this.tsbUsuarios.Size = new System.Drawing.Size(80, 28);
            this.tsbUsuarios.Text = "Usuarios";
            this.tsbUsuarios.Click += new System.EventHandler(this.tsbUsuarios_Click);
            // 
            // tsbDashboard
            // 
            this.tsbDashboard.Image = ((System.Drawing.Image)(resources.GetObject("tsbDashboard.Image")));
            this.tsbDashboard.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbDashboard.Name = "tsbDashboard";
            this.tsbDashboard.Size = new System.Drawing.Size(92, 28);
            this.tsbDashboard.Text = "Dashboard";
            this.tsbDashboard.Click += new System.EventHandler(this.tsbDashboard_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblUser});
            this.statusStrip1.Location = new System.Drawing.Point(0, 391);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 9, 0);
            this.statusStrip1.Size = new System.Drawing.Size(797, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblUser
            // 
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(0, 17);
            // 
            // pnlContainer
            // 
            this.pnlContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlContainer.BackColor = System.Drawing.Color.White;
            this.pnlContainer.Location = new System.Drawing.Point(0, 26);
            this.pnlContainer.Margin = new System.Windows.Forms.Padding(2);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(797, 372);
            this.pnlContainer.TabIndex = 2;
            // 
            // lblRol
            // 
            this.lblRol.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRol.AutoSize = true;
            this.lblRol.Location = new System.Drawing.Point(136, 400);
            this.lblRol.Name = "lblRol";
            this.lblRol.Size = new System.Drawing.Size(0, 13);
            this.lblRol.TabIndex = 0;
            this.lblRol.Click += new System.EventHandler(this.label1_Click);
            // 
            // frmHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(797, 413);
            this.Controls.Add(this.lblRol);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmHome";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmHome_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbAreas;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblUser;
        private System.Windows.Forms.Panel pnlContainer;
        private System.Windows.Forms.ToolStripButton tsbTipos;
        private System.Windows.Forms.ToolStripButton tsbNuevoTicket;
        private System.Windows.Forms.ToolStripButton tsbTickets;
        private System.Windows.Forms.ToolStripButton tsbUsuarios;
        private System.Windows.Forms.ToolStripButton tsbDashboard;
        private System.Windows.Forms.Label lblRol;
    }
}