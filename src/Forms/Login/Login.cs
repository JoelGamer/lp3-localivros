using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoLP3.Database.Tables;

namespace TrabalhoLP3
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();

            tbxUser.Text = Properties.Settings.Default.Username;
            TbxPassword.Text = Properties.Settings.Default.Password;
            ChbxRememberPassword.Checked = Properties.Settings.Default.IsSavingPassword;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            PerformUserLogin();
        }

        private void LblCreateAccount_Click(object sender, EventArgs e)
        {
            Hide();
            new FrmCreateLogin(this).Show();
        }

        private void TbxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)13))
            {
                PerformUserLogin();
            }
        }

        private void PerformUserLogin()
        {
            string username = tbxUser.Text;
            string password = TbxPassword.Text;

            if (new TableUsers().IsValidLogin(username, password))
            {
                SaveSettings();
                Hide();
                new FrmMainMenu().Show();
            }
            else
            {
                MessageBox.Show("Usuário e/ou senha inválido!", "Login", MessageBoxButtons.OK);
            }
        }

        private void SaveSettings()
        {
            if (ChbxRememberPassword.Checked)
            {
                Properties.Settings.Default.Username = tbxUser.Text;
                Properties.Settings.Default.Password = TbxPassword.Text;
                Properties.Settings.Default.IsSavingPassword = ChbxRememberPassword.Checked;
            } else
            {
                Properties.Settings.Default.Username = "";
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.IsSavingPassword = false;
            }

            Properties.Settings.Default.Save();
        }

        public string GetTbxUsername()
        {
            return tbxUser.Text;
        }

        public string GetTbxPassword()
        {
            return TbxPassword.Text;
        }

        private void FrmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
