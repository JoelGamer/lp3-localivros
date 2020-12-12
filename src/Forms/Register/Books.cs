using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using TrabalhoLP3.Classes;
using TrabalhoLP3.Classes.Database;
using TrabalhoLP3.Database.Tables;

namespace TrabalhoLP3.Forms.Register
{
    public partial class FrmBooks : Form
    {
        private readonly string MESSAGE_BOX_HEADER = "Livros";

        private readonly Utilities utilities = new Utilities();
        private readonly TableBooks tableBooks = new TableBooks();
        private readonly TableAuthors tableAuthors = new TableAuthors();
        private readonly TableGenres tableGenres = new TableGenres();
        private readonly FrmMainMenu frmMainMenu;
        private List<Book> books;
        private Book currentBook;
        private bool isFind;
        private bool isCrud;
        private bool isCreate;
        private int page;

        public FrmBooks(FrmMainMenu frmMainMenu)
        {
            InitializeComponent();
            HandleRegisterChanges(0);
            this.frmMainMenu = frmMainMenu;
        }

        private void HandleRegisterChanges(int page)
        {
            this.page = page;
            books = tableBooks.GetAll();

            if (books.Count > 0)
            {
                SetFormValues(books[page]);
                return;
            }

            ResetFormValues(true);
        }

        private void SetFormValues(Book book)
        {
            currentBook = book;
            LblUid.Text = currentBook.GetUid().ToString();
            LblName.Text = currentBook.GetName();
            LblDescription.Text = currentBook.GetDescription();
            LblAuthor.Text = currentBook.GetAuthor().GetName();
            LblPages.Text = currentBook.GetPages().ToString();
            LblGenre.Text = currentBook.GetGenre().GetName();
            LblReleaseDate.Text = utilities.GetFormatedDateTime(currentBook.GetReleaseDate());
            LblPrice.Text = utilities.ConvertToCurrency(currentBook.GetPrice());

            MstItemsAvailability(true);
            ChangeButtonsAvailability((page != 0), ((page + 1) != books.Count));
        }

        private void ResetFormValues(bool setAvailability)
        {
            currentBook = null;
            LblUid.Text = "N/D";
            LblName.Text = "N/D";
            LblDescription.Text = "N/D";
            LblAuthor.Text = "N/D";
            LblPages.Text = "N/D";
            LblGenre.Text = "N/D";
            LblReleaseDate.Text = "N/D";
            LblPrice.Text = "N/D";

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
                LblDescriptionPlaceholder.Text = "*" + LblDescriptionPlaceholder.Text;
                LblAuthorPlaceholder.Text = "*" + LblAuthorPlaceholder.Text;
                LblPagesPlaceholder.Text = "*" + LblPagesPlaceholder.Text;
                LblGenrePlaceholder.Text = "*" + LblGenrePlaceholder.Text;
                LblReleaseDatePlaceholder.Text = "*" + LblReleaseDatePlaceholder.Text;
                LblPricePlaceholder.Text = "*" + LblPricePlaceholder.Text;
                return;
            }

            LblNamePlaceholder.Text = LblNamePlaceholder.Text.Substring(1);
            LblDescriptionPlaceholder.Text = LblDescriptionPlaceholder.Text.Substring(1);
            LblAuthorPlaceholder.Text = LblAuthorPlaceholder.Text.Substring(1);
            LblPagesPlaceholder.Text = LblPagesPlaceholder.Text.Substring(1);
            LblGenrePlaceholder.Text = LblGenrePlaceholder.Text.Substring(1);
            LblReleaseDatePlaceholder.Text = LblReleaseDatePlaceholder.Text.Substring(1);
            LblPricePlaceholder.Text = LblPricePlaceholder.Text.Substring(1);
        }

        private void ResetRegisterValues()
        {
            currentBook = new Book();
            TbxName.Text = "";
            TbxDescription.Text = "";
            TbxPages.Text = "";
            MtxtReleaseDate.Text = "";
            TbxPrice.Text = "";
            SwitchComponentsVisibility();
        }

        private void SwitchComponentsVisibility()
        {
            LblUid.Visible = !LblUid.Visible;
            LblName.Visible = !LblName.Visible;
            LblDescription.Visible = !LblDescription.Visible;
            LblAuthor.Visible = !LblAuthor.Visible;
            LblPages.Visible = !LblPages.Visible;
            LblGenre.Visible = !LblGenre.Visible;
            LblReleaseDate.Visible = !LblReleaseDate.Visible;
            LblPrice.Visible = !LblPrice.Visible;

            TbxName.Visible = !TbxName.Visible;
            TbxDescription.Visible = !TbxDescription.Visible;
            CbxAuthors.Visible = !CbxAuthors.Visible;
            TbxPages.Visible = !TbxPages.Visible;
            CbxGenre.Visible = !CbxGenre.Visible;
            MtxtReleaseDate.Visible = !MtxtReleaseDate.Visible;
            TbxPrice.Visible = !TbxPrice.Visible;
        }

