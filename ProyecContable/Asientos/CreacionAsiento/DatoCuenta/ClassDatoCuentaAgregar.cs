using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyecContable.Asientos.CreacionAsiento.DatoCuenta
{
    public class ClassDatoCuentaAgregar
    {

        public int IDCuentaMovimiento { get; set; }
        public string  Codigo { get; set; }
        public string  Nombre { get; set; }
        public string  Concepto { get; set; }
        public decimal Debe { get; set; }
        public decimal Haber { get; set; }

    }
}
