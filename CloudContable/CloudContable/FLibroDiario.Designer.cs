namespace CloudContable
{
    partial class FLibroDiario
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FLibroDiario));
            this.label9 = new System.Windows.Forms.Label();
            this.TDebeT = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.THaberT = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.Data1 = new System.Windows.Forms.DataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.UFVT = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.USDT = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.FechaComprobanteD = new System.Windows.Forms.DateTimePicker();
            this.TipoAsientoC = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.label5 = new System.Windows.Forms.Label();
            this.NChequeT = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.GlosaT = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.RazonSocialT = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.NComprobanteT = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label10 = new System.Windows.Forms.Label();
            this.FechaInicioD = new System.Windows.Forms.DateTimePicker();
            this.label11 = new System.Windows.Forms.Label();
            this.FechaFinD = new System.Windows.Forms.DateTimePicker();
            this.PrimeroB = new DevComponents.DotNetBar.ButtonX();
            this.AtrasB = new DevComponents.DotNetBar.ButtonX();
            this.AdelanteB = new DevComponents.DotNetBar.ButtonX();
            this.FinalB = new DevComponents.DotNetBar.ButtonX();
            this.buttonX5 = new DevComponents.DotNetBar.ButtonX();
            this.TipoComprobanteC = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.label12 = new System.Windows.Forms.Label();
            this.radialMenuItem4 = new DevComponents.DotNetBar.RadialMenuItem();
            this.radialMenuItem5 = new DevComponents.DotNetBar.RadialMenuItem();
            this.OpcioneB = new DevComponents.DotNetBar.ButtonX();
            this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem2 = new DevComponents.DotNetBar.ButtonItem();
            this.ReportesB = new DevComponents.DotNetBar.ButtonX();
            this.buttonItem3 = new DevComponents.DotNetBar.ButtonItem();
            this.buttonItem4 = new DevComponents.DotNetBar.ButtonItem();
            this.codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuenta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.debe = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.haber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Data1)).BeginInit();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(632, 643);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 39;
            this.label9.Text = "Totales : ";
            // 
            // TDebeT
            // 
            this.TDebeT.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.TDebeT.Border.Class = "TextBoxBorder";
            this.TDebeT.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.TDebeT.DisabledBackColor = System.Drawing.Color.White;
            this.TDebeT.ForeColor = System.Drawing.Color.Black;
            this.TDebeT.Location = new System.Drawing.Point(689, 636);
            this.TDebeT.Name = "TDebeT";
            this.TDebeT.PreventEnterBeep = true;
            this.TDebeT.ReadOnly = true;
            this.TDebeT.Size = new System.Drawing.Size(99, 20);
            this.TDebeT.TabIndex = 38;
            // 
            // THaberT
            // 
            this.THaberT.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.THaberT.Border.Class = "TextBoxBorder";
            this.THaberT.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.THaberT.DisabledBackColor = System.Drawing.Color.White;
            this.THaberT.ForeColor = System.Drawing.Color.Black;
            this.THaberT.Location = new System.Drawing.Point(792, 636);
            this.THaberT.Name = "THaberT";
            this.THaberT.PreventEnterBeep = true;
            this.THaberT.ReadOnly = true;
            this.THaberT.Size = new System.Drawing.Size(96, 20);
            this.THaberT.TabIndex = 37;
            // 
            // Data1
            // 
            this.Data1.AllowUserToAddRows = false;
            this.Data1.AllowUserToDeleteRows = false;
            this.Data1.BackgroundColor = System.Drawing.Color.White;
            this.Data1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigo,
            this.cuenta,
            this.detalle,
            this.debe,
            this.haber});
            this.Data1.Location = new System.Drawing.Point(6, 184);
            this.Data1.Name = "Data1";
            this.Data1.ReadOnly = true;
            this.Data1.RowHeadersWidth = 15;
            this.Data1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Data1.Size = new System.Drawing.Size(899, 441);
            this.Data1.TabIndex = 36;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(744, 117);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Tasa de Cambio U.F.V.";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(744, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Tasa de Cambio USD";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(744, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Fecha";
            // 
            // UFVT
            // 
            this.UFVT.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.UFVT.Border.Class = "TextBoxBorder";
            this.UFVT.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.UFVT.DisabledBackColor = System.Drawing.Color.White;
            this.UFVT.ForeColor = System.Drawing.Color.Black;
            this.UFVT.Location = new System.Drawing.Point(747, 133);
            this.UFVT.Name = "UFVT";
            this.UFVT.PreventEnterBeep = true;
            this.UFVT.ReadOnly = true;
            this.UFVT.Size = new System.Drawing.Size(158, 20);
            this.UFVT.TabIndex = 32;
            // 
            // USDT
            // 
            this.USDT.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.USDT.Border.Class = "TextBoxBorder";
            this.USDT.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.USDT.DisabledBackColor = System.Drawing.Color.White;
            this.USDT.ForeColor = System.Drawing.Color.Black;
            this.USDT.Location = new System.Drawing.Point(747, 94);
            this.USDT.Name = "USDT";
            this.USDT.PreventEnterBeep = true;
            this.USDT.ReadOnly = true;
            this.USDT.Size = new System.Drawing.Size(158, 20);
            this.USDT.TabIndex = 31;
            // 
            // FechaComprobanteD
            // 
            this.FechaComprobanteD.Enabled = false;
            this.FechaComprobanteD.Location = new System.Drawing.Point(747, 54);
            this.FechaComprobanteD.Name = "FechaComprobanteD";
            this.FechaComprobanteD.Size = new System.Drawing.Size(158, 20);
            this.FechaComprobanteD.TabIndex = 30;
            // 
            // TipoAsientoC
            // 
            this.TipoAsientoC.DisplayMember = "Text";
            this.TipoAsientoC.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.TipoAsientoC.Enabled = false;
            this.TipoAsientoC.ForeColor = System.Drawing.Color.Black;
            this.TipoAsientoC.FormattingEnabled = true;
            this.TipoAsientoC.ItemHeight = 14;
            this.TipoAsientoC.Location = new System.Drawing.Point(747, 16);
            this.TipoAsientoC.Name = "TipoAsientoC";
            this.TipoAsientoC.Size = new System.Drawing.Size(158, 20);
            this.TipoAsientoC.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(744, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Tipo de Asiento";
            // 
            // NChequeT
            // 
            this.NChequeT.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.NChequeT.Border.Class = "TextBoxBorder";
            this.NChequeT.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.NChequeT.DisabledBackColor = System.Drawing.Color.White;
            this.NChequeT.ForeColor = System.Drawing.Color.Black;
            this.NChequeT.Location = new System.Drawing.Point(547, 16);
            this.NChequeT.Name = "NChequeT";
            this.NChequeT.PreventEnterBeep = true;
            this.NChequeT.ReadOnly = true;
            this.NChequeT.Size = new System.Drawing.Size(158, 20);
            this.NChequeT.TabIndex = 27;
            // 
            // GlosaT
            // 
            this.GlosaT.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.GlosaT.Border.Class = "TextBoxBorder";
            this.GlosaT.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.GlosaT.DisabledBackColor = System.Drawing.Color.White;
            this.GlosaT.ForeColor = System.Drawing.Color.Black;
            this.GlosaT.Location = new System.Drawing.Point(353, 94);
            this.GlosaT.Multiline = true;
            this.GlosaT.Name = "GlosaT";
            this.GlosaT.PreventEnterBeep = true;
            this.GlosaT.ReadOnly = true;
            this.GlosaT.Size = new System.Drawing.Size(350, 70);
            this.GlosaT.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(542, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Numero de Cheque";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 78);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Glosa";
            // 
            // RazonSocialT
            // 
            this.RazonSocialT.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.RazonSocialT.Border.Class = "TextBoxBorder";
            this.RazonSocialT.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.RazonSocialT.DisabledBackColor = System.Drawing.Color.White;
            this.RazonSocialT.ForeColor = System.Drawing.Color.Black;
            this.RazonSocialT.Location = new System.Drawing.Point(353, 55);
            this.RazonSocialT.Name = "RazonSocialT";
            this.RazonSocialT.PreventEnterBeep = true;
            this.RazonSocialT.ReadOnly = true;
            this.RazonSocialT.Size = new System.Drawing.Size(350, 20);
            this.RazonSocialT.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Razon Social";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(350, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 13);
            this.label1.TabIndex = 21;
            this.label1.Text = "Numero de Comprobante";
            // 
            // NComprobanteT
            // 
            this.NComprobanteT.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.NComprobanteT.Border.Class = "TextBoxBorder";
            this.NComprobanteT.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.NComprobanteT.DisabledBackColor = System.Drawing.Color.White;
            this.NComprobanteT.ForeColor = System.Drawing.Color.Black;
            this.NComprobanteT.Location = new System.Drawing.Point(353, 16);
            this.NComprobanteT.Name = "NComprobanteT";
            this.NComprobanteT.PreventEnterBeep = true;
            this.NComprobanteT.ReadOnly = true;
            this.NComprobanteT.Size = new System.Drawing.Size(158, 20);
            this.NComprobanteT.TabIndex = 20;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(0, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 41;
            this.label10.Text = "Filtar Desde";
            // 
            // FechaInicioD
            // 
            this.FechaInicioD.Location = new System.Drawing.Point(3, 15);
            this.FechaInicioD.Name = "FechaInicioD";
            this.FechaInicioD.Size = new System.Drawing.Size(158, 20);
            this.FechaInicioD.TabIndex = 40;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(0, 38);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(60, 13);
            this.label11.TabIndex = 43;
            this.label11.Text = "Filtar Hasta";
            // 
            // FechaFinD
            // 
            this.FechaFinD.Location = new System.Drawing.Point(3, 53);
            this.FechaFinD.Name = "FechaFinD";
            this.FechaFinD.Size = new System.Drawing.Size(158, 20);
            this.FechaFinD.TabIndex = 42;
            // 
            // PrimeroB
            // 
            this.PrimeroB.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.PrimeroB.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.PrimeroB.FocusCuesEnabled = false;
            this.PrimeroB.Image = ((System.Drawing.Image)(resources.GetObject("PrimeroB.Image")));
            this.PrimeroB.Location = new System.Drawing.Point(6, 141);
            this.PrimeroB.Name = "PrimeroB";
            this.PrimeroB.Size = new System.Drawing.Size(25, 25);
            this.PrimeroB.TabIndex = 44;
            this.PrimeroB.TabStop = false;
            this.PrimeroB.Click += new System.EventHandler(this.PrimeroB_Click);
            // 
            // AtrasB
            // 
            this.AtrasB.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.AtrasB.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.AtrasB.FocusCuesEnabled = false;
            this.AtrasB.Image = ((System.Drawing.Image)(resources.GetObject("AtrasB.Image")));
            this.AtrasB.Location = new System.Drawing.Point(38, 141);
            this.AtrasB.Name = "AtrasB";
            this.AtrasB.Size = new System.Drawing.Size(25, 25);
            this.AtrasB.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.AtrasB.TabIndex = 45;
            this.AtrasB.TabStop = false;
            this.AtrasB.Click += new System.EventHandler(this.AtrasB_Click);
            // 
            // AdelanteB
            // 
            this.AdelanteB.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.AdelanteB.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.AdelanteB.FocusCuesEnabled = false;
            this.AdelanteB.Image = ((System.Drawing.Image)(resources.GetObject("AdelanteB.Image")));
            this.AdelanteB.Location = new System.Drawing.Point(150, 141);
            this.AdelanteB.Name = "AdelanteB";
            this.AdelanteB.Size = new System.Drawing.Size(25, 25);
            this.AdelanteB.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.AdelanteB.TabIndex = 46;
            this.AdelanteB.TabStop = false;
            this.AdelanteB.Click += new System.EventHandler(this.AdelanteB_Click);
            // 
            // FinalB
            // 
            this.FinalB.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.FinalB.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.FinalB.FocusCuesEnabled = false;
            this.FinalB.Image = ((System.Drawing.Image)(resources.GetObject("FinalB.Image")));
            this.FinalB.Location = new System.Drawing.Point(181, 141);
            this.FinalB.Name = "FinalB";
            this.FinalB.Size = new System.Drawing.Size(25, 25);
            this.FinalB.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.FinalB.TabIndex = 47;
            this.FinalB.TabStop = false;
            this.FinalB.Click += new System.EventHandler(this.FinalB_Click);
            // 
            // buttonX5
            // 
            this.buttonX5.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.buttonX5.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.buttonX5.FocusCuesEnabled = false;
            this.buttonX5.Location = new System.Drawing.Point(69, 141);
            this.buttonX5.Name = "buttonX5";
            this.buttonX5.Size = new System.Drawing.Size(75, 25);
            this.buttonX5.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.buttonX5.TabIndex = 48;
            this.buttonX5.TabStop = false;
            this.buttonX5.Text = "Lista de Asientos";
            // 
            // TipoComprobanteC
            // 
            this.TipoComprobanteC.DisplayMember = "Text";
            this.TipoComprobanteC.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.TipoComprobanteC.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TipoComprobanteC.ForeColor = System.Drawing.Color.Black;
            this.TipoComprobanteC.FormattingEnabled = true;
            this.TipoComprobanteC.ItemHeight = 15;
            this.TipoComprobanteC.Location = new System.Drawing.Point(3, 92);
            this.TipoComprobanteC.Name = "TipoComprobanteC";
            this.TipoComprobanteC.Size = new System.Drawing.Size(158, 21);
            this.TipoComprobanteC.TabIndex = 49;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(0, 76);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(134, 13);
            this.label12.TabIndex = 50;
            this.label12.Text = "Filtar Tipo de Comprobante";
            // 
            // radialMenuItem4
            // 
            this.radialMenuItem4.Name = "radialMenuItem4";
            this.radialMenuItem4.Text = "Reporte de Asiento";
            // 
            // radialMenuItem5
            // 
            this.radialMenuItem5.Name = "radialMenuItem5";
            this.radialMenuItem5.Text = "Reporte de Libro Diario";
            // 
            // OpcioneB
            // 
            this.OpcioneB.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.OpcioneB.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.OpcioneB.FocusCuesEnabled = false;
            this.OpcioneB.Location = new System.Drawing.Point(6, 631);
            this.OpcioneB.Name = "OpcioneB";
            this.OpcioneB.Size = new System.Drawing.Size(75, 25);
            this.OpcioneB.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.OpcioneB.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem1,
            this.buttonItem2});
            this.OpcioneB.TabIndex = 51;
            this.OpcioneB.TabStop = false;
            this.OpcioneB.Text = "Opciones";
            // 
            // buttonItem1
            // 
            this.buttonItem1.GlobalItem = false;
            this.buttonItem1.Name = "buttonItem1";
            this.buttonItem1.Text = "Editar Asiento";
            // 
            // buttonItem2
            // 
            this.buttonItem2.GlobalItem = false;
            this.buttonItem2.Name = "buttonItem2";
            this.buttonItem2.Text = "Eliminar Asiento";
            // 
            // ReportesB
            // 
            this.ReportesB.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.ReportesB.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.ReportesB.FocusCuesEnabled = false;
            this.ReportesB.Location = new System.Drawing.Point(100, 631);
            this.ReportesB.Name = "ReportesB";
            this.ReportesB.Size = new System.Drawing.Size(75, 25);
            this.ReportesB.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.ReportesB.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.buttonItem3,
            this.buttonItem4});
            this.ReportesB.TabIndex = 52;
            this.ReportesB.TabStop = false;
            this.ReportesB.Text = "PDF Reporte";
            // 
            // buttonItem3
            // 
            this.buttonItem3.GlobalItem = false;
            this.buttonItem3.Name = "buttonItem3";
            this.buttonItem3.Text = "PDF Asiento";
            // 
            // buttonItem4
            // 
            this.buttonItem4.GlobalItem = false;
            this.buttonItem4.Name = "buttonItem4";
            this.buttonItem4.Text = "PDF Libro Diario";
            // 
            // codigo
            // 
            this.codigo.Frozen = true;
            this.codigo.HeaderText = "Codigo";
            this.codigo.Name = "codigo";
            this.codigo.ReadOnly = true;
            this.codigo.Width = 145;
            // 
            // cuenta
            // 
            this.cuenta.Frozen = true;
            this.cuenta.HeaderText = "Cuenta";
            this.cuenta.Name = "cuenta";
            this.cuenta.ReadOnly = true;
            this.cuenta.Width = 220;
            // 
            // detalle
            // 
            this.detalle.Frozen = true;
            this.detalle.HeaderText = "Detalle";
            this.detalle.Name = "detalle";
            this.detalle.ReadOnly = true;
            this.detalle.Width = 300;
            // 
            // debe
            // 
            this.debe.Frozen = true;
            this.debe.HeaderText = "Debe";
            this.debe.Name = "debe";
            this.debe.ReadOnly = true;
            // 
            // haber
            // 
            this.haber.Frozen = true;
            this.haber.HeaderText = "Haber";
            this.haber.Name = "haber";
            this.haber.ReadOnly = true;
            // 
            // FLibroDiario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.ReportesB);
            this.Controls.Add(this.OpcioneB);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.TipoComprobanteC);
            this.Controls.Add(this.buttonX5);
            this.Controls.Add(this.FinalB);
            this.Controls.Add(this.AdelanteB);
            this.Controls.Add(this.AtrasB);
            this.Controls.Add(this.PrimeroB);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.FechaFinD);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.FechaInicioD);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.TDebeT);
            this.Controls.Add(this.THaberT);
            this.Controls.Add(this.Data1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.UFVT);
            this.Controls.Add(this.USDT);
            this.Controls.Add(this.FechaComprobanteD);
            this.Controls.Add(this.TipoAsientoC);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.NChequeT);
            this.Controls.Add(this.GlosaT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.RazonSocialT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NComprobanteT);
            this.Name = "FLibroDiario";
            this.Size = new System.Drawing.Size(908, 659);
            ((System.ComponentModel.ISupportInitialize)(this.Data1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private DevComponents.DotNetBar.Controls.TextBoxX TDebeT;
        private DevComponents.DotNetBar.Controls.TextBoxX THaberT;
        private System.Windows.Forms.DataGridView Data1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private DevComponents.DotNetBar.Controls.TextBoxX UFVT;
        private DevComponents.DotNetBar.Controls.TextBoxX USDT;
        private System.Windows.Forms.DateTimePicker FechaComprobanteD;
        private DevComponents.DotNetBar.Controls.ComboBoxEx TipoAsientoC;
        private System.Windows.Forms.Label label5;
        private DevComponents.DotNetBar.Controls.TextBoxX NChequeT;
        private DevComponents.DotNetBar.Controls.TextBoxX GlosaT;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private DevComponents.DotNetBar.Controls.TextBoxX RazonSocialT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.TextBoxX NComprobanteT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker FechaInicioD;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DateTimePicker FechaFinD;
        private DevComponents.DotNetBar.ButtonX PrimeroB;
        private DevComponents.DotNetBar.ButtonX AtrasB;
        private DevComponents.DotNetBar.ButtonX AdelanteB;
        private DevComponents.DotNetBar.ButtonX FinalB;
        private DevComponents.DotNetBar.ButtonX buttonX5;
        private DevComponents.DotNetBar.Controls.ComboBoxEx TipoComprobanteC;
        private System.Windows.Forms.Label label12;
        private DevComponents.DotNetBar.RadialMenuItem radialMenuItem4;
        private DevComponents.DotNetBar.RadialMenuItem radialMenuItem5;
        private DevComponents.DotNetBar.ButtonX OpcioneB;
        private DevComponents.DotNetBar.ButtonItem buttonItem1;
        private DevComponents.DotNetBar.ButtonItem buttonItem2;
        private DevComponents.DotNetBar.ButtonX ReportesB;
        private DevComponents.DotNetBar.ButtonItem buttonItem3;
        private DevComponents.DotNetBar.ButtonItem buttonItem4;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn debe;
        private System.Windows.Forms.DataGridViewTextBoxColumn haber;
    }
}
