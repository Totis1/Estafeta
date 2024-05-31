using Mysqlx.Cursor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estafeta.Formularios
{
    public partial class Logistica : Form
    {
        public Logistica()
        {
            InitializeComponent();
            Clases.ClassPyM objPyM = new Clases.ClassPyM();
            objPyM.MostrarPyM(DgvTablaPyM);
        }

        private void Logistica_Load(object sender, EventArgs e)
        {
            Clases.ClassPyM objPyM = new Clases.ClassPyM();
            objPyM.MostrarPyM(DgvTablaPyM);
        }

        private void Btn_Insertar_Click(object sender, EventArgs e)
        {
            Formularios.Insert_Logistica insert = new Formularios.Insert_Logistica();
            insert.ShowDialog();
            Clases.ClassPyM objPyM = new Clases.ClassPyM();
            objPyM.MostrarPyM(DgvTablaPyM);
        }

        private void DgvTablaPyE_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Formularios.Update_Logistica F_update = new Formularios.Update_Logistica();
            Clases.ClassPyM objPyM = new Clases.ClassPyM();
            objPyM.SeleccionarPyM(DgvTablaPyM, F_update.CBoxTipoA, F_update.TxtBoxDestinoA, F_update.TxtBoxCostoA, F_update.DtpFechaA, F_update.TxtBoxId);
            F_update.ShowDialog();
            objPyM.MostrarPyM(DgvTablaPyM);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Clases.ClassPyM objPyM = new Clases.ClassPyM();
            Formularios.Delete_Logistica delete = new Formularios.Delete_Logistica();
            delete.ShowDialog();
            objPyM.MostrarPyM(DgvTablaPyM);
        }
    }
}
