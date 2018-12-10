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
    public partial class FLibroDiario : UserControl
    {
        ClsComprobante clsComp;
        int cantidadComprobantes = 0,NFlecha=0;
        string[] datos;
        public FLibroDiario()
        {
            InitializeComponent();
            clsComp = new ClsComprobante();
            TipoComprobanteC.Items.Add("Todos");
            TipoComprobanteC.Items.Add("Diario");
            TipoComprobanteC.Items.Add("Ingreso");
            TipoComprobanteC.Items.Add("Egreso");
            TipoComprobanteC.SelectedIndex = 0;
            TipoAsientoC.Items.Add("Diario");
            TipoAsientoC.Items.Add("Ingreso");
            TipoAsientoC.Items.Add("Egreso");
            FechaInicioD.Format = DateTimePickerFormat.Custom;
            FechaInicioD.CustomFormat = "dd/MM/yyyy";
            FechaFinD.Format = DateTimePickerFormat.Custom;
            FechaFinD.CustomFormat = "dd/MM/yyyy";
            FechaComprobanteD.Format = DateTimePickerFormat.Custom;
            FechaComprobanteD.CustomFormat = "dd/MM/yyyy";
            FechaInicioD.Value = Convert.ToDateTime(CloudContable.Info[2]);
            FechaFinD.Value = Convert.ToDateTime(CloudContable.Info[3]);
            CambiarComprobante();
            
            clsComp.OpenDB();
            cantidadComprobantes = clsComp.ObtenerCantidadComprobantes(CloudContable.Info[0], FechaInicioD.Value.ToString("yyyy-MM-dd"), FechaFinD.Value.ToString("yyyy-MM-dd"), TipoComprobanteC.SelectedItem.ToString(), 0);
            clsComp.CloseDB();
            SendKeys.Send("{TAB}");
        }

        private void PrimeroB_Click(object sender, EventArgs e)
        {
            NFlecha = 0;
            CambiarComprobante();
        }

        private void AtrasB_Click(object sender, EventArgs e)
        {
            if (NFlecha > 0) 
            {
                NFlecha--;
            }
            CambiarComprobante();
        }

        private void AdelanteB_Click(object sender, EventArgs e)
        {
            if (NFlecha < cantidadComprobantes - 1)
            {
                NFlecha++;
            }
            CambiarComprobante();
        }

        private void FinalB_Click(object sender, EventArgs e)
        {
            NFlecha = cantidadComprobantes - 1;
            CambiarComprobante();
        }

        void CambiarComprobante()
        {
            clsComp.OpenDB();
            datos = clsComp.ObtenerComprobantes(CloudContable.Info[0], FechaInicioD.Value.ToString("yyyy-MM-dd"), FechaFinD.Value.ToString("yyyy-MM-dd"), NFlecha, TipoComprobanteC.SelectedItem.ToString(), 0);
            Data1.Rows.Clear();
            clsComp.ObtenerComprobanteDetalle(datos[0], Data1);
            clsComp.CloseDB();
            NComprobanteT.Text = datos[2];
            if (datos[3] == "Diario")
            {
                TipoAsientoC.SelectedIndex = 0;
            }
            else if (datos[3] == "Ingreso")
            {
                TipoAsientoC.SelectedIndex = 1;
            }
            else if (datos[3] == "Egreso")
            {
                TipoAsientoC.SelectedIndex = 2;
            }
            RazonSocialT.Text = datos[4];
            GlosaT.Text = datos[5];
            NChequeT.Text = datos[6];
            FechaComprobanteD.Value = Convert.ToDateTime(datos[7]);
            USDT.Text = datos[8];
            UFVT.Text = datos[9];
            ClsPublic.SumarDebeHaberComprobante(Data1, TDebeT, THaberT);
        }
    }
}
