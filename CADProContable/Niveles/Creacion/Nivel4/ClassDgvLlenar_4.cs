using CADProContable.Niveles.DSNivelesTableAdapters;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CADProContable.Niveles.DSNiveles;

namespace CADProContable.Niveles.Creacion.Nivel4
{
    public class ClassDgvLlenar_4
    {
        Conta_Jerarquia_4TableAdapter adapter = new Conta_Jerarquia_4TableAdapter();

        public void LLenarGrupo4Lista(DataGridView DgvLista, int IDConta_Jera3)
        {
            DgvLista.Rows.Clear();
            Conta_Jerarquia_4DataTable mitabla = adapter.SelectJerar4(IDConta_Jera3);
            for (int i = 0; i < mitabla.Count; i++)
            {
                Conta_Jerarquia_4Row misRegistros = (Conta_Jerarquia_4Row)mitabla.Rows[i];
                DgvLista.Rows.Add(
                misRegistros.IDConta_Jera_4,
                null,
                null,
                misRegistros.Codigo,
                misRegistros.Nombre);
            }
            for (int i = 0; i < DgvLista.Rows.Count - 1; i++)
            {
                if ((i % 2) == 0)
                {
                    DgvLista.Rows[i].DefaultCellStyle.BackColor = Color.LightBlue;
                }
            }
        }

    }
}
