namespace ProyecContable.Cuentas
{
    partial class FrmMenuCreacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenuCreacion));
            this.PanelMenuCerrar = new System.Windows.Forms.Panel();
            this.BtnNuevo = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.PanelContenedorHijo = new System.Windows.Forms.Panel();
            this.TTMensasje = new System.Windows.Forms.ToolTip(this.components);
            this.BtnReteNuevo = new System.Windows.Forms.Button();
            this.BtnReporte = new System.Windows.Forms.Button();
            this.PanelMenuCerrar.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelMenuCerrar
            // 
            this.PanelMenuCerrar.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.PanelMenuCerrar.Controls.Add(this.BtnReporte);
            this.PanelMenuCerrar.Controls.Add(this.BtnReteNuevo);
            this.PanelMenuCerrar.Controls.Add(this.BtnNuevo);
            this.PanelMenuCerrar.Controls.Add(this.label2);
            this.PanelMenuCerrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelMenuCerrar.Location = new System.Drawing.Point(0, 0);
            this.PanelMenuCerrar.Name = "PanelMenuCerrar";
            this.PanelMenuCerrar.Size = new System.Drawing.Size(1261, 61);
            this.PanelMenuCerrar.TabIndex = 240;
            // 
            // BtnNuevo
            // 
            this.BtnNuevo.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnNuevo.FlatAppearance.BorderSize = 0;
            this.BtnNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNuevo.Image = ((System.Drawing.Image)(resources.GetObject("BtnNuevo.Image")));
            this.BtnNuevo.Location = new System.Drawing.Point(1181, 0);
            this.BtnNuevo.Name = "BtnNuevo";
            this.BtnNuevo.Size = new System.Drawing.Size(80, 61);
            this.BtnNuevo.TabIndex = 3;
            this.BtnNuevo.UseVisualStyleBackColor = true;
            this.BtnNuevo.Click += new System.EventHandler(this.BtnNuevo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(26, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(392, 37);
            this.label2.TabIndex = 2;
            this.label2.Text = "CUENTAS CONTABLES";
            // 
            // PanelContenedorHijo
            // 
            this.PanelContenedorHijo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PanelContenedorHijo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedorHijo.Location = new System.Drawing.Point(0, 61);
            this.PanelContenedorHijo.Name = "PanelContenedorHijo";
            this.PanelContenedorHijo.Size = new System.Drawing.Size(1261, 779);
            this.PanelContenedorHijo.TabIndex = 241;
            // 
            // BtnReteNuevo
            // 
            this.BtnReteNuevo.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnReteNuevo.FlatAppearance.BorderSize = 0;
            this.BtnReteNuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReteNuevo.Image = ((System.Drawing.Image)(resources.GetObject("BtnReteNuevo.Image")));
            this.BtnReteNuevo.Location = new System.Drawing.Point(1101, 0);
            this.BtnReteNuevo.Name = "BtnReteNuevo";
            this.BtnReteNuevo.Size = new System.Drawing.Size(80, 61);
            this.BtnReteNuevo.TabIndex = 5;
            this.BtnReteNuevo.UseVisualStyleBackColor = true;
            this.BtnReteNuevo.Click += new System.EventHandler(this.BtnReteNuevo_Click);
            // 
            // BtnReporte
            // 
            this.BtnReporte.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnReporte.FlatAppearance.BorderSize = 0;
            this.BtnReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnReporte.Image = ((System.Drawing.Image)(resources.GetObject("BtnReporte.Image")));
            this.BtnReporte.Location = new System.Drawing.Point(1021, 0);
            this.BtnReporte.Name = "BtnReporte";
            this.BtnReporte.Size = new System.Drawing.Size(80, 61);
            this.BtnReporte.TabIndex = 6;
            this.BtnReporte.UseVisualStyleBackColor = true;
            this.BtnReporte.Click += new System.EventHandler(this.BtnReporte_Click);
            // 
            // FrmMenuCreacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 840);
            this.Controls.Add(this.PanelContenedorHijo);
            this.Controls.Add(this.PanelMenuCerrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMenuCreacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMenuCreacion";
            this.PanelMenuCerrar.ResumeLayout(false);
            this.PanelMenuCerrar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelMenuCerrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BtnNuevo;
        private System.Windows.Forms.Panel PanelContenedorHijo;
        private System.Windows.Forms.ToolTip TTMensasje;
        private System.Windows.Forms.Button BtnReteNuevo;
        private System.Windows.Forms.Button BtnReporte;
    }
}