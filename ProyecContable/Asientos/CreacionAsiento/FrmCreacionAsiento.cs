using System;
using System.Windows.Forms;

namespace ProyecContable.Asientos.CreacionAsiento
{
    public partial class FrmCreacionAsiento : Form
    {
        public FrmCreacionAsiento()
        {
            InitializeComponent();
        }

        private void TxtDebe_Leave(object sender, EventArgs e)
        {
            try
            {
               
                if (Convert.ToDecimal(TxtDebe.Text) > 0)
                {
                    TxtHaber.Text = "0";
                }
                if (Convert.ToDecimal(TxtDebe.Text) < 0)
                {
                    TxtDebe.Text = "0";
                }
            }
            catch (Exception)
            {
                TxtDebe.Text = "0";
            }
        }

        private void TxtHaber_Leave(object sender, EventArgs e)
        {
            try
            {

                if (Convert.ToDecimal(TxtHaber.Text) > 0)
                {
                    TxtDebe.Text = "0";
                }
                if (Convert.ToDecimal(TxtHaber.Text) < 0)
                {
                    TxtHaber.Text = "0";
                }
            }
            catch (Exception)
            {
                TxtHaber.Text = "0";
            }
        }

    }
}
