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
        public int InsertAsientoDetalle(int IDTipoComprobante, string DocReferencia, string ConceptoGeneral, DateTime Fecha)
        {
           return Convert.ToInt32(adapter.InsertAsientoDetalle(IDTipoComprobante, DocReferencia, ConceptoGeneral, Fecha));
        }

        public int InsertAsientoDetalleFechaAuto(int IDTipoComprobante, string DocReferencia, string ConceptoGeneral)
        {
           return Convert.ToInt32(adapter.InsertAsientoDetalleFechaAuto(IDTipoComprobante, DocReferencia, ConceptoGeneral));
        }

        

    }
}
