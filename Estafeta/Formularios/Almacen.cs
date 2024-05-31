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
    public partial class Almacen : Form
    {
        public Almacen()
        {
            InitializeComponent();
            Clases.ClassAlmacen objAlmacen = new Clases.ClassAlmacen();
            objAlmacen.MostrarAlmacen(DgvTablaAlmacen);
        }

        private void Btn_Insertar_Click(object sender, EventArgs e)
        {
            Formularios.Insert_Almacen insert = new Formularios.Insert_Almacen();
            insert.ShowDialog();
            Clases.ClassAlmacen objAlmacen = new Clases.ClassAlmacen();
            objAlmacen.MostrarAlmacen(DgvTablaAlmacen);
        }

        private void Almacen_Load(object sender, EventArgs e)
        {
            Clases.ClassAlmacen objAlmacen = new Clases.ClassAlmacen();
            objAlmacen.MostrarAlmacen(DgvTablaAlmacen);
        }

        private void DgvTablaAlmacen_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Formularios.Update_Almacen F_update = new Formularios.Update_Almacen();
            Clases.ClassAlmacen objAlmacen = new Clases.ClassAlmacen();
            objAlmacen.SeleccionarAlmacen(DgvTablaAlmacen, F_update.CBoxTipoPaquete, F_update.TxtBoxDimensiones, F_update.DtpFechaEntrada, F_update.DtpFechaSalida, F_update.TxtBoxID);
            F_update.ShowDialog();
            objAlmacen.MostrarAlmacen(DgvTablaAlmacen);
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Clases.ClassAlmacen objAlmacen = new Clases.ClassAlmacen();
            Formularios.Delete_Almacen delete = new Formularios.Delete_Almacen();
            delete.ShowDialog();
            objAlmacen.MostrarAlmacen(DgvTablaAlmacen);
        }
    }
}
