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
using TrabalhoLP3.Classes.Database;

namespace TrabalhoLP3.Forms.Security
{
    public partial class FrmUser : Form
    {
        private readonly string MESSAGE_BOX_HEADER = "Usuários";

        private readonly Utilities utilities = new Utilities();
        private readonly TableUsers tableUsers = new TableUsers();
        private readonly FrmMainMenu frmMainMenu;
        private List<User> users;
        private User currentUser;
        private bool isFind;
        private bool isCrud;
        private bool isCreate;
        private int page;

        public FrmUser(FrmMainMenu frmMainMenu)
        {
            InitializeComponent();
            HandleRegisterChanges(0);
            this.frmMainMenu = frmMainMenu;
        }

        private void HandleRegisterChanges(int page)
        {
            this.page = page;
            users = tableUsers.GetAll();

            if (users.Count > 0)
            {
                SetFormValues(users[page]);
                return;
            }

            ResetFormValues(true);
        }

        private void SetFormValues(User user)
        {
            currentUser = user;
            LblUid.Text = currentUser.GetUid().ToString();
            LblName.Text = currentUser.GetName();
            LblCPF.Text = currentUser.GetCPF().ToString(@"000\.000\.000\-00");
            LblUser.Text = currentUser.GetUsername();
            LblPassword.Text = currentUser.GetPassword();

            MstItemsAvailability(true);
            ChangeButtonsAvailability((page != 0), ((page + 1) != users.Count));
        }

        private void ResetFormValues(bool setAvailability)
        {
            currentUser = null;
            LblUid.Text = "N/D";
            LblName.Text = "N/D";
            LblCPF.Text = "N/D";
            LblUser.Text = "N/D";
            LblPassword.Text = "N/D";

            if (setAvailability)
            {
                MstItemsAvailability(false, true, false, false);
                ChangeButtonsAvailability(false, false);
            }
        }

        private void MstItemsAvailability(bool enable)
        {
            MstItemFind.Enabled = enable;
            MstItemCreate.Enabled = enable;
            MstItemEdit.Enabled = enable;
            MstItemDelete.Enabled = enable;
        }

        private void MstItemsAvailability(bool find, bool create, bool edit, bool delete)
        {
            MstItemFind.Enabled = find;
            MstItemCreate.Enabled = create;
            MstItemEdit.Enabled = edit;
            MstItemDelete.Enabled = delete;
        }

        private void ChangeButtonsAvailability(bool leftButton, bool rightButton)
        {
            BtnLeft.Enabled = leftButton;
            BtnRight.Enabled = rightButton;
        }

        private void SwitchFindComponentsVisibility()
        {
            TbxUid.Visible = !TbxUid.Visible;
        }

        private void ChangeButtonsText(string leftButton, string rightButton)
        {
            BtnLeft.Text = leftButton;
            BtnRight.Text = rightButton;
        }

        private void ChangeCRUDValidations(bool isFind, bool isCrud, bool isCreate)
        {
            this.isFind = isFind;
            this.isCrud = isCrud;
            this.isCreate = isCreate;
        }

        private void ChangePlaceholdersText(bool isRegister)
        {
            if (isRegister)
            {
                LblNamePlaceholder.Text = "*" + LblNamePlaceholder.Text;
                LblCpfPlaceholder.Text = "*" + LblCpfPlaceholder.Text;
                LblUserPlaceholder.Text = "*" + LblUserPlaceholder.Text;
                LblPasswordPlaceholder.Text = "*" + LblPasswordPlaceholder.Text;
                return;
            }

            LblNamePlaceholder.Text = LblNamePlaceholder.Text.Substring(1);
            LblCpfPlaceholder.Text = LblCpfPlaceholder.Text.Substring(1);
            LblUserPlaceholder.Text = LblUserPlaceholder.Text.Substring(1);
            LblPasswordPlaceholder.Text = LblPasswordPlaceholder.Text.Substring(1);
        }

        private void ResetRegisterValues()
        {
            currentUser = new User();
            TbxName.Text = "";
            MtxtCPF.Text = "";
            TbxUser.Text = "";
            TbxPassword.Text = "";
            SwitchComponentsVisibility();
        }

        private void SwitchComponentsVisibility()
        {
            LblUid.Visible = !LblUid.Visible;
            LblName.Visible = !LblName.Visible;
            LblCPF.Visible = !LblCPF.Visible;
            LblUser.Visible = !LblUser.Visible;
            LblPassword.Visible = !LblPassword.Visible;

            TbxName.Visible = !TbxName.Visible;
            MtxtCPF.Visible = !MtxtCPF.Visible;
            TbxUser.Visible = !TbxUser.Visible;
            TbxPassword.Visible = !TbxPassword.Visible;
        }

        private void SetRegisterValuesForEdit()
        {
            TbxName.Text = LblName.Text;
            MtxtCPF.Text = LblCPF.Text;
            TbxUser.Text = LblUser.Text;
            TbxPassword.Text = LblPassword.Text;
        }

