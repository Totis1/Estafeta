using Estafeta.Clases;
using MySql.Data.MySqlClient;
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
    public partial class Login : Form
    {
        Clases.Conexion_DB objConn = new Clases.Conexion_DB();
        public Login()
        {
            InitializeComponent();
            objConn.establecerConn();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            string decision="";
            Clases.ClassRH objRH = new Clases.ClassRH();
            decision = objRH.LoginRH(TxtBoxUsu,TxtBoxPass);
            //MessageBox.Show(decision);
            switch (decision)
            {
                case "Logística":
                    //MessageBox.Show("Logística");
                    Formularios.Logistica logistica = new Formularios.Logistica();
                    this.Hide();
                    logistica.ShowDialog();
                    this.Close();
                    break;
                case "Recursos Humanos":
                    Formularios.RecursosHumanos recursosHumanos = new Formularios.RecursosHumanos();
                    this.Hide();
                    recursosHumanos.ShowDialog();
                    this.Close();
                    break;
                case "Finanzas":
                    Formularios.Finanzas finanzas = new Formularios.Finanzas();
                    this.Hide();
                    finanzas.ShowDialog();
                    this.Close();
                    break;
                case "Almacen":
                    Formularios.Almacen almacen = new Formularios.Almacen();
                    this.Hide();
                    almacen.ShowDialog();
                    this.Close();
                    break;
                case "Carga Aerea":
                    Formularios.Carga_Aerea carga_aerea = new Formularios.Carga_Aerea();
                    this.Hide();
                    carga_aerea.ShowDialog();
                    this.Close();
                    break;
                case "Admin":
                    Formularios.Admin_View Admin = new Formularios.Admin_View();
                    this.Hide();
                    Admin.ShowDialog();
                    this.Close();
                    break;

            }
        }
    }
}
