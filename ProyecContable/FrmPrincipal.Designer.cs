namespace ProyecContable
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.BtnMovimientos = new System.Windows.Forms.Button();
            this.BtnCuentas = new System.Windows.Forms.Button();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.Cerrar = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.PanelContenedorHijo = new System.Windows.Forms.Panel();
            this.panel7.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1430, 3);
            this.panel3.TabIndex = 2;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 843);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1430, 3);
            this.panel4.TabIndex = 3;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(0, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(3, 840);
            this.panel5.TabIndex = 4;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(1427, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(3, 840);
            this.panel6.TabIndex = 6;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel7.Controls.Add(this.BtnMovimientos);
            this.panel7.Controls.Add(this.BtnCuentas);
            this.panel7.Controls.Add(this.panel10);
            this.panel7.Controls.Add(this.panel9);
            this.panel7.Controls.Add(this.panel8);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(3, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(163, 840);
            this.panel7.TabIndex = 8;
            // 
            // BtnMovimientos
            // 
            this.BtnMovimientos.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnMovimientos.FlatAppearance.BorderSize = 0;
            this.BtnMovimientos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMovimientos.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMovimientos.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnMovimientos.Location = new System.Drawing.Point(0, 303);
            this.BtnMovimientos.Name = "BtnMovimientos";
            this.BtnMovimientos.Size = new System.Drawing.Size(163, 89);
            this.BtnMovimientos.TabIndex = 5;
            this.BtnMovimientos.Text = "ASIENTO";
            this.BtnMovimientos.UseVisualStyleBackColor = true;
            this.BtnMovimientos.Click += new System.EventHandler(this.BtnMovimientos_Click);
            // 
            // BtnCuentas
            // 
            this.BtnCuentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnCuentas.FlatAppearance.BorderSize = 0;
            this.BtnCuentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCuentas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCuentas.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnCuentas.Location = new System.Drawing.Point(0, 214);
            this.BtnCuentas.Name = "BtnCuentas";
            this.BtnCuentas.Size = new System.Drawing.Size(163, 89);
            this.BtnCuentas.TabIndex = 4;
            this.BtnCuentas.Text = "CUENTAS";
            this.BtnCuentas.UseVisualStyleBackColor = true;
            this.BtnCuentas.Click += new System.EventHandler(this.BtnCuentas_Click);
            // 
            // panel10
            // 
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 154);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(163, 60);
            this.panel10.TabIndex = 3;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.Cerrar);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel9.Location = new System.Drawing.Point(0, 751);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(163, 89);
            this.panel9.TabIndex = 1;
            // 
            // Cerrar
            // 
            this.Cerrar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cerrar.FlatAppearance.BorderSize = 0;
            this.Cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cerrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cerrar.ForeColor = System.Drawing.SystemColors.Control;
            this.Cerrar.Location = new System.Drawing.Point(0, 0);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(163, 89);
            this.Cerrar.TabIndex = 1;
            this.Cerrar.Text = "SALIR";
            this.Cerrar.UseVisualStyleBackColor = true;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.pbLogo);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(0, 0);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(163, 154);
            this.panel8.TabIndex = 0;
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.Color.Transparent;
            this.pbLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbLogo.Image = ((System.Drawing.Image)(resources.GetObject("pbLogo.Image")));
            this.pbLogo.Location = new System.Drawing.Point(0, 0);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(1);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(163, 154);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 76;
            this.pbLogo.TabStop = false;
            // 
            // PanelContenedorHijo
            // 
            this.PanelContenedorHijo.BackColor = System.Drawing.Color.Gray;
            this.PanelContenedorHijo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelContenedorHijo.Location = new System.Drawing.Point(166, 3);
            this.PanelContenedorHijo.Name = "PanelContenedorHijo";
            this.PanelContenedorHijo.Size = new System.Drawing.Size(1261, 840);
            this.PanelContenedorHijo.TabIndex = 10;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1430, 846);
            this.Controls.Add(this.PanelContenedorHijo);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmPrincipal";
            this.panel7.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Button Cerrar;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Button BtnCuentas;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel PanelContenedorHijo;
        private System.Windows.Forms.Button BtnMovimientos;
    }
}