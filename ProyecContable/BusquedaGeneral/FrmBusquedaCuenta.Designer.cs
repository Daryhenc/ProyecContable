
namespace ProyecContable.BusquedaGeneral
{
    partial class FrmBusquedaCuenta
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.DgvData = new System.Windows.Forms.DataGridView();
            this.panel7 = new System.Windows.Forms.Panel();
            this.TxtCuenta = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.BtnSalir = new System.Windows.Forms.Button();
            this.BtnAceptar = new System.Windows.Forms.Button();
            this.IDCuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDJ3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDJ4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDJ5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Codigos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cuanta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).BeginInit();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.HotPink;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(817, 3);
            this.panel2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.HotPink;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 3);
            this.panel1.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 724);
            this.panel1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.HotPink;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(814, 3);
            this.panel3.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(3, 724);
            this.panel3.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.HotPink;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(3, 724);
            this.panel4.Margin = new System.Windows.Forms.Padding(6, 8, 6, 8);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(811, 3);
            this.panel4.TabIndex = 6;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Pink;
            this.panel6.Controls.Add(this.label1);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(3, 3);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(811, 43);
            this.panel6.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(369, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "BUSQUEDA DE CUENTAS";
            // 
            // DgvData
            // 
            this.DgvData.AllowUserToAddRows = false;
            this.DgvData.AllowUserToDeleteRows = false;
            this.DgvData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvData.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDCuenta,
            this.IDJ3,
            this.IDJ4,
            this.IDJ5,
            this.Codigos,
            this.Cuanta});
            this.DgvData.Dock = System.Windows.Forms.DockStyle.Top;
            this.DgvData.Location = new System.Drawing.Point(3, 46);
            this.DgvData.MultiSelect = false;
            this.DgvData.Name = "DgvData";
            this.DgvData.ReadOnly = true;
            this.DgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvData.Size = new System.Drawing.Size(811, 583);
            this.DgvData.TabIndex = 10;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.TxtCuenta);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Controls.Add(this.TxtCodigo);
            this.panel7.Controls.Add(this.label2);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(3, 629);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(811, 33);
            this.panel7.TabIndex = 11;
            // 
            // TxtCuenta
            // 
            this.TxtCuenta.Dock = System.Windows.Forms.DockStyle.Left;
            this.TxtCuenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCuenta.Location = new System.Drawing.Point(521, 0);
            this.TxtCuenta.Name = "TxtCuenta";
            this.TxtCuenta.Size = new System.Drawing.Size(377, 31);
            this.TxtCuenta.TabIndex = 3;
            this.TxtCuenta.TextChanged += new System.EventHandler(this.TxtCuenta_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(403, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "CUENTA";
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Dock = System.Windows.Forms.DockStyle.Left;
            this.TxtCodigo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtCodigo.Location = new System.Drawing.Point(115, 0);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(288, 31);
            this.TxtCodigo.TabIndex = 1;
            this.TxtCodigo.TextChanged += new System.EventHandler(this.TxtCodigo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "CODIGO";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.BtnSalir);
            this.panel5.Controls.Add(this.BtnAceptar);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 662);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(811, 62);
            this.panel5.TabIndex = 12;
            // 
            // BtnSalir
            // 
            this.BtnSalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnSalir.FlatAppearance.BorderSize = 0;
            this.BtnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSalir.ForeColor = System.Drawing.Color.Maroon;
            this.BtnSalir.Location = new System.Drawing.Point(681, 0);
            this.BtnSalir.Name = "BtnSalir";
            this.BtnSalir.Size = new System.Drawing.Size(130, 62);
            this.BtnSalir.TabIndex = 1;
            this.BtnSalir.Text = "SALIR";
            this.BtnSalir.UseVisualStyleBackColor = true;
            this.BtnSalir.Click += new System.EventHandler(this.BtnSalir_Click);
            // 
            // BtnAceptar
            // 
            this.BtnAceptar.Dock = System.Windows.Forms.DockStyle.Left;
            this.BtnAceptar.FlatAppearance.BorderSize = 0;
            this.BtnAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAceptar.ForeColor = System.Drawing.Color.Maroon;
            this.BtnAceptar.Location = new System.Drawing.Point(0, 0);
            this.BtnAceptar.Name = "BtnAceptar";
            this.BtnAceptar.Size = new System.Drawing.Size(130, 62);
            this.BtnAceptar.TabIndex = 0;
            this.BtnAceptar.Text = "ACEPTAR";
            this.BtnAceptar.UseVisualStyleBackColor = true;
            this.BtnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // IDCuenta
            // 
            this.IDCuenta.HeaderText = "IDCuentaMovimiento";
            this.IDCuenta.Name = "IDCuenta";
            this.IDCuenta.ReadOnly = true;
            this.IDCuenta.Visible = false;
            // 
            // IDJ3
            // 
            this.IDJ3.HeaderText = "IDJ3";
            this.IDJ3.Name = "IDJ3";
            this.IDJ3.ReadOnly = true;
            this.IDJ3.Visible = false;
            // 
            // IDJ4
            // 
            this.IDJ4.HeaderText = "IDJ4";
            this.IDJ4.Name = "IDJ4";
            this.IDJ4.ReadOnly = true;
            this.IDJ4.Visible = false;
            // 
            // IDJ5
            // 
            this.IDJ5.HeaderText = "IDJ5";
            this.IDJ5.Name = "IDJ5";
            this.IDJ5.ReadOnly = true;
            this.IDJ5.Visible = false;
            // 
            // Codigos
            // 
            this.Codigos.HeaderText = "CODIGO";
            this.Codigos.Name = "Codigos";
            this.Codigos.ReadOnly = true;
            this.Codigos.Width = 200;
            // 
            // Cuanta
            // 
            this.Cuanta.HeaderText = "CUENTA";
            this.Cuanta.Name = "Cuanta";
            this.Cuanta.ReadOnly = true;
            this.Cuanta.Width = 550;
            // 
            // FrmBusquedaCuenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 727);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.DgvData);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmBusquedaCuenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmBusquedaCuenta";
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvData)).EndInit();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView DgvData;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox TxtCuenta;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button BtnSalir;
        private System.Windows.Forms.Button BtnAceptar;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDCuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDJ3;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDJ4;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDJ5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cuanta;
    }
}