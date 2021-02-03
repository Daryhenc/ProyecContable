using CADProContable.Niveles.DSNivelesTableAdapters;
using System.Drawing;
using System.Windows.Forms;
using static CADProContable.Niveles.DSNiveles;

namespace CADProContable.Niveles.Creacion.Nivel3
{
    public class ClassDgvLlenar_3
    {

        Conta_Jerarquia_3TableAdapter adapter = new Conta_Jerarquia_3TableAdapter();

        public void LLenarGrupo3Lista(DataGridView DgvLista, int IDConta_Jera2)
        {
            DgvLista.Rows.Clear();
            Conta_Jerarquia_3DataTable mitabla = adapter.SelectJerar3(IDConta_Jera2);
            for (int i = 0; i < mitabla.Count; i++)
            {
                Conta_Jerarquia_3Row misRegistros = (Conta_Jerarquia_3Row)mitabla.Rows[i];
                DgvLista.Rows.Add(
                misRegistros.IDConta_Jera_3,
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
