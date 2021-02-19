using CADProContable.Asiento.DSAsientosTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CADProContable.Asiento.DSAsientos;
using static CADProContable.Asiento.DSAsientosa;

namespace CADProContable.Asiento.LLenarTextBox
{
    public class ClassLLenarTextCodigoNom
    {

        public List<ClassDatoTextBoxCuenta> ListDato = new List<ClassDatoTextBoxCuenta>();


        public ClassLLenarTextCodigoNom()
        {
            AsientoCuentaBusquedaTableAdapter adapter = new AsientoCuentaBusquedaTableAdapter();
            AsientoCuentaBusquedaDataTable mitabla = adapter.GetData();
            int contador = mitabla.Rows.Count;
            if (contador == 0)
            {
                return;
            }
            for (int i = 0; i < contador; i++)
            {
                AsientoCuentaBusquedaRow miRegistro = (AsientoCuentaBusquedaRow)mitabla.Rows[i];
                ClassDatoTextBoxCuenta Insertar = new ClassDatoTextBoxCuenta {
                IDCuentaMovimiento = miRegistro.IDCuentaMovimiento,
                Codigo = miRegistro.Codigo,
                Nombre = miRegistro.Nombre
                };
                ListDato.Add(Insertar);
            }
        }


    }
}
