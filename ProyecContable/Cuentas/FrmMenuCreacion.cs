using ProyecContable.Cuentas.CreacionCuenta;
using ProyecContable.Cuentas.CreacionRetencion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyecContable.Cuentas
{
    public partial class FrmMenuCreacion : Form
    {
        public FrmMenuCreacion()
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
            AbrirFormulario(new FrmCrearCuentas());
        }

        private void BtnReporte_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmReporteCuentaContable());
        }

        private void BtnReteNuevo_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmCrearRetencione());
        }
        private void MensajesDeBotones()
        {

            TTMensasje.SetToolTip(this.BtnNuevo, "CREAR NUEVAS CUENTAS CONTABLES");
            TTMensasje.SetToolTip(this.BtnReporte, "REPORTE CUENTA CONTABLE.");
            TTMensasje.SetToolTip(this.BtnReteNuevo, "CREAR RETENCIONES.");

        }


    }
}
