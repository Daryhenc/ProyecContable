using CADProContable.Niveles.DSNivelesTableAdapters;
using CADProContable.Niveles.Nivel2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CADProContable.Niveles.Nivel5
{
    public class ClassLlenarCbAuxiliar
    {

        public void Llenar(ComboBox CbN5, int IDConta_Jera_4, RadioButton RbTransaccional4, TextBox TxtCodigoSubCuenta)
        {

            Conta_Jerarquia_5TableAdapter adapter = new Conta_Jerarquia_5TableAdapter();
            try
            {
                CbN5.DataSource = adapter.SelectJerar5(IDConta_Jera_4);
                CbN5.DisplayMember = "Nombre";
                CbN5.ValueMember = "IDConta_Jera_5";
                CbN5.SelectedIndex = 0;
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
                CbN5.DataSource = Datos;
                CbN5.DisplayMember = "Dato";
                CbN5.ValueMember = "ID";
            }

            LLenarCodigo(Convert.ToInt32(CbN5.SelectedValue), RbTransaccional4, TxtCodigoSubCuenta);
        }

        private void LLenarCodigo(int IDConta_Jera5, RadioButton RbTransaccional, TextBox TxtCodigoCuenta)
        {
            ClassLlenarTxtCodigoAuxiliar LlenarCodigo = new ClassLlenarTxtCodigoAuxiliar();
            TxtCodigoCuenta.Text = LlenarCodigo.LLenarTxtCodigoAuxiliar(IDConta_Jera5, RbTransaccional);
        }

        public void LLenarCodigoAuxiliar(int IDConta_Jera5, RadioButton RbTransaccional, TextBox TxtCodigoSubCuenta)
        {
            ClassLlenarTxtCodigoAuxiliar LlenarCodigo = new ClassLlenarTxtCodigoAuxiliar();
            TxtCodigoSubCuenta.Text = LlenarCodigo.LLenarTxtCodigoAuxiliar(IDConta_Jera5, RbTransaccional);
        }

    }
}
