using CADProContable.Niveles.Nivel2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyecContable.Niveles.Nivel2
{
    public partial class FrmNivel2Editar : Form
    {
        public FrmNivel2Editar(int IDConta_Jera_2, string Codigo, string Nombre)
        {
            InitializeComponent();
            this.IDConta_Jera_2 = IDConta_Jera_2;
            TxtAnteCodigo.Text = Codigo;
            TxtAnteNombre.Text = Nombre;
            TxtNombre.Text = TxtAnteNombre.Text;
            TxtNuevoCodigo.Text = TxtAnteCodigo.Text;
        }

        int IDConta_Jera_2;
        

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (TxtNombre.Text == "")
            {
                return;
            }
            if (TxtAnteCodigo.Text == "")
            {
                return;
            }

            CADNivel2 GuardarEditado = new CADNivel2();
            GuardarEditado.UpdateJerar2(TxtNombre.Text.ToUpper(), TxtNuevoCodigo.Text, IDConta_Jera_2);

        }
    }
}
