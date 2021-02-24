using CADProContable.Niveles.DSNivelesTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADProContable.Niveles.Retencion
{
    public class CADRetencion
    {

        Conta_RetencionCADTableAdapter adapter = new Conta_RetencionCADTableAdapter();
        public void InsertRetencion(int IDTipoRetencion, int IDConta_Jera3, int IDConta_Jera_4, int IDConta_Jera_5, string Codigo, string CodReferencia, string Descripcion,  decimal Porcen)
        {
            adapter.InsertRetencion(IDTipoRetencion, IDConta_Jera3, IDConta_Jera_4, IDConta_Jera_5, Codigo, CodReferencia, Descripcion, Porcen);
        }

        public void DeleteRetencion(int IDRetencion)
        {
            adapter.DeleteRetencion(IDRetencion);
        }
    }
}
