using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyecContable.Estados.Alerta
{
    public class ClassAlertActualizado
    {

        public ClassAlertActualizado(Form FrmActualizado, Panel pBorder1, Panel pBorder2, Panel pBorder3, Panel pBorder4, Label LblMensajeGrande, Label LblMensaje)
        {
            FrmActualizado.BackColor = Color.FromArgb(255, 212, 237, 218);
            pBorder1.BackColor = Color.FromArgb(255, 2, 96, 76);
            pBorder2.BackColor = Color.FromArgb(255, 2, 96, 76);
            pBorder3.BackColor = Color.FromArgb(255, 2, 96, 76);
            pBorder4.BackColor = Color.FromArgb(255, 2, 96, 76);
            LblMensajeGrande.Text = "ACTUALIZADO";
            LblMensaje.Text = "El registro se actualizó correctamente.";
        }


    }
}
