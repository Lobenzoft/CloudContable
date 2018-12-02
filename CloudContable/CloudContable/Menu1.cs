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
    public partial class Menu1 : UserControl
    {
        public Menu1()
        {
            InitializeComponent();
        }

        private void ComprobanteB_Click(object sender, EventArgs e)
        {
            //FRegistrarAsiento registrarasiento = new FRegistrarAsiento();
            CloudContable.CargarC(new FRegistrarAsiento());
        }

        private void LDiarioB_Click(object sender, EventArgs e)
        {
            //FLibroDiario libroDiario = new FLibroDiario();
            CloudContable.CargarC(new FLibroDiario());
        }

        private void LMayorB_Click(object sender, EventArgs e)
        {
            //FLibroMayor libroMayor = new FLibroMayor();
            CloudContable.CargarC(new FLibroMayor());
        }

        private void SSaldosB_Click(object sender, EventArgs e)
        {
            //FSumasSaldos fsumasSaldos = new FSumasSaldos();
            CloudContable.CargarC(new FSumasSaldos());
        }

        private void EResultadoB_Click(object sender, EventArgs e)
        {
            //FEstadoResultado festadoResultado = new FEstadoResultado();
            CloudContable.CargarC(new FEstadoResultado());
        }

        private void buttonX6_Click(object sender, EventArgs e)
        {
            //FBalanceGeneral fbalanceGeneral = new FBalanceGeneral();
            CloudContable.CargarC(new FBalanceGeneral());
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            //FFlujoEfectivo fflujoEfectivo = new FFlujoEfectivo();
            CloudContable.CargarC(new FFlujoEfectivo());
        }

        private void buttonX7_Click(object sender, EventArgs e)
        {
            //FEvolucionPatrimonio fevolucionPatrimonio = new FEvolucionPatrimonio();
            CloudContable.CargarC(new FEvolucionPatrimonio());
        }

        private void buttonX8_Click(object sender, EventArgs e)
        {
            //FLibroVC flibroVC = new FLibroVC();
            CloudContable.CargarC(new FLibroVC());
        }
    }
}
