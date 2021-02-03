using CADProContable.Niveles.DSNivelesTableAdapters;
using System.Windows.Forms;
using static CADProContable.Niveles.DSNiveles;

namespace CADProContable.Niveles.Nivel4
{
    public class ClassLlenarTxtCodigoSubCuenta
    {

        Conta_Jerarquia_4TableAdapter adapter = new Conta_Jerarquia_4TableAdapter();

        public string LLenarTxtCodigoSubCuenta(int IDConta_Jera4, RadioButton RbTransaccional)
        {
            Conta_Jerarquia_4DataTable mitabla = adapter.SelectJerarID(IDConta_Jera4);
            string Codigo = null;
            for (int i = 0; i < mitabla.Count; i++)
            {
                Conta_Jerarquia_4Row misRegistros = (Conta_Jerarquia_4Row)mitabla.Rows[i];
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
