using CADProContable.Niveles.DSNivelesTableAdapters;
using System.Windows.Forms;
using static CADProContable.Niveles.DSNiveles;

namespace CADProContable.Niveles.Nivel5
{
    public class ClassLlenarTxtCodigoAuxiliar
    {

        Conta_Jerarquia_5TableAdapter adapter = new Conta_Jerarquia_5TableAdapter();

        public string LLenarTxtCodigoAuxiliar(int IDConta_Jera5, RadioButton RbTransaccional)
        {
            Conta_Jerarquia_5DataTable mitabla = adapter.SelectJerarID(IDConta_Jera5);
            string Codigo = null;
            for (int i = 0; i < mitabla.Count; i++)
            {
                Conta_Jerarquia_5Row misRegistros = (Conta_Jerarquia_5Row)mitabla.Rows[i];
                Codigo = misRegistros.Codigo;
                RbTransaccional.Checked = misRegistros.EstadoMovimiento;
            }
            if (Codigo == null)
            {
                Codigo = "------";
                RbTransaccional.Checked = false;
            }
            return Codigo;
        }


    }
}