        private bool IsValidForm()
        {
            string stringifiedCPF = utilities.GetStringifiedMaskedTextBox(MtxtCPF);

            if (TbxName.Text.Equals(""))
            {
                MessageBox.Show("O campo nome está vazio!", MESSAGE_BOX_HEADER, MessageBoxButtons.OK);
                return false;
            }

            if (TbxUser.Text.Equals("") || TbxUser.Text.Length < 4)
            {
                MessageBox.Show("O campo username está vazio ou é pequeno demais!", MESSAGE_BOX_HEADER, MessageBoxButtons.OK);
                return false;
            }

            if (TbxPassword.Text.Equals("") || TbxPassword.Text.Length < 4)
            {
                MessageBox.Show("O campo senha está vazio ou é pequeno demais!", MESSAGE_BOX_HEADER, MessageBoxButtons.OK);
                return false;
            }

            if (stringifiedCPF.Equals("") || stringifiedCPF.Length != 11)
            {
                MessageBox.Show("O campo CPF está vazio ou é inválido!", MESSAGE_BOX_HEADER, MessageBoxButtons.OK);
                return false;
            }

            return true;
        }

        private void MstItemFind_Click(object sender, EventArgs e)
        {
            ResetFormValues(false);
            SwitchFindComponentsVisibility();
            ChangeButtonsText("Cancelar", "Confirmar");
            ChangeButtonsAvailability(true, true);
            MstItemsAvailability(false);

            ChangeCRUDValidations(true, false, false);
        }

        private void MstItemCreate_Click(object sender, EventArgs e)
        {
            ChangePlaceholdersText(true);
            ResetRegisterValues();
            ChangeButtonsText("Cancelar", "Confirmar");
            ChangeButtonsAvailability(true, true);
            MstItemsAvailability(false);

            ChangeCRUDValidations(false, true, true);
        }

        private void MstItemEdit_Click(object sender, EventArgs e)
        {
            ChangePlaceholdersText(true);
            ResetRegisterValues();
            SetRegisterValuesForEdit();
            ChangeButtonsText("Cancelar", "Confirmar");
            ChangeButtonsAvailability(true, true);
            MstItemsAvailability(false);

            ChangeCRUDValidations(false, true, false);
        }

        private void MstItemDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja apagar o registro?", MESSAGE_BOX_HEADER, MessageBoxButtons.YesNo);
            if (result == DialogResult.No) return;
            tableUsers.DeleteUser(currentUser);

            page = page == 0 ? page : page--;
            HandleRegisterChanges(page);
        }

        private void BtnRight_Click(object sender, EventArgs e)
        {
            if (isFind)
            {
                int index = users.FindIndex(user => user.GetUid() == Convert.ToInt32(TbxUid.Text));

                if (index < 0)
                {
                    MessageBox.Show("Não existe nenhum usuário com esse id!", MESSAGE_BOX_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                TbxUid.Text = "";
                SwitchFindComponentsVisibility();
                ChangeCRUDValidations(false, false, false);
                ChangeButtonsText("Anterior", "Próximo");

                if (index >= 0)
                {
                    page = index;
                    SetFormValues(users[page]);
                    MessageBox.Show("Registro encontrado com sucesso!", MESSAGE_BOX_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    HandleRegisterChanges(page);
                }

                return;
            }

            if (isCrud)
            {
                if (!IsValidForm())
                {
                    return;
                }

                User user = new User();
                user.SetName(TbxName.Text);
                user.SetUsername(TbxUser.Text);
                user.SetPassword(TbxPassword.Text);
                user.SetCPF(Convert.ToInt64(utilities.GetStringifiedMaskedTextBox(MtxtCPF)));

                string message = "";

                if (isCreate)
                {
                    tableUsers.CreateUser(user);
                    message = "Usuário criado com successo!";
                    page = users.Count == 0 ? page : page++;
                }
                else
                {
                    tableUsers.UpdateUser(Convert.ToInt32(LblUid.Text), user);
                    message = "Usuário alterado com successo!";
                }

                MessageBox.Show(message, MESSAGE_BOX_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetRegisterValues();
                ChangePlaceholdersText(false);
                ChangeCRUDValidations(false, false, false);
                ChangeButtonsText("Anterior", "Próximo");
                HandleRegisterChanges(page);

                return;
            }

            page++;
            SetFormValues(users[page]);
        }

        private void BtnLeft_Click(object sender, EventArgs e)
        {
            if (isFind)
            {
                DialogResult result = MessageBox.Show("Deseja cancelar a busca?", MESSAGE_BOX_HEADER, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No) return;

                TbxUid.Text = "";
                SwitchFindComponentsVisibility();
                ChangeCRUDValidations(false, false, false);
                ChangeButtonsText("Anterior", "Próximo");
                HandleRegisterChanges(page);
                return;
            }

            if (isCrud)
            {
                string message = isCreate
                    ? "Deseja cancelar a criação do registro?"
                    : "Deseja cancelar a edição do registro?";

                DialogResult result = MessageBox.Show(message, MESSAGE_BOX_HEADER, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No) return;

                ResetRegisterValues();
                ChangePlaceholdersText(false);
                ChangeCRUDValidations(false, false, false);
                ChangeButtonsText("Anterior", "Próximo");
                HandleRegisterChanges(page);

                return;
            }

            page--;
            SetFormValues(users[page]);
        }

        private void FrmUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMainMenu.SetIsFormOpen(false);
        }
    }
}
