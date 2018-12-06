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

        public void RegistrarComprobante(DataGridView data,string idempresa, string idusuario, string n_comprobante,string comprobante_tipo, string comprobante_razon, string comprobante_glosa, string comprobante_cheque, string comprobante_fecha, string comprobante_usd, string comprobante_ufv,bool comprobante_valido=true, string idproyecto="1")
        {
            if (conexion.State == ConnectionState.Open)
            {
                MySqlCommand query;
                MySqlDataAdapter tabla;
                DataTable datatable = new DataTable();
                string comando = "call registrarComprobante ( {0}, {1}, '{2}', '{3}', '{4}', '{5}', '{6}', {7}, {8}, {9}, {10})";
                string cmd = string.Format(comando,idempresa, n_comprobante, comprobante_tipo, comprobante_razon, comprobante_glosa, comprobante_cheque, comprobante_fecha, comprobante_usd, comprobante_ufv, comprobante_valido, idproyecto);
                query = new MySqlCommand(cmd, conexion);
                tabla = new MySqlDataAdapter(cmd, conexion);
                tabla.Fill(datatable);

                DataRow row = datatable.Rows[0];
                string lastId = row[0].ToString();
                //query.ExecuteNonQuery();
                // If has last inserted id, add a parameter to hold it.
                //if (query.LastInsertedId == 0)
                //query.Parameters.Add(new MySqlParameter("newId", query.LastInsertedId));

                // Return the id of the new record. Convert from Int64 to Int32 (int).
                //int lastId=(int)query.Parameters["lastid"].Value;
                //int lastId= (int)query.LastInsertedId;
                comando = "call registrarComprobanteDetalle ( {0}, {1}, '{2}', {3}, {4})";
                string codigo, detalle, debe, haber;
                for (int fila = 0; fila < data.Rows.Count - 1; fila++)
                {
                    /*MessageBox.Show(data.Rows[fila].Cells[0].Value.ToString());
                    */
                    codigo = data.Rows[fila].Cells[0].Value.ToString();
                    detalle = data.Rows[fila].Cells[2].Value.ToString();
                    debe = data.Rows[fila].Cells[3].Value.ToString();
                    haber = data.Rows[fila].Cells[4].Value.ToString();
                    cmd = string.Format(comando, lastId, codigo,detalle, debe, haber);
                    query = new MySqlCommand(cmd, conexion);
                    query.ExecuteNonQuery();
                    
                }
                
                
            }
            else
            {
                MessageBox.Show("No existe Conexión", "Cloud Contable");
            }
        }
    }
}
