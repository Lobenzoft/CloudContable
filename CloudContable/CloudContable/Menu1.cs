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
            RegistrarAsiento registrarasiento = new RegistrarAsiento();
            CloudContable.CargarC(registrarasiento);
        }
    }
}
