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
    public partial class Update_Logistica : Form
    {
        public Update_Logistica()
        {
            InitializeComponent();
        }

        private void Update_Logistica_Load(object sender, EventArgs e)
        {

        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            Clases.ClassPyM objPyM = new Clases.ClassPyM();
            objPyM.ActualizarPyM(CBoxTipoA, TxtBoxDestinoA, TxtBoxCostoA, DtpFechaA, TxtBoxId);
            this.Close();
        }
    }
}
