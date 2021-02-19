using CADProContable.Asiento.LLenarTextBox;
using ProyecContable.Asientos.CreacionAsiento.DatoCuenta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyecContable.Asientos.CreacionAsiento.LlenarText
{
    public class ClassLlenarCodigo
    {

        AutoCompleteStringCollection Autocomplete = new AutoCompleteStringCollection();

        ClassLLenarTextCodigoNom TraerDatos { get; set; }
        List<ClassDatoTextCuenta> ListDatos = new List<ClassDatoTextCuenta>();
        public ClassLlenarCodigo()
        {
            TraerDatos = new ClassLLenarTextCodigoNom();
            for (int i = 0; i < TraerDatos.ListDato.Count; i++)
            {
                ClassDatoTextCuenta Insertar = new ClassDatoTextCuenta
                {
                    IDCuentaMovimiento = TraerDatos.ListDato[i].IDCuentaMovimiento,
                    Codigo = TraerDatos.ListDato[i].Codigo,
                    Nombre = TraerDatos.ListDato[i].Nombre
                };
                ListDatos.Add(Insertar);
            }
          //   LlenarAutoComplete(TxtCodigo);
        }



        public void LlenarAutoComplete(TextBox TxtCodigo)
        {
            for (int i = 0; i < ListDatos.Count; i++)
            {
                Autocomplete.Add(ListDatos[i].Codigo.ToUpper());
            }
            TxtCodigo.AutoCompleteCustomSource = Autocomplete;
        }
        public void RetornaLista(string Dato, TextBox TxtNombre, ClassDatoCuenta DatoCuenta)
        {        
            for (int i = 0; i < ListDatos.Count; i++)
            {
                if (ListDatos[i].Codigo == Dato)
                {
                    DatoCuenta.IDCuentaMovimiento = ListDatos[i].IDCuentaMovimiento;
                    DatoCuenta.Codigo = ListDatos[i].Codigo;
                    DatoCuenta.Nombre = ListDatos[i].Nombre;
                    TxtNombre.Text = ListDatos[i].Nombre;
                    return;
                }
            }
        }
        public bool Existe(string Dato)
        {
            if (Autocomplete.Contains(Dato) == true)
            {
                return true;
            }
            else
            {               
                return false;
            }
        }

    }
}
