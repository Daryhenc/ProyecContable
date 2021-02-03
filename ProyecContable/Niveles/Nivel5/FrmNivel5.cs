using CADProContable.Niveles.Creacion.Nivel5;
using CADProContable.Niveles.Nivel1;
using CADProContable.Niveles.Nivel2;
using CADProContable.Niveles.Nivel3;
using CADProContable.Niveles.Nivel4;
using CADProContable.Niveles.Nivel5;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyecContable.Niveles.Nivel5
{
    public partial class FrmNivel5 : Form
    {
        public FrmNivel5()
        {
            InitializeComponent();

            LlenarCB = new ClassLlenarCbClase();
          //  LlenarCB.Llenar(CbNivel1);

            LlenarCB2 = new ClassLLenarCbGrupo();
          //  LlenarCB2.Llenar(CbNivel2, Convert.ToInt32(CbNivel1.SelectedValue));

            LlenarCB3 = new ClassLlenarCbCuenta();
         //   LlenarCB3.Llenar(CbNivel3, Convert.ToInt32(CbNivel2.SelectedValue));

        //    LlenarCB4 = new ClassLlenarCb4();
        //    LlenarCB4.Llenar(CbNivel4, Convert.ToInt32(CbNivel3.SelectedValue));
            IDConta_Jera4 = Convert.ToInt32(CbNivel4.SelectedValue);
        }

        ClassLlenarCbClase LlenarCB { get; set; }
        ClassLLenarCbGrupo LlenarCB2 { get; set; }
        ClassLlenarCbCuenta LlenarCB3 { get; set; }
    //    ClassLlenarCb4 LlenarCB4 { get; set; }
        ClassDgvLlenar_5 LlenarDgv { get; set; }
        int IDConta_Jera4;

        private void CbNivel4_SelectionChangeCommitted(object sender, EventArgs e)
        {
            IDConta_Jera4 = Convert.ToInt32(CbNivel4.SelectedValue);
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            LlenarDgv = new ClassDgvLlenar_5();
            if (IDConta_Jera4 != 0)
            {
                LlenarDgv.LLenarGrupo5Lista(DgvDatos, IDConta_Jera4);
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

            CADNivel5 Guardar = new CADNivel5();
      //      Guardar.InsertJerar5(IDConta_Jera4, TxtNombre.Text.ToUpper(), TxtCodigo.Text);
            TxtNombre.Text = null;
            TxtCodigo.Text = null;
            LlenarDgv = new ClassDgvLlenar_5();
            LlenarDgv.LLenarGrupo5Lista(DgvDatos, IDConta_Jera4);
        }
    }
}
