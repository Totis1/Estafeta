using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estafeta.Clases
{
    internal class Conexion_DB
    {
        MySqlConnection conn = new MySqlConnection();
        static string servidor = "localhost";
        static string bd = "estafeta";
        static string user = "root";
        static string pass = "Sanuma21";
        static string puerto = "3306";

        string cadenaconn = "server=" + servidor + ";" + "port=" + puerto + ";" + "user id=" + user + ";" + "password=" + pass + ";" + "database=" + bd + ";" ;

        public MySqlConnection establecerConn()
        {
            try
            {
                conn.ConnectionString = cadenaconn;
                conn.Open();
                //MessageBox.Show("Se Conecto a la BD");
            }
            catch (MySqlException e)
            {
                MessageBox.Show("No se pudo conectar a la base de datos, error: " + e.ToString());
            }
            return conn;
        }
        
        public void cerrarConn() 
        {
            conn.Close();
        }

    }
}
