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
    public partial class Insert_Logistica : Form
    {
        public Insert_Logistica()
        {
            InitializeComponent();
        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            Clases.ClassPyM objPyM = new Clases.ClassPyM();
            objPyM.InsertarPyM(CBoxTipo,TxtBoxDestino,TxtBoxCosto,DtpFecha);
            this.Close();
        }

        private void Insert_Logistica_Load(object sender, EventArgs e)
        {
            CBoxTipo.SelectedIndex = 0;
        }
    }
}
