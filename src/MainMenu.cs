using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoLP3.Forms.Library;
using TrabalhoLP3.Forms.Register;
using TrabalhoLP3.Forms.Security;

namespace TrabalhoLP3
{
    public partial class FrmMainMenu : Form
    {
        private bool logout = false;
        private bool isAboutOpen = false;

        public FrmMainMenu()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void FrmMainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!logout)
            {
                Application.Exit();
            }
        }

        private void mstItemAbout_Click(object sender, EventArgs e)
        {
            if (!isAboutOpen)
            {
                setIsAboutOpen(true);
                FrmAbout frmSobre = new FrmAbout(this);
                frmSobre.MdiParent = this;
                frmSobre.Show();
            }
        }

        private void MstItemLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja fazer logout do sistema?", "Logout", MessageBoxButtons.YesNo);
            if (result == DialogResult.No) return;
            
            logout = true;
            new FrmLogin().Show();
            Close();
        }

        private void mstItemExit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja sair do sistema?", "Sair", MessageBoxButtons.YesNo);
            if (result == DialogResult.No) return;

            Application.Exit();
        }

        public void setIsAboutOpen(bool isAboutOpen)
        {
            this.isAboutOpen = isAboutOpen;
        }

        private void BtnAuthor_Click(object sender, EventArgs e)
        {
            FrmAuthor frmAuthor = new FrmAuthor();
            frmAuthor.MdiParent = this;
            frmAuthor.Show();
        }

        private void ClickOnUsers()
        {
            FrmUser frmUser = new FrmUser();
            frmUser.MdiParent = this;
            frmUser.Show();
        }

        private void BtnUsers_Click(object sender, EventArgs e)
        {
            ClickOnUsers();
        }

        private void PbxUsers_Click(object sender, EventArgs e)
        {
            ClickOnUsers();
        }
    }
}
