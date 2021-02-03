namespace ProyecContable.Estados
{
    partial class FrmMensaje
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
            this.pBorder4 = new System.Windows.Forms.Panel();
            this.pBorder2 = new System.Windows.Forms.Panel();
            this.pBorder1 = new System.Windows.Forms.Panel();
            this.pBorder3 = new System.Windows.Forms.Panel();
            this.LblMensajeTitulo = new System.Windows.Forms.Label();
            this.LblMensaje = new System.Windows.Forms.Label();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.PbImagen = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbImagen)).BeginInit();
            this.SuspendLayout();
            // 
            // pBorder4
            // 
            this.pBorder4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(2)))), ((int)(((byte)(96)))), ((int)(((byte)(76)))));
            this.pBorder4.Dock = System.Windows.Forms.DockStyle.Left;
            this.pBorder4.Location = new System.Drawing.Point(0, 0);
            this.pBorder4.Name = "pBorder4";
            this.pBorder4.Size = new System.Drawing.Size(2, 105);
            this.pBorder4.TabIndex = 0;
            // 
            // pBorder2
            // 
            this.pBorder2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(2)))), ((int)(((byte)(96)))), ((int)(((byte)(76)))));
            this.pBorder2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pBorder2.Location = new System.Drawing.Point(555, 0);
            this.pBorder2.Name = "pBorder2";
            this.pBorder2.Size = new System.Drawing.Size(2, 105);
            this.pBorder2.TabIndex = 1;
            // 
            // pBorder1
            // 
            this.pBorder1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(2)))), ((int)(((byte)(96)))), ((int)(((byte)(76)))));
            this.pBorder1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pBorder1.Location = new System.Drawing.Point(2, 0);
            this.pBorder1.Name = "pBorder1";
            this.pBorder1.Size = new System.Drawing.Size(553, 2);
            this.pBorder1.TabIndex = 2;
            // 
            // pBorder3
            // 
            this.pBorder3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(2)))), ((int)(((byte)(96)))), ((int)(((byte)(76)))));
            this.pBorder3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pBorder3.Location = new System.Drawing.Point(2, 103);
            this.pBorder3.Name = "pBorder3";
            this.pBorder3.Size = new System.Drawing.Size(553, 2);
            this.pBorder3.TabIndex = 3;
            // 
            // LblMensajeTitulo
            // 
            this.LblMensajeTitulo.AutoSize = true;
            this.LblMensajeTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMensajeTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(2)))), ((int)(((byte)(96)))), ((int)(((byte)(76)))));
            this.LblMensajeTitulo.Location = new System.Drawing.Point(116, 23);
            this.LblMensajeTitulo.Name = "LblMensajeTitulo";
            this.LblMensajeTitulo.Size = new System.Drawing.Size(85, 29);
            this.LblMensajeTitulo.TabIndex = 5;
            this.LblMensajeTitulo.Text = "label1";
            // 
            // LblMensaje
            // 
            this.LblMensaje.AutoSize = true;
            this.LblMensaje.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblMensaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(2)))), ((int)(((byte)(96)))), ((int)(((byte)(76)))));
            this.LblMensaje.Location = new System.Drawing.Point(116, 57);
            this.LblMensaje.Name = "LblMensaje";
            this.LblMensaje.Size = new System.Drawing.Size(70, 25);
            this.LblMensaje.TabIndex = 6;
            this.LblMensaje.Text = "label2";
            // 
            // BtnSalir
            // 
            this.BtnSalir.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.Location = new System.Drawing.Point(713, 0);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(120, 101);
            this.BtnSalir.TabIndex = 7;
            this.BtnSalir.Text = "ACEPTAR";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // PbImagen
            // 
            this.PbImagen.Image = global::ProyecContable.Properties.Resources.ok_32px;
            this.PbImagen.Location = new System.Drawing.Point(12, 12);
            this.PbImagen.Name = "PbImagen";
            this.PbImagen.Size = new System.Drawing.Size(80, 80);
            this.PbImagen.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PbImagen.TabIndex = 4;
            this.PbImagen.TabStop = false;
            // 
            // FrmMensaje
            // 
            this.AcceptButton = this.BtnSalir;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(237)))), ((int)(((byte)(218)))));
            this.CancelButton = this.BtnSalir;
            this.ClientSize = new System.Drawing.Size(557, 105);
            this.Controls.Add(this.BtnSalir);
            this.Controls.Add(this.LblMensaje);
            this.Controls.Add(this.LblMensajeTitulo);
            this.Controls.Add(this.PbImagen);
            this.Controls.Add(this.pBorder3);
            this.Controls.Add(this.pBorder1);
            this.Controls.Add(this.pBorder2);
            this.Controls.Add(this.pBorder4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMensaje";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMensaje";
            ((System.ComponentModel.ISupportInitialize)(this.PbImagen)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pBorder4;
        private System.Windows.Forms.Panel pBorder2;
        private System.Windows.Forms.Panel pBorder1;
        private System.Windows.Forms.Panel pBorder3;
        private System.Windows.Forms.PictureBox PbImagen;
        private System.Windows.Forms.Label LblMensajeTitulo;
        private System.Windows.Forms.Label LblMensaje;
        private System.Windows.Forms.Button BtnSalir;
    }
}