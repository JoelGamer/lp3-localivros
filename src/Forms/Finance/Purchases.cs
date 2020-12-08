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
        private readonly Utilities utilities = new Utilities();
        private readonly TablePurchases tablePurchases = new TablePurchases();
        private readonly FrmMainMenu frmMainMenu;
        private bool isFind;
        private bool isCrud;
        private bool isCreate;

        public FrmPurchases(FrmMainMenu frmMainMenu)
        {
            InitializeComponent();
            this.frmMainMenu = frmMainMenu;
        }

        private void MstItemsController(bool enable)
        {
            MstItemFind.Enabled = enable;
            MstItemCreate.Enabled = enable;
            MstItemEdit.Enabled = enable;
            MstItemDelete.Enabled = enable;
        }

        private void MstItemsController(bool find, bool create, bool edit, bool delete)
        {
            MstItemFind.Enabled = find;
            MstItemCreate.Enabled = create;
            MstItemEdit.Enabled = edit;
            MstItemDelete.Enabled = delete;
        }

        private void MstItemFind_Click(object sender, EventArgs e)
        {
            MstItemsController(false);
            BtnRight.Enabled = true;
            BtnLeft.Enabled = true;
            TbxUid.Enabled = true;
            isFind = true;
        }

        private void BtnRight_Click(object sender, EventArgs e)
        {
            if (isFind)
            {
                string sUid = TbxUid.Text;

                if (sUid.Equals(""))
                {
                    MessageBox.Show("Insira um id válido!", "Compras", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Purchase purchase = tablePurchases.GetPurchase(Convert.ToInt32(sUid));

                if (purchase.GetBook().GetUid() <= 0)
                {
                    MessageBox.Show("Não existe nenhum registro com esse id!", "Compras", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                TbxQuantity.Text = purchase.GetQuantity().ToString();
                MstItemsController(true, false, true, true);
                return;
            }
        }

        private void FrmPurchases_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMainMenu.SetIsFormOpen(false);
        }
    }
}
