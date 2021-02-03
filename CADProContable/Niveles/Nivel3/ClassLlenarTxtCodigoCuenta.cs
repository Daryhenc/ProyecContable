using CADProContable.Niveles.DSNivelesTableAdapters;
using System.Windows.Forms;
using static CADProContable.Niveles.DSNiveles;

namespace CADProContable.Niveles.Nivel3
{
    public class ClassLlenarTxtCodigoCuenta
    {

        Conta_Jerarquia_3TableAdapter adapter = new Conta_Jerarquia_3TableAdapter();

        public string LLenarTxtCodigoCuenta(int IDConta_Jera3, RadioButton RbTransaccional)
        {
            Conta_Jerarquia_3DataTable mitabla = adapter.SelectJerarID(IDConta_Jera3);
            string Codigo = null;
            for (int i = 0; i < mitabla.Count; i++)
            {
                Conta_Jerarquia_3Row misRegistros = (Conta_Jerarquia_3Row)mitabla.Rows[i];
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
