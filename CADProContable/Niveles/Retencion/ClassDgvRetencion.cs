using CADProContable.Niveles.DSNivelesTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CADProContable.Niveles.DSNiveles;

namespace CADProContable.Niveles.Retencion
{
    public class ClassDgvRetencion
    {

        Conta_RetenTableAdapter adapter = new Conta_RetenTableAdapter();

        public void GetRetencion(DataGridView DgvMostrar, int IDTipoRetencion)
        {
            DgvMostrar.Rows.Clear();
            Conta_RetenDataTable mitabla = adapter.GetData(IDTipoRetencion);
            for (int i = 0; i < mitabla.Count; i++)
            {
                Conta_RetenRow misRegistros = (Conta_RetenRow)mitabla.Rows[i];
                DgvMostrar.Rows.Add(
                null,
                null,
                misRegistros.IDRetencion,
                misRegistros.Codigo,
                misRegistros.Descripcion,
                misRegistros.Porcen,
                misRegistros.CodReferencia,
               
               
                misRegistros.CodigoCuenta,
                misRegistros.NombreCuenta);
            }
        }
    
    }
}
