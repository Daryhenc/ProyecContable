using CADProContable.Niveles.DSNivelesTableAdapters;
using static CADProContable.Niveles.DSNiveles;

namespace CADProContable.Niveles.Nivel1
{
    public class ClassLLenarTxtCodigoClase
    {

        Conta_JerarquiaTableAdapter adapter = new Conta_JerarquiaTableAdapter();

        public string LLenarTxtCodigoClase(int IDConta_Jera)
        {
            Conta_JerarquiaDataTable mitabla = adapter.SelectJerar(IDConta_Jera);
            string Codigo = null;
            for (int i = 0; i < mitabla.Count; i++)
            {
                Conta_JerarquiaRow misRegistros = (Conta_JerarquiaRow)mitabla.Rows[i];
                Codigo = misRegistros.Codigo;
            }
            if (Codigo == null)
            {
                Codigo = "------";
            }
            return Codigo;
        }

    }
}
