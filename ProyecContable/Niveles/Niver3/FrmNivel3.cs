using CADProContable.Niveles.Creacion.Nivel3;
using CADProContable.Niveles.Nivel1;
using CADProContable.Niveles.Nivel2;
using CADProContable.Niveles.Nivel3;
using System;
using System.Windows.Forms;

namespace ProyecContable.Niveles.Niver3
{
    public partial class FrmNivel3 : Form
    {
        public FrmNivel3()
        {
            InitializeComponent();
            LlenarCB = new ClassLlenarCbClase();
           // LlenarCB.Llenar(CbNivel1);
            IDConta_Jera = Convert.ToInt32(CbNivel1.SelectedValue);
            LlenarCB2 = new ClassLLenarCbGrupo();
         //   LlenarCB2.Llenar(CbNivel2, Convert.ToInt32(CbNivel1.SelectedValue));
            IDConta_Jera2 = Convert.ToInt32(CbNivel2.SelectedValue);
        }

        ClassLlenarCbClase LlenarCB { get; set; }
        ClassLLenarCbGrupo LlenarCB2 { get; set; }
        ClassDgvLlenar_3 LlenarDgv { get; set; }

        int IDConta_Jera;
        int IDConta_Jera2;

        private void CbNivel1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            LlenarCB2 = new ClassLLenarCbGrupo();
         //   LlenarCB2.Llenar(CbNivel2, Convert.ToInt32(CbNivel1.SelectedValue));
            IDConta_Jera = Convert.ToInt32(CbNivel1.SelectedValue);
        }

        private void CbNivel2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            IDConta_Jera2 = Convert.ToInt32(CbNivel2.SelectedValue);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            LlenarDgv = new ClassDgvLlenar_3();
            LlenarDgv.LLenarGrupo3Lista(DgvDatos, Convert.ToInt32(CbNivel2.SelectedValue));
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (TxtCodigo.Text == null || TxtCodigo.Text == "")
            {
                return;
            }

            if (TxtNombre.Text == null || TxtCodigo.Text == "")
            {
                return;
            }

            CADNivel3 Guardar = new CADNivel3();
          //  Guardar.InsertJerar3(IDConta_Jera2, TxtNombre.Text.ToUpper(), TxtCodigo.Text);
            TxtNombre.Text = null;
            TxtCodigo.Text = null;
            LlenarDgv = new ClassDgvLlenar_3();
            LlenarDgv.LLenarGrupo3Lista(DgvDatos, Convert.ToInt32(CbNivel2.SelectedValue));
        }
    }
}
