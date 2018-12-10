using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CloudContable
{
    class ClsLogin
    {
        MySqlConnection conexion;
        ClsCloud Cloud;
        public ClsLogin()
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

        public void IniciarSession(DataGridView data,string cliente,string user,string pass)
        {
            if (conexion.State == ConnectionState.Open)
            {
                MySqlDataAdapter tabla;
                DataTable datatable = new DataTable();
                string comando = "call loginUser('{0}','{1}','{2}')";
                string cmd = string.Format(comando, cliente, user, pass);
                tabla = new MySqlDataAdapter(cmd, conexion);
                tabla.Fill(datatable);
                int cantEmpresa = datatable.Rows.Count;
                if (cantEmpresa == 0)
                {
                    MessageBox.Show("No se encontraron considencias.\nPor favor verifique sus datos.", "Cloud Contable");
                }
                else
                {
                    data.DataSource = datatable;
                    data.Columns[0].Visible = false;
                    data.Columns[3].HeaderText = "Inicio de Gestión";
                    data.Columns[4].HeaderText = "Fin de Gestión";
                }
            }
            else
            {
                MessageBox.Show("No existe Conexión", "Cloud Contable");
            }
            
        }
    }
}
