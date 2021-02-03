using ReportesContables.Reportes.Cuentas.ListaCuenta.DatosListCuenta;
using System.Windows.Forms;

namespace ReportesContables.Reportes.Cuentas.ListaCuenta
{
    public partial class FormReportListCuenta : Form
    {
        public FormReportListCuenta()
        {
            InitializeComponent();

            ClassReporteListCuenta ReporteModel = new ClassReporteListCuenta();
            ReporteModel.LlamarReporteListaCuenta();
            ClassObDatoListCuentaBindingSource.DataSource = ReporteModel.DatosLista;
            this.reportViewer.RefreshReport();
        }

    }
}
