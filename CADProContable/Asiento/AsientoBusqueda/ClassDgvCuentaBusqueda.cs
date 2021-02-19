using CADProContable.Asiento.DSAsientosTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CADProContable.Asiento.DSAsientos;
using static CADProContable.Asiento.DSAsientosa;

namespace CADProContable.Asiento.AsientoBusqueda
{
    public class ClassDgvCuentaBusqueda
    {

        BusquedaAsientoTableAdapter adapter = new BusquedaAsientoTableAdapter();

        public void LLenarMovimientoDetalleLista(DataGridView DgvMostrar, int Estado, string TComprobante, string Concepto, string FECHA1, string FECHA2)
        {
            DgvMostrar.Rows.Clear();
            if (Estado == 1)
            {
                GetDataByDia(DgvMostrar, TComprobante, Concepto);
                return;
            }
            if (Estado == 2)
            {
                GetDataBySemana(DgvMostrar, TComprobante, Concepto);
                return;
            }
            if (Estado == 3)
            {
                GetDataByMes(DgvMostrar, TComprobante, Concepto);
                return;
            }
            if (Estado == 4)
            {
                GetDataPorFecha(DgvMostrar, TComprobante, Concepto, FECHA1, FECHA2);
                return;
            }
        }
        private void GetDataByDia(DataGridView DgvMostrar, string TComprobante, string Concepto)
        {
            BusquedaAsientoDataTable mitabla = adapter.GetDataByDia(TComprobante, Concepto);
            for (int i = 0; i < mitabla.Count; i++)
            {
                BusquedaAsientoRow misRegistros = (BusquedaAsientoRow)mitabla.Rows[i];
                DgvMostrar.Rows.Add(
                null,
                misRegistros.IDAsiento,
                misRegistros.Fecha,
                misRegistros.TIPO,
                misRegistros.NComprobante,
                misRegistros.DocReferencia,
                misRegistros.ConcenptoGeneral );
            }
        }
        private void GetDataBySemana(DataGridView DgvMostrar, string TComprobante, string Concepto)
        {
            BusquedaAsientoDataTable mitabla = adapter.GetDataBySemana(TComprobante, Concepto);
            for (int i = 0; i < mitabla.Count; i++)
            {
                BusquedaAsientoRow misRegistros = (BusquedaAsientoRow)mitabla.Rows[i];
                DgvMostrar.Rows.Add(
                null,
                misRegistros.IDAsiento,
                misRegistros.Fecha,
                misRegistros.TIPO,
                misRegistros.NComprobante,
                misRegistros.DocReferencia,
                misRegistros.ConcenptoGeneral);
            }
        }
        private void GetDataByMes(DataGridView DgvMostrar, string TComprobante, string Concepto)
        {
            BusquedaAsientoDataTable mitabla = adapter.GetDataByMes(TComprobante, Concepto);
            for (int i = 0; i < mitabla.Count; i++)
            {
                BusquedaAsientoRow misRegistros = (BusquedaAsientoRow)mitabla.Rows[i];
                DgvMostrar.Rows.Add(
                null,
                misRegistros.IDAsiento,
                misRegistros.Fecha,
                misRegistros.TIPO,
                misRegistros.NComprobante,
                misRegistros.DocReferencia,
                misRegistros.ConcenptoGeneral);
            }
        }
        private void GetDataPorFecha(DataGridView DgvMostrar, string TComprobante, string Concepto, string Fecha1, string Fecha2)
        {
            BusquedaAsientoDataTable mitabla = adapter.GetDataPorFecha(TComprobante, Concepto, Fecha1, Fecha2);
            for (int i = 0; i < mitabla.Count; i++)
            {
                BusquedaAsientoRow misRegistros = (BusquedaAsientoRow)mitabla.Rows[i];
                DgvMostrar.Rows.Add(
                null,
                misRegistros.IDAsiento,
                misRegistros.Fecha,
                misRegistros.TIPO,
                misRegistros.NComprobante,
                misRegistros.DocReferencia,
                misRegistros.ConcenptoGeneral);
            }
        }
    }
}
