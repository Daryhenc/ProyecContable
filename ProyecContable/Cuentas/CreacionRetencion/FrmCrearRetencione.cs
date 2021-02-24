using CADProContable.Niveles.Retencion;
using ProyecContable.BusquedaGeneral;
using ProyecContable.Estados;
using ProyecContable.Estados.Alerta;
using System;
using System.Windows.Forms;

namespace ProyecContable.Cuentas.CreacionRetencion
{
    public partial class FrmCrearRetencione : Form
    {
        public FrmCrearRetencione()
        {
            InitializeComponent();
            CbRetencion = new ClassLlenarCbRetencion();
            CbRetencion.LlenarCb(CbTipoRetencion);
            DgvLLenar = new ClassDgvRetencion();
            DgvLLenar.GetRetencion(DgvDato, Convert.ToInt32(CbTipoRetencion.SelectedValue));
            DgvDato.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        }

        ClassLlenarCbRetencion CbRetencion { get; set; }
        ClassDgvRetencion DgvLLenar { get; set; }
        ClassToast Alerta { get; set; }
        int IDCuenta;
        int CJ5;
        int CJ4;
        int CJ3;
        private void CbTipoRetencion_SelectionChangeCommitted(object sender, EventArgs e)
        {
            DgvLLenar = new ClassDgvRetencion();
            DgvLLenar.GetRetencion(DgvDato, Convert.ToInt32(CbTipoRetencion.SelectedValue));
        }

        private void BtnCuentaBuscar_Click(object sender, EventArgs e)
        {
            FrmBusquedaCuenta Busqueda = new FrmBusquedaCuenta();
            Busqueda.ShowDialog();
            if (Busqueda.Estado == true)
            {
                IDCuenta = Busqueda.IDCuentaMovimiento;
                CJ3 = Busqueda.CJ3;
                CJ4 = Busqueda.CJ4;
                CJ5 = Busqueda.CJ5;
                TxtCodCuenta.Text = Busqueda.Codigo;
                TxtCuenta.Text = Busqueda.Nombre;
            }
            else
            {
                IDCuenta = 0;
                TxtCodCuenta.Text = null;
                TxtCuenta.Text = null;
            }
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (TxtCodigo.Text == null || TxtCodigo.Text == "")
            {
                Alerta = new ClassToast(ClassColorAlerta.Alerta.Validado.ToString(), "ALERTA", "Ingresar código.");
                TxtCodigo.Focus();
                return;
            }
            if (TxtCodigoReferencia.Text == null || TxtCodigoReferencia.Text == "")
            {
                Alerta = new ClassToast(ClassColorAlerta.Alerta.Validado.ToString(), "ALERTA", "Ingresar código referencia.");
                TxtCodigoReferencia.Focus();
                return;
            }
            if (TxtPorcentaje.Text == null || TxtPorcentaje.Text == "")
            {
                Alerta = new ClassToast(ClassColorAlerta.Alerta.Validado.ToString(), "ALERTA", "Ingresar el procentaje.");
                TxtPorcentaje.Focus();
                return;
            }

            if (Convert.ToDecimal(TxtPorcentaje.Text) <=  0)
            {
                Alerta = new ClassToast(ClassColorAlerta.Alerta.Validado.ToString(), "ALERTA", "Ingresar el procentaje mayor a cero.");
                TxtPorcentaje.Focus();
                return;
            }
            FrmPregunta FrmGuardar = new FrmPregunta();
            FrmGuardar.ShowDialog();
            if (FrmGuardar.Estado == true)
            {
                CADRetencion Guardar = new CADRetencion();
                Guardar.InsertRetencion(Convert.ToInt32(CbTipoRetencion.SelectedValue),
                CJ3, CJ4, CJ5, TxtCodigo.Text.ToUpper(), TxtCodigoReferencia.Text.ToUpper(),
                TxtDescripcion.Text.ToUpper(), Convert.ToDecimal(TxtPorcentaje.Text));

                Alerta = new ClassToast(ClassColorAlerta.Alerta.Guardado.ToString(), "GUARDADO", "Registro guardado perfectamente.");

                TxtCodCuenta.Text = null;
                TxtCodigo.Text = null;
                TxtCodigoReferencia.Text = null;
                TxtCuenta.Text = null;
                TxtDescripcion.Text = null;
                TxtPorcentaje.Text = "0";
                DgvLLenar = new ClassDgvRetencion();
                DgvLLenar.GetRetencion(DgvDato, Convert.ToInt32(CbTipoRetencion.SelectedValue));
            }

        }

        private void TxtPorcentaje_Leave(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToDecimal(TxtPorcentaje.Text) <= 0)
                {
                    TxtPorcentaje.Text = "0";
                }
            }
            catch (Exception)
            {
                TxtPorcentaje.Text = "0";
            }
          
        }

        private void DgvDato_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvDato.CurrentRow == null)
            {
                return;
            }

            int Fila = e.RowIndex;
            int Column = e.ColumnIndex;

            if (Column == 0)
            {
                FrmPreguntaBorrar FrmBorrar = new FrmPreguntaBorrar();
                FrmBorrar.ShowDialog();
                if (FrmBorrar.Estado == true)
                {
                    CADRetencion Borrar = new CADRetencion();
                    Borrar.DeleteRetencion(Convert.ToInt32(DgvDato.Rows[Fila].Cells[2].Value));

                    Alerta = new ClassToast(ClassColorAlerta.Alerta.Guardado.ToString(), "ELIMINADO", "Registro borrado perfectamente.");
                    DgvLLenar = new ClassDgvRetencion();
                    DgvLLenar.GetRetencion(DgvDato, Convert.ToInt32(CbTipoRetencion.SelectedValue));

                }
            }
        }
    }
}
