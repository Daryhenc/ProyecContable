using CADProContable.Asiento.DSAsientosTableAdapters;

namespace CADProContable.Asiento.AsientoCuenta
{
    public class CADAsientoCuenta
    {

        AsientoCuentasTableAdapter adapter = new AsientoCuentasTableAdapter();
        public void InsertAsientoCuentas(int IDAsiento, int IDCuentaMovimiento, string Concepto, decimal Debe, decimal Haber)
        {
            adapter.InsertAsientoCuentas(IDAsiento, IDCuentaMovimiento, Concepto, Debe, Haber);
        }



    }
}
