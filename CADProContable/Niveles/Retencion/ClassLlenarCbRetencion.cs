using CADProContable.Niveles.DSNivelesTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CADProContable.Niveles.Retencion
{
    public class ClassLlenarCbRetencion
    {

        public void LlenarCb(ComboBox CbRete)
        {

            Conta_TipoRetencionTableAdapter adapter = new Conta_TipoRetencionTableAdapter();
            CbRete.DataSource = adapter.SelectTipoRetencion();
            CbRete.DisplayMember = "Descripcion";
            CbRete.ValueMember = "IDTipoRetencion";
            CbRete.SelectedIndex = 0;
        }

    }
}
