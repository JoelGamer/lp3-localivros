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

namespace TrabalhoLP3
{
    public partial class FrmBooks : Form
    {
        private readonly FrmMainMenu frmMainMenu;
        private List<Book> books;
        private int page;

        public FrmBooks(FrmMainMenu frmMainMenu)
        {
            InitializeComponent();
            this.frmMainMenu = frmMainMenu;

            books = new TableBooks().GetAll();

            LblUid.Text = books[0].GetUid().ToString();
            LblName.Text = books[0].GetName();
            LblDescription.Text = books[0].GetDescription();
            LblAuthor.Text = books[0].GetAuthor().GetUid().ToString();
            LblPages.Text = books[0].GetPages().ToString();
            LblGenre.Text = books[0].GetGenre().GetUid().ToString();
            LblReleaseDate.Text = books[0].GetReleaseDate().ToString();
            LblPrice.Text = books[0].GetPrice().ToString();
        }

        private void TbxPrice_Leave(object sender, EventArgs e)
        {
            string priceString = TbxPrice.Text;
            if (!priceString.Equals(""))
            {
                double price = Convert.ToDouble(priceString);
                TbxPrice.Text = price.ToString("C");
            }
        }

        private void TbxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TbxPrice_Click(object sender, EventArgs e)
        {
            LblPrice.Text = "";
        }

        private void FrmBooks_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMainMenu.SetIsFormOpen(false);
        }
    }
}
