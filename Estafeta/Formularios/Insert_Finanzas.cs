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
    public partial class Insert_Finanzas : Form
    {
        public Insert_Finanzas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clases.ClassFinanzas objFinanzas = new Clases.ClassFinanzas();
            objFinanzas.InsertarFinanza(DtpFechaTransaccion,CboxTdT,TxtBoxDdT,TxtBoxMdT,TxtBoxCudT,CboxCadT,CboxCdC,
                                        CboxMdP,CboxEdT,TxtBoxID);
            this.Close();
        }
    }
}
