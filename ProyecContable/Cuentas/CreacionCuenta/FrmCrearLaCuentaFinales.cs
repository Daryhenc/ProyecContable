using CADProContable.Niveles.CMovimiento;
using CADProContable.Niveles.Nivel3;
using CADProContable.Niveles.Nivel4;
using CADProContable.Niveles.Nivel5;
using ProyecContable.Estados;
using ProyecContable.Estados.Alerta;
using System;
using System.Windows.Forms;

namespace ProyecContable.Cuentas.CreacionCuenta
{
    public partial class FrmCrearLaCuentaFinales : Form
    {
        public FrmCrearLaCuentaFinales(int Count, int IDCuenta2, int IDCuenta3, int IDCuenta4, int IDCuenta5, int IDCuentaComodin)
        {
            InitializeComponent();

            this.Count = Count;
            this.IDCuenta2 = IDCuenta2;
            this.IDCuenta3 = IDCuenta3;
            this.IDCuenta4 = IDCuenta4;
            this.IDCuenta5 = IDCuenta5;
            this.IDCuentaComodin = IDCuentaComodin;
            NombreCrear();
        }

        ClassToast Alerta { get; set; }
        int Count;
        int IDCuenta2;
        int IDCuenta3;
        int IDCuenta4;
        int IDCuenta5;
        int IDCuentaComodin;
        private void NombreCrear()
        {
            
            if (Count == 3)
            {
                LblCrearTitulo.Text = "CREAR CUENTA";
                return;
            }
            if (Count == 4)
            {
                LblCrearTitulo.Text = "CREAR SUBCUENTA";
                return;
            }
            if (Count == 5)
            {
                LblCrearTitulo.Text = "CREAR CUENTA AUXILIAR";
                CbEstado.Enabled = false;
                CbEstado.Checked = true;
                return;
            }
        }
        private int GuardarCrear(string Nombre, string Codigo, bool Estado)
        {
          int IDCuenta;
          if (IDCuenta3 == IDCuentaComodin && Count == 3)
          {
                
                CADNivel3 GuardarCuenta = new CADNivel3();
                IDCuenta = GuardarCuenta.InsertJerar3(IDCuenta2, Nombre, Codigo, Estado);
                if (Estado == true)
                {
                    CADCoDMovimiento CMovimiento = new CADCoDMovimiento();
                    CMovimiento.InsertCMovimiento(IDCuenta, 0, 0);
                }
                return 1;
          }            
          if (IDCuenta4 == IDCuentaComodin && Count == 4)
          {
              CADNivel4 GuardarGrupo = new CADNivel4();
              IDCuenta = GuardarGrupo.InsertJerar4(IDCuenta3, Nombre, Codigo, Estado);
              if (Estado == true)
              {
                 CADCoDMovimiento CMovimiento = new CADCoDMovimiento();
                 CMovimiento.InsertCMovimiento(0, IDCuenta, 0);
              }
              return 1;
          }
          if (IDCuenta5 == IDCuentaComodin && Count == 5)
          {
             CADNivel5 GuardarGrupo = new CADNivel5();
             IDCuenta = GuardarGrupo.InsertJerar5(IDCuenta4, Nombre, Codigo, Estado);
             if (Estado == true)
             {
                CADCoDMovimiento CMovimiento = new CADCoDMovimiento();
                CMovimiento.InsertCMovimiento(0, 0, IDCuenta);
             }
             return 1;
          }
            return 0;
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (TxtCodigoClase.Text == "")
            {
                Alerta = new ClassToast(ClassColorAlerta.Alerta.Validado.ToString(), "ALERTA", "Debe ingresar un código.");
                return;
            }
            if (TxtNombreClase.Text == "")
            {
                Alerta = new ClassToast(ClassColorAlerta.Alerta.Validado.ToString(), "ALERTA", "Debe ingresar un nombre de cuenta.");
                return;
            }

            FrmPregunta FrmGuardar = new FrmPregunta();
            FrmGuardar.ShowDialog();
            if (FrmGuardar.Estado == true)
            {
                if (GuardarCrear(TxtNombreClase.Text.ToUpper(), TxtCodigoClase.Text.ToUpper(), CbEstado.Checked) == 1)
                {
                    Alerta = new ClassToast(ClassColorAlerta.Alerta.Guardado.ToString(), "GUARDADO", "Registro guardado correctamente.");
                    TxtCodigoClase.Text = "";
                    TxtNombreClase.Text = "";
                    return;
                }
            }
           
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
