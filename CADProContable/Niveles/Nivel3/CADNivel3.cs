using CADProContable.Niveles.DSNivelesTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADProContable.Niveles.Nivel3
{
    public class CADNivel3
    {

        Conta_Jerarquia_3TableAdapter adapter = new Conta_Jerarquia_3TableAdapter();
        public int InsertJerar3(int IDConta_Jera2, string Nombre, string Codigo, bool Estado)
        {
           return Convert.ToInt32(adapter.InsertJerar3(IDConta_Jera2, Nombre, Codigo, Estado));
        }

        public void UpdateJerar3(string Nombre, string Codigo, int IDConta_Jera3)
        {
            adapter.UpdateJerar3(Nombre, Codigo, IDConta_Jera3);
        }

        public void DeleteJerar3(int Original_IDConta_Jera_3)
        {
            adapter.DeleteJerar3(Original_IDConta_Jera_3);
        }
    }
}
