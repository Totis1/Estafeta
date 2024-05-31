using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Estafeta.Clases
{
    internal class ClassAlmacen
    {
        public void MostrarAlmacen(DataGridView tablaAlmacen)
        {
            try
            {
                Conexion_DB objConn = new Conexion_DB();
                string query = "select * from Almacen";
                tablaAlmacen.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, objConn.establecerConn());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaAlmacen.DataSource = dt;
                objConn.cerrarConn();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo mostrar la DB," + ex.ToString());
            }
        }
        public void InsertarAlmacen(ComboBox TipoPaquete, TextBox Dimensiones, DateTimePicker FechaEntrada, DateTimePicker FechaSalida)
        {
            int indice = TipoPaquete.SelectedIndex;
            DateTime fechaentrada = FechaEntrada.Value;
            DateTime fechasalida = FechaSalida.Value;
            string aux = "";
            string aux2 = "";
            //MessageBox.Show(fecha.ToString(formato));
            aux = fechaentrada.ToString("yyyy-MM-dd");
            aux2 = fechasalida.ToString("yyyy-MM-dd");
            try
            {
                Conexion_DB objConn = new Conexion_DB();
                string query = "insert into Almacen (Tipo_Paquete_Almacen, Dimensiones_Paquete_Almacen, Fecha_Entrada, Fecha_Salida) " +
                    "values ('" + TipoPaquete.Items[indice].ToString() + "','" + Dimensiones.Text + "','" + aux + "','" + aux2 + "');";
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
                MessageBox.Show("No se pudo agregar el registro, error: " + ex.ToString());
            }
        }
        public void SeleccionarAlmacen(DataGridView tablaAlmacen, ComboBox TipoPaquete, TextBox Dimensiones, DateTimePicker FechaEntrada, DateTimePicker FechaSalida, TextBox ID)
        {
            try
            {
                ID.Text = tablaAlmacen.CurrentRow.Cells[0].Value.ToString();
                TipoPaquete.Text = tablaAlmacen.CurrentRow.Cells[1].Value.ToString();
                Dimensiones.Text = tablaAlmacen.CurrentRow.Cells[2].Value.ToString();
                FechaEntrada.Value = Convert.ToDateTime(tablaAlmacen.CurrentRow.Cells[3].Value.ToString());
                //MessageBox.Show(tablaPyM.CurrentRow.Cells[4].Value.ToString());
                FechaSalida.Value = Convert.ToDateTime(tablaAlmacen.CurrentRow.Cells[4].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo seleccionar, error:" + ex.ToString());
            }
        }
        public void ActualizarAlmacen(ComboBox TipoPaquete, TextBox Dimensiones, DateTimePicker FechaEntrada, DateTimePicker FechaSalida, TextBox ID)
        {
            int indice = TipoPaquete.SelectedIndex;
            DateTime fechaentrada = FechaEntrada.Value;
            DateTime fechasalida = FechaSalida.Value;
            string aux = "";
            string aux2 = "";
            //MessageBox.Show(fecha.ToString(formato));
            aux = fechaentrada.ToString("yyyy-MM-dd");
            aux2 = fechasalida.ToString("yyyy-MM-dd");

            try
            {
                Conexion_DB objConn = new Conexion_DB();
                string query = "update Almacen set Tipo_Paquete_Almacen='" + TipoPaquete.Items[indice].ToString() + "', Dimensiones_Paquete_Almacen='" +
                       Dimensiones.Text + "', Fecha_Entrada='" + aux + "', Fecha_Salida='" + aux2 +
                       "'where ID_Paquete_Almacen ='" + ID.Text + "';";
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
                MessageBox.Show("No se actualizo el registro, error: " + ex.ToString());
            }
        }
        public void EliminarAlmacen(TextBox ID)
        {
            try
            {
                Conexion_DB objConn = new Conexion_DB();
                string query = "delete from Almacen where ID_Paquete_Almacen ='" + ID.Text + "';";
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
