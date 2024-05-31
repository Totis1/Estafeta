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
    public partial class Update_RH : Form
    {
        public Update_RH()
        {
            InitializeComponent();
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            Clases.ClassRH objRH = new Clases.ClassRH();
            objRH.ActualizarRH(TxtBoxNombresu,TxtBoxApellidosu,TxtBoxTelefonou,TxtBoxNSSu,TxtBoxCorreou,DtpFechaContrau,
                               CBoxDepartamentosu,CBoxCargou,TxtBoxSalariou,TxtBoxContraseñau,TxtBoxIDu);
            this.Close();
        }
    }
}
