namespace TrabalhoLP3
{
    partial class FrmMainMenu
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
            this.mstMainMenu = new System.Windows.Forms.MenuStrip();
            this.perfilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mstItemAccount = new System.Windows.Forms.ToolStripMenuItem();
            this.MstItemBooks = new System.Windows.Forms.ToolStripMenuItem();
            this.livrariaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mstItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.mstItemExit = new System.Windows.Forms.ToolStripMenuItem();
            this.mstMainMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mstMainMenu
            // 
            this.mstMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.perfilToolStripMenuItem,
            this.livrariaToolStripMenuItem,
            this.mstItemAbout,
            this.mstItemExit});
            this.mstMainMenu.Location = new System.Drawing.Point(0, 0);
            this.mstMainMenu.Name = "mstMainMenu";
            this.mstMainMenu.Size = new System.Drawing.Size(800, 24);
            this.mstMainMenu.TabIndex = 0;
            this.mstMainMenu.Text = "menuStrip1";
            // 
            // perfilToolStripMenuItem
            // 
            this.perfilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mstItemAccount,
            this.MstItemBooks});
            this.perfilToolStripMenuItem.Name = "perfilToolStripMenuItem";
            this.perfilToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.perfilToolStripMenuItem.Text = "Perfil";
            // 
            // mstItemAccount
            // 
            this.mstItemAccount.Name = "mstItemAccount";
            this.mstItemAccount.Size = new System.Drawing.Size(180, 22);
            this.mstItemAccount.Text = "Conta";
            this.mstItemAccount.Click += new System.EventHandler(this.mstItemAccount_Click);
            // 
            // MstItemBooks
            // 
            this.MstItemBooks.Name = "MstItemBooks";
            this.MstItemBooks.Size = new System.Drawing.Size(180, 22);
            this.MstItemBooks.Text = "Livros";
            this.MstItemBooks.Click += new System.EventHandler(this.MstItemBooks_Click);
            // 
            // livrariaToolStripMenuItem
            // 
            this.livrariaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarToolStripMenuItem});
            this.livrariaToolStripMenuItem.Name = "livrariaToolStripMenuItem";
            this.livrariaToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.livrariaToolStripMenuItem.Text = "Livraria";
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.consultarToolStripMenuItem.Text = "Consultar";
            // 
            // mstItemAbout
            // 
            this.mstItemAbout.Name = "mstItemAbout";
            this.mstItemAbout.Size = new System.Drawing.Size(49, 20);
            this.mstItemAbout.Text = "Sobre";
            this.mstItemAbout.Click += new System.EventHandler(this.mstItemAbout_Click);
            // 
            // mstItemExit
            // 
            this.mstItemExit.Name = "mstItemExit";
            this.mstItemExit.Size = new System.Drawing.Size(38, 20);
            this.mstItemExit.Text = "Sair";
            this.mstItemExit.Click += new System.EventHandler(this.mstItemExit_Click);
            // 
            // FrmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mstMainMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mstMainMenu;
            this.Name = "FrmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Localivros";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMainMenu_FormClosed);
            this.mstMainMenu.ResumeLayout(false);
            this.mstMainMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mstMainMenu;
        private System.Windows.Forms.ToolStripMenuItem mstItemAbout;
        private System.Windows.Forms.ToolStripMenuItem mstItemExit;
        private System.Windows.Forms.ToolStripMenuItem perfilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem livrariaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mstItemAccount;
        private System.Windows.Forms.ToolStripMenuItem MstItemBooks;
    }
}