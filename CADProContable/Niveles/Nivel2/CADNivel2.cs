using CADProContable.Niveles.DSNivelesTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADProContable.Niveles.Nivel2
{
    public class CADNivel2
    {
        Conta_Jerarquia_2TableAdapter adapter = new Conta_Jerarquia_2TableAdapter();
        public void InsertJerar2(int IDConta_Jera, string Nombre, string Codigo)
        {
            adapter.InsertJerar2(IDConta_Jera, Nombre, Codigo);
         }
       
        public void UpdateJerar2(string Nombre, string Codigo, int IDConta_Jera2)
        {
            adapter.UpdateJerar2(Nombre, Codigo, IDConta_Jera2);
        }
       
        public void DeleteJerar2(int IDConta_Jera_2)
        {
            adapter.DeleteJerar2(IDConta_Jera_2);
        }

        /*
       public static void UpdateActivoCuentaNombre(string Nombre, int IDActivoCuenta)
       {
           adapter.UpdateActivoCuentaNombre(Nombre.ToUpper(), IDActivoCuenta);
       }
       public static bool ExisteActivoCuentaNombre(string Nombre)
       {
           if (adapter.ExisteActivoCuentaNombre(Nombre) == null)
           {
               return false;
           }
           else
           {
               return true;
           }
       }
             */
    }
}
