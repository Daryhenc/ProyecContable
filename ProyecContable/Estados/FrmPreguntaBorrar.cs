using System;
using System.Windows.Forms;

namespace ProyecContable.Estados
{
    public partial class FrmPreguntaBorrar : Form
    {
        public FrmPreguntaBorrar()
        {
            InitializeComponent();
        }

        public bool Estado;

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            Estado = true;
            this.Close();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            Estado = false;
            this.Close();
        }
    }
}
