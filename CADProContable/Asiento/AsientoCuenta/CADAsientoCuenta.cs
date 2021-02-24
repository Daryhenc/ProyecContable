using CADProContable.Asiento.DSAsientosTableAdapters;
using System;

namespace CADProContable.Asiento.AsientoCuenta
{
    public class CADAsientoCuenta
    {

        AsientoCuentaTableAdapter adapter = new AsientoCuentaTableAdapter();
        public void InsertAsientoCuenta(int IDAsiento, int IDCuentaMovimiento, string Concepto, decimal Debe, decimal Haber)
        {
              adapter.InsertAsientoCuenta(IDAsiento, IDCuentaMovimiento, Concepto, Debe, Haber);
        }

        public void DeleteAsientoCuenta(int IDAsiento)
        {
            adapter.DeleteAsientoCuenta(IDAsiento);
        }

    }
}
