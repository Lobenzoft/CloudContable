using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CloudContable
{
    public partial class FLogin : UserControl
    {
        ClsLogin clslog;
        ClsPlanCuentas clsplan;
        public FLogin()
        {
            InitializeComponent();
            clslog = new ClsLogin();
            clsplan = new ClsPlanCuentas();
        }

        private void IngresarB_Click(object sender, EventArgs e)
        {
            clslog.OpenDB();
            clslog.IniciarSession(Data1,EmpresaT.Text,UserT.Text,PassT.Text);
            clslog.CloseDB();
            SendKeys.Send("{TAB}");
        }

        private void SeleccionB_Click(object sender, EventArgs e)
        {
            try
            {
                CloudContable.empresa = Data1.CurrentRow.Cells[0].Value.ToString();
                CloudContable.usuario = Data1.CurrentRow.Cells[6].Value.ToString();
                clsplan.OpenDB();
                CloudContable.plan_cuentas = clsplan.ObtenerPlanCuentas(Data1.CurrentRow.Cells[5].Value.ToString());
                clsplan.CloseDB();
                CloudContable.CargarC(new Inicio());
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Debe de Seleccionar una Empresa.","Cloud Contable");
            }
        }
    }
}
