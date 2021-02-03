using CADProyecContable.Niveles.DSProyecContableTableAdapters;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using static CADProyecContable.Niveles.DSProyecContable;

namespace CADProyecContable.Niveles.Nivel1
{
    public class ClassLLenarCbN1
    {
     //   public List<ClassDatoN1> ListDatos = new List<ClassDatoN1>();
        public void Llenar(ComboBox CbN1)
        {
                 
            Conta_JerarquiaTableAdapter adapter = new Conta_JerarquiaTableAdapter();
            CbN1.DataSource = adapter.GetData();
            CbN1.DisplayMember = "Nombre";
            CbN1.ValueMember = "IDConta_Jera";
            CbN1.SelectedIndex = 0;
            //     CbSucursal.Enabled = false;
        }


    }
}