        private void SetRegisterValuesForEdit()
        {
            TbxName.Text = LblName.Text;
            TbxDescription.Text = LblDescription.Text;
            TbxPages.Text = LblPages.Text;
            MtxtReleaseDate.Text = LblReleaseDate.Text;
            TbxPrice.Text = decimal.Parse(LblPrice.Text, NumberStyles.AllowCurrencySymbol | NumberStyles.Number).ToString();
        }

        private void PopulateComboBoxes()
        {
            Dictionary<int, string> authors = new Dictionary<int, string>();
            tableAuthors.GetAll().ForEach(dbAuthors => authors.Add(dbAuthors.GetUid(), dbAuthors.GetName()));
            CbxAuthors.DataSource = new BindingSource(authors, null);
            CbxAuthors.DisplayMember = "Value";
            CbxAuthors.ValueMember = "Key";

            Dictionary<int, string> genres = new Dictionary<int, string>();
            tableGenres.GetAll().ForEach(dbGenre => genres.Add(dbGenre.GetUid(), dbGenre.GetName()));
            CbxGenre.DataSource = new BindingSource(genres, null);
            CbxGenre.DisplayMember = "Value";
            CbxGenre.ValueMember = "Key";
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
            PopulateComboBoxes();

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
            PopulateComboBoxes();

            ChangeCRUDValidations(false, true, false);
        }

        private void MstItemDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja apagar o registro?", MESSAGE_BOX_HEADER, MessageBoxButtons.YesNo);
            if (result == DialogResult.No) return;
            tableBooks.DeleteBook(currentBook);

            page = page == 0 ? page : page--;
            HandleRegisterChanges(page);
        }

        private bool IsValidForm()
        {
            if (TbxName.Text.Equals(""))
            {
                MessageBox.Show("O campo nome está vazio!", MESSAGE_BOX_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (TbxDescription.Text.Equals(""))
            {
                MessageBox.Show("O campo descrição está vazio!", MESSAGE_BOX_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (CbxAuthors.SelectedIndex < 0)
            {
                MessageBox.Show("Deve selecionar um autor para vincular a este livro!", MESSAGE_BOX_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (TbxPages.Text.Equals(""))
            {
                MessageBox.Show("O campo páginas está vazio!", MESSAGE_BOX_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (CbxGenre.SelectedIndex < 0)
            {
                MessageBox.Show("Deve selecionar um gênero para vincular a este livro!", MESSAGE_BOX_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!utilities.IsValidDateTime(MtxtReleaseDate.Text))
            {
                MessageBox.Show("O campo lançamento está vazio ou inválido!", MESSAGE_BOX_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (TbxPrice.Text.Equals(""))
            {
                MessageBox.Show("O campo preço está vazio!", MESSAGE_BOX_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void BtnRight_Click(object sender, EventArgs e)
        {
            if (isFind)
            {
                int index = books.FindIndex(book => book.GetUid() == Convert.ToInt32(TbxUid.Text));

                if (index < 0)
                {
                    MessageBox.Show("Não existe nenhum livro com esse id!", MESSAGE_BOX_HEADER, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                TbxUid.Text = "";
                SwitchFindComponentsVisibility();
                ChangeCRUDValidations(false, false, false);
                ChangeButtonsText("Anterior", "Próximo");

                if (index >= 0)
                {
                    page = index;
                    SetFormValues(books[page]);
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

                Book book = new Book();
                book.SetName(TbxName.Text);
                book.SetDescripton(TbxDescription.Text);
                book.SetAuthor(tableAuthors.GetAuthor(Convert.ToInt32(CbxAuthors.SelectedValue)));
                book.SetPages(Convert.ToInt32(TbxPages.Text));
                book.SetGenre(tableGenres.GetGenre(Convert.ToInt32(CbxGenre.SelectedValue)));
                book.SetReleaseDate(Convert.ToDateTime(MtxtReleaseDate.Text));
                book.SetPrice(Convert.ToDouble(TbxPrice.Text));

                string message = "";

                if (isCreate)
                {
                    tableBooks.CreateBook(book);
                    message = "Livro criado com successo!";
                    page = books.Count == 0 ? page : page++;
                }
                else
                {
                    tableBooks.UpdateBook(Convert.ToInt32(LblUid.Text), book);
                    message = "Livro alterado com successo!";
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
            SetFormValues(books[page]);
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
            SetFormValues(books[page]);
        }

        private bool HandleNumericalInput(KeyPressEventArgs e)
        {
            return !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void TbxPages_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (HandleNumericalInput(e)) e.Handled = true;
        }

        private void TbxPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (HandleNumericalInput(e)) e.Handled = true;
        }

        private void FrmBooks_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMainMenu.SetIsFormOpen(false);
        }

        private void TbxDescription_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
