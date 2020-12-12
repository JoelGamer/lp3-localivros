using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TrabalhoLP3.Database.Tables;
using TrabalhoLP3.Classes.Database;

namespace TrabalhoLP3.Forms.Finance
{
    public partial class FrmSales : Form
    {
        private readonly string MESSAGE_BOX_HEADER = "Vendas";

        private readonly TableSales tableSales = new TableSales();
        private readonly FrmMainMenu frmMainMenu;
        private List<Sale> sales;
        private Sale currentSale;
        private bool isFind;
        private bool isCrud;
        private bool isCreate;
        private int page;

        public FrmSales(FrmMainMenu frmMainMenu)
        {
            InitializeComponent();
            HandleRegisterChanges(0);
            this.frmMainMenu = frmMainMenu;
        }

        private void HandleRegisterChanges(int page)
        {
            this.page = page;
            sales = tableSales.GetAll();

            if (sales.Count > 0)
            {
                SetFormValues(sales[page]);
                return;
            }

            ResetFormValues(true);
        }

        private void SetFormValues(Sale sale)
        {
            currentSale = sale;
            TbxUid.Text = currentSale.GetUid().ToString();
            TbxBookId.Text = currentSale.GetBook().GetUid().ToString();
            TbxBook.Text = currentSale.GetBook().GetName();
            TbxClientId.Text = currentSale.GetClient().GetUid().ToString();
            TbxClient.Text = currentSale.GetClient().GetName();
            TbxQuantity.Text = currentSale.GetQuantity().ToString();

            MstItemsAvailability(true);
            ChangeButtonsAvailability((page != 0), ((page + 1) != sales.Count));
        }

        private void ResetFormValues(bool setAvailability)
        {
            currentSale = null;
            TbxUid.Text = "";
            TbxBookId.Text = "";
            TbxBook.Text = "";
            TbxClientId.Text = "";
            TbxClient.Text = "";
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
                LblClient.Text = "*" + LblClient.Text;
                LblQuantity.Text = "*" + LblQuantity.Text;
                return;
            }

            LblBook.Text = LblBook.Text.Substring(1);
            LblClient.Text = LblClient.Text.Substring(1);
            LblQuantity.Text = LblQuantity.Text.Substring(1);
        }

        private void ResetRegisterValues()
        {
            currentSale = new Sale();
            TbxUid.Text = "";
            TbxBookId.Text = "";
            TbxBook.Text = "";
            TbxClientId.Text = "";
            TbxClient.Text = "";
            TbxQuantity.Text = "";
            SwitchComponentsEnabled();
        }

        private void SwitchComponentsEnabled()
        {
            TbxBookId.Enabled = !TbxBookId.Enabled;
            TbxBook.Enabled = !TbxBook.Enabled;
            TbxClientId.Enabled = !TbxClientId.Enabled;
            TbxClient.Enabled = !TbxClient.Enabled;
            TbxQuantity.Enabled = !TbxQuantity.Enabled;
        }

        private bool IsValidForm()
        {
            if (TbxBookId.Text.Equals(""))
            {
                MessageBox.Show("O campo livro está vazio!", MESSAGE_BOX_HEADER, MessageBoxButtons.OK);
                return false;
            }

            if (TbxClientId.Text.Equals(""))
            {
                MessageBox.Show("O campo cliente está vazio!", MESSAGE_BOX_HEADER, MessageBoxButtons.OK);
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
            tableSales.DeleteSale(currentSale);

            page = page == 0 ? page : page--;
            HandleRegisterChanges(page);
        }

        private void BtnRight_Click(object sender, EventArgs e)
        {
            if (isFind)
            {
                int index = sales.FindIndex(user => user.GetUid() == Convert.ToInt32(TbxUid.Text));

                if (index < 0)
                {
                    MessageBox.Show("Não existe nenhuma venda com esse id!", MESSAGE_BOX_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                TbxUid.Text = "";
                SwitchFindComponentsVisibility();
                ChangeCRUDValidations(false, false, false);
                ChangeButtonsText("Anterior", "Próximo");

                if (index >= 0)
                {
                    page = index;
                    SetFormValues(sales[page]);
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

                Sale sale = new Sale();
                sale.SetBook(new Book(Convert.ToInt32(TbxBookId.Text)));
                sale.SetClient(new Client(Convert.ToInt32(TbxClientId.Text)));
                sale.SetQuantity(Convert.ToInt32(TbxQuantity.Text));

                string message = "";

                if (isCreate)
                {
                    tableSales.CreateSale(sale);
                    message = "Venda criado com successo!";
                    page = sales.Count == 0 ? page : page++;
                }
                else
                {
                    tableSales.UpdateSale(Convert.ToInt32(TbxUid.Text), sale);
                    message = "Venda alterado com successo!";
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
            SetFormValues(sales[page]);
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
            SetFormValues(sales[page]);
        }

        private void FrmSales_FormClosing(object sender, FormClosingEventArgs e)
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

        private void TbxClientId_KeyPress(object sender, KeyPressEventArgs e)
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

        private void TbxClientId_Leave(object sender, EventArgs e)
        {
            if (TbxClientId.Text.Equals("")) return;

            Client client = new TableClients().GetClient(Convert.ToInt32(TbxClientId.Text));

            if (client == null || client.GetName() == null)
            {
                MessageBox.Show("Não existe nenhum cliente com esse id!", MESSAGE_BOX_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TbxClientId.Text = "";
                return;
            }

            TbxClient.Text = client.GetName();
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

        private void TbxClient_Leave(object sender, EventArgs e)
        {
            if (!TbxClientId.Text.Equals("")) return;
            if (TbxClient.Text.Equals("")) return;

            Client client = new TableClients().GetClient(TbxClient.Text);

            if (client == null || client.GetName() == null)
            {
                MessageBox.Show("Não existe nenhum cliente com esse nome!", MESSAGE_BOX_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TbxBookId.Text = "";
                TbxBook.Text = "";
                return;
            }

            TbxClientId.Text = client.GetUid().ToString();
            TbxClient.Text = client.GetName();
        }
    }
}
