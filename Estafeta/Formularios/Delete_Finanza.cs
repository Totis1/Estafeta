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
    public partial class Delete_Finanza : Form
    {
        public Delete_Finanza()
        {
            InitializeComponent();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            Clases.ClassFinanzas ObjFinanzas = new Clases.ClassFinanzas();
            ObjFinanzas.EliminarFinanza(TxtBoxID_Delete);
            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
