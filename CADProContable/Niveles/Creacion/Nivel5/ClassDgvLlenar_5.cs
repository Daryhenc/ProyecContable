using CADProContable.Niveles.DSNivelesTableAdapters;
using System.Drawing;
using System.Windows.Forms;
using static CADProContable.Niveles.DSNiveles;

namespace CADProContable.Niveles.Creacion.Nivel5
{
    public class ClassDgvLlenar_5
    {

        Conta_Jerarquia_5TableAdapter adapter = new Conta_Jerarquia_5TableAdapter();

        public void LLenarGrupo5Lista(DataGridView DgvLista, int IDConta_Jera4)
        {
            DgvLista.Rows.Clear();
            Conta_Jerarquia_5DataTable mitabla = adapter.SelectJerar5(IDConta_Jera4);
            for (int i = 0; i < mitabla.Count; i++)
            {
                Conta_Jerarquia_5Row misRegistros = (Conta_Jerarquia_5Row)mitabla.Rows[i];
                DgvLista.Rows.Add(
                misRegistros.IDConta_Jera_5,
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
