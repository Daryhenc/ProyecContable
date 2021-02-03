using CADProContable.Niveles.DSNivelesTableAdapters;
using System;

namespace CADProContable.Niveles.Nivel4
{
    public class CADNivel4
    {

        Conta_Jerarquia_4TableAdapter adapter = new Conta_Jerarquia_4TableAdapter();
        public int InsertJerar4(int IDConta_Jera3, string Nombre, string Codigo, bool EstadoMovimiento)
        {
           return Convert.ToInt32( adapter.InsertJerar4(IDConta_Jera3, Nombre, Codigo, EstadoMovimiento));
        }

        public void UpdateJerar4(string Nombre, string Codigo, int IDConta_Jera4)
        {
            adapter.UpdateJerar4(Nombre, Codigo, IDConta_Jera4);
        }

        public void DeleteJerar4(int IDConta_Jera_4)
        {
            adapter.DeleteJerar4(IDConta_Jera_4);
        }
    }
}
