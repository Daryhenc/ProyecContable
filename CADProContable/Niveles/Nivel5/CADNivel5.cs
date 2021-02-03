using CADProContable.Niveles.DSNivelesTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADProContable.Niveles.Nivel5
{
    public class CADNivel5
    {

        Conta_Jerarquia_5TableAdapter adapter = new Conta_Jerarquia_5TableAdapter();
        public int InsertJerar5(int IDConta_Jera4, string Nombre, string Codigo, bool EstadoMovimiento)
        {
           return Convert.ToInt32(adapter.InsertJerar5(IDConta_Jera4, Nombre, Codigo, EstadoMovimiento));
        }

        public void UpdateJerar5(string Nombre, string Codigo, int IDConta_Jera5)
        {
            adapter.UpdateJerar5(Nombre, Codigo, IDConta_Jera5);
        }

        public void DeleteJerar5(int IDConta_Jera_5)
        {
            adapter.DeleteJerar5(IDConta_Jera_5);
        }
    }
}
