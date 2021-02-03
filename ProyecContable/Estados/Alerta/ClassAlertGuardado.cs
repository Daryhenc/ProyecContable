using System.Drawing;
using System.Windows.Forms;

namespace ProyecContable.Estados.Alerta
{
    public class ClassAlertGuardado
    {

        public ClassAlertGuardado(Form FrmGuardado, Panel pBorder1, Panel pBorder2, Panel pBorder3, Panel pBorder4, Label LblMensajeGrande, Label LblMensaje) {
            FrmGuardado.BackColor = Color.FromArgb(255, 212, 237, 218);
            pBorder1.BackColor = Color.FromArgb(255, 2, 96, 76);
            pBorder2.BackColor = Color.FromArgb(255, 2, 96, 76);
            pBorder3.BackColor = Color.FromArgb(255, 2, 96, 76);
            pBorder4.BackColor = Color.FromArgb(255, 2, 96, 76);
            LblMensajeGrande.Text = "GUARDADO";
            LblMensaje.Text = "El registro se guardo correctamente.";
        }


    }
}
