namespace MenuPrincipal
{
    partial class Menu
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aeronavesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pesquisarWebApiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.engenhariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraMODToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadora10ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraAssentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.calculadoraOrigemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aeronavesToolStripMenuItem,
            this.engenhariaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aeronavesToolStripMenuItem
            // 
            this.aeronavesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pesquisarWebApiToolStripMenuItem,
            this.pToolStripMenuItem});
            this.aeronavesToolStripMenuItem.Name = "aeronavesToolStripMenuItem";
            this.aeronavesToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.aeronavesToolStripMenuItem.Text = "Aeronaves";
            // 
            // pesquisarWebApiToolStripMenuItem
            // 
            this.pesquisarWebApiToolStripMenuItem.Name = "pesquisarWebApiToolStripMenuItem";
            this.pesquisarWebApiToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.pesquisarWebApiToolStripMenuItem.Text = "Pesquisar Web Api";
            this.pesquisarWebApiToolStripMenuItem.Click += new System.EventHandler(this.pesquisarWebApiToolStripMenuItem_Click);
            // 
            // pToolStripMenuItem
            // 
            this.pToolStripMenuItem.Name = "pToolStripMenuItem";
            this.pToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.pToolStripMenuItem.Text = "Pesquisar no BD Local ";
            // 
            // engenhariaToolStripMenuItem
            // 
            this.engenhariaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculadoraMODToolStripMenuItem,
            this.calculadora10ToolStripMenuItem,
            this.calculadoraAssentosToolStripMenuItem,
            this.calculadoraOrigemToolStripMenuItem});
            this.engenhariaToolStripMenuItem.Name = "engenhariaToolStripMenuItem";
            this.engenhariaToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.engenhariaToolStripMenuItem.Text = "Engenharia";
            // 
            // calculadoraMODToolStripMenuItem
            // 
            this.calculadoraMODToolStripMenuItem.Name = "calculadoraMODToolStripMenuItem";
            this.calculadoraMODToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.calculadoraMODToolStripMenuItem.Text = "Calculadora MOD";
            this.calculadoraMODToolStripMenuItem.Click += new System.EventHandler(this.calculadoraMODToolStripMenuItem_Click);
            // 
            // calculadora10ToolStripMenuItem
            // 
            this.calculadora10ToolStripMenuItem.Name = "calculadora10ToolStripMenuItem";
            this.calculadora10ToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.calculadora10ToolStripMenuItem.Text = "Calculadora 10%";
            this.calculadora10ToolStripMenuItem.Click += new System.EventHandler(this.calculadora10ToolStripMenuItem_Click);
            // 
            // calculadoraAssentosToolStripMenuItem
            // 
            this.calculadoraAssentosToolStripMenuItem.Name = "calculadoraAssentosToolStripMenuItem";
            this.calculadoraAssentosToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.calculadoraAssentosToolStripMenuItem.Text = "Calculadora Assentos";
            this.calculadoraAssentosToolStripMenuItem.Click += new System.EventHandler(this.calculadoraAssentosToolStripMenuItem_Click);
            // 
            // calculadoraOrigemToolStripMenuItem
            // 
            this.calculadoraOrigemToolStripMenuItem.Name = "calculadoraOrigemToolStripMenuItem";
            this.calculadoraOrigemToolStripMenuItem.Size = new System.Drawing.Size(187, 22);
            this.calculadoraOrigemToolStripMenuItem.Text = "Calculadora Origem";
            this.calculadoraOrigemToolStripMenuItem.Click += new System.EventHandler(this.calculadoraOrigemToolStripMenuItem_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Menu";
            this.Text = "VoeAirlines Client";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aeronavesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pesquisarWebApiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem engenhariaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadoraMODToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadora10ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadoraAssentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculadoraOrigemToolStripMenuItem;
    }
}

