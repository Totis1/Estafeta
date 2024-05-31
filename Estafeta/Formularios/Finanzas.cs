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
    public partial class Finanzas : Form
    {
        public Finanzas()
        {
            InitializeComponent();
            Clases.ClassFinanzas objFinanzas = new Clases.ClassFinanzas();
            objFinanzas.MostrarFinanzas(DgvTablaFinanzas);
        }

        private void Btn_Insertar_Click(object sender, EventArgs e)
        {
            Formularios.Insert_Finanzas insert_Finanzas = new Formularios.Insert_Finanzas();
            insert_Finanzas.ShowDialog();
            Clases.ClassFinanzas objFinanzas = new Clases.ClassFinanzas();
            objFinanzas.MostrarFinanzas(DgvTablaFinanzas);

        }

        private void DgvTablaFinanzas_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Formularios.Update_Finanzas update_F = new Update_Finanzas();
            Clases.ClassFinanzas objFinanzas = new Clases.ClassFinanzas();
            objFinanzas.SeleccionarFinanza(DgvTablaFinanzas,update_F.DtpFechaTransaccion,update_F.CboxTdT,update_F.TxtBoxDdT,update_F.TxtBoxMdT,update_F.TxtBoxCudT,
                                           update_F.CboxCadT,update_F.CboxCdC,update_F.CboxMdP,update_F.CboxEdT,update_F.TxtBoxID, update_F.TxtBoxIDTransaccion);
            update_F.ShowDialog();
            objFinanzas.MostrarFinanzas(DgvTablaFinanzas);
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            Clases.ClassFinanzas objFinanzas = new Clases.ClassFinanzas();
            Formularios.Delete_Finanza delete_Finanza = new Formularios.Delete_Finanza();
            delete_Finanza.ShowDialog();
            objFinanzas.MostrarFinanzas(DgvTablaFinanzas);
        }
    }
}
