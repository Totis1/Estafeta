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
    public partial class Carga_Aerea : Form
    {
        public Carga_Aerea()
        {
            InitializeComponent();
            Clases.ClassCarga_Aerea objCarga_Aerea = new Clases.ClassCarga_Aerea();
            objCarga_Aerea.MostrarCarga_Aerea(DgvTablaCA);
        }

        private void Btn_Insertar_Click(object sender, EventArgs e)
        {
            Formularios.Insert_Carga_Aerea insert = new Formularios.Insert_Carga_Aerea();
            insert.ShowDialog();
            Clases.ClassCarga_Aerea objCarga_Aerea = new Clases.ClassCarga_Aerea();
            objCarga_Aerea.MostrarCarga_Aerea(DgvTablaCA);
        }

        private void DgvTablaCA_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Formularios.Update_Carga_Aerea F_update = new Formularios.Update_Carga_Aerea();
            Clases.ClassCarga_Aerea objCarga_Aerea = new Clases.ClassCarga_Aerea();
            objCarga_Aerea.SeleccionarCarga_Aerea(DgvTablaCA,F_update.TxtBoxOrigen,F_update.TxtBoxDestino,F_update.DtpFechaEnvio, F_update.TxtBoxPeso, F_update.TxtBoxVolumen, F_update.CboxEstado, F_update.TxtBoxID);
            F_update.ShowDialog();
            objCarga_Aerea.MostrarCarga_Aerea(DgvTablaCA);
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            Clases.ClassCarga_Aerea objCarga_Aerea = new Clases.ClassCarga_Aerea();
            Formularios.Delete_Carga_Aerea delete = new Formularios.Delete_Carga_Aerea();
            delete.ShowDialog();
            objCarga_Aerea.MostrarCarga_Aerea(DgvTablaCA);
        }
    }
}
