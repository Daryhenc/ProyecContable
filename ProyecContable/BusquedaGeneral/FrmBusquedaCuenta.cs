using CADProContable.Asiento.AsientoBusqueda;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyecContable.BusquedaGeneral
{
    public partial class FrmBusquedaCuenta : Form
    {
        public FrmBusquedaCuenta()
        {
            InitializeComponent();
            LlenarBusqueda = new ClassDgvLlenarBusquedaCuenta();
            LlenarBusqueda.BusquedaCuenta(DgvData, TxtCodigo.Text.ToUpper(), TxtCuenta.Text.ToUpper());
            DgvData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }
        ClassDgvLlenarBusquedaCuenta LlenarBusqueda { get; set; }
        public bool Estado;
        public int IDCuentaMovimiento;
        public int CJ5;
        public int CJ4;
        public int CJ3;
        public string Codigo;
        public string Nombre;

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Estado = false;
            this.Close();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            if (DgvData.CurrentRow == null)
            {
                return;
            }
            else
            {
                Estado = true;
                int fila = Convert.ToInt32(DgvData.CurrentRow.Index);
                IDCuentaMovimiento = Convert.ToInt32(DgvData.Rows[fila].Cells[0].Value);
                CJ3 = Convert.ToInt32(DgvData.Rows[fila].Cells[1].Value);
                CJ4 = Convert.ToInt32(DgvData.Rows[fila].Cells[2].Value);
                CJ5 = Convert.ToInt32(DgvData.Rows[fila].Cells[3].Value);
                Codigo = DgvData.Rows[fila].Cells[4].Value.ToString();
                Nombre = DgvData.Rows[fila].Cells[5].Value.ToString();
                DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        private void TxtCodigo_TextChanged(object sender, EventArgs e)
        {
            LlenarBusqueda = new ClassDgvLlenarBusquedaCuenta();
            LlenarBusqueda.BusquedaCuenta(DgvData, TxtCodigo.Text.ToUpper(), TxtCuenta.Text.ToUpper());

        }

        private void TxtCuenta_TextChanged(object sender, EventArgs e)
        {
            LlenarBusqueda = new ClassDgvLlenarBusquedaCuenta();
            LlenarBusqueda.BusquedaCuenta(DgvData, TxtCodigo.Text.ToUpper(), TxtCuenta.Text.ToUpper());

        }
    }
}
