using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CloudContable
{
    class ClsComprobante
    {
        MySqlConnection conexion;
        ClsCloud Cloud;
        public ClsComprobante()
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

        public string ObtenerNComprobante(string empresa)
        {
            string retorno = "";
            if (conexion.State == ConnectionState.Open)
            {
                MySqlDataAdapter tabla;
                DataTable datatable = new DataTable();
                string comando = "call obtenerNComprobante({0})";
                string cmd = string.Format(comando, empresa);
                tabla = new MySqlDataAdapter(cmd, conexion);
                tabla.Fill(datatable);

                DataRow row = datatable.Rows[0];
                retorno= row[0].ToString();
            }
            else
            {
                MessageBox.Show("No existe Conexión", "Cloud Contable");
            }
            return retorno;
        }

        public void RegistrarComprobante()
        {

        }
    }
}
