using CADProContable.Niveles.DSNivelesTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CADProContable.Niveles.Nivel1
{
    public class ClassLlenarCbClase
    {

        public void Llenar(ComboBox CbN1, TextBox TxtCodigoClase)
        {

            Conta_JerarquiaTableAdapter adapter = new Conta_JerarquiaTableAdapter();
            CbN1.DataSource = adapter.GetData();
            CbN1.DisplayMember = "Nombre";
            CbN1.ValueMember = "IDConta_Jera";
            CbN1.SelectedIndex = 0;
            LLenarCodigo(Convert.ToInt32(CbN1.SelectedValue), TxtCodigoClase);
        }



        private void LLenarCodigo(int IDConta_Jera, TextBox TxtCodigoClase)
        {
            ClassLLenarTxtCodigoClase LlenarCodigo = new ClassLLenarTxtCodigoClase();
            TxtCodigoClase.Text = LlenarCodigo.LLenarTxtCodigoClase(IDConta_Jera);
        }

        public void LLenarCodigoClase(int IDConta_Jera, TextBox TxtCodigoClase)
        {
            ClassLLenarTxtCodigoClase LlenarCodigo = new ClassLLenarTxtCodigoClase();
            TxtCodigoClase.Text = LlenarCodigo.LLenarTxtCodigoClase(IDConta_Jera);
        }
    }
}
