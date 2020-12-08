using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TrabalhoLP3.Database.Tables;
using TrabalhoLP3.Classes;
using TrabalhoLP3.Classes.Database;

namespace TrabalhoLP3.Forms.Register
{
    public partial class FrmAuthor : Form
    {
        private readonly Utilities utilities = new Utilities();
        private readonly TableAuthors tableAuthors = new TableAuthors();
        private readonly FrmMainMenu frmMainMenu;
        private List<Author> authors;
        private Author currentAuthor;
        private bool isFind;
        private bool isCrud;
        private bool isCreate;
        private int page;

        public FrmAuthor(FrmMainMenu frmMainMenu)
        {
            InitializeComponent();
            HandleRegisterChanges(0);
            this.frmMainMenu = frmMainMenu;
        }

        private void SetFormValues(Author author)
        {
            currentAuthor = author;
            LblUid.Text = currentAuthor.GetUid().ToString();
            LblName.Text = currentAuthor.GetName();
            LblBirthDate.Text = utilities.GetFormatedDateTime(currentAuthor.GetBirthDate());
            LblDeathDate.Text = utilities.GetFormatedDateTime(currentAuthor.GetDeathDate());

            MstItemsAvailability(true);
            ChangeButtonsAvailability((page != 0), ((page + 1) != authors.Count));
        }

        private void ResetFormValues(bool setAvailability)
        {
            currentAuthor = null;
            LblUid.Text = "N/D";
            LblName.Text = "N/D";
            LblBirthDate.Text = "N/D";
            LblDeathDate.Text = "N/D";

            if (setAvailability)
            {
                MstItemsAvailability(false, true, false, false);
                ChangeButtonsAvailability(false, false);
            }
        }

        private void ResetRegisterValues()
        {
            currentAuthor = new Author();
            TbxName.Text = "";
            MtxtBirthDate.Text = "";
            MtxtDeathDate.Text = "";
            SwitchComponentsVisibility();
        }

        private void SetRegisterValuesForEdit()
        {
            TbxName.Text = LblName.Text;
            MtxtBirthDate.Text = LblBirthDate.Text;
            MtxtDeathDate.Text = LblDeathDate.Text;
        }

        private void HandleRegisterChanges(int page)
        {
            this.page = page;
            authors = tableAuthors.GetAll();

            if (authors.Count > 0)
            {
                SetFormValues(authors[page]);
                return;
            }

            ResetFormValues(true);
        }

        private void SwitchFindComponentsVisibility()
        {
            TbxUid.Visible = !TbxUid.Visible;
        }

        private void SwitchComponentsVisibility()
        {
            LblUid.Visible = !LblUid.Visible;
            LblName.Visible = !LblName.Visible;
            LblBirthDate.Visible = !LblBirthDate.Visible;
            LblDeathDate.Visible = !LblDeathDate.Visible;

            TbxName.Visible = !TbxName.Visible;
            MtxtBirthDate.Visible = !MtxtBirthDate.Visible;
            MtxtDeathDate.Visible = !MtxtDeathDate.Visible;
        }

        private void ChangeButtonsAvailability(bool leftButton, bool rightButton)
        {
            BtnLeft.Enabled = leftButton;
            BtnRight.Enabled = rightButton;
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
                LblBirthDatePlaceholder.Text = "*" + LblBirthDatePlaceholder.Text;
                return;
            }

            LblNamePlaceholder.Text = LblNamePlaceholder.Text.Substring(1);
            LblBirthDatePlaceholder.Text = LblBirthDatePlaceholder.Text.Substring(1);
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
            DialogResult result = MessageBox.Show("Deseja apagar o registro?", "Autores", MessageBoxButtons.YesNo);
            if (result == DialogResult.No) return;
            tableAuthors.DeleteAuthor(currentAuthor);

            page = page == 0 ? page : page--;
            HandleRegisterChanges(page);
        }

        private bool IsValidForm()
        {
            if (TbxName.Text.Equals(""))
            {
                MessageBox.Show("O campo nome está vazio!", "Autores", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!utilities.IsValidDateTime(MtxtBirthDate.Text))
            {
                MessageBox.Show("O campo nascimento está vazio ou inválido!", "Autores", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void BtnRight_Click(object sender, EventArgs e)
        {
            if (isFind)
            {
                int index = authors.FindIndex(author => author.GetUid() == Convert.ToInt32(TbxUid.Text));

                if (index < 0)
                {
                    MessageBox.Show("Não existe nenhum autor com esse id!", "Autores", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                TbxUid.Text = "";
                SwitchFindComponentsVisibility();
                ChangeCRUDValidations(false, false, false);
                ChangeButtonsText("Anterior", "Próximo");

                if (index >= 0)
                {
                    page = index;
                    SetFormValues(authors[page]);
                    MessageBox.Show("Registro encontrado com sucesso!", "Autores", MessageBoxButtons.OK, MessageBoxIcon.Information);
                } else
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

                Author author = new Author();
                author.SetName(TbxName.Text);
                author.SetBirthDate(Convert.ToDateTime(MtxtBirthDate.Text));

                if (!utilities.GetStringifiedMaskedTextBox(MtxtDeathDate).Equals(""))
                {
                    if (!utilities.IsValidDateTime(MtxtDeathDate.Text))
                    {
                        MessageBox.Show("O campo falecimento está inválido!", "Autores", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    author.SetDeathDate(Convert.ToDateTime(MtxtDeathDate.Text));

                    if (!utilities.IsDateTimeIntervalValid(author.GetBirthDate(), author.GetDeathDate()))
                    {
                        MessageBox.Show("O campo de nascimento não ter uma data mais recente que a de falecimento!", "Autores", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }

                string message = "";

                if (isCreate)
                {
                    tableAuthors.CreateAuthor(author);
                    message = "Author criado com successo!";
                    page = authors.Count == 0 ? page : page++;
                } else
                {
                    tableAuthors.UpdateAuthor(Convert.ToInt32(LblUid.Text), author);
                    message = "Author alterado com successo!";
                }

                MessageBox.Show(message, "Autores", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetRegisterValues();
                ChangePlaceholdersText(false);
                ChangeCRUDValidations(false, false, false);
                ChangeButtonsText("Anterior", "Próximo");
                HandleRegisterChanges(page);

                return;
            }

            page++;
            SetFormValues(authors[page]);
        }

        private void BtnLeft_Click(object sender, EventArgs e)
        {
            if (isFind)
            {
                DialogResult result = MessageBox.Show("Deseja cancelar a busca?", "Autores", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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

                DialogResult result = MessageBox.Show(message, "Autores", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No) return;

                ResetRegisterValues();
                ChangePlaceholdersText(false);
                ChangeCRUDValidations(false, false, false);
                ChangeButtonsText("Anterior", "Próximo");
                HandleRegisterChanges(page);

                return;
            }

            page--;
            SetFormValues(authors[page]);
        }

        private void FrmAuthor_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMainMenu.SetIsFormOpen(false);
        }
    }
}
