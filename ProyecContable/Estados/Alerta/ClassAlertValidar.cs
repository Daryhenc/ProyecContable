using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyecContable.Estados.Alerta
{
    public class ClassAlertValidar
    {

        public ClassAlertValidar(Form FrmError, Panel pBorder1, Panel pBorder2, Panel pBorder3, Panel pBorder4, Label LblMensajeGrande, Label LblMensaje, string Mensaje)
        {
            FrmError.BackColor = Color.FromArgb(255, 255, 250, 230);
            pBorder1.BackColor = Color.FromArgb(255, 255, 171, 0);
            pBorder2.BackColor = Color.FromArgb(255, 255, 171, 0);
            pBorder3.BackColor = Color.FromArgb(255, 255, 171, 0);
            pBorder4.BackColor = Color.FromArgb(255, 255, 171, 0);
            LblMensajeGrande.Text = "VALIDAR";
            LblMensaje.Text = Mensaje;
        }

    }
}
