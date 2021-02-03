using System.Drawing;
using System.Windows.Forms;

namespace ProyecContable.Estados.Alerta
{
    public class ClassAlertError
    {

        public ClassAlertError(Form FrmError, Panel pBorder1, Panel pBorder2, Panel pBorder3, Panel pBorder4, Label LblMensajeGrande, Label LblMensaje, string Mensaje)
        {
            FrmError.BackColor = Color.FromArgb(255, 248, 215, 218);
            pBorder1.BackColor = Color.FromArgb(255, 114, 28, 36);
            pBorder2.BackColor = Color.FromArgb(255, 114, 28, 36);
            pBorder3.BackColor = Color.FromArgb(255, 114, 28, 36);
            pBorder4.BackColor = Color.FromArgb(255, 114, 28, 36);
            LblMensajeGrande.Text = "ERROR";
            LblMensaje.Text = Mensaje;
        }

    }
}
