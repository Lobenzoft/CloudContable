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
    public partial class FRegistrarAsiento : UserControl
    {
        ClsComprobante clsComp;
        public FRegistrarAsiento()
        {
            InitializeComponent();
            clsComp = new ClsComprobante();
            clsComp.OpenDB();
            NComprobanteT.Text = clsComp.ObtenerNComprobante(CloudContable.empresa);
            clsComp.CloseDB();
            SendKeys.Send("{TAB}");
        }

        protected override void OnKeyDown(KeyEventArgs keyEvent)
        {
            if (keyEvent.KeyCode == Keys.A)
            {
                MessageBox.Show("'A' was pressed.");
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                MessageBox.Show("f1");
            }

            if (keyData == Keys.Z)
            {
                CloudContable.AgregarC(new FPlanCuentas());
            }
            if (!this.Focused)
                return base.ProcessCmdKey(ref msg, keyData);

            else if ((keyData != Keys.F1) & (keyData != Keys.F2))
                return base.ProcessCmdKey(ref msg, keyData);

            

            return true;
        }

        private void FRegistrarAsiento_Load(object sender, EventArgs e)
        {
        }
    }
}
