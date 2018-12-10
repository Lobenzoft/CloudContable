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
    public partial class FComprobante : UserControl
    {
        ClsComprobante clsComp;
        public FComprobante()
        {
            InitializeComponent();
            clsComp = new ClsComprobante();
            clsComp.OpenDB();
            NComprobanteT.Text = clsComp.ObtenerNComprobante(CloudContable.Info[0]);
            clsComp.CloseDB();
            TipoComprobanteC.Items.Add("Diario");
            TipoComprobanteC.Items.Add("Ingreso");
            TipoComprobanteC.Items.Add("Egreso");
            TipoComprobanteC.SelectedIndex = 0;
            FechaComprobanteD.Format = DateTimePickerFormat.Custom;
            FechaComprobanteD.CustomFormat = "dd/MM/yyyy";
            SendKeys.Send("{TAB}");
        }

        void Clear()
        {
            clsComp.OpenDB();
            NComprobanteT.Text = clsComp.ObtenerNComprobante(CloudContable.Info[0]);
            clsComp.CloseDB();
            NChequeT.Text = "";
            RazonSocialT.Text = "";
            GlosaT.Text = "";
            TotalDebeT.Text = "0.00";
            TotalHaberT.Text = "0.00";
            Data1.Rows.Clear();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.F1)
            {
                MessageBox.Show("f1");
            }
            if (keyData == Keys.F2)
            {
                CloudContable.AgregarC(new FPlanCuentas(Data1,GlosaT.Text));
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

        private void Data1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            TextBox autoText = e.Control as TextBox;
            autoText.AutoCompleteMode = AutoCompleteMode.Suggest;
            autoText.AutoCompleteSource = AutoCompleteSource.CustomSource;
            if (Data1.CurrentCell.ColumnIndex==0)
            {
                if (autoText != null)
                {
                    autoText.AutoCompleteCustomSource = ClsPublic.CargatAutoCompleteCodigo();
                }
            }
            else if (Data1.CurrentCell.ColumnIndex == 1)
            {
                if (autoText != null)
                {
                    autoText.AutoCompleteCustomSource = ClsPublic.CargatAutoCompleteCuenta();
                }
            }
            else
            {
                autoText.AutoCompleteCustomSource = null;
            }
        }

        private void Data1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (Data1.Rows[Data1.CurrentCell.RowIndex].Cells[0].Value == null)
            {
                Data1.Rows[Data1.CurrentCell.RowIndex].Cells[0].Value = "";
            }
            if (Data1.Rows[Data1.CurrentCell.RowIndex].Cells[1].Value == null)
            {
                Data1.Rows[Data1.CurrentCell.RowIndex].Cells[1].Value = "";
            }
            if (Data1.Columns[e.ColumnIndex].Index==0)
            {
                string[] Data = ClsPublic.ObtenerDataPlanCuentaAutoComplete(Data1.Rows[Data1.CurrentCell.RowIndex].Cells[0].Value.ToString());
                Data1.Rows[Data1.CurrentCell.RowIndex].Cells[0].Value = Data[0];
                Data1.Rows[Data1.CurrentCell.RowIndex].Cells[1].Value = Data[1];
            }else if (Data1.Columns[e.ColumnIndex].Index == 1)
            {
                string[] Data = ClsPublic.ObtenerDataPlanCuentaAutoComplete(Data1.Rows[Data1.CurrentCell.RowIndex].Cells[1].Value.ToString());
                Data1.Rows[Data1.CurrentCell.RowIndex].Cells[0].Value = Data[0];
                Data1.Rows[Data1.CurrentCell.RowIndex].Cells[1].Value = Data[1];
            }else if (Data1.Columns[e.ColumnIndex].Index == 3)
            {
                try
                {
                    Data1.Rows[Data1.CurrentCell.RowIndex].Cells[3].Value = Convert.ToDouble(Data1.Rows[Data1.CurrentCell.RowIndex].Cells[3].Value);
                }
                catch (FormatException)
                {
                    Data1.Rows[Data1.CurrentCell.RowIndex].Cells[3].Value = 0.00;
                }
            }
            else if (Data1.Columns[e.ColumnIndex].Index == 4)
            {
                try
                {
                    Data1.Rows[Data1.CurrentCell.RowIndex].Cells[4].Value = Convert.ToDouble(Data1.Rows[Data1.CurrentCell.RowIndex].Cells[4].Value);
                }
                catch (FormatException)
                {
                    Data1.Rows[Data1.CurrentCell.RowIndex].Cells[4].Value = 0.00;
                }
            }
            if (Data1.Rows[Data1.CurrentCell.RowIndex].Cells[2].Value == null)Data1.Rows[Data1.CurrentCell.RowIndex].Cells[2].Value = GlosaT.Text;
            if (Data1.Rows[Data1.CurrentCell.RowIndex].Cells[3].Value == null)Data1.Rows[Data1.CurrentCell.RowIndex].Cells[3].Value = 0.00;
            if (Data1.Rows[Data1.CurrentCell.RowIndex].Cells[4].Value == null)Data1.Rows[Data1.CurrentCell.RowIndex].Cells[4].Value = 0.00;
            //ClsPublic.LimpiarDataGridSinCodigo(Data1);
            ClsPublic.SumarDebeHaberComprobante(Data1,TotalDebeT,TotalHaberT,DiferenciaL);
        }

        private void Data1_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                var hti = Data1.HitTest(e.X, e.Y);
                if ((e.Button == MouseButtons.Right && (Data1.CurrentCell.ColumnIndex == 0 || Data1.CurrentCell.ColumnIndex == 1 || Data1.CurrentCell.ColumnIndex == 2) && Data1.CurrentCell.Value != null))
                {
                    Data1.CurrentCell = Data1.Rows[hti.RowIndex].Cells[hti.ColumnIndex];
                    if (hti.Type == DataGridViewHitTestType.Cell)
                    {
                        MenuEliminar.Show(Data1, new Point(e.X, e.Y));
                    }
                }
                if ((e.Button == MouseButtons.Right && (Data1.CurrentCell.ColumnIndex == 3 || Data1.CurrentCell.ColumnIndex == 4) && Data1.CurrentCell.Value != null))
                {
                    if (hti.Type == DataGridViewHitTestType.Cell)
                    {
                        MenuIVA.Show(Data1, new Point(e.X, e.Y));
                    }
                }
            }
            catch
            {

            }
        }

        private void EliminarCeldaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Data1.Rows.RemoveAt(Data1.CurrentCell.RowIndex);
        }

        private void Data1_MouseDown(object sender, MouseEventArgs e)
        {
            var hti = Data1.HitTest(e.X, e.Y);
            if (hti.Type == DataGridViewHitTestType.Cell && e.Button == MouseButtons.Right)
            {
                Data1.CurrentCell = Data1.Rows[hti.RowIndex].Cells[hti.ColumnIndex];
            }
        }

        private void valorNeto87ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double valorneto = Convert.ToDouble(Data1.CurrentCell.Value);
            valorneto = valorneto * 0.87;
            Data1.CurrentCell.Value = valorneto.ToString();
        }

        private void iVA13ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double iva = Convert.ToDouble(Data1.CurrentCell.Value);
            iva = iva * 0.13;
            Data1.CurrentCell.Value = iva.ToString();
        }

        private void iT3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double it = Convert.ToDouble(Data1.CurrentCell.Value);
            it = (it * 0.03);
            Data1.CurrentCell.Value = it.ToString();
        }

        private void rCIVACOMPRAS8ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double rccompras = Convert.ToDouble(Data1.CurrentCell.Value);
            rccompras = (rccompras * 0.08);
            Data1.CurrentCell.Value = rccompras.ToString();
        }

        private void rCIVASERVICIOS155ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double rcventas = Convert.ToDouble(Data1.CurrentCell.Value);
            rcventas = (rcventas * 0.155);
            Data1.CurrentCell.Value = rcventas.ToString();
        }

        private void CancelarB_Click(object sender, EventArgs e)
        {
            ClsPublic.LimpiarDataGridSinCodigo(Data1);
            if (TotalDebeT.Text== TotalHaberT.Text && Data1.RowCount > 1)
            {
                clsComp.OpenDB();
                if (!clsComp.ObtenerNComprobante(CloudContable.Info[0]).Equals(NComprobanteT.Text)) MessageBox.Show("El Número de Comprobante Se ha Actualizado");
                clsComp.RegistrarComprobante(Data1, CloudContable.Info[0], CloudContable.Info[1], clsComp.ObtenerNComprobante(CloudContable.Info[0]), TipoComprobanteC.SelectedItem.ToString(), RazonSocialT.Text, GlosaT.Text, NChequeT.Text, FechaComprobanteD.Value.ToString("yyyy-MM-dd"), TasaUSDT.Text, TasaUFVT.Text);
                NComprobanteT.Text = clsComp.ObtenerNComprobante(CloudContable.Info[0]);
                clsComp.CloseDB();
                Clear();
            }
            else MessageBox.Show("No se Puede Registrar el Asiento\n-Revise los totales\n-Revise que la cantidad de cuentas utilizadas","Cloud Contable");
            
        }
    }
}
