using CADProContable.Asiento.DSAsientosTableAdapters;
using System.Collections.Generic;
using System.Windows.Forms;
using static CADProContable.Asiento.DSAsientos;

namespace CADProContable.Asiento.AsientoBusqueda
{
    public class ClassDgvCuentaMovimiento
    {

        public void TraerListaCuentaMovimiento(DataGridView DgvMostrar, int IDAsiento)
        {
            DgvMostrar.Rows.Clear();
            BusquedaAsientoCuentaTableAdapter adapter = new BusquedaAsientoCuentaTableAdapter();
            BusquedaAsientoCuentaDataTable mitabla = adapter.GetData(IDAsiento);
            for (int i = 0; i < mitabla.Count; i++)
            {
                BusquedaAsientoCuentaRow misRegistro = (BusquedaAsientoCuentaRow)mitabla.Rows[i];
                DgvMostrar.Rows.Add(
                misRegistro.Codigo,
                misRegistro.Nombre,
                misRegistro.Concepto,
                misRegistro.Debe,
                misRegistro.Haber);
            }
        }
    }
}
