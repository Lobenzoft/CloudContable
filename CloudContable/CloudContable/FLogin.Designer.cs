namespace CloudContable
{
    partial class FLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EmpresaT = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label2 = new System.Windows.Forms.Label();
            this.UserT = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.label3 = new System.Windows.Forms.Label();
            this.PassT = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.IngresarB = new DevComponents.DotNetBar.ButtonX();
            this.Data1 = new System.Windows.Forms.DataGridView();
            this.SeleccionB = new DevComponents.DotNetBar.ButtonX();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Data1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(902, 329);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 344);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Empresa";
            // 
            // EmpresaT
            // 
            this.EmpresaT.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.EmpresaT.Border.Class = "TextBoxBorder";
            this.EmpresaT.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.EmpresaT.DisabledBackColor = System.Drawing.Color.White;
            this.EmpresaT.ForeColor = System.Drawing.Color.Black;
            this.EmpresaT.Location = new System.Drawing.Point(36, 360);
            this.EmpresaT.Name = "EmpresaT";
            this.EmpresaT.PreventEnterBeep = true;
            this.EmpresaT.Size = new System.Drawing.Size(158, 20);
            this.EmpresaT.TabIndex = 1;
            this.EmpresaT.Text = "zensoft";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Usuario";
            // 
            // UserT
            // 
            this.UserT.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.UserT.Border.Class = "TextBoxBorder";
            this.UserT.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.UserT.DisabledBackColor = System.Drawing.Color.White;
            this.UserT.ForeColor = System.Drawing.Color.Black;
            this.UserT.Location = new System.Drawing.Point(36, 420);
            this.UserT.Name = "UserT";
            this.UserT.PreventEnterBeep = true;
            this.UserT.Size = new System.Drawing.Size(158, 20);
            this.UserT.TabIndex = 2;
            this.UserT.Text = "admin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 464);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Contraseña";
            // 
            // PassT
            // 
            this.PassT.BackColor = System.Drawing.Color.White;
            // 
            // 
            // 
            this.PassT.Border.Class = "TextBoxBorder";
            this.PassT.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.PassT.DisabledBackColor = System.Drawing.Color.White;
            this.PassT.ForeColor = System.Drawing.Color.Black;
            this.PassT.Location = new System.Drawing.Point(36, 480);
            this.PassT.Name = "PassT";
            this.PassT.PreventEnterBeep = true;
            this.PassT.Size = new System.Drawing.Size(158, 20);
            this.PassT.TabIndex = 3;
            this.PassT.Text = "admin123";
            // 
            // IngresarB
            // 
            this.IngresarB.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.IngresarB.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.IngresarB.Location = new System.Drawing.Point(97, 518);
            this.IngresarB.Name = "IngresarB";
            this.IngresarB.Size = new System.Drawing.Size(97, 23);
            this.IngresarB.TabIndex = 4;
            this.IngresarB.Text = "Ingresar";
            this.IngresarB.Click += new System.EventHandler(this.IngresarB_Click);
            // 
            // Data1
            // 
            this.Data1.AllowUserToAddRows = false;
            this.Data1.AllowUserToDeleteRows = false;
            this.Data1.BackgroundColor = System.Drawing.Color.White;
            this.Data1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Data1.Location = new System.Drawing.Point(200, 338);
            this.Data1.Name = "Data1";
            this.Data1.ReadOnly = true;
            this.Data1.RowHeadersWidth = 15;
            this.Data1.Size = new System.Drawing.Size(705, 272);
            this.Data1.TabIndex = 5;
            // 
            // SeleccionB
            // 
            this.SeleccionB.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.SeleccionB.ColorTable = DevComponents.DotNetBar.eButtonColor.Orange;
            this.SeleccionB.Location = new System.Drawing.Point(808, 616);
            this.SeleccionB.Name = "SeleccionB";
            this.SeleccionB.Size = new System.Drawing.Size(97, 23);
            this.SeleccionB.TabIndex = 6;
            this.SeleccionB.Text = "Seleccionar";
            this.SeleccionB.Click += new System.EventHandler(this.SeleccionB_Click);
            // 
            // FLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.SeleccionB);
            this.Controls.Add(this.Data1);
            this.Controls.Add(this.IngresarB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PassT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UserT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EmpresaT);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FLogin";
            this.Size = new System.Drawing.Size(908, 659);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Data1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private DevComponents.DotNetBar.Controls.TextBoxX EmpresaT;
        private System.Windows.Forms.Label label2;
        private DevComponents.DotNetBar.Controls.TextBoxX UserT;
        private System.Windows.Forms.Label label3;
        private DevComponents.DotNetBar.Controls.TextBoxX PassT;
        private DevComponents.DotNetBar.ButtonX IngresarB;
        private System.Windows.Forms.DataGridView Data1;
        private DevComponents.DotNetBar.ButtonX SeleccionB;
    }
}
