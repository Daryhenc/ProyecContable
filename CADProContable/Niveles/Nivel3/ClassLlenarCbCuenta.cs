using CADProContable.Niveles.DSNivelesTableAdapters;
using CADProContable.Niveles.Nivel2;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CADProContable.Niveles.Nivel3
{
    public class ClassLlenarCbCuenta
    {

        public void Llenar(ComboBox CbN3, int IDConta_Jera_2, RadioButton RbTransaccional3, TextBox TxtCodigoCuenta)
        {

            Conta_Jerarquia_3TableAdapter adapter = new Conta_Jerarquia_3TableAdapter();
            try
            {
                CbN3.DataSource = adapter.SelectJerar3(IDConta_Jera_2);
                CbN3.DisplayMember = "Nombre";
                CbN3.ValueMember = "IDConta_Jera_3";
                CbN3.SelectedIndex = 0;
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
                CbN3.DataSource = Datos;
                CbN3.DisplayMember = "Dato";
                CbN3.ValueMember = "ID";
            }

            LLenarCodigo(Convert.ToInt32(CbN3.SelectedValue), RbTransaccional3, TxtCodigoCuenta);
        }

        private void LLenarCodigo(int IDConta_Jera3, RadioButton RbTransaccional, TextBox TxtCodigoCuenta)
        {
            ClassLlenarTxtCodigoCuenta LlenarCodigo = new ClassLlenarTxtCodigoCuenta();
            TxtCodigoCuenta.Text = LlenarCodigo.LLenarTxtCodigoCuenta(IDConta_Jera3, RbTransaccional);
        }

        public void LLenarCodigoCuenta(int IDConta_Jera3, RadioButton RbTransaccional, TextBox TxtCodigoCuenta)
        {
            ClassLlenarTxtCodigoCuenta LlenarCodigo = new ClassLlenarTxtCodigoCuenta();
            TxtCodigoCuenta.Text = LlenarCodigo.LLenarTxtCodigoCuenta(IDConta_Jera3, RbTransaccional);
        }


    }
}
