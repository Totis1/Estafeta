using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace Estafeta.Clases
{
    internal class ClassFinanzas
    {
        public void MostrarFinanzas(DataGridView tablaFinanzas)
        {
            try
            {
                Conexion_DB objConn = new Conexion_DB();
                string query = "select * from finanzas";
                tablaFinanzas.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, objConn.establecerConn());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaFinanzas.DataSource = dt;
                objConn.cerrarConn();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo mostrar la tabla finanzas, error:" + ex.ToString());
            }
        }
        public void InsertarFinanza(DateTimePicker FechaTransaccion, ComboBox TipodeTransaccion, TextBox DescripciondeTransacccion, TextBox Monto, TextBox Cuenta,
                                    ComboBox Categoria, ComboBox CentrodeCostos, ComboBox MetododePago, ComboBox EstadodeTransaccion,TextBox ID)
        {
            int indice1 = TipodeTransaccion.SelectedIndex;
            int indice2 = Categoria.SelectedIndex;
            int indice3 = CentrodeCostos.SelectedIndex;
            int indice4 = MetododePago.SelectedIndex;
            int indice5 = EstadodeTransaccion.SelectedIndex;
            DateTime fecha = FechaTransaccion.Value;
            string aux = "";
            aux = fecha.ToString("yyyy-MM-dd");
            try
            {
                Conexion_DB objConn = new Conexion_DB();
                string query = "insert into Finanzas (Fecha_Transaccion, Tipo_Transaccion, Descripcion_Transaccion, Monto_Transaccion, Cuenta_Transaccion, Categoria_Transaccion, Centro_Costos, Metodo_Pago_Transaccion, Estado_Transaccion, ID_Empleado) " +
                    "values ('" + aux + "','" + TipodeTransaccion.Items[indice1].ToString() + "','" + DescripciondeTransacccion.Text + "'," + Monto.Text + "," + Cuenta.Text + ",'" + Categoria.Items[indice2].ToString() + "','"
                                + CentrodeCostos.Items[indice3].ToString() + "','" + MetododePago.Items[indice4].ToString() + "','" + EstadodeTransaccion.Items[indice5].ToString() + "','" + ID.Text + "');";
                MySqlCommand cmd = new MySqlCommand(query, objConn.establecerConn());
                MySqlDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {

                }
                objConn.cerrarConn();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo Insertar en la tabla RH, error: " + ex.ToString());
            }
        }
        public void SeleccionarFinanza(DataGridView tablaFinanzas, DateTimePicker FechaTransaccion, ComboBox TipodeTransaccion, TextBox DescripciondeTransacccion, TextBox Monto, TextBox Cuenta,
                                    ComboBox Categoria, ComboBox CentrodeCostos, ComboBox MetododePago, ComboBox EstadodeTransaccion, TextBox ID_Empleado, TextBox ID_Finanza)
        {
            try
            {
                ID_Finanza.Text = tablaFinanzas.CurrentRow.Cells[0].Value.ToString();
                FechaTransaccion.Value = Convert.ToDateTime(tablaFinanzas.CurrentRow.Cells[1].Value.ToString());
                TipodeTransaccion.Text = tablaFinanzas.CurrentRow.Cells[2].Value.ToString();
                DescripciondeTransacccion.Text = tablaFinanzas.CurrentRow.Cells[3].Value.ToString();
                Monto.Text = tablaFinanzas.CurrentRow.Cells[4].Value.ToString();
                Cuenta.Text = tablaFinanzas.CurrentRow.Cells[5].Value.ToString();
                Categoria.Text = tablaFinanzas.CurrentRow.Cells[6].Value.ToString();
                CentrodeCostos.Text = tablaFinanzas.CurrentRow.Cells[7].Value.ToString();
                MetododePago.Text = tablaFinanzas.CurrentRow.Cells[8].Value.ToString();
                EstadodeTransaccion.Text = tablaFinanzas.CurrentRow.Cells[9].Value.ToString();
                ID_Empleado.Text = tablaFinanzas.CurrentRow.Cells[10].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo seleccionar, error:" + ex.ToString());
            }
        }
        public void ActualizarFinanza(DateTimePicker FechaTransaccion, ComboBox TipodeTransaccion, TextBox DescripciondeTransacccion, TextBox Monto, TextBox Cuenta,
                                    ComboBox Categoria, ComboBox CentrodeCostos, ComboBox MetododePago, ComboBox EstadodeTransaccion, TextBox ID_Empleado, TextBox ID_Finanza)
        {
            int indice1 = TipodeTransaccion.SelectedIndex;
            int indice2 = Categoria.SelectedIndex;
            int indice3 = CentrodeCostos.SelectedIndex;
            int indice4 = MetododePago.SelectedIndex;
            int indice5 = EstadodeTransaccion.SelectedIndex;
            DateTime fecha = FechaTransaccion.Value;
            string aux = "";
            aux = fecha.ToString("yyyy-MM-dd");

            try
            {
                Conexion_DB objConn = new Conexion_DB();
                string query = "update Finanzas set Fecha_Transaccion='" + aux + "', Tipo_Transaccion='" +
                       TipodeTransaccion.Items[indice1].ToString() + "', Descripcion_Transaccion='" + DescripciondeTransacccion.Text + "', Monto_Transaccion=" + Monto.Text +
                       ", Cuenta_Transaccion=" + Cuenta.Text + ", Categoria_Transaccion='" + Categoria.Items[indice2].ToString() + "', Centro_Costos='" + CentrodeCostos.Items[indice3].ToString() +
                       "', Metodo_Pago_Transaccion='" + MetododePago.Items[indice4].ToString() + "', Estado_Transaccion='" + EstadodeTransaccion.Items[indice5].ToString() + "', ID_Empleado='" + ID_Empleado.Text +
                       "'where ID_Transaccion ='" + ID_Finanza.Text + "';";
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
        public void EliminarFinanza(TextBox ID)
        {
            try
            {
                Conexion_DB objConn = new Conexion_DB();
                string query = "delete from Finanzas where ID_Transaccion ='" + ID.Text + "';";
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
