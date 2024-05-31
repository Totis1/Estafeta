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
    public partial class RecursosHumanos : Form
    {
        public RecursosHumanos()
        {
            InitializeComponent();
            Clases.ClassRH objRH = new Clases.ClassRH();
            objRH.MostrarRH(DgvTablaRH);
        }

        private void Btn_Insertar_Click(object sender, EventArgs e)
        {
            Formularios.Insert_RH insert_RH = new Formularios.Insert_RH();
            insert_RH.ShowDialog();
            Clases.ClassRH objRH = new Clases.ClassRH();
            objRH.MostrarRH(DgvTablaRH);
        }

        private void DgvTablaRH_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Formularios.Update_RH F_update = new Formularios.Update_RH();
            Clases.ClassRH objRH = new Clases.ClassRH();
            objRH.SeleccionarRH(DgvTablaRH, F_update.TxtBoxNombresu, F_update.TxtBoxApellidosu, F_update.TxtBoxTelefonou,
                                F_update.TxtBoxNSSu, F_update.TxtBoxCorreou, F_update.DtpFechaContrau, F_update.CBoxDepartamentosu,
                                F_update.CBoxCargou, F_update.TxtBoxSalariou, F_update.TxtBoxContraseñau, F_update.TxtBoxIDu);
            F_update.ShowDialog();
            objRH.MostrarRH(DgvTablaRH);
        }

        private void Btn_Eliminar_Click(object sender, EventArgs e)
        {
            Clases.ClassRH objRH = new Clases.ClassRH();
            Formularios.Delete_RH delete_RH = new Formularios.Delete_RH();
            delete_RH.ShowDialog();
            objRH.MostrarRH(DgvTablaRH);
        }
    }
}
