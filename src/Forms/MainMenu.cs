using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoLP3.Forms.Finance;
using TrabalhoLP3.Forms.Library;
using TrabalhoLP3.Forms.Register;
using TrabalhoLP3.Forms.Security;

namespace TrabalhoLP3
{
    public partial class FrmMainMenu : Form
    {
        private bool logout = false;
        private bool isFormOpen = false;

        public FrmMainMenu()
        {
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }

        private void OpenSelectedForm(Form form, Form parentForm)
        {
            if (isFormOpen)
            {
                MessageBox.Show("Já existe um formulário aberto!", "Logout", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            isFormOpen = true;
            form.MdiParent = parentForm;
            form.Show();
        }

        private void mstItemAbout_Click(object sender, EventArgs e)
        {
            OpenSelectedForm(new FrmAbout(this), this);
        }

        private void MstItemLogout_Click(object sender, EventArgs e)
        {
            logout = true;
            Close();
        }

        private void mstItemExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FrmMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (logout)
            {
                DialogResult logoutResult = MessageBox.Show("Deseja fazer logout do sistema?", "Logout", MessageBoxButtons.YesNo);
                if (logoutResult == DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }

                new FrmLogin().Show();
                return;
            }

            DialogResult result = MessageBox.Show("Deseja sair do sistema?", "Sair", MessageBoxButtons.YesNo);
            if (result == DialogResult.No) e.Cancel = true;
        }

        private void FrmMainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!logout)
            {
                Application.Exit();
            }
        }

        public void SetIsFormOpen(bool isFormOpen)
        {
            this.isFormOpen = isFormOpen;
        }

        private void BtnAuthor_Click(object sender, EventArgs e)
        {
            OpenSelectedForm(new FrmAuthor(this), this);
        }

        private void PbxAuthor_Click(object sender, EventArgs e)
        {
            OpenSelectedForm(new FrmAuthor(this), this);
        }

        private void BtnBooks_Click(object sender, EventArgs e)
        {
            OpenSelectedForm(new FrmBooks(this), this);
        }

        private void PbxBooks_Click(object sender, EventArgs e)
        {
            OpenSelectedForm(new FrmBooks(this), this);
        }

        private void BtnUsers_Click(object sender, EventArgs e)
        {
            OpenSelectedForm(new FrmUser(this), this);
        }

        private void PbxUsers_Click(object sender, EventArgs e)
        {
            OpenSelectedForm(new FrmUser(this), this);
        }

        private void BtnGenre_Click(object sender, EventArgs e)
        {
            OpenSelectedForm(new FrmGenre(this), this);
        }
        
        private void PbxGenre_Click(object sender, EventArgs e)
        {
            OpenSelectedForm(new FrmGenre(this), this);
        }
    }
}
