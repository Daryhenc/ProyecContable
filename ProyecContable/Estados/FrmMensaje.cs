using ProyecContable.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ProyecContable.Estados
{
    public partial class FrmMensaje : Form
    {
        public FrmMensaje(Bitmap Imagen, string LblMensajeTitulo, string LblMensaje, List<int> FormClaro, List<int> FormOscuro) 
        {
            InitializeComponent();            
            pBorder1.BackColor = Color.FromArgb(255, FormOscuro[0], FormOscuro[1], FormOscuro[2]);
            pBorder2.BackColor = Color.FromArgb(255, FormOscuro[0], FormOscuro[1], FormOscuro[2]);
            pBorder3.BackColor = Color.FromArgb(255, FormOscuro[0], FormOscuro[1], FormOscuro[2]);
            pBorder4.BackColor = Color.FromArgb(255, FormOscuro[0], FormOscuro[1], FormOscuro[2]);
            this.BackColor  = Color.FromArgb(255, FormClaro[0], FormClaro[1], FormClaro[2]);
            this.LblMensajeTitulo.Text = LblMensajeTitulo;
            this.LblMensajeTitulo.ForeColor = Color.FromArgb(255, FormOscuro[0], FormOscuro[1], FormOscuro[2]);
            this.LblMensaje.Text = LblMensaje;
            this.LblMensaje.ForeColor = Color.FromArgb(255, FormOscuro[0], FormOscuro[1], FormOscuro[2]);
            PbImagen.Image = Imagen;
        }


        private void BtnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
