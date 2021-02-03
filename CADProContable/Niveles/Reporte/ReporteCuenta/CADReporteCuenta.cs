using CADProContable.Niveles.Reporte.ReporteCuenta.DSReporteCuentaTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static CADProContable.Niveles.Reporte.ReporteCuenta.DSReporteCuenta;

namespace CADProContable.Niveles.Reporte.ReporteCuenta
{
    public class CADReporteCuenta
    {

        public List<CADDatoCuenta> Datos = new List<CADDatoCuenta>();
        public void SelectReportListaCuenta()
        {
            Datos.Clear();
            ReporteListaCuentaTableAdapter adapter = new ReporteListaCuentaTableAdapter();
            ReporteListaCuentaDataTable mitabla = adapter.GetData();

            for (int i = 0; i < mitabla.Count; i++)
            {

                ReporteListaCuentaRow miRegistro = (ReporteListaCuentaRow)mitabla.Rows[i];
                CADDatoCuenta Insertar = new CADDatoCuenta
                {
                    Codigo = miRegistro.Codigo,
                    Nombre = miRegistro.Nombre
                };
                Datos.Add(Insertar);
            }
        }
    }
}
