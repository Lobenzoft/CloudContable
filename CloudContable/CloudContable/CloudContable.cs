using DevComponents.DotNetBar;
using DevComponents.DotNetBar.Metro;
using DevComponents.DotNetBar.Metro.ColorTables;
using System.Drawing;
using System.Windows.Forms;
using System.Data;

namespace CloudContable
{
    public partial class CloudContable : MetroForm
    {
        public static Panel ContenidoM, ContenidoC, ContenidoD;
        public static string empresa;
        public static DataTable plan_cuentas; 
        public CloudContable()
        {
            InitializeComponent();
            //StyleManager.MetroColorGeneratorParameters = new MetroColorGeneratorParameters(Color.White, Color.FromArgb(0, 223, 252));
            ContenidoM = MenuPanel;
            ContenidoC = ContenidoPanel;
            ContenidoD = DetallePanel;
            Menu1 menu1 = new Menu1();
            CargarM(menu1);
            //FLogin flogin = new FLogin();
            CargarC(new FLogin());
        }
        public static void CargarM(Control cont)
        {
            ContenidoM.Controls.Clear();
            ContenidoM.Controls.Add(cont);
        }

        public static void CargarC(Control cont)
        {
            ClsPublic.Ocultar(ContenidoC);
            ContenidoC.Controls.Clear();
            Control fh = cont as Control;
            ContenidoC.Controls.Add(fh);
            ClsPublic.Animar(ContenidoC);
            //ContenidoC.Controls.Clear();
            //ContenidoC.Controls.Add(cont);
        }

        public static void AgregarC(Control cont)
        {
            ClsPublic.Ocultar(ContenidoC);
            Control fh = cont as Control;
            ContenidoC.Controls.Add(fh);
            int i=ContenidoC.Controls.Count;
            ContenidoC.Controls[0].Visible = false;
            ClsPublic.Animar(ContenidoC);
        }
        public static void QuitarC()
        {
            int i = ContenidoC.Controls.Count;
            //ClsPublic.Ocultar(ContenidoC.Controls[i-1]);
            ContenidoC.Controls.RemoveAt(i - 1);
            ContenidoC.Controls[0].Visible = true;
            ContenidoC.Controls[0].Focus();
        }

        public static void CargarForm(object formulario)
        {
            ClsPublic.Ocultar(ContenidoC);
            ContenidoC.Controls.Clear();
            Control fh = formulario as Control;
            ContenidoC.Controls.Add(fh);
            ClsPublic.Animar(ContenidoC);
        }

        public static void CargarD(Control cont)
        {
            ContenidoD.Controls.Clear();
            ContenidoD.Controls.Add(cont);
        }
    }
}
