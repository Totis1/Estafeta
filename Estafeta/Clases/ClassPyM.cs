using Google.Protobuf.WellKnownTypes;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estafeta.Clases
{
    internal class ClassPyM
    {
        public void MostrarPyM(DataGridView tablaPyM )
        {
            try
            {
                Conexion_DB objConn = new Conexion_DB();
                string query = "select * from myp";
                tablaPyM.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(query,objConn.establecerConn());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaPyM.DataSource = dt;
                objConn.cerrarConn();
            }
            catch ( Exception ex )
            {
                MessageBox.Show( "No se pudo mostrar la DB,"+ex.ToString() );
            }
        }

        public void InsertarPyM(ComboBox Tipo,TextBox Destino, TextBox Costo, DateTimePicker Fecha )
        {
            int indice = Tipo.SelectedIndex;
            DateTime fecha = Fecha.Value;
            string aux = "";
            //MessageBox.Show(fecha.ToString(formato));

            aux = fecha.ToString("yyyy-MM-dd");
            try
            {
                Conexion_DB objConn = new Conexion_DB();
                string query = "insert into myp (Tipo_MoP, Destino_MoP, Costo_MoP, Fecha_Registro_MoP) " +
                    "values ('" + Tipo.Items[indice].ToString() + "','" + Destino.Text + "'," + Costo.Text + ",'"
                    + aux + "');";
                MySqlCommand cmd = new MySqlCommand(query, objConn.establecerConn());
                MySqlDataReader reader = cmd.ExecuteReader();
                //MessageBox.Show("Se guardo el registro");
                while (reader.Read())
                {

                }
                objConn.cerrarConn();
            }
            catch(Exception ex) 
            {
                MessageBox.Show("No se pudo Insertar, error:" + ex.ToString());
            }
        }

        public void SeleccionarPyM(DataGridView tablaPyM, ComboBox Tipo, TextBox Destino, TextBox Costo, DateTimePicker Fecha, TextBox ID)
        {
            try
            {
                ID.Text = tablaPyM.CurrentRow.Cells[0].Value.ToString();
                Tipo.Text = tablaPyM.CurrentRow.Cells[1].Value.ToString();
                Destino.Text = tablaPyM.CurrentRow.Cells[2].Value.ToString();
                Costo.Text = tablaPyM.CurrentRow.Cells[3].Value.ToString();
                //MessageBox.Show(tablaPyM.CurrentRow.Cells[4].Value.ToString());
                Fecha.Value = Convert.ToDateTime(tablaPyM.CurrentRow.Cells[4].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo seleccionar, error:" + ex.ToString());
            }
        }

        public void ActualizarPyM(ComboBox Tipo, TextBox Destino, TextBox Costo, DateTimePicker Fecha, TextBox ID)
        {
            int indice = Tipo.SelectedIndex;
            DateTime fecha = Fecha.Value;
            string aux = "";
            aux = fecha.ToString("yyyy-MM-dd");

            try
            {
                Conexion_DB objConn = new Conexion_DB();
                string query = "update myp set Tipo_MoP='" + Tipo.Items[indice].ToString() + "', Destino_MoP='" +
                       Destino.Text + "', Costo_MoP='" + Costo.Text + "', Fecha_Registro_MoP='" + aux +
                       "'where ID_MoP ='" + ID.Text + "';";
                MySqlCommand cmd = new MySqlCommand(query, objConn.establecerConn());
                MySqlDataReader reader = cmd.ExecuteReader();
                //MessageBox.Show("Se guardo el registro");
                while (reader.Read())
                {

                }
                objConn.cerrarConn();
            }
            catch(Exception ex)
            {
                MessageBox.Show("No se actualizo el registro, error: " + ex.ToString());
            }
        }

        public void EliminarPyM(TextBox ID)
        {
            try
            {
                Conexion_DB objConn = new Conexion_DB();
                string query = "delete from myp where ID_MoP ='" + ID.Text + "';";
                MySqlCommand cmd = new MySqlCommand(query, objConn.establecerConn());
                MySqlDataReader reader = cmd.ExecuteReader();
                //MessageBox.Show("Se guardo el registro");
                while (reader.Read())
                {

                }
                objConn.cerrarConn();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se elimino el registro, error: " + ex.ToString());
            }
        }
    }
}
