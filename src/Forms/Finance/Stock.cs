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
using TrabalhoLP3.Classes.Database;

namespace TrabalhoLP3.Forms.Finance
{
    public partial class FrmStock : Form
    {
        private readonly string MESSAGE_BOX_HEADER = "Estoque";
        private readonly FrmMainMenu frmMainMenu;

        public FrmStock(FrmMainMenu frmMainMenu)
        {
            InitializeComponent();
            this.frmMainMenu = frmMainMenu;
            LblQuantity.Text = "N/D";
        }

        private void ResetFormValues()
        {
            TbxBookId.Text = "";
            TbxBook.Text = "";
            LblQuantity.Text = "N/D";
        }

        private void ChangeButtonsAvailability(bool leftButton, bool rightButton)
        {
            BtnLeft.Enabled = leftButton;
            BtnRight.Enabled = rightButton;
        }

        private void SwitchComponentsEnabled()
        {
            TbxBookId.Enabled = !TbxBookId.Enabled;
            TbxBook.Enabled = !TbxBook.Enabled;
        }

        private void MstItemFind_Click(object sender, EventArgs e)
        {
            ResetFormValues();
            SwitchComponentsEnabled();
            ChangeButtonsAvailability(true, true);
            MstItemFind.Enabled = false;
        }

        private void BtnRight_Click(object sender, EventArgs e)
        {
            if (TbxBookId.Text.Equals(""))
            {
                MessageBox.Show("O campo livro está vazio!", MESSAGE_BOX_HEADER, MessageBoxButtons.OK);
            }

            int uid = Convert.ToInt32(TbxBookId.Text);
            int quantity = 0;
            List<Purchase> purchases = new TablePurchases().GetAll(uid);
            List<Sale> sales = new TableSales().GetAll(uid);

            purchases.ForEach(purchase => {
                quantity += purchase.GetQuantity();
            });

            sales.ForEach(sale => {
                quantity -= sale.GetQuantity();
            });

            MstItemFind.Enabled = true;
            LblQuantity.Text = quantity.ToString();
            SwitchComponentsEnabled();
            ChangeButtonsAvailability(false, false);
        }

        private void FrmStock_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMainMenu.SetIsFormOpen(false);
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

        private void BtnLeft_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja cancelar a busca?", MESSAGE_BOX_HEADER, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No) return;

            MstItemFind.Enabled = true;
            ResetFormValues();
            SwitchComponentsEnabled();
            ChangeButtonsAvailability(false, false);
        }

        private void TbxBookId_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
