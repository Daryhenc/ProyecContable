using ProyecContable.Asientos.CreacionAsiento.DatoCuenta;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ProyecContable.Asientos.CreacionAsiento.Actividades
{
    public class ClassLlenarDgv
    {



        public void Crear(ClassDatoCuenta DatoCuenta, List<ClassDatoCuentaAgregar> ListDato, string TxtConcepto, decimal Debes, decimal Habers)
        {
            ClassDatoCuentaAgregar Insertar = new ClassDatoCuentaAgregar {

                IDCuentaMovimiento = DatoCuenta.IDCuentaMovimiento,
                Codigo = DatoCuenta.Codigo,
                Nombre = DatoCuenta.Nombre,
                Concepto = TxtConcepto,
                Debe = Debes,
                Haber = Habers
            };
            ListDato.Add(Insertar);
            DatoCuenta.IDCuentaMovimiento = 0;
            DatoCuenta.Codigo = null;
            DatoCuenta.Nombre = null;
        }

        public void Borrar(List<ClassDatoCuentaAgregar> ListDato, int IDCuentaMovimiento)
        {
              ListDato.RemoveAll(x => x.IDCuentaMovimiento == IDCuentaMovimiento);                    
              return;
        }

        public void LlenarDgv(DataGridView DgvDatos, List<ClassDatoCuentaAgregar> ListDato )
        {
            DgvDatos.Rows.Clear();
            for (int i = 0; i < ListDato.Count; i++)
            {
                DgvDatos.Rows.Add(null, ListDato[i].IDCuentaMovimiento, ListDato[i].Codigo, ListDato[i].Nombre, ListDato[i].Debe, ListDato[i].Haber, ListDato[i].Concepto);
            }
        }

        public void TDebeHaber(List<ClassDatoCuentaAgregar> ListDato, TextBox TxtTotalDebe, TextBox TxtTotalHaber)
        {
            decimal TotalDebe = 0;
            decimal TotalHaber = 0;

            for (int i = 0; i < ListDato.Count; i++)
            {
                TotalDebe += ListDato[i].Debe;
                TotalHaber += ListDato[i].Haber;
            }
            TxtTotalDebe.Text = TotalDebe.ToString();
            TxtTotalHaber.Text = TotalHaber.ToString();
        }
    }
}
