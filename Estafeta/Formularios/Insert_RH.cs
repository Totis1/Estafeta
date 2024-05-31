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
    public partial class Insert_RH : Form
    {
        public Insert_RH()
        {
            InitializeComponent();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            Clases.ClassRH objRH = new Clases.ClassRH();
            objRH.InsertarRH(TxtBoxNombres, TxtBoxApellidos, TxtBoxTelefono, TxtBoxNSS, TxtBoxCorreo,
                             DtpFechaContra, CboxDepartamentos, CBoxCargo, TxtBoxSalario, TxtBoxContraseña);
            this.Close();
        }

        private void Insert_RH_Load(object sender, EventArgs e)
        {
            CBoxCargo.SelectedIndex = 0;
            CboxDepartamentos.SelectedIndex = 0;
        }
    }
}
