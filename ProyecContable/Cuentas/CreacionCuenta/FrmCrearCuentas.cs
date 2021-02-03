using CADProContable.Niveles.CMovimiento;
using CADProContable.Niveles.Nivel1;
using CADProContable.Niveles.Nivel2;
using CADProContable.Niveles.Nivel3;
using CADProContable.Niveles.Nivel4;
using CADProContable.Niveles.Nivel5;
using ProyecContable.Estados;
using ProyecContable.Estados.Alerta;
using System;
using System.Windows.Forms;

namespace ProyecContable.Cuentas.CreacionCuenta
{
    public partial class FrmCrearCuentas : Form
    {
        public FrmCrearCuentas()
        {
            InitializeComponent();
            //LLama todos los combo
            CbClase = new ClassLlenarCbClase();
            CbClase.Llenar(CbNivel1, TxtCodigoClase);
            CbGrupo = new ClassLLenarCbGrupo();
            CbGrupo.Llenar(CbNivel2, Convert.ToInt32(CbNivel1.SelectedValue), TxtCodigoGrupo);
            CbCuenta = new ClassLlenarCbCuenta();
            CbCuenta.Llenar(CbNivel3, Convert.ToInt32(CbNivel2.SelectedValue), RbTransaccional3, TxtCodigoCuenta);
            CbSubCuenta = new ClassLlenarCbSubCuenta();
            CbSubCuenta.Llenar(CbNivel4, Convert.ToInt32(CbNivel3.SelectedValue), RbTransaccional4, TxtCodigoSubCuenta);
            CbAuxiliar = new ClassLlenarCbAuxiliar();
            CbAuxiliar.Llenar(CbNivel5, Convert.ToInt32(CbNivel4.SelectedValue), RbTransaccional5, TxtCodigoAuxiliar);
        }

        ClassLlenarCbClase CbClase { get; set; }
        ClassLLenarCbGrupo CbGrupo { get; set; }
        ClassLlenarCbCuenta CbCuenta { get; set; }
        ClassLlenarCbSubCuenta CbSubCuenta { get; set; }
        ClassLlenarCbAuxiliar CbAuxiliar { get; set; }
        FrmCrearLaCuenta FrmCrear  { get; set; }
        FrmEditarCuenta FrmEditar { get; set; }
        FrmCrearLaCuentaFinales FrmCrearCuentaTrans { get; set; }
        FrmPreguntaBorrar FrmMensajeBorrar { get; set; }

        ClassToast Mensajes { get; set; }



        private void CbNivel1_SelectionChangeCommitted(object sender, System.EventArgs e)
        {
            // LLENAR CODIGO
            CbClase = new ClassLlenarCbClase();
            CbClase.LLenarCodigoClase(Convert.ToInt32(CbNivel1.SelectedValue), TxtCodigoClase);
            // LLENAR GRUPO
            CbGrupo = new ClassLLenarCbGrupo();
            CbGrupo.Llenar(CbNivel2, Convert.ToInt32(CbNivel1.SelectedValue), TxtCodigoGrupo);
            // LLENAR CUENTA
            CbCuenta = new ClassLlenarCbCuenta();
            CbCuenta.Llenar(CbNivel3, Convert.ToInt32(CbNivel2.SelectedValue), RbTransaccional3, TxtCodigoCuenta);
            // LLENAR SUB CUENTA
            CbSubCuenta = new ClassLlenarCbSubCuenta();
            CbSubCuenta.Llenar(CbNivel4, Convert.ToInt32(CbNivel3.SelectedValue), RbTransaccional4, TxtCodigoSubCuenta);
            // LLENAR aUXILIAR
            CbAuxiliar = new ClassLlenarCbAuxiliar();
            CbAuxiliar.Llenar(CbNivel5, Convert.ToInt32(CbNivel4.SelectedValue), RbTransaccional5, TxtCodigoAuxiliar);
        }

