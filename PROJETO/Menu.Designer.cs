namespace PROJETO
{
    partial class FrmMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuCadastro = new System.Windows.Forms.ToolStripMenuItem();
            this.entradasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saídasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferênciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuHome = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuMovimentações = new System.Windows.Forms.ToolStripMenuItem();
            this.listarEntradasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarSaídasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuRelatórios = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSair = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuCadastro,
            this.MenuHome,
            this.MenuMovimentações,
            this.MenuRelatórios,
            this.MenuSair});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1301, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MenuCadastro
            // 
            this.MenuCadastro.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entradasToolStripMenuItem,
            this.saídasToolStripMenuItem,
            this.transferênciaToolStripMenuItem});
            this.MenuCadastro.Image = ((System.Drawing.Image)(resources.GetObject("MenuCadastro.Image")));
            this.MenuCadastro.Name = "MenuCadastro";
            this.MenuCadastro.Size = new System.Drawing.Size(108, 24);
            this.MenuCadastro.Text = "Cadastros";
            // 
            // entradasToolStripMenuItem
            // 
            this.entradasToolStripMenuItem.Name = "entradasToolStripMenuItem";
            this.entradasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.entradasToolStripMenuItem.Text = "Entradas";
            this.entradasToolStripMenuItem.Click += new System.EventHandler(this.EntradasToolStripMenuItem_Click);
            // 
            // saídasToolStripMenuItem
            // 
            this.saídasToolStripMenuItem.Name = "saídasToolStripMenuItem";
            this.saídasToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.saídasToolStripMenuItem.Text = "Saídas";
            // 
            // transferênciaToolStripMenuItem
            // 
            this.transferênciaToolStripMenuItem.Name = "transferênciaToolStripMenuItem";
            this.transferênciaToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.transferênciaToolStripMenuItem.Text = "Transferência";
            // 
            // MenuHome
            // 
            this.MenuHome.Image = ((System.Drawing.Image)(resources.GetObject("MenuHome.Image")));
            this.MenuHome.Name = "MenuHome";
            this.MenuHome.Size = new System.Drawing.Size(84, 24);
            this.MenuHome.Text = "Home";
            // 
            // MenuMovimentações
            // 
            this.MenuMovimentações.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listarEntradasToolStripMenuItem,
            this.listarSaídasToolStripMenuItem});
            this.MenuMovimentações.Image = ((System.Drawing.Image)(resources.GetObject("MenuMovimentações.Image")));
            this.MenuMovimentações.Name = "MenuMovimentações";
            this.MenuMovimentações.Size = new System.Drawing.Size(148, 24);
            this.MenuMovimentações.Text = "Movimentações";
            // 
            // listarEntradasToolStripMenuItem
            // 
            this.listarEntradasToolStripMenuItem.Name = "listarEntradasToolStripMenuItem";
            this.listarEntradasToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.listarEntradasToolStripMenuItem.Text = "Listar Entradas";
            // 
            // listarSaídasToolStripMenuItem
            // 
            this.listarSaídasToolStripMenuItem.Name = "listarSaídasToolStripMenuItem";
            this.listarSaídasToolStripMenuItem.Size = new System.Drawing.Size(188, 26);
            this.listarSaídasToolStripMenuItem.Text = "Listar Saídas";
            // 
            // MenuRelatórios
            // 
            this.MenuRelatórios.Image = ((System.Drawing.Image)(resources.GetObject("MenuRelatórios.Image")));
            this.MenuRelatórios.Name = "MenuRelatórios";
            this.MenuRelatórios.Size = new System.Drawing.Size(110, 24);
            this.MenuRelatórios.Text = "Relatórios";
            // 
            // MenuSair
            // 
            this.MenuSair.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem});
            this.MenuSair.Image = ((System.Drawing.Image)(resources.GetObject("MenuSair.Image")));
            this.MenuSair.Name = "MenuSair";
            this.MenuSair.Size = new System.Drawing.Size(68, 24);
            this.MenuSair.Text = "Sair";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(139, 26);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(988, 94);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.Location = new System.Drawing.Point(989, 31);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(312, 810);
            this.panel2.TabIndex = 2;
            // 
            // FrmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1301, 724);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmMenu";
            this.Text = "Menu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Resize += new System.EventHandler(this.FrmMenu_Resize);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MenuCadastro;
        private System.Windows.Forms.ToolStripMenuItem MenuHome;
        private System.Windows.Forms.ToolStripMenuItem MenuMovimentações;
        private System.Windows.Forms.ToolStripMenuItem MenuRelatórios;
        private System.Windows.Forms.ToolStripMenuItem MenuSair;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem entradasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saídasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transferênciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarEntradasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarSaídasToolStripMenuItem;
    }
}