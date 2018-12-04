using MySql.Data.MySqlClient;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CloudContable
{
    class ClsPlanCuentas
    {
        MySqlConnection conexion;
        ClsCloud Cloud;
        public ClsPlanCuentas()
        {
            Cloud = new ClsCloud();
        }
        public void OpenDB()
        {
            conexion = Cloud.AbrirConexion();
        }
        public void CloseDB()
        {
            conexion = Cloud.CerrarConexion();
        }

        public DataTable ObtenerPlanCuentas(string plan)
        {
            DataTable datatable = new DataTable();
            if (conexion.State == ConnectionState.Open)
            {
                MySqlDataAdapter tabla;
                string comando = "select * from {0}";
                string cmd = string.Format(comando, plan);
                tabla = new MySqlDataAdapter(cmd, conexion);
                tabla.Fill(datatable);
            }
            else
            {
                MessageBox.Show("No existe Conexión", "Cloud Contable");
            }
            return datatable;
        }
    }
}
