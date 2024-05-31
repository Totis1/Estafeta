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
    internal class ClassCarga_Aerea
    {
        public void MostrarCarga_Aerea(DataGridView tablaCA)
        {
            try
            {
                Conexion_DB objConn = new Conexion_DB();
                string query = "select * from Carga_Aerea";
                tablaCA.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, objConn.establecerConn());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaCA.DataSource = dt;
                objConn.cerrarConn();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo mostrar la DB," + ex.ToString());
            }
        }
        public void InsertarCarga_Aerea(TextBox Origen, TextBox Destino, DateTimePicker Fecha_Envio, TextBox Peso, TextBox Volumen, ComboBox Estado_Entrega)
        {
            int indice = Estado_Entrega.SelectedIndex;
            DateTime fecha = Fecha_Envio.Value;
            string aux = "";
            //MessageBox.Show(fecha.ToString(formato));

            aux = fecha.ToString("yyyy-MM-dd");
            try
            {
                Conexion_DB objConn = new Conexion_DB();
                string query = "insert into Carga_Aerea (Origen, Destino, Fecha_Envio, Peso, Volumen, Estado_Entrega) " +
                    "values ('" + Origen.Text + "','" + Destino.Text + "','" + aux + "'," + Peso.Text + "," + Volumen.Text + ",'" + Estado_Entrega.Items[indice].ToString() +"');";
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
                MessageBox.Show("No se pudo Insertar, error:" + ex.ToString());
            }
        }
        public void SeleccionarCarga_Aerea(DataGridView tablaCA, TextBox Origen, TextBox Destino, DateTimePicker Fecha_Envio, TextBox Peso, TextBox Volumen, ComboBox Estado_Entrega, TextBox ID)
        {
            try
            {
                ID.Text = tablaCA.CurrentRow.Cells[0].Value.ToString();
                Origen.Text = tablaCA.CurrentRow.Cells[1].Value.ToString();
                Destino.Text = tablaCA.CurrentRow.Cells[2].Value.ToString();
                Fecha_Envio.Value = Convert.ToDateTime(tablaCA.CurrentRow.Cells[3].Value.ToString());
                //MessageBox.Show(tablaPyM.CurrentRow.Cells[4].Value.ToString())
                Peso.Text = tablaCA.CurrentRow.Cells[4].Value.ToString();
                Volumen.Text = tablaCA.CurrentRow.Cells[5].Value.ToString();
                Estado_Entrega.Text = tablaCA.CurrentRow.Cells[6].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo seleccionar, error:" + ex.ToString());
            }
        }
        public void ActualizarCarga_Aerea(TextBox Origen, TextBox Destino, DateTimePicker Fecha_Envio, TextBox Peso, TextBox Volumen, ComboBox Estado_Entrega, TextBox ID)
        {
            int indice = Estado_Entrega.SelectedIndex;
            DateTime fecha = Fecha_Envio.Value;
            string aux = "";
            aux = fecha.ToString("yyyy-MM-dd");
            try
            {
                Conexion_DB objConn = new Conexion_DB();
                string query = "update Carga_Aerea set Origen='" + Origen.Text + "', Destino='" +
                       Destino.Text + "', Fecha_Envio='" + aux + "', Peso=" + Peso.Text + ", Volumen=" + Volumen.Text + ", Estado_Entrega='" + Estado_Entrega.Items[indice].ToString() +
                       "'where ID_Carga_Aerea ='" + ID.Text + "';";
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
        public void EliminarCarga_Aerea(TextBox ID)
        {
            try
            {
                Conexion_DB objConn = new Conexion_DB();
                string query = "delete from Carga_Aerea where ID_Carga_Aerea ='" + ID.Text + "';";
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
