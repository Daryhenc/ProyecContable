using CADProContable.Asiento.AsientoCuenta;
using CADProContable.Asiento.AsientoDetalle;
using ProyecContable.Asientos.CreacionAsiento.DatoCuenta;
using System;
using System.Collections.Generic;

namespace ProyecContable.Asientos.CreacionAsiento.GuardarAsiento
{
    public class ClassGuardarAsiento
    {

        CADAsientoDetalle GuardarAsiento { get; set; }
        CADAsientoCuenta  GuardarCuenta   { get; set; }

        public void GuardarAsientoContable(int IDTipoComprobante, int NComprobante, string DocReferencia, string ConceptoGeneral, List<ClassDatoCuentaAgregar> ListDatos,  DateTime Fecha)
        {
            GuardarAsiento = new CADAsientoDetalle();
            GuardarCuenta = new CADAsientoCuenta();
            int IDAsiento =  GuardarAsiento.InsertAsientoDetalle(IDTipoComprobante, NComprobante, DocReferencia, ConceptoGeneral, Fecha);
          
            for (int i = 0; i < ListDatos.Count; i++)
            {
                GuardarCuenta.InsertAsientoCuenta(IDAsiento, ListDatos[i].IDCuentaMovimiento, 
                ListDatos[i].Concepto.ToUpper(), ListDatos[i].Debe, ListDatos[i].Haber);
            }
        }

    }
}
