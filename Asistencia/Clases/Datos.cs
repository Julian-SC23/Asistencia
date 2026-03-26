using System;
using System.Data;
using MySqlConnector;

namespace Asistencia.Clases
{
    internal class Datos
    {
        string cadenaConexion = "server=localhost;user=juliansini;pwd=julian;Database=asistencia_escolar";
        MySqlConnection conexion;

        private void Conectar()
        {
            conexion = new MySqlConnection(cadenaConexion);
            conexion.Open();
        }

        private void Desconectar()
        {
            conexion.Close();
        }

        public DataSet ejecutar(string comando)
        {
            try
            {
                Conectar();
                MySqlDataAdapter da = new MySqlDataAdapter(comando, conexion);
                DataSet ds = new DataSet();
                da.Fill(ds);
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al consultar: " + ex.Message);
                return null;
            }
            finally
            {
                Desconectar();
            }
        }

        public bool ejecutarComando(string comando)
        {
            try
            {
                Conectar();
                MySqlCommand cmd = new MySqlCommand(comando, conexion);
                cmd.ExecuteNonQuery();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar: " + ex.Message);
                return false;
            }
            finally
            {
                Desconectar();
            }
        }
    }
}
