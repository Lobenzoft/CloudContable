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
    public partial class FPlanCuentas : UserControl
    {
        public FPlanCuentas()
        {
            InitializeComponent();
            Data1.DataSource = CloudContable.plan_cuentas;
            SendKeys.Send("{TAB}");
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            CloudContable.QuitarC();
        }
    }
}
