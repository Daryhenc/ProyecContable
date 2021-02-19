using CADProContable.Asiento.DSAsientosTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADProContable.Asiento.AsientoDetalle
{
    public class CADAsientoDetalle
    {

        AsientoDetalleTableAdapter adapter = new AsientoDetalleTableAdapter();
        public int InsertAsientoDetalle(int IDTipoComprobante, int NComprobante, string DocReferencia, string ConceptoGeneral, DateTime Fecha)
        {
           return Convert.ToInt32(adapter.InsertAsientoDetalle(IDTipoComprobante, NComprobante, DocReferencia, ConceptoGeneral, Fecha));
        }

        

    }
}
