using CADProContable.Asiento.AsientoBusqueda;
using System.Windows.Forms;

namespace ProyecContable.Asientos.BusquedaAsiento
{
    public partial class FrmBusquedaAsiento : Form
    {
        public FrmBusquedaAsiento()
        {
            InitializeComponent();
            panelDetalle.Visible = true;
            panelDetalle.Visible = false;
        }

        ClassDgvCuentaBusqueda BusquedaDetalle { get; set; }

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
    }
}
