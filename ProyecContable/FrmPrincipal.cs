using ProyecContable.Cuentas;
using ProyecContable.Estados;
using ProyecContable.Estados.Alerta;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyecContable
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        ClassColorAlerta Alerta { get; set; }

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

        private void Btnlv2_Click(object sender, EventArgs e)
        {
            ClassToast Estados = new ClassToast(ClassColorAlerta.Alerta.Validado.ToString(), "ALERTA", "Error al picar");

        }

        private void BtnCuentas_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmMenuCreacion());
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
