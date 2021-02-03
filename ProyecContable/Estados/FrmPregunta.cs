using System;
using System.Windows.Forms;

namespace ProyecContable.Estados
{
    public partial class FrmPregunta : Form
    {
        public FrmPregunta()
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
