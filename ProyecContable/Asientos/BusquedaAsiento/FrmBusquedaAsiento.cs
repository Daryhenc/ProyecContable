using CADProContable.Asiento.AsientoBusqueda;
using CADProContable.Asiento.AsientoDetalle;
using ProyecContable.Estados;
using ProyecContable.Estados.Alerta;
using System;
using System.Windows.Forms;

namespace ProyecContable.Asientos.BusquedaAsiento
{
    public partial class FrmBusquedaAsiento : Form
    {
        public FrmBusquedaAsiento()
        {
            InitializeComponent();
            PanelBusqueda.Visible = true;
            panelDetalle.Visible = false;
            DgvDatos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            DgvCuentas.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        ClassDgvCuentaBusqueda BusquedaDetalle { get; set; }
        ClassDgvCuentaMovimiento CuentaMovimiento { get; set; }
        ClassToast Alerta { get; set; }
        private void BtnDia_Click(object sender, System.EventArgs e)
        {
            BusquedaDetalle = new ClassDgvCuentaBusqueda();
            BusquedaDetalle.LLenarMovimientoDetalleLista(DgvDatos, 1,
            CbTComprobante.Text, TxtBuscarConceptoGeneral.Text, TxtBusquedaFechaInicio.Value.ToString(), TxtBusquedaFechaFinal.Value.ToString());
        }

        private void BtnSemana_Click(object sender, System.EventArgs e)
        {
            BusquedaDetalle = new ClassDgvCuentaBusqueda();
            BusquedaDetalle.LLenarMovimientoDetalleLista(DgvDatos, 2,
            CbTComprobante.Text, TxtBuscarConceptoGeneral.Text, TxtBusquedaFechaInicio.Value.ToString(), TxtBusquedaFechaFinal.Value.ToString());
        }

        private void BtnMes_Click(object sender, System.EventArgs e)
        {
            BusquedaDetalle = new ClassDgvCuentaBusqueda();
            BusquedaDetalle.LLenarMovimientoDetalleLista(DgvDatos, 3,
            CbTComprobante.Text, TxtBuscarConceptoGeneral.Text, TxtBusquedaFechaInicio.Value.ToString(), TxtBusquedaFechaFinal.Value.ToString());
        }

        private void BtnVariado_Click(object sender, System.EventArgs e)
        {
            BusquedaDetalle = new ClassDgvCuentaBusqueda();
            BusquedaDetalle.LLenarMovimientoDetalleLista(DgvDatos, 4,
            CbTComprobante.Text, TxtBuscarConceptoGeneral.Text, TxtBusquedaFechaInicio.Value.ToString(), TxtBusquedaFechaFinal.Value.ToString());
        }

        private void DgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvDatos.CurrentRow == null)
            {
                return;
            }

            int Fila = e.RowIndex;
            int Column = e.ColumnIndex;
            if (Fila < 0)
            {
                return;
            }
            if (Column == 0 )
            {
                PanelBusqueda.Visible = false;
                panelDetalle.Visible = true;

                CuentaMovimiento = new ClassDgvCuentaMovimiento();
                CuentaMovimiento.TraerListaCuentaMovimiento(DgvCuentas, Convert.ToInt32(DgvDatos.Rows[Fila].Cells[1].Value));
                TxtIDAsiento.Text = DgvDatos.Rows[Fila].Cells[1].Value.ToString();
                TxtFecha.Text = DgvDatos.Rows[Fila].Cells[2].Value.ToString();
                TxtTComprobante.Text = DgvDatos.Rows[Fila].Cells[3].Value.ToString();
                TxtComprobante.Text = DgvDatos.Rows[Fila].Cells[4].Value.ToString();
                TxtDocReferencia.Text = DgvDatos.Rows[Fila].Cells[5].Value.ToString();
                TxtConceptoGeneral.Text = DgvDatos.Rows[Fila].Cells[6].Value.ToString();

            }

        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            PanelBusqueda.Visible = true;
            panelDetalle.Visible = false;
        }

        private void BtnBorrar_Click(object sender, EventArgs e)
        {
            FrmPreguntaBorrar FrmBorrar = new FrmPreguntaBorrar();
            FrmBorrar.ShowDialog();
            if (FrmBorrar.Estado == true)
            {
                CADAsientoDetalle Borrar = new CADAsientoDetalle();
                Borrar.DeleteAsiento(Convert.ToInt32(TxtIDAsiento.Text));

                Alerta = new ClassToast(ClassColorAlerta.Alerta.Guardado.ToString(), "ELIMINADO", "Registro borrado correctamente.");

                PanelBusqueda.Visible = true;
                panelDetalle.Visible = false;

                DgvDatos.Rows.Clear();
            }
        }
    }
}
