using ProyecContable.Asientos.BusquedaAsiento;
using ProyecContable.Asientos.CreacionAsiento;
using System;
using System.Windows.Forms;

namespace ProyecContable.Asientos
{
    public partial class FrmMenuAsiento : Form
    {
        public FrmMenuAsiento()
        {
            InitializeComponent();
            MensajesDeBotones();
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


        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmCreacionAsiento());
        }

        private void BtnBusqueda_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmBusquedaAsiento());
        }

        private void BtnReporte_Click(object sender, EventArgs e)
        {

        }

        private void MensajesDeBotones()
        {

            TTMensasje.SetToolTip(this.BtnNuevo, "CREAR ASIENTOS");
            TTMensasje.SetToolTip(this.BtnReporte, "REPORTE DE ASIENTOS");
            TTMensasje.SetToolTip(this.BtnBusqueda, "BUSCAR ASIENTOS.");

        }
    }
}
