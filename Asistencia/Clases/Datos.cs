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
            Conectar();
            MySqlDataAdapter da = new MySqlDataAdapter(comando, conexion);
            DataSet ds = new DataSet();
            da.Fill(ds);
            Desconectar();
            return ds;
        }

        public bool ejecutarComando(string comando)
        {
            Conectar();
            MySqlCommand cmd = new MySqlCommand(comando, conexion);
            cmd.ExecuteNonQuery();
            Desconectar();
            return true;
        }
    }
}
