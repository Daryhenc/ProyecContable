using CADProContable.Niveles.DSNivelesTableAdapters;
using CADProContable.Niveles.Nivel2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CADProContable.Niveles.Nivel4
{
    public class ClassLlenarCbSubCuenta
    {

        public void Llenar(ComboBox CbN4, int IDConta_Jera_3, RadioButton RbTransaccional4, TextBox TxtCodigoSubCuenta)
        {

            Conta_Jerarquia_4TableAdapter adapter = new Conta_Jerarquia_4TableAdapter();
            try
            {
                CbN4.DataSource = adapter.SelectJerar4(IDConta_Jera_3);
                CbN4.DisplayMember = "Nombre";
                CbN4.ValueMember = "IDConta_Jera_4";
                CbN4.SelectedIndex = 0;
            }
            catch (Exception)
            {
                List<ClassCbDatoMostrar> Datos = new List<ClassCbDatoMostrar>();
                ClassCbDatoMostrar Insertar = new ClassCbDatoMostrar
                {
                    ID = 0,
                    Dato = "NO EXISTE"
                };
                Datos.Add(Insertar);
                CbN4.DataSource = Datos;
                CbN4.DisplayMember = "Dato";
                CbN4.ValueMember = "ID";
            }

            LLenarCodigo(Convert.ToInt32(CbN4.SelectedValue), RbTransaccional4, TxtCodigoSubCuenta);
        }

        private void LLenarCodigo(int IDConta_Jera4, RadioButton RbTransaccional, TextBox TxtCodigoCuenta)
        {
            ClassLlenarTxtCodigoSubCuenta LlenarCodigo = new ClassLlenarTxtCodigoSubCuenta();
            TxtCodigoCuenta.Text = LlenarCodigo.LLenarTxtCodigoSubCuenta(IDConta_Jera4, RbTransaccional);
        }

        public void LLenarCodigoSubCuenta(int IDConta_Jera4, RadioButton RbTransaccional, TextBox TxtCodigoSubCuenta)
        {
            ClassLlenarTxtCodigoSubCuenta LlenarCodigo = new ClassLlenarTxtCodigoSubCuenta();
            TxtCodigoSubCuenta.Text = LlenarCodigo.LLenarTxtCodigoSubCuenta(IDConta_Jera4, RbTransaccional);
        }

    }
}
