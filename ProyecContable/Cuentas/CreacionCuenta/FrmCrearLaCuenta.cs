using CADProContable.Niveles.Nivel1;
using CADProContable.Niveles.Nivel2;
using CADProContable.Niveles.Nivel3;
using ProyecContable.Estados;
using ProyecContable.Estados.Alerta;
using System;
using System.Windows.Forms;

namespace ProyecContable.Cuentas.CreacionCuenta
{
    public partial class FrmCrearLaCuenta : Form
    {
        public FrmCrearLaCuenta(int Count, int IDCuenta, int IDCuenta2,  int IDCuentaComodin)
        {
            InitializeComponent();
            this.Count = Count;
            this.IDCuenta = IDCuenta;
            this.IDCuenta2 = IDCuenta2;
            this.IDCuentaComodin = IDCuentaComodin;
            NombreCrear();
        }

        int Count;
        int IDCuenta;
        int IDCuenta2;
        int IDCuentaComodin;
        ClassToast Alerta { get; set; }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
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
                if (GuardarCrear(TxtNombreClase.Text.ToUpper(), TxtCodigoClase.Text.ToUpper()) == 1)
                {
                    Alerta = new ClassToast(ClassColorAlerta.Alerta.Guardado.ToString(), "GUARDADO", "Registro guardado correctamente.");
                    return;
                }
            }                  
        }

        private void NombreCrear()
        {
            if (Count == 1)
            {
                LblCrearTitulo.Text = "CREAR CUENTA CLASE";
                return;
            }
            if (Count == 2)
            {
                LblCrearTitulo.Text = "CREAR CUENTA GRUPO";
                return;
            }
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
                return;
            }
        }
        private int GuardarCrear(string Nombre, string Codigo)
        {
            if ((IDCuenta == IDCuentaComodin) && (Count == 1))
            {
                CADNivel1 GuardarClase = new CADNivel1();
                GuardarClase.InsertJerar(Nombre, Codigo);            
                TxtCodigoClase.Text = "";
                TxtNombreClase.Text = "";
                return 1;
            }
            
            if ((IDCuenta2 == IDCuentaComodin) && (Count == 2))
            {
                CADNivel2 GuardarGrupo = new CADNivel2();
                GuardarGrupo.InsertJerar2(IDCuenta, Nombre, Codigo);
                TxtCodigoClase.Text = "";
                TxtNombreClase.Text = "";
                return 1;
            }

            return 0;
        }

    }
}
