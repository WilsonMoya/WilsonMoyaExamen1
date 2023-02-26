namespace WilsonMoya
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.financieraElProgramadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiendaElProgramadorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Bienvenido al Sistema \"El Buen Programador\"";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.financieraElProgramadorToolStripMenuItem,
            this.tiendaElProgramadorToolStripMenuItem,
            this.numerosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(379, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // financieraElProgramadorToolStripMenuItem
            // 
            this.financieraElProgramadorToolStripMenuItem.Name = "financieraElProgramadorToolStripMenuItem";
            this.financieraElProgramadorToolStripMenuItem.Size = new System.Drawing.Size(158, 20);
            this.financieraElProgramadorToolStripMenuItem.Text = "Financiera El Programador";
            this.financieraElProgramadorToolStripMenuItem.Click += new System.EventHandler(this.financieraElProgramadorToolStripMenuItem_Click);
            // 
            // tiendaElProgramadorToolStripMenuItem
            // 
            this.tiendaElProgramadorToolStripMenuItem.Name = "tiendaElProgramadorToolStripMenuItem";
            this.tiendaElProgramadorToolStripMenuItem.Size = new System.Drawing.Size(139, 20);
            this.tiendaElProgramadorToolStripMenuItem.Text = "Tienda El Programador";
            this.tiendaElProgramadorToolStripMenuItem.Click += new System.EventHandler(this.tiendaElProgramadorToolStripMenuItem_Click);
            // 
            // numerosToolStripMenuItem
            // 
            this.numerosToolStripMenuItem.Name = "numerosToolStripMenuItem";
            this.numerosToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.numerosToolStripMenuItem.Text = "Numeros";
            this.numerosToolStripMenuItem.Click += new System.EventHandler(this.numerosToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 75);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem financieraElProgramadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiendaElProgramadorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem numerosToolStripMenuItem;
    }
}

