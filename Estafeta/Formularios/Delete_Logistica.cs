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
    public partial class Delete_Logistica : Form
    {
        public Delete_Logistica()
        {
            InitializeComponent();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            Clases.ClassPyM objPyM = new Clases.ClassPyM();
            objPyM.EliminarPyM(TxtBoxID_Delete);
            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TxtBoxID_Delete_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
