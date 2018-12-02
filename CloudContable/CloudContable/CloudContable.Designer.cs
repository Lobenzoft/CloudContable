namespace CloudContable
{
    partial class CloudContable
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CloudContable));
            this.MenuPanel = new System.Windows.Forms.Panel();
            this.ContenidoPanel = new System.Windows.Forms.Panel();
            this.DetallePanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // MenuPanel
            // 
            this.MenuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.MenuPanel.Location = new System.Drawing.Point(0, 0);
            this.MenuPanel.Name = "MenuPanel";
            this.MenuPanel.Size = new System.Drawing.Size(100, 689);
            this.MenuPanel.TabIndex = 0;
            // 
            // ContenidoPanel
            // 
            this.ContenidoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContenidoPanel.Location = new System.Drawing.Point(100, 0);
            this.ContenidoPanel.Name = "ContenidoPanel";
            this.ContenidoPanel.Size = new System.Drawing.Size(908, 659);
            this.ContenidoPanel.TabIndex = 0;
            // 
            // DetallePanel
            // 
            this.DetallePanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.DetallePanel.Location = new System.Drawing.Point(100, 659);
            this.DetallePanel.Name = "DetallePanel";
            this.DetallePanel.Size = new System.Drawing.Size(908, 30);
            this.DetallePanel.TabIndex = 0;
            // 
            // CloudContable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 689);
            this.Controls.Add(this.ContenidoPanel);
            this.Controls.Add(this.DetallePanel);
            this.Controls.Add(this.MenuPanel);
            this.DoubleBuffered = true;
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "CloudContable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cloud Contable";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MenuPanel;
        private System.Windows.Forms.Panel ContenidoPanel;
        private System.Windows.Forms.Panel DetallePanel;
    }
}

