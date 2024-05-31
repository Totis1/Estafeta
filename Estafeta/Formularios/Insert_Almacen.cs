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
    public partial class Insert_Almacen : Form
    {
        public Insert_Almacen()
        {
            InitializeComponent();
        }

        private void BtnInsertar_Click(object sender, EventArgs e)
        {
            Clases.ClassAlmacen objAlmacen = new Clases.ClassAlmacen();
            objAlmacen.InsertarAlmacen(CBoxTipoPaquete,TxtBoxDimensiones,DtpFechaEntrada,DtpFechaSalida);
            this.Close();
        }
    }
}
