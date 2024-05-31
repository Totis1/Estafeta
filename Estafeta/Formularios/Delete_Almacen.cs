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
    public partial class Delete_Almacen : Form
    {
        public Delete_Almacen()
        {
            InitializeComponent();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            Clases.ClassAlmacen objAlmacen = new Clases.ClassAlmacen();
            objAlmacen.EliminarAlmacen(TxtBoxID_Delete);
            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtBoxID_Delete_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
