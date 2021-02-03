using CADProContable.Niveles.DSNivelesTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CADProContable.Niveles.Nivel2
{
    public class ClassLLenarCbGrupo
    {


        public void Llenar(ComboBox CbN2, int IDConta_Jera, TextBox TxtCodigoGrupo)
        {

            Conta_Jerarquia_2TableAdapter adapter = new Conta_Jerarquia_2TableAdapter();
            try
            {
                CbN2.DataSource = adapter.SelectJerar2(IDConta_Jera);
                CbN2.DisplayMember = "Nombre";
                CbN2.ValueMember = "IDConta_Jera_2";
                CbN2.SelectedIndex = 0;
            }
            catch (Exception)
            {
                List<ClassCbDatoMostrar> Datos = new List<ClassCbDatoMostrar>();
                ClassCbDatoMostrar Insertar = new ClassCbDatoMostrar();
                Insertar.ID = 0;
                Insertar.Dato = "NO EXISTRE";
                Datos.Add(Insertar);
                CbN2.DataSource = Datos;
                CbN2.DisplayMember = "Dato";
                CbN2.ValueMember = "ID";
            }
         
            
            LLenarCodigo(Convert.ToInt32(CbN2.SelectedValue), TxtCodigoGrupo);
        }

        private void LLenarCodigo(int IDConta_Jera2, TextBox TxtCodigoGrupo)
        {
            ClassLlenarTxtCodigoGrupo LlenarCodigo = new ClassLlenarTxtCodigoGrupo();
            TxtCodigoGrupo.Text = LlenarCodigo.LLenarTxtCodigoGrupo(IDConta_Jera2);
        }

        public void LLenarCodigoGrupo(int IDConta_Jera2, TextBox TxtCodigoGrupo)
        {
            ClassLlenarTxtCodigoGrupo LlenarCodigo = new ClassLlenarTxtCodigoGrupo();
            TxtCodigoGrupo.Text = LlenarCodigo.LLenarTxtCodigoGrupo(IDConta_Jera2);
        }

    }
}
