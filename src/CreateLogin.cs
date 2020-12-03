using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TrabalhoLP3.Database.Tables;
using TrabalhoLP3.Classes;

namespace TrabalhoLP3
{
    public partial class FrmCreateLogin : Form
    {
        readonly FrmLogin frmLogin;

        public FrmCreateLogin(FrmLogin frmLogin)
        {
            InitializeComponent();
            this.frmLogin = frmLogin;
            TbxUsername.Text = frmLogin.GetTbxUsername();
            TbxPassword.Text = frmLogin.GetTbxPassword();
        }

        private void MtxtCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void FrmCreateLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmLogin.Show();
        }

        private void BtnCreateAccount_Click(object sender, EventArgs e)
        {
            CreateAccount();
        }

        private void TbxPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals((char)13))
            {
                CreateAccount();
            }
        }

        private void CreateAccount()
        {
            if (IsFormValid())
            {
                User user = new User();
                user.SetName(TbxName.Text);
                user.SetUsername(TbxUsername.Text);
                user.SetCPF(Convert.ToInt64(GetStringifiedCPF()));

                new TableUsers().CreateUser(user, TbxPassword.Text);
                MessageBox.Show("Usuário criado com sucesso!", "Nova conta", MessageBoxButtons.OK);
                Close();
            }
        }

        private bool IsFormValid()
        {
            if (TbxName.Text.Equals(""))
            {
                MessageBox.Show("O campo nome está vazio!", "Nova conta", MessageBoxButtons.OK);
                return false;
            }

            if (TbxUsername.Text.Equals("") || TbxUsername.Text.Length < 4)
            {
                MessageBox.Show("O campo username está vazio ou é pequeno demais!", "Nova conta", MessageBoxButtons.OK);
                return false;
            }

            if (TbxPassword.Text.Equals("") || TbxPassword.Text.Length < 4)
            {
                MessageBox.Show("O campo senha está vazio ou é pequeno demais!", "Nova conta", MessageBoxButtons.OK);
                return false;
            }

            if (GetStringifiedCPF().Equals("") || GetStringifiedCPF().Length != 11)
            {
                Console.WriteLine(MtxtCPF.Text);
                MessageBox.Show("O campo CPF está vazio ou é inválido!", "Nova conta", MessageBoxButtons.OK);
                return false;
            }

            return true;
        }

        private string GetStringifiedCPF()
        {
            MtxtCPF.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            string stringifiedCPF = MtxtCPF.Text;
            MtxtCPF.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
            return stringifiedCPF;
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
