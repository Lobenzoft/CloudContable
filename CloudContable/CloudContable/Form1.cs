﻿using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Metro;
using DevComponents.DotNetBar.Metro.ColorTables;
using System.Drawing;
using System.Windows.Forms;

namespace CloudContable
{
    public partial class CloudContable : MetroForm
    {
        public static Panel ContenidoM, ContenidoC, ContenidoD;
        public CloudContable()
        {
            InitializeComponent();
            StyleManager.MetroColorGeneratorParameters = new MetroColorGeneratorParameters(Color.White, Color.FromArgb(0, 223, 252));
            ContenidoM = MenuPanel;
            ContenidoC = ContenidoPanel;
            ContenidoD = DetallePanel;
            Menu1 menu1 = new Menu1();
            CargarM(menu1);

            Inicio inicio = new Inicio();
            CargarC(inicio);
        }
        public static void CargarM(Control cont)
        {
            ContenidoM.Controls.Clear();
            ContenidoM.Controls.Add(cont);
        }


        public static void CargarC(Control cont)
        {
            ContenidoC.Controls.Clear();
            ContenidoC.Controls.Add(cont);
        }
        public static void CargarD(Control cont)
        {
            ContenidoD.Controls.Clear();
            ContenidoD.Controls.Add(cont);
        }
    }
}
