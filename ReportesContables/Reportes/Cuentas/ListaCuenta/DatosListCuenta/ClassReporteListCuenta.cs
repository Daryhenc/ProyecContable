using CADProContable.Niveles.Reporte.ReporteCuenta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReportesContables.Reportes.Cuentas.ListaCuenta.DatosListCuenta
{
    public class ClassReporteListCuenta
    {

        CADReporteCuenta Reporte { get; set; }

        public List<ClassObDatoListCuenta> DatosLista { get; private set; }

        public void LlamarReporteListaCuenta()
        {
            Reporte = new CADReporteCuenta();
            DatosLista = new List<ClassObDatoListCuenta>();

            Reporte.SelectReportListaCuenta();

            for (int i = 0; i < Reporte.Datos.Count; i++)
            {
                ClassObDatoListCuenta insertar = new ClassObDatoListCuenta
                {
                    Codigo = Reporte.Datos[i].Codigo,
                    Nombre = Reporte.Datos[i].Nombre
                };

                DatosLista.Add(insertar);

            }


        }

    }
}
