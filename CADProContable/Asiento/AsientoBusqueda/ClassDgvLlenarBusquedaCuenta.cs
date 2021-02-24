using CADProContable.Asiento.DSAsientosTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CADProContable.Asiento.DSAsientos;

namespace CADProContable.Asiento.AsientoBusqueda
{
    public class ClassDgvLlenarBusquedaCuenta
    {


        BusquedaCuentaTableAdapter adapter = new BusquedaCuentaTableAdapter();

        public void BusquedaCuenta(DataGridView DgvMostrar, string Codigo, string Nombre)
        {
            BusquedaCuentaDataTable mitabla = adapter.GetData(Codigo, Nombre);
            for (int i = 0; i < mitabla.Count; i++)
            {
                BusquedaCuentaRow misRegistros = (BusquedaCuentaRow)mitabla.Rows[i];
                DgvMostrar.Rows.Add(
                misRegistros.IDCuentaMovimiento,
                misRegistros.CJ3,
                misRegistros.CJ4,
                misRegistros.CJ5,
                misRegistros.Codigo,
                misRegistros.Nombre);
            }
        }

    }
}
