using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabalhoLP3
{
    public partial class FrmMainMenu : Form
    {
        public FrmMainMenu()
        {
            InitializeComponent();
        }

        private void frmMainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void mstItemAbout_Click(object sender, EventArgs e)
        {
            frmSobre frmSobre = new frmSobre();
            frmSobre.MdiParent = this;
            frmSobre.Show();
        }

        private void mstItemAccount_Click(object sender, EventArgs e)
        {
            FrmProfile frmProfile = new FrmProfile();
            frmProfile.MdiParent = this;
            frmProfile.Show();
        }

        private void MstItemBooks_Click(object sender, EventArgs e)
        {
            FrmBooks frmBooks = new FrmBooks();
            frmBooks.MdiParent = this;
            frmBooks.Show();
        }

        private void mstItemExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
