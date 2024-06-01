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
    public partial class Admin_View : Form
    {
        public Admin_View()
        {
            InitializeComponent();
        }

        private void Btn_Logistica_Click(object sender, EventArgs e)
        {
            Formularios.Logistica logistica = new Formularios.Logistica();
            logistica.ShowDialog();
        }

        private void Btn_RH_Click(object sender, EventArgs e)
        {
            Formularios.RecursosHumanos recursosHumanos = new Formularios.RecursosHumanos();
            recursosHumanos.ShowDialog();
        }

        private void Btn_Finanzas_Click(object sender, EventArgs e)
        {
            Formularios.Finanzas finanzas = new Formularios.Finanzas();
            finanzas.ShowDialog();
        }

        private void Btn_Almacen_Click(object sender, EventArgs e)
        {
            Formularios.Almacen almacen = new Formularios.Almacen();
            almacen.ShowDialog();
        }

        private void Btn_CA_Click(object sender, EventArgs e)
        {
            Formularios.Carga_Aerea carga_aerea = new Formularios.Carga_Aerea();
            carga_aerea.ShowDialog();
        }
    }
}
