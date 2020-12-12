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

namespace TrabalhoLP3.Forms.Finance
{
    public partial class FrmPurchases : Form
    {
        private readonly string MESSAGE_BOX_HEADER = "Compras";

        private readonly TablePurchases tablePurchases = new TablePurchases();
        private readonly FrmMainMenu frmMainMenu;
        private List<Purchase> purchases;
        private Purchase currentPurchase;
        private bool isFind;
        private bool isCrud;
        private bool isCreate;
        private int page;

        public FrmPurchases(FrmMainMenu frmMainMenu)
        {
            InitializeComponent();
            HandleRegisterChanges(0);
            this.frmMainMenu = frmMainMenu;
        }

        private void HandleRegisterChanges(int page)
        {
            this.page = page;
            purchases = tablePurchases.GetAll();

            if (purchases.Count > 0)
            {
                SetFormValues(purchases[page]);
                return;
            }

            ResetFormValues(true);
        }

        private void SetFormValues(Purchase purchase)
        {
            currentPurchase = purchase;
            TbxUid.Text = currentPurchase.GetUid().ToString();
            TbxBookId.Text = currentPurchase.GetBook().GetUid().ToString();
            TbxBook.Text = currentPurchase.GetBook().GetName();
            TbxProviderId.Text = currentPurchase.GetProvider().GetUid().ToString();
            TbxProvider.Text = currentPurchase.GetProvider().GetName();
            TbxQuantity.Text = currentPurchase.GetQuantity().ToString();

            MstItemsAvailability(true);
            ChangeButtonsAvailability((page != 0), ((page + 1) != purchases.Count));
        }

        private void ResetFormValues(bool setAvailability)
        {
            currentPurchase = null;
            TbxUid.Text = "";
            TbxBookId.Text = "";
            TbxBook.Text = "";
            TbxProviderId.Text = "";
            TbxProvider.Text = "";
            TbxQuantity.Text = "";

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
            TbxUid.Enabled = !TbxUid.Enabled;
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
                LblBook.Text = "*" + LblBook.Text;
                LblProvider.Text = "*" + LblProvider.Text;
                LblQuantity.Text = "*" + LblQuantity.Text;
                return;
            }

            LblBook.Text = LblBook.Text.Substring(1);
            LblProvider.Text = LblProvider.Text.Substring(1);
            LblQuantity.Text = LblQuantity.Text.Substring(1);
        }

        private void ResetRegisterValues()
        {
            currentPurchase = new Purchase();
            TbxUid.Text = "";
            TbxBookId.Text = "";
            TbxBook.Text = "";
            TbxProviderId.Text = "";
            TbxProvider.Text = "";
            TbxQuantity.Text = "";
            SwitchComponentsEnabled();
        }

        private void SwitchComponentsEnabled()
        {
            TbxBookId.Enabled = !TbxBookId.Enabled;
            TbxBook.Enabled = !TbxBook.Enabled;
            TbxProviderId.Enabled = !TbxProviderId.Enabled;
            TbxProvider.Enabled = !TbxProvider.Enabled;
            TbxQuantity.Enabled = !TbxQuantity.Enabled;
        }

        private bool IsValidForm()
        {
            if (TbxBookId.Text.Equals(""))
            {
                MessageBox.Show("O campo livro está vazio!", MESSAGE_BOX_HEADER, MessageBoxButtons.OK);
                return false;
            }

            if (TbxProviderId.Text.Equals(""))
            {
                MessageBox.Show("O campo fornecedor está vazio!", MESSAGE_BOX_HEADER, MessageBoxButtons.OK);
                return false;
            }

            if (TbxQuantity.Text.Equals(""))
            {
                MessageBox.Show("O campo quantidade está vazio!", MESSAGE_BOX_HEADER, MessageBoxButtons.OK);
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
            SwitchComponentsEnabled();
            ChangeButtonsText("Cancelar", "Confirmar");
            ChangeButtonsAvailability(true, true);
            MstItemsAvailability(false);

            ChangeCRUDValidations(false, true, false);
        }

        private void MstItemDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja apagar o registro?", MESSAGE_BOX_HEADER, MessageBoxButtons.YesNo);
            if (result == DialogResult.No) return;
            tablePurchases.DeletePurchase(currentPurchase);

            page = page == 0 ? page : page--;
            HandleRegisterChanges(page);
        }

