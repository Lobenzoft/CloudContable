using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace CloudContable
{
    class ClsCloud
    {
        private MySqlConnection Conexion;

        public ClsCloud()
        {
            string cnx= "Server = sql10.freemysqlhosting.net; Database = sql10269128; Uid = sql10269128; Pwd = pqVCj3lSxt; Port = 3306;";
            //string cnx = "Server = 127.0.0.1; Database = zencontable; Uid = root; Pwd = ''; Port = 3306; old guids = true;";
            //Conexion = new MySqlConnection("Server=85.10.205.173;Port=3306;Database=zencloud;Uid=zensoft;Pwd='zen12345';");
            Conexion = new MySqlConnection(cnx);
        }

        public MySqlConnection AbrirConexion()
        {
            if (Conexion.State == ConnectionState.Closed)
            {
                try
                {
                    Conexion.Open();
                }
                catch(MySqlException)
                {
                    MessageBox.Show("Error En la Conexión","Cloud Contable");
                }
            }
            return Conexion;
        }

        public MySqlConnection CerrarConexion()
        {
            if (Conexion.State == ConnectionState.Open)
                Conexion.Close();
            return Conexion;
        }
    }
}
