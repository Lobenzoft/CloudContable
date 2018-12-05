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
        DataGridView data;
        string glosa;
        public FPlanCuentas(DataGridView data,string glosa)
        {
            InitializeComponent();
            Data1.DataSource = CloudContable.plan_cuentas;
            this.data = data;
            this.glosa = glosa;
            SendKeys.Send("{TAB}");
        }

        void EnviarData()
        {
            data.Rows.Add(Data1.CurrentRow.Cells[1].Value, Data1.CurrentRow.Cells[2].Value, glosa, 0.00, 0.00);
            CloudContable.QuitarC();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter && Data1.CurrentRow.Cells[4].Value.Equals("5")) EnviarData();
            if (!this.Focused)return base.ProcessCmdKey(ref msg, keyData);
            else if ((keyData != Keys.F1) & (keyData != Keys.F2))return base.ProcessCmdKey(ref msg, keyData);
            return true;
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void CancelarB_Click(object sender, EventArgs e) => CloudContable.QuitarC();

        private void Data1_DoubleClick(object sender, EventArgs e)
        {
        }

        private void Data1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Data1.CurrentRow.Cells[4].Value.Equals("5")) EnviarData();
        }
    }
}
