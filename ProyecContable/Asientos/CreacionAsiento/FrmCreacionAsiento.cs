using ProyecContable.Asientos.CreacionAsiento.Actividades;
using ProyecContable.Asientos.CreacionAsiento.DatoCuenta;
using ProyecContable.Asientos.CreacionAsiento.GuardarAsiento;
using ProyecContable.Asientos.CreacionAsiento.LlenarText;
using ProyecContable.Estados;
using ProyecContable.Estados.Alerta;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyecContable.Asientos.CreacionAsiento
{
    public partial class FrmCreacionAsiento : Form
    {
        public FrmCreacionAsiento()
        {
            InitializeComponent();
            LlenarCodigo.LlenarAutoComplete(TxtCodigoCuenta);
            DgvDatos.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            RbIngreso.Checked = true;
            EstadoComp();
        }

        ClassLlenarCodigo LlenarCodigo = new ClassLlenarCodigo();
        ClassDatoCuenta DatoCuenta = new ClassDatoCuenta();
        List<ClassDatoCuentaAgregar> ListDatos = new List<ClassDatoCuentaAgregar>();
        ClassToast Alerta { get; set; }
        ClassLlenarDgv LlenarDgv { get; set; }
        int Estado;
        private void TxtDebe_Leave(object sender, EventArgs e)
        {
            try
            {
               
                if (Convert.ToDecimal(TxtDebe.Text) > 0)
                {
                    TxtHaber.Text = "0";
                }
                if (Convert.ToDecimal(TxtDebe.Text) < 0)
                {
                    TxtDebe.Text = "0";
                }
            }
            catch (Exception)
            {
                TxtDebe.Text = "0";
            }
        }

        private void TxtHaber_Leave(object sender, EventArgs e)
        {
            try
            {

                if (Convert.ToDecimal(TxtHaber.Text) > 0)
                {
                    TxtDebe.Text = "0";
                }
                if (Convert.ToDecimal(TxtHaber.Text) < 0)
                {
                    TxtHaber.Text = "0";
                }
            }
            catch (Exception)
            {
                TxtHaber.Text = "0";
            }
        }

        private void TxtCodigoCuenta_Leave(object sender, EventArgs e)
        {
            if (LlenarCodigo.Existe(TxtCodigoCuenta.Text) == true)
            {
                LlenarCodigo.RetornaLista(TxtCodigoCuenta.Text, TxtNombreCuenta, DatoCuenta);
            }
            else
            {
                DatoCuenta.IDCuentaMovimiento = 0;
                DatoCuenta.Nombre = null;
                DatoCuenta.Codigo = null;
                TxtNombreCuenta.Text = "";
            }
        }

     

        private void DgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvDatos.CurrentRow == null)
            {
                return;
            }

            int Fila = e.RowIndex;
            int Column = e.ColumnIndex;

            // MOSTRAR COMPRA O VENTA
            if (Column == 0)
            {
                LlenarDgv = new ClassLlenarDgv();
                LlenarDgv.Borrar(ListDatos, Convert.ToInt32(DgvDatos.Rows[Fila].Cells[1].Value));
                LlenarDgv.LlenarDgv(DgvDatos, ListDatos);
                LlenarDgv.TDebeHaber(ListDatos, TxtTotalDebe, TxtTotalHaber);
                return;
            }
        }

        #region Botones
        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            if (DatoCuenta.IDCuentaMovimiento == 0)
            {
                Alerta = new ClassToast(ClassColorAlerta.Alerta.Validado.ToString(), "ALERTA", "Debe ingresar un código de cuenta.");
                TxtCodigoCuenta.Focus();
                return;
            }
            if (TxtConcepto.Text == null || TxtConcepto.Text == "")
            {
                Alerta = new ClassToast(ClassColorAlerta.Alerta.Validado.ToString(), "ALERTA", "Debe ingresar un concepto.");
                TxtConcepto.Focus();
                return;
            }
            if (Convert.ToDecimal(TxtDebe.Text) == 0 && Convert.ToDecimal(TxtHaber.Text) == 0)
            {
                Alerta = new ClassToast(ClassColorAlerta.Alerta.Validado.ToString(), "ALERTA", "Ingresar valor en el DEBE o en el HABER.");
                TxtDebe.Focus();
                return;
            }

            LlenarDgv = new ClassLlenarDgv();
            LlenarDgv.Crear(DatoCuenta, ListDatos, TxtConcepto.Text, Convert.ToDecimal(TxtDebe.Text), Convert.ToDecimal(TxtHaber.Text));
            LlenarDgv.LlenarDgv(DgvDatos, ListDatos);
            LlenarDgv.TDebeHaber(ListDatos, TxtTotalDebe, TxtTotalHaber);
            TxtCodigoCuenta.Text = null;
            TxtNombreCuenta.Text = null;
            TxtConcepto.Text = null;
            TxtDebe.Text = "0";
            TxtHaber.Text = "0";
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (TxtComprobante.Text == null || TxtComprobante.Text == "")
            {
                Alerta = new ClassToast(ClassColorAlerta.Alerta.Validado.ToString(), "ALERTA", "Ingresar un código de comprobante.");
                TxtComprobante.Focus();
                return;
            }
            if (TxtDocReferencia.Text == null || TxtDocReferencia.Text == "")
            {
                Alerta = new ClassToast(ClassColorAlerta.Alerta.Validado.ToString(), "ALERTA", "Ingresar un doc. de referencia.");
                TxtDocReferencia.Focus();
                return;
            }
            if (TxtConceptoGeneral.Text == null || TxtConceptoGeneral.Text == "")
            {
                Alerta = new ClassToast(ClassColorAlerta.Alerta.Validado.ToString(), "ALERTA", "Ingresar concepto general.");
                TxtDocReferencia.Focus();
                return;
            }
            if (ListDatos.Count == 0)
            {
                Alerta = new ClassToast(ClassColorAlerta.Alerta.Error.ToString(), "ALTO", "Debe ingresar cuentas.");
                TxtCodigoCuenta.Focus();
                return;

            }
            if (Convert.ToDecimal(TxtTotalDebe.Text) != Convert.ToDecimal(TxtTotalHaber.Text))
            {
                Alerta = new ClassToast(ClassColorAlerta.Alerta.Validado.ToString(), "ALERTA", "El DEBE es diferente al HABER.");
                return;
            }

            string Fecha = TxtFecha.Value.Date.ToString("dd-MM-yyyy ") + TxtHora.Value.ToLongTimeString();
            ClassGuardarAsiento Guardar = new ClassGuardarAsiento();
            Guardar.GuardarAsientoContable(Estado, Convert.ToInt32(TxtComprobante.Text), TxtDocReferencia.Text.ToUpper(), TxtConceptoGeneral.Text.ToUpper(), 
            ListDatos, Convert.ToDateTime(Fecha));

            TxtFecha.Value = DateTime.Now;
            TxtHora.Value = DateTime.Now;
            TxtDocReferencia.Text = null;
            TxtConceptoGeneral.Text = null;
            TxtComprobante.Text = null;
            ListDatos.Clear();
            DgvDatos.Rows.Clear();
            LlenarDgv = new ClassLlenarDgv();
            LlenarDgv.TDebeHaber(ListDatos, TxtTotalDebe, TxtTotalHaber);

            Alerta = new ClassToast(ClassColorAlerta.Alerta.Guardado.ToString(), "GUARDADO", "Registro guardado perfectamente.");
        }


        #endregion

        private void RbIngreso_CheckedChanged(object sender, EventArgs e)
        {
            EstadoComp();
        }

        private void RbEgreso_CheckedChanged(object sender, EventArgs e)
        {
            EstadoComp();
        }

        private void RbCompDiario_CheckedChanged(object sender, EventArgs e)
        {
            EstadoComp();
        }

        private void EstadoComp()
        {
            // 1 INGRESO
            // 2 EGRESO
            // 3 DIARIO
            if (RbIngreso.Checked == true)
            {
                Estado = 1;
                return;
            }
            if (RbEgreso.Checked == true)
            {
                Estado = 2;
                return;
            }
            if (RbCompDiario.Checked == true)
            {
                Estado = 3;
                return;
            }
        }
    }
}
