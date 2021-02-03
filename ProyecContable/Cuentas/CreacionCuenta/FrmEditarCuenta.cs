using CADProContable.Niveles.Nivel1;
using CADProContable.Niveles.Nivel2;
using CADProContable.Niveles.Nivel3;
using CADProContable.Niveles.Nivel4;
using CADProContable.Niveles.Nivel5;
using ProyecContable.Estados;
using ProyecContable.Estados.Alerta;
using System.Windows.Forms;

namespace ProyecContable.Cuentas.CreacionCuenta
{
    public partial class FrmEditarCuenta : Form
    {
        public FrmEditarCuenta(int Count, int IDCuenta1, int IDCuenta2, int IDCuenta3, int IDCuenta4, int IDCuenta5, int IDCuentaComodin, string Codigo, string Nombre)
        {
            InitializeComponent();
            TxtCodigoClaseAn.Text = Codigo;
            TxtNombreClaseAn.Text = Nombre;         
            this.Count = Count;
            this.IDCuenta1 = IDCuenta1;
            this.IDCuenta2 = IDCuenta2;
            this.IDCuenta3 = IDCuenta3;
            this.IDCuenta4 = IDCuenta4;
            this.IDCuenta5 = IDCuenta5;
            this.IDCuentaComodin = IDCuentaComodin;
            NombreEditar();
        }

        ClassToast Alerta { get; set; }
        int Count;
        int IDCuenta1;
        int IDCuenta2;
        int IDCuenta3;
        int IDCuenta4;
        int IDCuenta5;
        int IDCuentaComodin;
        private void NombreEditar()
        {
            if (Count == 1)
            {
                LblCrearTitulo.Text = "EDITAR CLASE";
                return;
            }
            if (Count == 2)
            {
                LblCrearTitulo.Text = "EDITAR GRUPO";
                return;
            }
            if (Count == 3)
            {
                LblCrearTitulo.Text = "EDITAR CUENTA";
                return;
            }
            if (Count == 4)
            {
                LblCrearTitulo.Text = "EDITAR SUBCUENTA";
                return;
            }
            if (Count == 5)
            {
                LblCrearTitulo.Text = "EDITAR CUENTA AUXILIAR";
                return;
            }
        }

        private int GuardarEditar(string Nombre, string Codigo)
        {
            if ((IDCuenta1 == IDCuentaComodin) && Count == 1)
            {
                CADNivel1 GuardarEditar = new CADNivel1();
                GuardarEditar.UpdateJerar(Nombre, Codigo, IDCuenta1);
                return 1;
            }
            if ((IDCuenta2 == IDCuentaComodin) && Count == 2)
            {
                CADNivel2 GuardarEditar = new CADNivel2();
                GuardarEditar.UpdateJerar2( Nombre, Codigo, IDCuenta2);
                return 1;
            }
            if ((IDCuenta3 == IDCuentaComodin) && Count == 3)
            {
                CADNivel3 GuardarCuenta = new CADNivel3();
                GuardarCuenta.UpdateJerar3(Nombre, Codigo, IDCuenta3);
                return 1;
            }
            if (IDCuenta4 == IDCuentaComodin && Count == 4)
            {
                CADNivel4 GuardarEditar = new CADNivel4();
                GuardarEditar.UpdateJerar4(Nombre, Codigo, IDCuenta4);
                return 1;
            }
            if (IDCuenta5 == IDCuentaComodin && Count == 5)
            {
                CADNivel5 GuardarEditar = new CADNivel5();
                GuardarEditar.UpdateJerar5(Nombre, Codigo, IDCuenta5);
                return 1;
            }

            return 0;
        }

        private void BtnCerrar_Click(object sender, System.EventArgs e)
        {
            this.Close();
        }

        private void BtnGuardar_Click(object sender, System.EventArgs e)
        {
            if (TxtCodigoClaseNu.Text == "")
            {
                Alerta = new ClassToast(ClassColorAlerta.Alerta.Validado.ToString(), "ALERTA", "Debe ingresar un código.");
                return;
            }
            if (TxtNombreClaseNu.Text == "")
            {
                Alerta = new ClassToast(ClassColorAlerta.Alerta.Validado.ToString(), "ALERTA", "Debe ingresar un nombre de cuenta.");
                return;
            }

            FrmPregunta FrmGuardar = new FrmPregunta();
            FrmGuardar.ShowDialog();
            if (FrmGuardar.Estado == true)
            {
                if (GuardarEditar(TxtNombreClaseNu.Text.ToUpper(), TxtCodigoClaseNu.Text.ToUpper()) == 1)
                {
                    Alerta = new ClassToast(ClassColorAlerta.Alerta.Actualizado.ToString(), "ACTUALIZADO", "Registro actualizado correctamente.");
                    this.Close();                    
                }
            }
        
        }
    }
}
