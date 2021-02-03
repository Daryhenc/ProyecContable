using CADProContable.Niveles.DSNivelesTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CADProContable.Niveles.Nivel1
{
    public class CADNivel1
    {

        Conta_JerarquiaTableAdapter adapter = new Conta_JerarquiaTableAdapter();
        public void InsertJerar(string Nombre, string Codigo)
        {
            adapter.InsertJerar(Nombre, Codigo);
        }

        public void UpdateJerar(string Nombre, string Codigo, int IDConta_Jera)
        {
            adapter.UpdateJerar(Nombre, Codigo, IDConta_Jera);
        }
        
        public void DeleteJerar(int IDConta_Jera)
        {
            adapter.DeleteJerar(IDConta_Jera);
        }
        

    }
}
