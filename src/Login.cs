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
                Hide();
                new FrmMainMenu().Show();
            }
            else
            {
                MessageBox.Show("Usuário e/ou senha inválido!", "Login", MessageBoxButtons.OK);
            }
        }

        public string GetTbxUsername()
        {
            return tbxUser.Text;
        }

        public string GetTbxPassword()
        {
            return TbxPassword.Text;
        }
    }
}
