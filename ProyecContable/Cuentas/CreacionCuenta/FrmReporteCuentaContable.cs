using ReportesContables.Reportes.Cuentas.ListaCuenta;
using System.Windows.Forms;

namespace ProyecContable.Cuentas.CreacionCuenta
{
    public partial class FrmReporteCuentaContable : Form
    {
        public FrmReporteCuentaContable()
        {
            InitializeComponent();
            AbrirFormulario(new FormReportListCuenta());
        }

        private Form FormActivo = null;
        private void AbrirFormulario(Form FrmHijo)
        {
            if (FormActivo != null)
            {
                FormActivo.Close();
            }
            FormActivo = FrmHijo;
            FrmHijo.TopLevel = false;
            FrmHijo.FormBorderStyle = FormBorderStyle.None;
            FrmHijo.Dock = DockStyle.None;
            PanelContenedorHijo.Controls.Add(FrmHijo);
            PanelContenedorHijo.Tag = FrmHijo;
            FrmHijo.BringToFront();
            FrmHijo.Show();
        }
    }
}
