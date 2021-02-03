using CADProContable.Niveles.DSNivelesTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CADProContable.Niveles.DSNiveles;

namespace CADProContable.Niveles.Nivel2
{
    public class ClassLlenarTxtCodigoGrupo
    {


        Conta_Jerarquia_2TableAdapter adapter = new Conta_Jerarquia_2TableAdapter();

        public string LLenarTxtCodigoGrupo(int IDConta_Jera2)
        {
            Conta_Jerarquia_2DataTable mitabla = adapter.SelectJerarID(IDConta_Jera2);
            string Codigo = null;
            for (int i = 0; i < mitabla.Count; i++)
            {
                Conta_Jerarquia_2Row misRegistros = (Conta_Jerarquia_2Row)mitabla.Rows[i];
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
