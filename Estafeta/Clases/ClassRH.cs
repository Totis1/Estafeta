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
    internal class ClassRH
    {
        public string LoginRH(TextBox Correo, TextBox Pass)
        {
            string query = "select * from rh where Correo = '" + Correo.Text + "' and Contraseña = '" + Pass.Text + "' ";
            Conexion_DB objConn = new Conexion_DB();
            MySqlCommand command = new MySqlCommand(query, objConn.establecerConn());
            MySqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                string dd = reader.GetString("Departamento");
                return dd;
            }
            else
            {
                MessageBox.Show("Logeado incorrectamente");
                return "0";
            }
        }
        public void MostrarRH(DataGridView tablaRH)
        {
            try
            {
                Conexion_DB objConn = new Conexion_DB();
                string query = "select * from rh";
                tablaRH.DataSource = null;
                MySqlDataAdapter adapter = new MySqlDataAdapter(query, objConn.establecerConn());
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                tablaRH.DataSource = dt;
                objConn.cerrarConn();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo mostrar la DB, error: " + ex.ToString());
            }
        }
        public void InsertarRH(TextBox Nombres, TextBox Apellidos, TextBox Telefono, TextBox NSS, TextBox Correo, 
                               DateTimePicker FechaContra, ComboBox Departamento, ComboBox Cargo, TextBox Salario,
                               TextBox Contraseña) 
        {
            int indice = Cargo.SelectedIndex;
            int indice2 = Departamento.SelectedIndex;
            DateTime fecha = FechaContra.Value;
            string aux = "";
            aux = fecha.ToString("yyyy-MM-dd");
            try
            {
                Conexion_DB objConn = new Conexion_DB();
                string query = "insert into rh (Nombres, Apellidos, Telefono, Correo, NSS, Fecha_Contratacion, Departamento, Cargo, Salario, Contraseña) " +
                    "values ('" + Nombres.Text + "','" + Apellidos.Text + "','" + Telefono.Text + "','" + Correo.Text + "','" + NSS.Text + "','" + aux + "','" 
                                + Departamento.Items[indice2].ToString() + "','" + Cargo.Items[indice].ToString() + "'," + Salario.Text + ",'" + Contraseña.Text + "');";
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

        public void SeleccionarRH(DataGridView tablaRH, TextBox Nombres, TextBox Apellidos, TextBox Telefono, TextBox NSS, TextBox Correo,
                               DateTimePicker FechaContra, ComboBox Departamento, ComboBox Cargo, TextBox Salario,
                               TextBox Contraseña, TextBox ID)
        {
            try
            {
                ID.Text = tablaRH.CurrentRow.Cells[0].Value.ToString();
                Nombres.Text = tablaRH.CurrentRow.Cells[1].Value.ToString();
                Apellidos.Text = tablaRH.CurrentRow.Cells[2].Value.ToString();
                Telefono.Text = tablaRH.CurrentRow.Cells[3].Value.ToString();
                Correo.Text = tablaRH.CurrentRow.Cells[4].Value.ToString();
                NSS.Text = tablaRH.CurrentRow.Cells[5].Value.ToString();
                FechaContra.Value = Convert.ToDateTime(tablaRH.CurrentRow.Cells[6].Value.ToString());
                Departamento.Text = tablaRH.CurrentRow.Cells[7].Value.ToString();
                Cargo.Text = tablaRH.CurrentRow.Cells[8].Value.ToString();
                Salario.Text = tablaRH.CurrentRow.Cells[9].Value.ToString();
                Contraseña.Text = tablaRH.CurrentRow.Cells[10].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se pudo seleccionar, error:" + ex.ToString());
            }
        }
        public void ActualizarRH(TextBox Nombres, TextBox Apellidos, TextBox Telefono, TextBox NSS, TextBox Correo,
                                 DateTimePicker FechaContra, ComboBox Departamento, ComboBox Cargo, TextBox Salario,
                                 TextBox Contraseña, TextBox ID)
        {
            int indice = Cargo.SelectedIndex;
            int indice2 = Departamento.SelectedIndex;
            DateTime fecha = FechaContra.Value;
            string aux = "";
            aux = fecha.ToString("yyyy-MM-dd");

            try
            {
                Conexion_DB objConn = new Conexion_DB();
                string query = "update rh set Nombres='" + Nombres.Text + "', Apellidos='" +
                       Apellidos.Text + "', Telefono='" + Telefono.Text + "', Correo='" + Correo.Text +
                       "', NSS='" + NSS.Text + "', Fecha_Contratacion='" + aux + "', Departamento='" + Departamento.Items[indice2].ToString() +
                       "', Cargo='" + Cargo.Items[indice].ToString() + "', Salario=" + Salario.Text + ", Contraseña='" + Contraseña.Text +
                       "'where ID_Empleado ='" + ID.Text + "';";
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
        public void EliminarRH(TextBox ID)
        {
            try
            {
                Conexion_DB objConn = new Conexion_DB();
                string query = "delete from rh where ID_Empleado ='" + ID.Text + "';";
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
