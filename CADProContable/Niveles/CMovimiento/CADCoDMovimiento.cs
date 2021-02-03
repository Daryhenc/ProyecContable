using CADProContable.Niveles.DSNivelesTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADProContable.Niveles.CMovimiento
{
    public class CADCoDMovimiento
    {

        Conta_CodigoCuentaMovimientoTableAdapter adapter = new Conta_CodigoCuentaMovimientoTableAdapter();
        public void InsertCMovimiento(int IDConta_Jera_3, int IDConta_Jera_4, int IDConta_Jera_5)
        {
            adapter.InsertCMovimiento(IDConta_Jera_3, IDConta_Jera_4, IDConta_Jera_5);
        }

        public void DeleteJerar3(int IDConta_Jera_3)
        {
            adapter.DeleteJerar3(IDConta_Jera_3);
        }

        public void DeleteJerar4(int IDConta_Jera_4)
        {
            adapter.DeleteJerar4(IDConta_Jera_4);
        }

        public void DeleteJerar5(int IDConta_Jera_5)
        {
            adapter.DeleteJerar5(IDConta_Jera_5);
        }

    }
}
