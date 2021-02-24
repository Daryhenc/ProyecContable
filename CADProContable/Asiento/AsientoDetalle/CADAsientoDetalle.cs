using CADProContable.Asiento.AsientoCuenta;
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
        CADAsientoCuenta CADCuenta { get; set; }
        public int InsertAsientoDetalle(int IDTipoComprobante, int NComprobante, string DocReferencia, string ConceptoGeneral, DateTime Fecha)
        {
           return Convert.ToInt32(adapter.InsertAsientoDetalle(IDTipoComprobante, NComprobante, DocReferencia, ConceptoGeneral, Fecha));
        }

        public void DeleteAsiento(int IDAsiento)
        {
            CADCuenta = new CADAsientoCuenta();
            CADCuenta.DeleteAsientoCuenta(IDAsiento);
            adapter.DeleteAsientoDetalle(IDAsiento);
        }

    }
}
