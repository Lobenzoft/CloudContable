using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CloudContable
{
    class ClsPublic
    {
        /*
         *
         * METODO PARA CARGAR DATOS A UN COMBO BOX CON VALOR E ID
         *
         */
        public class ComboboxItem
        {
            public int id { get; set; }
            public string value { get; set; }

            public override string ToString()
            {
                return value;
            }

        }

        public static int ObtenerIdCombo(ComboBox combo)
        {
            int id;
            id = (combo.SelectedItem as ComboboxItem).id;
            return id;
        }

        public static string ObtenerValorCombo(ComboBox combo)
        {
            string texto;
            texto = (combo.SelectedItem as ComboboxItem).value;
            return texto;
        }

        public static void CargarDatosCombo(ComboBox combo, string id, string value)
        {
            ComboboxItem datos = new ComboboxItem();
            datos.id = Convert.ToInt32(id);
            datos.value = value;
            combo.Items.Add(datos);
            combo.SelectedIndex = 0;
        }

        /*
         *
         * METODO PARA CARGAR DATOS A UN COMBO BOX CON VALOR E ID
         *
         */

        /*
         *
         * METODO METODO PARA CARGAR CODIGO Y CUENTA A AUTOCOMPLETE
         *
         */
        public class DataPlan
        {
            public string Codigo { get; set; }
            public string TCodigo { get; set; }
            public string Cuenta { get; set; }
        }

        public static List<DataPlan> AutoPlan(DataTable datatable)
        {
            List<DataPlan> lista = new List<DataPlan>();
            foreach (DataRow DtRow in datatable.Rows)
            {
                if (DtRow[4].Equals("5"))
                {
                    DataPlan item = new DataPlan
                    {
                        Codigo = Convert.ToString(DtRow[1]),
                        TCodigo = String.Format("{0}  ||  {1}", DtRow[1], DtRow[2]),
                        Cuenta = Convert.ToString(DtRow[2]),
                    };
                    lista.Add(item);
                }
                
            }
            return lista;
        }

        public static string [] ObtenerDataPlanCuentaAutoComplete(string Texto)
        {
            string[] Data = new string[] { "", "" };
            foreach (DataRow DtRow in CloudContable.plan_cuentas.Rows)
            {
                string compare = String.Format("{0}  ||  {1}", DtRow[1], DtRow[2]);
                string compare2 = String.Format("{0}", DtRow[1]);
                string compare3 = "5";
                if ((compare.Equals(Texto) || compare2.Equals(Texto))&&compare3.Equals(DtRow[4]))
                {
                    Data[0] = DtRow[1].ToString();
                    Data[1] = DtRow[2].ToString();
                }
            }
            if (Data[0].Equals(""))
            {
                foreach (DataRow DtRow in CloudContable.plan_cuentas.Rows)
                {
                    string compare = String.Format("{0}", DtRow[2]);
                    if (compare.Equals(Texto))
                    {
                        Data[0] = DtRow[1].ToString();
                        Data[1] = DtRow[2].ToString();
                    }
                }
            }
            return Data;
        }
        /*
         *
         * METODO METODO PARA CARGAR CODIGO Y CUENTA A AUTOCOMPLETE
         *
         */

        public static AutoCompleteStringCollection CargatAutoCompleteCuenta()
        {
            List<DataPlan> _lista = new List<DataPlan>();
            AutoCompleteStringCollection stringdata = new AutoCompleteStringCollection();
            _lista = AutoPlan(CloudContable.plan_cuentas);
            foreach (DataPlan item in _lista)
            {
                stringdata.Add(Convert.ToString(item.Cuenta));
            }
            
            return stringdata;
        }

        public static AutoCompleteStringCollection CargatAutoCompleteCodigo()
        {
            List<DataPlan> _lista = new List<DataPlan>();
            AutoCompleteStringCollection stringdata = new AutoCompleteStringCollection();
            _lista = AutoPlan(CloudContable.plan_cuentas);
            foreach (DataPlan item in _lista)
            {
                stringdata.Add(Convert.ToString(item.TCodigo));
            }
            return stringdata;
        }



        public static DataTable DataGridToDataTable(DataGridView data)
        {
            DataTable dt = new DataTable();
            dt = data.DataSource as DataTable;
            /*
            DataTable dt = new DataTable();
            DataColumn[] dcs = new DataColumn[] { };

            foreach (DataGridViewColumn c in data.Columns)
            {
                DataColumn dc = new DataColumn();
                dc.ColumnName = c.Name;
                dc.DataType = c.ValueType;
                dt.Columns.Add(dc);

            }

            foreach (DataGridViewRow r in data.Rows)
            {
                DataRow drow = dt.NewRow();

                foreach (DataGridViewCell cell in r.Cells)
                {
                    drow[cell.OwningColumn.Name] = cell.Value;
                }
                dt.Rows.Add(drow);
            }
            */
            return dt;
        }

        public static void LimpiarDataGridSinCodigo(DataGridView data)
        {
            for (int fila = 0; fila < data.Rows.Count - 1; fila++)
            {
                if (data.Rows[fila].Cells[0].Value == null || data.Rows[fila].Cells[0].Value.ToString() == "")
                {
                    try
                    {
                        data.Rows.RemoveAt(fila);
                    }
                    catch(InvalidOperationException)
                    {
                    }
                }
            }
            while (VCamposNulos(data))
            {
                LimpiarDataGridSinCodigo(data);
            }
        }
        static bool VCamposNulos(DataGridView data)
        {
            int nulos = 0;
            for (int fila = 0; fila < data.Rows.Count - 1; fila++)
            {
                if (data.Rows[fila].Cells[0].Value == null || data.Rows[fila].Cells[0].Value.ToString() == "")
                {
                    nulos++;
                }
            }
            if (nulos > 0)
                return true;
            else
                return false;
        }

        public static void SumarDebeHaberComprobante(DataGridView data,TextBox debe,TextBox haber,Label label)
        {
            double tdebe = 0.00, thaber = 0.00;
            for (int fila = 0; fila < data.Rows.Count - 1; fila++)
            {
                try
                {
                    tdebe += Convert.ToDouble(data.Rows[fila].Cells[3].Value);
                    thaber += Convert.ToDouble(data.Rows[fila].Cells[4].Value);
                }
                catch { }
            }
            debe.Text = tdebe.ToString("N2");
            haber.Text = thaber.ToString("N2");
            double diferencia = tdebe - thaber;
            label.Text = diferencia.ToString("N2");
            if (diferencia != 0)
            {
                label.ForeColor = Color.Red;
            }
            else
            {
                label.ForeColor = Color.Green;
            }
        }

        public static void SumarDebeHaberComprobante(DataGridView data, TextBox debe, TextBox haber)
        {
            double tdebe = 0.00, thaber = 0.00;
            for (int fila = 0; fila < data.Rows.Count; fila++)
            {
                try
                {
                    tdebe += Convert.ToDouble(data.Rows[fila].Cells[3].Value);
                    thaber += Convert.ToDouble(data.Rows[fila].Cells[4].Value);
                }
                catch { }
            }
            debe.Text = tdebe.ToString("N2");
            haber.Text = thaber.ToString("N2");
            double diferencia = tdebe - thaber;
        }

        public static string ObtenerNombreCuenta(string codigo)
        {
            string cuenta = "";
            foreach (DataRow DtRow in CloudContable.plan_cuentas.Rows)
            {
                string compare = String.Format("{0}", DtRow[1]);
                if (compare.Equals(codigo))
                {
                    cuenta = String.Format("{0}", DtRow[2]);
                    break;
                }
            }
            return cuenta;
        }







































        /*
         *
         *PUBLIC STATIC PARA HACE LA ANIMACION
         * 
         */

        public static void Animar(Control ctl)
        {
            AnimateWindow(ctl.Handle, 500, effmap[7] | effmap[0] | effmap[6]);
        }

        public static void Ocultar(Control ctl)
        {
            AnimateWindow(ctl.Handle, 500, effmap[5] | effmap[0]);
        }

        public static void Load(Control ctl)
        {
            AnimateWindow(ctl.Handle, 500, effmap[4] | effmap[7]);
        }

        private static int[] dirmap = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        private static int[] effmap = { 0x00000001, 0x00000002, 0x00000004, 0x00000008, 0x00000010, 0x00010000, 0x00020000, 0x00040000, 0x00080000 };

        [System.Runtime.InteropServices.DllImport("user32.dll")]

        private static extern bool AnimateWindow(IntPtr handle, int msec, int flags);

        /*
         *
         *PUBLIC STATIC PARA HACE LA ANIMACION
         * 
         */

    }
}
