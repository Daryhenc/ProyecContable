using CADProContable.Niveles.Creacion.Nivel2;
using CADProContable.Niveles.Nivel1;
using CADProContable.Niveles.Nivel2;
using ProyecContable.Niveles.Nivel2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyecContable.Niveles
{
    public partial class FrmNivel2 : Form
    {
        public FrmNivel2()
        {
            InitializeComponent();
            LlenarCB = new ClassLlenarCbClase();
          //  LlenarCB.Llenar(CbNivel1);
            IDConta_Jera = Convert.ToInt32(CbNivel1.SelectedValue);
        }

        ClassLlenarCbClase LlenarCB { get; set; }
        ClassDgvLLenar_2 LlenarDgv { get; set; } 
        int IDConta_Jera;
        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            LlenarDgv = new ClassDgvLLenar_2();
            LlenarDgv.LLenarActivoCuentaLista(DgvDatos, IDConta_Jera);
        }

        private void CbNivel1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            IDConta_Jera = Convert.ToInt32(CbNivel1.SelectedValue);
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            if (IDConta_Jera == 0)
            {
                LlenarDgv = new ClassDgvLLenar_2();
                LlenarDgv.LLenarActivoCuentaLista(DgvDatos, IDConta_Jera);
                return;
            }
            if (TxtCodigo.Text == null || TxtCodigo.Text == "")
            {
                return;
            }
                                       
            if (TxtNombre.Text == null || TxtCodigo.Text == "")
            {
                return;
            }

            CADNivel2 Guardar = new CADNivel2();
            Guardar.InsertJerar2(IDConta_Jera, TxtNombre.Text.ToUpper(), TxtCodigo.Text);
            TxtNombre.Text = null;
            TxtCodigo.Text = null;
            LlenarDgv = new ClassDgvLLenar_2();
            LlenarDgv.LLenarActivoCuentaLista(DgvDatos, IDConta_Jera);
        }

        private void DgvDatos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (DgvDatos.CurrentRow == null)
            {
                return;
            }

            int Fila = e.RowIndex;
            int Column = e.ColumnIndex;

            if (Column == 1)
            {
                string Nombre = null;
                string Codigo = null;
                if (DgvDatos.Rows[Fila].Cells[3].Value.ToString() == "")
                {
                    Nombre = "No hay nombre";
                }
                else
                {
                    Nombre = DgvDatos.Rows[Fila].Cells[3].Value.ToString();
                }
                if (DgvDatos.Rows[Fila].Cells[4].Value.ToString() == "")
                {
                    Codigo = "No hay nombre";
                }
                else
                {
                    Codigo = DgvDatos.Rows[Fila].Cells[4].Value.ToString();
                }
                FrmNivel2Editar FrmEditar = new FrmNivel2Editar(Convert.ToInt32(DgvDatos.Rows[Fila].Cells[0].Value), Nombre, Codigo);
                FrmEditar.ShowDialog();
                LlenarDgv = new ClassDgvLLenar_2();
                LlenarDgv.LLenarActivoCuentaLista(DgvDatos, IDConta_Jera);
            }
        }
    }
}