        private void CbNivel2_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // LLENAR CODIGO GRUPO
            CbGrupo = new ClassLLenarCbGrupo();
            CbGrupo.LLenarCodigoGrupo(Convert.ToInt32(CbNivel2.SelectedValue), TxtCodigoGrupo);
            // LLENAR CUENTA
            CbCuenta = new ClassLlenarCbCuenta();
            CbCuenta.Llenar(CbNivel3, Convert.ToInt32(CbNivel2.SelectedValue), RbTransaccional3, TxtCodigoCuenta);
            // LLENAR SUB CUENTA
            CbSubCuenta = new ClassLlenarCbSubCuenta();
            CbSubCuenta.Llenar(CbNivel4, Convert.ToInt32(CbNivel3.SelectedValue), RbTransaccional4, TxtCodigoSubCuenta);
            // LLENAR aUXILIAR
            CbAuxiliar = new ClassLlenarCbAuxiliar();
            CbAuxiliar.Llenar(CbNivel5, Convert.ToInt32(CbNivel4.SelectedValue), RbTransaccional5, TxtCodigoAuxiliar);
        }

        private void CbNivel3_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // LLENAR CODIGO CUENTA
            CbCuenta.LLenarCodigoCuenta(Convert.ToInt32(CbNivel3.SelectedValue), RbTransaccional3, TxtCodigoCuenta);
            // LLENAR SUB CUENTA
            CbSubCuenta = new ClassLlenarCbSubCuenta();
            CbSubCuenta.Llenar(CbNivel4, Convert.ToInt32(CbNivel3.SelectedValue), RbTransaccional4, TxtCodigoSubCuenta);
            // LLENAR aUXILIAR
            CbAuxiliar = new ClassLlenarCbAuxiliar();
            CbAuxiliar.Llenar(CbNivel5, Convert.ToInt32(CbNivel4.SelectedValue), RbTransaccional5, TxtCodigoAuxiliar);
        }

        private void CbNivel4_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // LLENAR CODIGO SUB CUENTA
            CbSubCuenta.LLenarCodigoSubCuenta(Convert.ToInt32(CbNivel4.SelectedValue), RbTransaccional4, TxtCodigoSubCuenta);
            // LLENAR aUXILIAR
            CbAuxiliar = new ClassLlenarCbAuxiliar();
            CbAuxiliar.Llenar(CbNivel5, Convert.ToInt32(CbNivel4.SelectedValue), RbTransaccional5, TxtCodigoAuxiliar);
        }

        private void CbNivel5_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // LLENAR aUXILIAR
            CbAuxiliar = new ClassLlenarCbAuxiliar();
            CbAuxiliar.LLenarCodigoAuxiliar(Convert.ToInt32(CbNivel5.SelectedValue), RbTransaccional5, TxtCodigoAuxiliar);
        }

        private void BtnCrear1_Click(object sender, EventArgs e)
        {
            FrmCrear = new FrmCrearLaCuenta(1,
            Convert.ToInt32(CbNivel1.SelectedValue), Convert.ToInt32(CbNivel2.SelectedValue),
            Convert.ToInt32(CbNivel1.SelectedValue));
            FrmCrear.ShowDialog();
            RefreshCb(1);
        }
        private void BtnCrear2_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(CbNivel1.SelectedValue) == 0)
            {
                return;
            }
            FrmCrear = new FrmCrearLaCuenta(2,
            Convert.ToInt32(CbNivel1.SelectedValue), Convert.ToInt32(CbNivel2.SelectedValue),
            Convert.ToInt32(CbNivel2.SelectedValue));
            FrmCrear.ShowDialog();   
            RefreshCb(2);
        }
        private void BtnCrear3_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(CbNivel2.SelectedValue) == 0)
            {
                return;
            }

            FrmCrearCuentaTrans = new FrmCrearLaCuentaFinales(3, 
            Convert.ToInt32(CbNivel2.SelectedValue), Convert.ToInt32(CbNivel3.SelectedValue), 
            Convert.ToInt32(CbNivel4.SelectedValue), Convert.ToInt32(CbNivel5.SelectedValue), 
            Convert.ToInt32(CbNivel3.SelectedValue));
            FrmCrearCuentaTrans.ShowDialog();
            RefreshCb(3);
        }
        private void BtnCrear4_Click(object sender, EventArgs e)
        {
            if (RbTransaccional3.Checked == true)
            {
                return;
            }
            if (Convert.ToInt32(CbNivel3.SelectedValue) == 0)
            {
                return;
            }

            FrmCrearCuentaTrans = new FrmCrearLaCuentaFinales(4,
            Convert.ToInt32(CbNivel2.SelectedValue), Convert.ToInt32(CbNivel3.SelectedValue),
            Convert.ToInt32(CbNivel4.SelectedValue), Convert.ToInt32(CbNivel5.SelectedValue),
            Convert.ToInt32(CbNivel4.SelectedValue));
            FrmCrearCuentaTrans.ShowDialog();
            RefreshCb(4);
        }
        private void BtnCrear5_Click(object sender, EventArgs e)
        {
            if (RbTransaccional4.Checked == true)
            {
                return;
            }
            if (Convert.ToInt32(CbNivel4.SelectedValue) == 0)
            {
                return;
            }

            FrmCrearCuentaTrans = new FrmCrearLaCuentaFinales(5,
            Convert.ToInt32(CbNivel2.SelectedValue), Convert.ToInt32(CbNivel3.SelectedValue),
            Convert.ToInt32(CbNivel4.SelectedValue), Convert.ToInt32(CbNivel5.SelectedValue),
            Convert.ToInt32(CbNivel5.SelectedValue));
            FrmCrearCuentaTrans.ShowDialog();
            RefreshCb(5);
        }
        private void BtnEditar1_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(CbNivel1.SelectedValue) == 0)
            {
                return;
            }
            FrmEditar = new FrmEditarCuenta(1, Convert.ToInt32(CbNivel1.SelectedValue), Convert.ToInt32(CbNivel2.SelectedValue),
            Convert.ToInt32(CbNivel3.SelectedValue), Convert.ToInt32(CbNivel4.SelectedValue), Convert.ToInt32(CbNivel5.SelectedValue),
            Convert.ToInt32(CbNivel1.SelectedValue), TxtCodigoClase.Text, CbNivel1.Text);
            FrmEditar.ShowDialog();
            RefreshCb(1);
        }
        private void BtnEditar2_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(CbNivel2.SelectedValue) == 0)
            {
                return;
            }
            FrmEditar = new FrmEditarCuenta(2, Convert.ToInt32(CbNivel1.SelectedValue), Convert.ToInt32(CbNivel2.SelectedValue),
            Convert.ToInt32(CbNivel3.SelectedValue), Convert.ToInt32(CbNivel4.SelectedValue), Convert.ToInt32(CbNivel5.SelectedValue),
            Convert.ToInt32(CbNivel2.SelectedValue), TxtCodigoGrupo.Text, CbNivel2.Text);
            FrmEditar.ShowDialog();
            RefreshCb(2);
        }
        private void BtnEditar3_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(CbNivel3.SelectedValue) == 0)
            {
                return;
            }
            FrmEditar = new FrmEditarCuenta(3, Convert.ToInt32(CbNivel1.SelectedValue), Convert.ToInt32(CbNivel2.SelectedValue),
            Convert.ToInt32(CbNivel3.SelectedValue), Convert.ToInt32(CbNivel4.SelectedValue), Convert.ToInt32(CbNivel5.SelectedValue),
            Convert.ToInt32(CbNivel3.SelectedValue), TxtCodigoCuenta.Text, CbNivel3.Text);
            FrmEditar.ShowDialog();
            RefreshCb(3);
        }
        private void BtnEditar4_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(CbNivel4.SelectedValue) == 0)
            {
                return;
            }
            FrmEditar = new FrmEditarCuenta(4, Convert.ToInt32(CbNivel1.SelectedValue), Convert.ToInt32(CbNivel2.SelectedValue),
            Convert.ToInt32(CbNivel3.SelectedValue), Convert.ToInt32(CbNivel4.SelectedValue), Convert.ToInt32(CbNivel5.SelectedValue),
            Convert.ToInt32(CbNivel4.SelectedValue), TxtCodigoSubCuenta.Text, CbNivel4.Text);
            FrmEditar.ShowDialog();
            RefreshCb(4);
        }
        private void BtnEditar5_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(CbNivel5.SelectedValue) == 0)
            {
                return;
            }
            FrmEditar = new FrmEditarCuenta(5, Convert.ToInt32(CbNivel1.SelectedValue), Convert.ToInt32(CbNivel2.SelectedValue),
            Convert.ToInt32(CbNivel3.SelectedValue), Convert.ToInt32(CbNivel4.SelectedValue), Convert.ToInt32(CbNivel5.SelectedValue),
            Convert.ToInt32(CbNivel5.SelectedValue), TxtCodigoSubCuenta.Text, CbNivel4.Text);
            FrmEditar.ShowDialog();
            RefreshCb(5);
        }
        private void BtnBorrar1_Click(object sender, EventArgs e)
        {
            FrmMensajeBorrar = new FrmPreguntaBorrar();
            FrmMensajeBorrar.ShowDialog();
            if (FrmMensajeBorrar.Estado == true)
            {
                try
                {
                    CADNivel1 CN1 = new CADNivel1();
                    int IDNivel1 = Convert.ToInt32(CbNivel1.SelectedValue);
                    CN1.DeleteJerar(IDNivel1);

                    Mensajes = new ClassToast(ClassColorAlerta.Alerta.Actualizado.ToString(), "ACTUALIZADO", "Registro borrado correctamente.");
                    // LLENAR CLASE
                    CbClase = new ClassLlenarCbClase();
                    CbClase.Llenar(CbNivel1, TxtCodigoClase);
                    // LLENAR GRUPO
                    CbGrupo = new ClassLLenarCbGrupo();
                    CbGrupo.Llenar(CbNivel2, Convert.ToInt32(CbNivel1.SelectedValue), TxtCodigoGrupo);
                    // LLENAR CUENTA
                    CbCuenta = new ClassLlenarCbCuenta();
                    CbCuenta.Llenar(CbNivel3, Convert.ToInt32(CbNivel2.SelectedValue), RbTransaccional3, TxtCodigoCuenta);
                    // LLENAR SUBCUENTA
                    CbSubCuenta = new ClassLlenarCbSubCuenta();
                    CbSubCuenta.Llenar(CbNivel4, Convert.ToInt32(CbNivel3.SelectedValue), RbTransaccional4, TxtCodigoSubCuenta);
                    // LLENAR AUXILIAR
                    CbAuxiliar = new ClassLlenarCbAuxiliar();
                    CbAuxiliar.Llenar(CbNivel5, Convert.ToInt32(CbNivel4.SelectedValue), RbTransaccional5, TxtCodigoAuxiliar);
                }
                catch (Exception)
                {
                    Mensajes = new ClassToast(ClassColorAlerta.Alerta.Error.ToString(), "ERROR", "Problemas entre tablas enlazadas.");
                }
            }
        }
        private void BtnBorrar2_Click(object sender, EventArgs e)
        {
            FrmMensajeBorrar = new FrmPreguntaBorrar();
            FrmMensajeBorrar.ShowDialog();
            if (FrmMensajeBorrar.Estado == true)
            {
                try
                {
                    CADNivel2 CN2 = new CADNivel2();                    
                    int IDNivel2 = Convert.ToInt32(CbNivel2.SelectedValue);
                    CN2.DeleteJerar2(IDNivel2);
                    
                    Mensajes = new ClassToast(ClassColorAlerta.Alerta.Actualizado.ToString(), "ACTUALIZADO", "Registro borrado correctamente.");
                    // LLENAR GRUPO
                    CbGrupo = new ClassLLenarCbGrupo();
                    CbGrupo.Llenar(CbNivel2, Convert.ToInt32(CbNivel1.SelectedValue), TxtCodigoGrupo);
                    // LLENAR CUENTA
                    CbCuenta = new ClassLlenarCbCuenta();
                    CbCuenta.Llenar(CbNivel3, Convert.ToInt32(CbNivel2.SelectedValue), RbTransaccional3, TxtCodigoCuenta);
                    // LLENAR SUBCUENTA
                    CbSubCuenta = new ClassLlenarCbSubCuenta();
                    CbSubCuenta.Llenar(CbNivel4, Convert.ToInt32(CbNivel3.SelectedValue), RbTransaccional4, TxtCodigoSubCuenta);
                    // LLENAR AUXILIAR
                    CbAuxiliar = new ClassLlenarCbAuxiliar();
                    CbAuxiliar.Llenar(CbNivel5, Convert.ToInt32(CbNivel4.SelectedValue), RbTransaccional5, TxtCodigoAuxiliar);
                }
                catch (Exception)
                {
                    Mensajes = new ClassToast(ClassColorAlerta.Alerta.Error.ToString(), "ERROR", "Problemas entre tablas enlazadas.");
                }
            }
        }
        private void BtnBorrar3_Click(object sender, EventArgs e)
        {
            FrmMensajeBorrar = new FrmPreguntaBorrar();
            FrmMensajeBorrar.ShowDialog();
            if (FrmMensajeBorrar.Estado == true)
            {
                try
                {
                    CADNivel3 CN3 = new CADNivel3();
                    CADCoDMovimiento CMovimiento = new CADCoDMovimiento();

                    int IDNivel3 = Convert.ToInt32(CbNivel3.SelectedValue);
                    CN3.DeleteJerar3(IDNivel3);
                    CMovimiento.DeleteJerar3(IDNivel3);

                    Mensajes = new ClassToast(ClassColorAlerta.Alerta.Actualizado.ToString(), "ACTUALIZADO", "Registro borrado correctamente.");

                    // LLENAR CUENTA
                    CbCuenta = new ClassLlenarCbCuenta();
                    CbCuenta.Llenar(CbNivel3, Convert.ToInt32(CbNivel2.SelectedValue), RbTransaccional3, TxtCodigoCuenta);
                    // LLENAR SUBCUENTA
                    CbSubCuenta = new ClassLlenarCbSubCuenta();
                    CbSubCuenta.Llenar(CbNivel4, Convert.ToInt32(CbNivel3.SelectedValue), RbTransaccional4, TxtCodigoSubCuenta);
                    // LLENAR AUXILIAR
                    CbAuxiliar = new ClassLlenarCbAuxiliar();
                    CbAuxiliar.Llenar(CbNivel5, Convert.ToInt32(CbNivel4.SelectedValue), RbTransaccional5, TxtCodigoAuxiliar);
                }
                catch (Exception)
                {
                    Mensajes = new ClassToast(ClassColorAlerta.Alerta.Error.ToString(), "ERROR", "Problemas entre tablas enlazadas.");
                }
            }
        }
        private void BtnBorrar4_Click(object sender, EventArgs e)
        {
            FrmMensajeBorrar = new FrmPreguntaBorrar();
            FrmMensajeBorrar.ShowDialog();
            if (FrmMensajeBorrar.Estado == true)
            {
                try
                {
                    CADNivel4 CN4 = new CADNivel4();
                    CADCoDMovimiento CMovimiento = new CADCoDMovimiento();

                    int IDNivel4 = Convert.ToInt32(CbNivel4.SelectedValue);
                    CN4.DeleteJerar4(IDNivel4);
                    CMovimiento.DeleteJerar4(IDNivel4);

                    Mensajes = new ClassToast(ClassColorAlerta.Alerta.Actualizado.ToString(), "ACTUALIZADO", "Registro borrado correctamente.");

                    // LLENAR SUBCUENTA
                    CbSubCuenta = new ClassLlenarCbSubCuenta();
                    CbSubCuenta.Llenar(CbNivel4, Convert.ToInt32(CbNivel3.SelectedValue), RbTransaccional4, TxtCodigoSubCuenta);
                    // LLENAR AUXILIAR
                    CbAuxiliar = new ClassLlenarCbAuxiliar();
                    CbAuxiliar.Llenar(CbNivel5, Convert.ToInt32(CbNivel4.SelectedValue), RbTransaccional5, TxtCodigoAuxiliar);
                }
                catch (Exception)
                {
                    Mensajes = new ClassToast(ClassColorAlerta.Alerta.Error.ToString(), "ERROR", "Problemas entre tablas enlazadas.");
                }
            }
        }
        private void BtnBorrar5_Click(object sender, EventArgs e)
        {
            FrmMensajeBorrar = new FrmPreguntaBorrar();
            FrmMensajeBorrar.ShowDialog();
            if (FrmMensajeBorrar.Estado == true)
            {
                try
                {
                    
                    CADNivel5 CN5 = new CADNivel5();
                    CADCoDMovimiento CMovimiento = new CADCoDMovimiento();

                    int IDNivel5 = Convert.ToInt32(CbNivel5.SelectedValue);
                    CN5.DeleteJerar5(IDNivel5);
                    CMovimiento.DeleteJerar5(IDNivel5);

                    Mensajes = new ClassToast(ClassColorAlerta.Alerta.Actualizado.ToString(), "ACTUALIZADO", "Registro borrado correctamente.");

                    // LLENAR AUXILIAR
                    CbAuxiliar = new ClassLlenarCbAuxiliar();
                    CbAuxiliar.Llenar(CbNivel5, Convert.ToInt32(CbNivel4.SelectedValue), RbTransaccional5, TxtCodigoAuxiliar);
                    

                }
                catch (Exception)
                {
                    Mensajes = new ClassToast(ClassColorAlerta.Alerta.Error.ToString(), "ERROR", "Problemas entre tablas enlazadas.");
                }
            }
        }




        private void RefreshCb(int IDCount)
        {
            if (IDCount == 1)
            {
                // LLENAR CODIGO
                CbClase = new ClassLlenarCbClase();
                CbClase.LLenarCodigoClase(Convert.ToInt32(CbNivel1.SelectedValue), TxtCodigoClase);
                // LLENAR GRUPO
                CbGrupo = new ClassLLenarCbGrupo();
                CbGrupo.Llenar(CbNivel2, Convert.ToInt32(CbNivel1.SelectedValue), TxtCodigoGrupo);
                // LLENAR CUENTA
                CbCuenta = new ClassLlenarCbCuenta();
                CbCuenta.Llenar(CbNivel3, Convert.ToInt32(CbNivel2.SelectedValue), RbTransaccional3, TxtCodigoCuenta);
                // LLENAR SUB CUENTA
                CbSubCuenta = new ClassLlenarCbSubCuenta();
                CbSubCuenta.Llenar(CbNivel4, Convert.ToInt32(CbNivel3.SelectedValue), RbTransaccional4, TxtCodigoSubCuenta);
                // LLENAR aUXILIAR
                CbAuxiliar = new ClassLlenarCbAuxiliar();
                CbAuxiliar.Llenar(CbNivel5, Convert.ToInt32(CbNivel4.SelectedValue), RbTransaccional5, TxtCodigoAuxiliar);
                return;
            }
            if (IDCount == 2)
            {
                // LLENAR CODIGO GRUPO
                CbGrupo = new ClassLLenarCbGrupo();
                CbGrupo.LLenarCodigoGrupo(Convert.ToInt32(CbNivel2.SelectedValue), TxtCodigoGrupo);
                // LLENAR CUENTA
                CbCuenta = new ClassLlenarCbCuenta();
                CbCuenta.Llenar(CbNivel3, Convert.ToInt32(CbNivel2.SelectedValue), RbTransaccional3, TxtCodigoCuenta);
                // LLENAR SUB CUENTA
                CbSubCuenta = new ClassLlenarCbSubCuenta();
                CbSubCuenta.Llenar(CbNivel4, Convert.ToInt32(CbNivel3.SelectedValue), RbTransaccional4, TxtCodigoSubCuenta);
                // LLENAR aUXILIAR
                CbAuxiliar = new ClassLlenarCbAuxiliar();
                CbAuxiliar.Llenar(CbNivel5, Convert.ToInt32(CbNivel4.SelectedValue), RbTransaccional5, TxtCodigoAuxiliar);
            }
            if (IDCount == 3)
            {
                // LLENAR CODIGO CUENTA
                CbCuenta.LLenarCodigoCuenta(Convert.ToInt32(CbNivel3.SelectedValue), RbTransaccional3, TxtCodigoCuenta);
                // LLENAR SUB CUENTA
                CbSubCuenta = new ClassLlenarCbSubCuenta();
                CbSubCuenta.Llenar(CbNivel4, Convert.ToInt32(CbNivel3.SelectedValue), RbTransaccional4, TxtCodigoSubCuenta);
                // LLENAR aUXILIAR
                CbAuxiliar = new ClassLlenarCbAuxiliar();
                CbAuxiliar.Llenar(CbNivel5, Convert.ToInt32(CbNivel4.SelectedValue), RbTransaccional5, TxtCodigoAuxiliar);
            }
            if (IDCount == 4)
            {
                // LLENAR CODIGO SUB CUENTA
                CbSubCuenta.LLenarCodigoSubCuenta(Convert.ToInt32(CbNivel4.SelectedValue), RbTransaccional4, TxtCodigoSubCuenta);
                // LLENAR aUXILIAR
                CbAuxiliar = new ClassLlenarCbAuxiliar();
                CbAuxiliar.Llenar(CbNivel5, Convert.ToInt32(CbNivel4.SelectedValue), RbTransaccional5, TxtCodigoAuxiliar);
            }
            if (IDCount == 5)
            {
                // LLENAR aUXILIAR
                CbAuxiliar = new ClassLlenarCbAuxiliar();
                CbAuxiliar.LLenarCodigoAuxiliar(Convert.ToInt32(CbNivel5.SelectedValue), RbTransaccional5, TxtCodigoAuxiliar);
            }
        }
    }
}
