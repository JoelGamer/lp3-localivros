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

namespace TrabalhoLP3.Forms.Library
{
    public partial class FrmProvider : Form
    {

        private readonly string MESSAGE_BOX_HEADER = "Clientes";

        private readonly Utilities utilities = new Utilities();
        private readonly TableProviders tableProviders = new TableProviders();
        private readonly FrmMainMenu frmMainMenu;
        private List<Provider> providers;
        private Provider currentProvider;
        private bool isFind;
        private bool isCrud;
        private bool isCreate;
        private int page;

        public FrmProvider(FrmMainMenu frmMainMenu)
        {
            InitializeComponent();
            HandleRegisterChanges(0);
            this.frmMainMenu = frmMainMenu;
        }

        private void HandleRegisterChanges(int page)
        {
            this.page = page;
            providers = tableProviders.GetAll();

            if (providers.Count > 0)
            {
                SetFormValues(providers[page]);
                return;
            }

            ResetFormValues(true);
        }

        private void SetFormValues(Provider provider)
        {
            currentProvider = provider;
            LblUid.Text = currentProvider.GetUid().ToString();
            LblName.Text = currentProvider.GetName();
            LblCNPJ.Text = currentProvider.GetCNPJ().ToString(@"00\.000\.000\\0000-00");
            LblAddress.Text = currentProvider.GetAddress();
            LblAddressNumber.Text = currentProvider.GetAddressNumber();

            MstItemsAvailability(true);
            ChangeButtonsAvailability((page != 0), ((page + 1) != providers.Count));
        }

        private void ResetFormValues(bool setAvailability)
        {
            currentProvider = null;
            LblUid.Text = "N/D";
            LblName.Text = "N/D";
            LblCNPJ.Text = "N/D";
            LblAddress.Text = "N/D";
            LblAddressNumber.Text = "N/D";

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
                LblCNPJPlaceholder.Text = "*" + LblCNPJPlaceholder.Text;
                LblAddressPlaceholder.Text = "*" + LblAddressPlaceholder.Text;
                LblAddressNumberPlaceholder.Text = "*" + LblAddressNumberPlaceholder.Text;
                return;
            }

            LblNamePlaceholder.Text = LblNamePlaceholder.Text.Substring(1);
            LblCNPJPlaceholder.Text = LblCNPJPlaceholder.Text.Substring(1);
            LblAddressPlaceholder.Text = LblAddressPlaceholder.Text.Substring(1);
            LblAddressNumberPlaceholder.Text = LblAddressNumberPlaceholder.Text.Substring(1);
        }

        private void ResetRegisterValues()
        {
            currentProvider = new Provider();
            TbxName.Text = "";
            MTbxCNPJ.Text = "";
            TbxAddress.Text = "";
            TbxAddressNumber.Text = "";
            SwitchComponentsVisibility();
        }

        private void SwitchComponentsVisibility()
        {
            LblUid.Visible = !LblUid.Visible;
            LblName.Visible = !LblName.Visible;
            LblCNPJ.Visible = !LblCNPJ.Visible;
            LblAddress.Visible = !LblAddress.Visible;
            LblAddressNumber.Visible = !LblAddressNumber.Visible;

            TbxName.Visible = !TbxName.Visible;
            MTbxCNPJ.Visible = !MTbxCNPJ.Visible;
            TbxAddress.Visible = !TbxAddress.Visible;
            TbxAddressNumber.Visible = !TbxAddressNumber.Visible;
        }

        private void SetRegisterValuesForEdit()
        {
            TbxName.Text = LblName.Text;
            MTbxCNPJ.Text = LblCNPJ.Text;
            TbxAddress.Text = LblAddress.Text;
            TbxAddressNumber.Text = LblAddressNumber.Text;
        }

        private bool IsValidForm()
        {
            string stringifiedCNPJ = utilities.GetStringifiedMaskedTextBox(MTbxCNPJ);

            if (TbxName.Text.Equals(""))
            {
                MessageBox.Show("O campo nome está vazio!", MESSAGE_BOX_HEADER, MessageBoxButtons.OK);
                return false;
            }

            if (TbxAddress.Text.Equals("") || TbxAddress.Text.Length < 4)
            {
                MessageBox.Show("A rua do endereço está vazio ou é pequeno demais!", MESSAGE_BOX_HEADER, MessageBoxButtons.OK);
                return false;
            }

            if (TbxAddressNumber.Text.Equals(""))
            {
                MessageBox.Show("O número do endereço está vazio!", MESSAGE_BOX_HEADER, MessageBoxButtons.OK);
                return false;
            }

            if (stringifiedCNPJ.Equals("") || stringifiedCNPJ.Length != 14)
            {
                MessageBox.Show("O campo CNPJ está vazio ou é inválido!", MESSAGE_BOX_HEADER, MessageBoxButtons.OK);
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
            tableProviders.DeleteProvider(currentProvider);

            page = page == 0 ? page : page--;
            HandleRegisterChanges(page);
        }

        private void BtnRight_Click(object sender, EventArgs e)
        {
            if (isFind)
            {
                int index = providers.FindIndex(user => user.GetUid() == Convert.ToInt32(TbxUid.Text));

                if (index < 0)
                {
                    MessageBox.Show("Não existe nenhum fornecedor com esse id!", MESSAGE_BOX_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                TbxUid.Text = "";
                SwitchFindComponentsVisibility();
                ChangeCRUDValidations(false, false, false);
                ChangeButtonsText("Anterior", "Próximo");

                if (index >= 0)
                {
                    page = index;
                    SetFormValues(providers[page]);
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

                Provider provider = new Provider();
                provider.SetName(TbxName.Text);
                provider.SetAddress(TbxAddress.Text);
                provider.SetAddressNumber(TbxAddressNumber.Text);
                provider.SetCNPJ(Convert.ToInt64(utilities.GetStringifiedMaskedTextBox(MTbxCNPJ)));

                string message = "";

                if (isCreate)
                {
                    tableProviders.CreateProvider(provider);
                    message = "Fornecedor criado com successo!";
                    page = providers.Count == 0 ? page : page++;
                }
                else
                {
                    tableProviders.UpdateProvider(Convert.ToInt32(LblUid.Text), provider);
                    message = "Fornecedor alterado com successo!";
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
            SetFormValues(providers[page]);
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
            SetFormValues(providers[page]);
        }

        private void FrmProvider_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMainMenu.SetIsFormOpen(false);
        }

        private void TbxAddressNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
