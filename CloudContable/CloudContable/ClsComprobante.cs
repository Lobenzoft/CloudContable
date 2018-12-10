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

        public void RegistrarComprobante(DataGridView data,string idempresa, string idusuario, string n_comprobante,string comprobante_tipo, string comprobante_razon, string comprobante_glosa, string comprobante_cheque, string comprobante_fecha, string comprobante_usd, string comprobante_ufv,bool comprobante_valido=true, string idproyecto="0")
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
                comando = "call registrarComprobanteDetalle ( {0}, {1}, '{2}', {3}, {4})";
                string codigo, detalle, debe, haber;
                for (int fila = 0; fila < data.Rows.Count - 1; fila++)
                {
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

        public int ObtenerCantidadComprobantes(string idempresa,string desde,string hasta,string tipo,int idproyecto)
        {
            //CALL `obtenerCantidadComprobantes`(1, '2018-01-01', '2018-12-31', 'Ingreso', 0)
            int retorno = 0;
            if (conexion.State == ConnectionState.Open)
            {
                MySqlDataAdapter tabla;
                DataTable datatable = new DataTable();
                string comando = "CALL obtenerCantidadComprobantes({0}, '{1}', '{2}', '{3}', {4})";
                string cmd = string.Format(comando,idempresa,desde,hasta,tipo,idproyecto);
                tabla = new MySqlDataAdapter(cmd, conexion);
                tabla.Fill(datatable);
                DataRow row = datatable.Rows[0];
                retorno=Convert.ToInt16( row[0]);
            }
            else
            {
                MessageBox.Show("No existe Conexión", "Cloud Contable");
            }
            return retorno;
        }

        public string [] ObtenerComprobantes(string idempresa, string desde, string hasta,int pagina, string tipo, int idproyecto)
        {
            //CALL `obtenerComprobantes`(1, '2018-01-01', '2018-12-31', 0, 'Todos', 0)
            string[] datos = new string[12];
            if (conexion.State == ConnectionState.Open)
            {
                MySqlDataAdapter tabla;
                DataTable datatable = new DataTable();
                string comando = "CALL obtenerComprobantes({0}, '{1}', '{2}', {3}, '{4}', {5})";
                string cmd = string.Format(comando, idempresa, desde, hasta, pagina, tipo, idproyecto);
                tabla = new MySqlDataAdapter(cmd, conexion);
                tabla.Fill(datatable);
                DataRow row = datatable.Rows[0];
                datos[0] = row[0].ToString();
                datos[1] = row[1].ToString();
                datos[2] = row[2].ToString();
                datos[3] = row[3].ToString();
                datos[4] = row[4].ToString();
                datos[5] = row[5].ToString();
                datos[6] = row[6].ToString();
                datos[7] = row[7].ToString();
                datos[8] = row[8].ToString();
                datos[9] = row[9].ToString();
                datos[10] = row[10].ToString();
                datos[11] = row[11].ToString();
            }
            else
            {
                MessageBox.Show("No existe Conexión", "Cloud Contable");
            }
            return datos;
        }

        public void ObtenerComprobanteDetalle(string idcomprobante, DataGridView data)
        {
            if (conexion.State == ConnectionState.Open)
            {
                MySqlDataAdapter tabla;
                DataTable datatable = new DataTable();
                string comando = "CALL obtenerComprobantesDetalle({0})";
                string cmd = string.Format(comando, idcomprobante);
                tabla = new MySqlDataAdapter(cmd, conexion);
                tabla.Fill(datatable);
                foreach (DataRow dtRow in datatable.Rows)
                {
                    data.Rows.Add(dtRow[2], ClsPublic.ObtenerNombreCuenta(dtRow[2].ToString()), dtRow[3], Convert.ToDouble(dtRow[4]).ToString("N2"), Convert.ToDouble(dtRow[5]).ToString("N2"));
                }
            }
            else
            {
                MessageBox.Show("No existe Conexión", "Cloud Contable");
            }
        }
    }
}
