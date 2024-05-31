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
    public partial class Update_Finanzas : Form
    {
        public Update_Finanzas()
        {
            InitializeComponent();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            Clases.ClassFinanzas ObjFinanzas = new Clases.ClassFinanzas();
            ObjFinanzas.ActualizarFinanza(DtpFechaTransaccion,CboxTdT,TxtBoxDdT,TxtBoxMdT,TxtBoxCudT,CboxCadT,CboxCdC,
                                          CboxMdP,CboxEdT,TxtBoxID,TxtBoxIDTransaccion);
            this.Close();
        }
    }
}
