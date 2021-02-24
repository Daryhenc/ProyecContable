namespace ProyecContable.Asientos.BusquedaAsiento
{
    partial class FrmBusquedaAsiento
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmBusquedaAsiento));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.DgvDatos = new System.Windows.Forms.DataGridView();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.CbTComprobante = new System.Windows.Forms.ComboBox();
            this.TxtBuscarConceptoGeneral = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtBusquedaFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBusquedaFechaFinal = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnVariado = new System.Windows.Forms.Button();
            this.BtnMes = new System.Windows.Forms.Button();
            this.BtnSemana = new System.Windows.Forms.Button();
            this.BtnDia = new System.Windows.Forms.Button();
            this.PanelBusqueda = new System.Windows.Forms.Panel();
            this.panelDetalle = new System.Windows.Forms.Panel();
            this.TxtIDAsiento = new System.Windows.Forms.TextBox();
            this.TxtFecha = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.TxtTComprobante = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtComprobante = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtConceptoGeneral = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtDocReferencia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.BtnVolver = new System.Windows.Forms.Button();
            this.BtnBorrar = new System.Windows.Forms.Button();
            this.DgvCuentas = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Concepto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Haber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Detalle = new System.Windows.Forms.DataGridViewImageColumn();
            this.IDAsiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TComp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NComp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Doc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Concep = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DgvDatos)).BeginInit();
            this.panel8.SuspendLayout();
            this.PanelBusqueda.SuspendLayout();
            this.panelDetalle.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCuentas)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.SteelBlue;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(1258, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 780);
            this.panel2.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 780);
            this.panel1.TabIndex = 7;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.SteelBlue;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(3, 777);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1255, 3);
            this.panel3.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.SteelBlue;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1255, 3);
            this.panel4.TabIndex = 9;
            // 
            // DgvDatos
            // 
            this.DgvDatos.AllowUserToAddRows = false;
            this.DgvDatos.AllowUserToDeleteRows = false;
            this.DgvDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvDatos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Detalle,
            this.IDAsiento,
            this.Fecha,
            this.TComp,
            this.NComp,
            this.Doc,
            this.Concep});
            this.DgvDatos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DgvDatos.Location = new System.Drawing.Point(0, 0);
            this.DgvDatos.Name = "DgvDatos";
            this.DgvDatos.ReadOnly = true;
            this.DgvDatos.Size = new System.Drawing.Size(1234, 606);
            this.DgvDatos.TabIndex = 10;
            this.DgvDatos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDatos_CellClick);
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.label3);
            this.panel8.Controls.Add(this.CbTComprobante);
            this.panel8.Controls.Add(this.TxtBuscarConceptoGeneral);
            this.panel8.Controls.Add(this.label4);
            this.panel8.Controls.Add(this.TxtBusquedaFechaInicio);
            this.panel8.Controls.Add(this.label2);
            this.panel8.Controls.Add(this.TxtBusquedaFechaFinal);
            this.panel8.Controls.Add(this.label1);
            this.panel8.Controls.Add(this.BtnVariado);
            this.panel8.Controls.Add(this.BtnMes);
            this.panel8.Controls.Add(this.BtnSemana);
            this.panel8.Controls.Add(this.BtnDia);
            this.panel8.Location = new System.Drawing.Point(3, 635);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1255, 142);
            this.panel8.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(15)))), ((int)(((byte)(16)))));
            this.label3.Location = new System.Drawing.Point(13, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 25);
            this.label3.TabIndex = 301;
            this.label3.Text = "TIPO COMPROBANTE";
            // 
            // CbTComprobante
            // 
            this.CbTComprobante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbTComprobante.FormattingEnabled = true;
            this.CbTComprobante.Location = new System.Drawing.Point(14, 41);
            this.CbTComprobante.Name = "CbTComprobante";
            this.CbTComprobante.Size = new System.Drawing.Size(348, 28);
            this.CbTComprobante.TabIndex = 0;
            // 
            // TxtBuscarConceptoGeneral
            // 
            this.TxtBuscarConceptoGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBuscarConceptoGeneral.Location = new System.Drawing.Point(368, 41);
            this.TxtBuscarConceptoGeneral.Name = "TxtBuscarConceptoGeneral";
            this.TxtBuscarConceptoGeneral.Size = new System.Drawing.Size(352, 29);
            this.TxtBuscarConceptoGeneral.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(15)))), ((int)(((byte)(16)))));
            this.label4.Location = new System.Drawing.Point(368, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 25);
            this.label4.TabIndex = 298;
            this.label4.Text = "CONCEPTO GENERAL";
            // 
            // TxtBusquedaFechaInicio
            // 
            this.TxtBusquedaFechaInicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBusquedaFechaInicio.Location = new System.Drawing.Point(14, 98);
            this.TxtBusquedaFechaInicio.Name = "TxtBusquedaFechaInicio";
            this.TxtBusquedaFechaInicio.Size = new System.Drawing.Size(348, 29);
            this.TxtBusquedaFechaInicio.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(15)))), ((int)(((byte)(16)))));
            this.label2.Location = new System.Drawing.Point(368, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 24);
            this.label2.TabIndex = 297;
            this.label2.Text = "FECHA FINAL";
            // 
            // TxtBusquedaFechaFinal
            // 
            this.TxtBusquedaFechaFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtBusquedaFechaFinal.Location = new System.Drawing.Point(368, 98);
            this.TxtBusquedaFechaFinal.Name = "TxtBusquedaFechaFinal";
            this.TxtBusquedaFechaFinal.Size = new System.Drawing.Size(352, 29);
            this.TxtBusquedaFechaFinal.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(15)))), ((int)(((byte)(16)))));
            this.label1.Location = new System.Drawing.Point(14, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(146, 24);
            this.label1.TabIndex = 296;
            this.label1.Text = "FECHA INICIO";
            // 
            // BtnVariado
            // 
            this.BtnVariado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(171)))), ((int)(((byte)(156)))));
            this.BtnVariado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnVariado.BackgroundImage")));
            this.BtnVariado.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnVariado.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnVariado.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(75)))), ((int)(((byte)(62)))));
            this.BtnVariado.FlatAppearance.BorderSize = 2;
            this.BtnVariado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVariado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVariado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(15)))), ((int)(((byte)(16)))));
            this.BtnVariado.Location = new System.Drawing.Point(739, 0);
            this.BtnVariado.Name = "BtnVariado";
            this.BtnVariado.Size = new System.Drawing.Size(129, 142);
            this.BtnVariado.TabIndex = 4;
            this.BtnVariado.Text = "VARIADO";
            this.BtnVariado.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnVariado.UseVisualStyleBackColor = false;
            this.BtnVariado.Click += new System.EventHandler(this.BtnVariado_Click);
            // 
            // BtnMes
            // 
            this.BtnMes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(171)))), ((int)(((byte)(156)))));
            this.BtnMes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnMes.BackgroundImage")));
            this.BtnMes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnMes.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnMes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(75)))), ((int)(((byte)(62)))));
            this.BtnMes.FlatAppearance.BorderSize = 2;
            this.BtnMes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnMes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(15)))), ((int)(((byte)(16)))));
            this.BtnMes.Location = new System.Drawing.Point(868, 0);
            this.BtnMes.Name = "BtnMes";
            this.BtnMes.Size = new System.Drawing.Size(129, 142);
            this.BtnMes.TabIndex = 5;
            this.BtnMes.Text = "MES";
            this.BtnMes.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnMes.UseVisualStyleBackColor = false;
            this.BtnMes.Click += new System.EventHandler(this.BtnMes_Click);
            // 
            // BtnSemana
            // 
            this.BtnSemana.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(171)))), ((int)(((byte)(156)))));
            this.BtnSemana.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnSemana.BackgroundImage")));
            this.BtnSemana.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnSemana.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnSemana.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(75)))), ((int)(((byte)(62)))));
            this.BtnSemana.FlatAppearance.BorderSize = 2;
            this.BtnSemana.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSemana.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSemana.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(15)))), ((int)(((byte)(16)))));
            this.BtnSemana.Location = new System.Drawing.Point(997, 0);
            this.BtnSemana.Name = "BtnSemana";
            this.BtnSemana.Size = new System.Drawing.Size(129, 142);
            this.BtnSemana.TabIndex = 6;
            this.BtnSemana.Text = "SEMANA";
            this.BtnSemana.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnSemana.UseVisualStyleBackColor = false;
            this.BtnSemana.Click += new System.EventHandler(this.BtnSemana_Click);
            // 
            // BtnDia
            // 
            this.BtnDia.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(171)))), ((int)(((byte)(156)))));
            this.BtnDia.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnDia.BackgroundImage")));
            this.BtnDia.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnDia.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnDia.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(75)))), ((int)(((byte)(62)))));
            this.BtnDia.FlatAppearance.BorderSize = 2;
            this.BtnDia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDia.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(15)))), ((int)(((byte)(16)))));
            this.BtnDia.Location = new System.Drawing.Point(1126, 0);
            this.BtnDia.Name = "BtnDia";
            this.BtnDia.Size = new System.Drawing.Size(129, 142);
            this.BtnDia.TabIndex = 7;
            this.BtnDia.Text = "DIA";
            this.BtnDia.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnDia.UseVisualStyleBackColor = false;
            this.BtnDia.Click += new System.EventHandler(this.BtnDia_Click);
            // 
            // PanelBusqueda
            // 
            this.PanelBusqueda.Controls.Add(this.DgvDatos);
            this.PanelBusqueda.Location = new System.Drawing.Point(12, 15);
            this.PanelBusqueda.Name = "PanelBusqueda";
            this.PanelBusqueda.Size = new System.Drawing.Size(1234, 606);
            this.PanelBusqueda.TabIndex = 15;
            // 
            // panelDetalle
            // 
            this.panelDetalle.Controls.Add(this.TxtIDAsiento);
            this.panelDetalle.Controls.Add(this.TxtFecha);
            this.panelDetalle.Controls.Add(this.label8);
            this.panelDetalle.Controls.Add(this.TxtTComprobante);
            this.panelDetalle.Controls.Add(this.label7);
            this.panelDetalle.Controls.Add(this.TxtComprobante);
            this.panelDetalle.Controls.Add(this.label12);
            this.panelDetalle.Controls.Add(this.TxtConceptoGeneral);
            this.panelDetalle.Controls.Add(this.label6);
            this.panelDetalle.Controls.Add(this.TxtDocReferencia);
            this.panelDetalle.Controls.Add(this.label5);
            this.panelDetalle.Controls.Add(this.panel5);
            this.panelDetalle.Controls.Add(this.DgvCuentas);
            this.panelDetalle.Location = new System.Drawing.Point(12, 15);
            this.panelDetalle.Name = "panelDetalle";
            this.panelDetalle.Size = new System.Drawing.Size(1235, 606);
            this.panelDetalle.TabIndex = 16;
            // 
            // TxtIDAsiento
            // 
            this.TxtIDAsiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtIDAsiento.Location = new System.Drawing.Point(1239, 67);
            this.TxtIDAsiento.MaxLength = 100;
            this.TxtIDAsiento.Name = "TxtIDAsiento";
            this.TxtIDAsiento.ReadOnly = true;
            this.TxtIDAsiento.Size = new System.Drawing.Size(234, 24);
            this.TxtIDAsiento.TabIndex = 29;
            // 
            // TxtFecha
            // 
            this.TxtFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtFecha.Location = new System.Drawing.Point(641, 97);
            this.TxtFecha.MaxLength = 100;
            this.TxtFecha.Name = "TxtFecha";
            this.TxtFecha.ReadOnly = true;
            this.TxtFecha.Size = new System.Drawing.Size(578, 24);
            this.TxtFecha.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(642, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 18);
            this.label8.TabIndex = 28;
            this.label8.Text = "FECHA";
            // 
            // TxtTComprobante
            // 
            this.TxtTComprobante.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtTComprobante.Location = new System.Drawing.Point(16, 97);
            this.TxtTComprobante.MaxLength = 100;
            this.TxtTComprobante.Name = "TxtTComprobante";
            this.TxtTComprobante.ReadOnly = true;
            this.TxtTComprobante.Size = new System.Drawing.Size(234, 24);
            this.TxtTComprobante.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(17, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 18);
            this.label7.TabIndex = 26;
            this.label7.Text = "TIPO COMPROBANTE";
            // 
            // TxtComprobante
            // 
            this.TxtComprobante.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtComprobante.Location = new System.Drawing.Point(281, 97);
            this.TxtComprobante.MaxLength = 100;
            this.TxtComprobante.Name = "TxtComprobante";
            this.TxtComprobante.ReadOnly = true;
            this.TxtComprobante.Size = new System.Drawing.Size(330, 24);
            this.TxtComprobante.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(282, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 18);
            this.label12.TabIndex = 24;
            this.label12.Text = "COMPROBANTE";
            // 
            // TxtConceptoGeneral
            // 
            this.TxtConceptoGeneral.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtConceptoGeneral.Location = new System.Drawing.Point(16, 189);
            this.TxtConceptoGeneral.MaxLength = 250;
            this.TxtConceptoGeneral.Name = "TxtConceptoGeneral";
            this.TxtConceptoGeneral.ReadOnly = true;
            this.TxtConceptoGeneral.Size = new System.Drawing.Size(1203, 24);
            this.TxtConceptoGeneral.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 169);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(185, 18);
            this.label6.TabIndex = 23;
            this.label6.Text = "CONCEPTO GENERAL";
            // 
            // TxtDocReferencia
            // 
            this.TxtDocReferencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDocReferencia.Location = new System.Drawing.Point(16, 143);
            this.TxtDocReferencia.MaxLength = 250;
            this.TxtDocReferencia.Name = "TxtDocReferencia";
            this.TxtDocReferencia.ReadOnly = true;
            this.TxtDocReferencia.Size = new System.Drawing.Size(1203, 24);
            this.TxtDocReferencia.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 18);
            this.label5.TabIndex = 22;
            this.label5.Text = "DOC REFERENCIA";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.BtnVolver);
            this.panel5.Controls.Add(this.BtnBorrar);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1235, 62);
            this.panel5.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label9.Location = new System.Drawing.Point(15, 14);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(270, 29);
            this.label9.TabIndex = 13;
            this.label9.Text = "DETALLE DE ASIENTO";
            // 
            // BtnVolver
            // 
            this.BtnVolver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.BtnVolver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnVolver.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnVolver.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(75)))), ((int)(((byte)(62)))));
            this.BtnVolver.FlatAppearance.BorderSize = 2;
            this.BtnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVolver.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVolver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(15)))), ((int)(((byte)(16)))));
            this.BtnVolver.Location = new System.Drawing.Point(1075, 0);
            this.BtnVolver.Name = "BtnVolver";
            this.BtnVolver.Size = new System.Drawing.Size(80, 62);
            this.BtnVolver.TabIndex = 12;
            this.BtnVolver.Text = "RETURN";
            this.BtnVolver.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnVolver.UseVisualStyleBackColor = false;
            this.BtnVolver.Click += new System.EventHandler(this.BtnVolver_Click);
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.BtnBorrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BtnBorrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnBorrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(75)))), ((int)(((byte)(62)))));
            this.BtnBorrar.FlatAppearance.BorderSize = 2;
            this.BtnBorrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnBorrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(15)))), ((int)(((byte)(16)))));
            this.BtnBorrar.Location = new System.Drawing.Point(1155, 0);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(80, 62);
            this.BtnBorrar.TabIndex = 11;
            this.BtnBorrar.Text = "DELETE";
            this.BtnBorrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.BtnBorrar.UseVisualStyleBackColor = false;
            this.BtnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // DgvCuentas
            // 
            this.DgvCuentas.AllowUserToAddRows = false;
            this.DgvCuentas.AllowUserToDeleteRows = false;
            this.DgvCuentas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvCuentas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Concepto,
            this.Debe,
            this.Haber});
            this.DgvCuentas.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DgvCuentas.Location = new System.Drawing.Point(0, 239);
            this.DgvCuentas.Name = "DgvCuentas";
            this.DgvCuentas.ReadOnly = true;
            this.DgvCuentas.Size = new System.Drawing.Size(1235, 367);
            this.DgvCuentas.TabIndex = 5;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "CODIGO";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            this.Codigo.Width = 180;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "CUENTA";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            this.Nombre.Width = 250;
            // 
            // Concepto
            // 
            this.Concepto.HeaderText = "CONCEPTO";
            this.Concepto.Name = "Concepto";
            this.Concepto.ReadOnly = true;
            this.Concepto.Width = 490;
            // 
            // Debe
            // 
            this.Debe.HeaderText = "DEBE";
            this.Debe.Name = "Debe";
            this.Debe.ReadOnly = true;
            this.Debe.Width = 130;
            // 
            // Haber
            // 
            this.Haber.HeaderText = "HABER";
            this.Haber.Name = "Haber";
            this.Haber.ReadOnly = true;
            this.Haber.Width = 130;
            // 
            // Detalle
            // 
            this.Detalle.HeaderText = "";
            this.Detalle.Image = ((System.Drawing.Image)(resources.GetObject("Detalle.Image")));
            this.Detalle.Name = "Detalle";
            this.Detalle.ReadOnly = true;
            // 
            // IDAsiento
            // 
            this.IDAsiento.HeaderText = "IDASIENTO";
            this.IDAsiento.Name = "IDAsiento";
            this.IDAsiento.ReadOnly = true;
            this.IDAsiento.Visible = false;
            // 
            // Fecha
            // 
            dataGridViewCellStyle1.Format = "g";
            dataGridViewCellStyle1.NullValue = null;
            this.Fecha.DefaultCellStyle = dataGridViewCellStyle1;
            this.Fecha.HeaderText = "FECHA";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 140;
            // 
            // TComp
            // 
            this.TComp.HeaderText = "T. COMP";
            this.TComp.Name = "TComp";
            this.TComp.ReadOnly = true;
            // 
            // NComp
            // 
            this.NComp.HeaderText = "N. COMP";
            this.NComp.Name = "NComp";
            this.NComp.ReadOnly = true;
            // 
            // Doc
            // 
            this.Doc.HeaderText = "DOC. REFEREN";
            this.Doc.Name = "Doc";
            this.Doc.ReadOnly = true;
            this.Doc.Width = 350;
            // 
            // Concep
            // 
            this.Concep.HeaderText = "CONCEPT.";
            this.Concep.Name = "Concep";
            this.Concep.ReadOnly = true;
            this.Concep.Width = 350;
            // 
            // FrmBusquedaAsiento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 780);
            this.Controls.Add(this.panelDetalle);
            this.Controls.Add(this.PanelBusqueda);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmBusquedaAsiento";
            this.Text = "FrmBusquedaAsiento";
            ((System.ComponentModel.ISupportInitialize)(this.DgvDatos)).EndInit();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.PanelBusqueda.ResumeLayout(false);
            this.panelDetalle.ResumeLayout(false);
            this.panelDetalle.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvCuentas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView DgvDatos;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.TextBox TxtBuscarConceptoGeneral;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker TxtBusquedaFechaInicio;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker TxtBusquedaFechaFinal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button BtnVariado;
        private System.Windows.Forms.Button BtnMes;
        private System.Windows.Forms.Button BtnSemana;
        private System.Windows.Forms.Button BtnDia;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox CbTComprobante;
        private System.Windows.Forms.Panel PanelBusqueda;
        private System.Windows.Forms.Panel panelDetalle;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGridView DgvCuentas;
        private System.Windows.Forms.TextBox TxtFecha;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TxtTComprobante;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtComprobante;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtConceptoGeneral;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtDocReferencia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button BtnVolver;
        private System.Windows.Forms.Button BtnBorrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concepto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Haber;
        private System.Windows.Forms.TextBox TxtIDAsiento;
        private System.Windows.Forms.DataGridViewImageColumn Detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDAsiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn TComp;
        private System.Windows.Forms.DataGridViewTextBoxColumn NComp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Doc;
        private System.Windows.Forms.DataGridViewTextBoxColumn Concep;
    }
}