        private void BtnRight_Click(object sender, EventArgs e)
        {
            if (isFind)
            {
                int index = purchases.FindIndex(user => user.GetUid() == Convert.ToInt32(TbxUid.Text));

                if (index < 0)
                {
                    MessageBox.Show("Não existe nenhuma compra com esse id!", MESSAGE_BOX_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                TbxUid.Text = "";
                SwitchFindComponentsVisibility();
                ChangeCRUDValidations(false, false, false);
                ChangeButtonsText("Anterior", "Próximo");

                if (index >= 0)
                {
                    page = index;
                    SetFormValues(purchases[page]);
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

                Purchase purchase = new Purchase();
                purchase.SetBook(new Book(Convert.ToInt32(TbxBookId.Text)));
                purchase.SetProvider(new Provider(Convert.ToInt32(TbxProviderId.Text)));
                purchase.SetQuantity(Convert.ToInt32(TbxQuantity.Text));

                string message = "";

                if (isCreate)
                {
                    tablePurchases.CreateProvider(purchase);
                    message = "Compra criado com successo!";
                    page = purchases.Count == 0 ? page : page++;
                }
                else
                {
                    tablePurchases.UpdateProvider(Convert.ToInt32(TbxUid.Text), purchase);
                    message = "Compra alterado com successo!";
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
            SetFormValues(purchases[page]);
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
            SetFormValues(purchases[page]);
        }

        private void FrmPurchases_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMainMenu.SetIsFormOpen(false);
        }

        private void TbxUid_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TbxBookId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TbxProviderId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TbxQuantity_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void TbxBookId_Leave(object sender, EventArgs e)
        {
            if (TbxBookId.Text.Equals("")) return;

            Book book = new TableBooks().GetBook(Convert.ToInt32(TbxBookId.Text));

            if (book == null || book.GetName() == null)
            {
                MessageBox.Show("Não existe nenhum livro com esse id!", MESSAGE_BOX_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TbxBookId.Text = "";
                TbxBook.Text = "";
                return;
            }

            TbxBook.Text = book.GetName();
        }

        private void TbxBook_Leave(object sender, EventArgs e)
        {
            if (!TbxBookId.Text.Equals("")) return;
            if (TbxBook.Text.Equals("")) return;

            Book book = new TableBooks().GetBook(TbxBook.Text);

            if (book == null || book.GetName() == null)
            {
                MessageBox.Show("Não existe nenhum livro com esse nome!", MESSAGE_BOX_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TbxBookId.Text = "";
                TbxBook.Text = "";
                return;
            }

            TbxBookId.Text = book.GetUid().ToString();
            TbxBook.Text = book.GetName();
        }

        private void TbxProviderId_Leave(object sender, EventArgs e)
        {
            if (TbxProviderId.Text.Equals("")) return;

            Provider provider = new TableProviders().GetProvider(Convert.ToInt32(TbxProviderId.Text));

            if (provider == null || provider.GetName() == null)
            {
                MessageBox.Show("Não existe nenhum fornecedor com esse id!", MESSAGE_BOX_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TbxProviderId.Text = "";
                return;
            }

            TbxProvider.Text = provider.GetName();
        }

        private void TbxProvider_Leave(object sender, EventArgs e)
        {
            if (!TbxProviderId.Text.Equals("")) return;
            if (TbxProvider.Text.Equals("")) return;

            Provider provider = new TableProviders().GetProvider(TbxProvider.Text);

            if (provider == null || provider.GetName() == null)
            {
                MessageBox.Show("Não existe nenhum fornecedor com esse nome!", MESSAGE_BOX_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TbxBookId.Text = "";
                TbxBook.Text = "";
                return;
            }

            TbxProviderId.Text = provider.GetUid().ToString();
            TbxProvider.Text = provider.GetName();
        }
    }
}
