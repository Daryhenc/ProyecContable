using CADProContable.Niveles.Creacion.Nivel4;
using CADProContable.Niveles.Nivel1;
using CADProContable.Niveles.Nivel2;
using CADProContable.Niveles.Nivel3;
using CADProContable.Niveles.Nivel4;
using System;
using System.Windows.Forms;

namespace ProyecContable.Niveles.Nivel4
{
    public partial class FrmNivel4 : Form
    {
        public FrmNivel4()
        {
            InitializeComponent();
            LlenarCB = new ClassLlenarCbClase();
          //  LlenarCB.Llenar(CbNivel1);

            LlenarCB2 = new ClassLLenarCbGrupo();
           // LlenarCB2.Llenar(CbNivel2, Convert.ToInt32(CbNivel1.SelectedValue));

            LlenarCB3 = new ClassLlenarCbCuenta();
         //   LlenarCB3.Llenar(CbNivel3, Convert.ToInt32(CbNivel2.SelectedValue));
            IDConta_Jera3 = Convert.ToInt32(CbNivel3.SelectedValue);
        }

        ClassLlenarCbClase LlenarCB { get; set; }
        ClassLLenarCbGrupo LlenarCB2 { get; set; }
        ClassLlenarCbCuenta LlenarCB3 { get; set; }
        ClassDgvLlenar_4 LlenarDgv { get; set; }
        int IDConta_Jera3;

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            LlenarDgv = new ClassDgvLlenar_4();
            if (Convert.ToInt32(CbNivel2.SelectedValue) != 0)
            {
                LlenarDgv.LLenarGrupo4Lista(DgvDatos, Convert.ToInt32(CbNivel3.SelectedValue));
            }
           
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

            CADNivel4 Guardar = new CADNivel4();
          //  Guardar.InsertJerar4(IDConta_Jera3, TxtNombre.Text.ToUpper(), TxtCodigo.Text);
            TxtNombre.Text = null;
            TxtCodigo.Text = null;
            LlenarDgv = new ClassDgvLlenar_4();
            LlenarDgv.LLenarGrupo4Lista(DgvDatos, IDConta_Jera3);
        }

        private void CbNivel3_SelectionChangeCommitted(object sender, EventArgs e)
        {
            IDConta_Jera3 = Convert.ToInt32(CbNivel3.SelectedValue);
        }
    }
}
