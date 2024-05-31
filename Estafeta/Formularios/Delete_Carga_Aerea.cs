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
    public partial class Delete_Carga_Aerea : Form
    {
        public Delete_Carga_Aerea()
        {
            InitializeComponent();
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            Clases.ClassCarga_Aerea objCarga_Aerea = new Clases.ClassCarga_Aerea();
            objCarga_Aerea.EliminarCarga_Aerea(TxtBoxID_Delete);
            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
