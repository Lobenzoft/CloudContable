using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
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





        public DataTable DataGridToDataTable(DataGridView data)
        {
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
            return dt;
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
