using CADProContable.Niveles.DSNivelesTableAdapters;
using System.Drawing;
using System.Windows.Forms;
using static CADProContable.Niveles.DSNiveles;

namespace CADProContable.Niveles.Creacion.Nivel2
{
    public class ClassDgvLLenar_2
    {

        Conta_Jerarquia_2TableAdapter adapter = new Conta_Jerarquia_2TableAdapter();


        public void LLenarActivoCuentaLista(DataGridView DgvLista, int IDConta_Jera)
        {
            DgvLista.Rows.Clear();
            Conta_Jerarquia_2DataTable mitabla = adapter.SelectJerar2(IDConta_Jera);
            for (int i = 0; i < mitabla.Count; i++)
            {
                Conta_Jerarquia_2Row misRegistros = (Conta_Jerarquia_2Row)mitabla.Rows[i];

                DgvLista.Rows.Add(
                misRegistros.IDConta_Jera_2,
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
