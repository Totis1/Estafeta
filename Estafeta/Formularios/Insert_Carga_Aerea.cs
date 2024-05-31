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
    public partial class Insert_Carga_Aerea : Form
    {
        public Insert_Carga_Aerea()
        {
            InitializeComponent();
        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            Clases.ClassCarga_Aerea objCarga_Aerea = new Clases.ClassCarga_Aerea();
            objCarga_Aerea.InsertarCarga_Aerea(TxtBoxOrigen,TxtBoxDestino,DtpFechaEnvio,TxtBoxPeso,TxtBoxVolumen,CboxEstado);
            this.Close();
        }
    }
}
