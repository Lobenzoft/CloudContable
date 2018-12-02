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
    public partial class FSumasSaldos : UserControl
    {
        public FSumasSaldos()
        {
            InitializeComponent();
            SendKeys.Send("{TAB}");
        }
    }
}
