using System;
using System.Collections.Generic;
using System.Windows.Forms;
using TrabalhoLP3.Database.Tables;
using TrabalhoLP3.Classes.Database;

namespace TrabalhoLP3.Forms.Register
{
    public partial class FrmGenre : Form
    {
        private readonly FrmMainMenu frmMainMenu = new FrmMainMenu();
        private readonly TableGenres tableGenres = new TableGenres();
        private List<Genre> genres;
        private Genre currentGenre;
        private bool isFind;
        private bool isCrud;
        private bool isCreate;
        private int page;

        public FrmGenre(FrmMainMenu frmMainMenu)
        {
            InitializeComponent();
            HandleRegisterChanges(0);
            this.frmMainMenu = frmMainMenu;
        }

        private void HandleRegisterChanges(int page)
        {
            this.page = page;
            genres = tableGenres.GetAll();

            if (genres.Count > 0)
            {
                SetFormValues(genres[page]);
                return;
            }

            ResetFormValues(true);
        }

        private void SetFormValues(Genre genre)
        {
            currentGenre = genre;
            LblUid.Text = currentGenre.GetUid().ToString();
            LblName.Text = currentGenre.GetName();

            MstItemsAvailability(true);
            ChangeButtonsAvailability((page != 0), ((page + 1) != genres.Count));
        }

        private void ResetFormValues(bool setAvailability)
        {
            currentGenre = null;
            LblUid.Text = "N/D";
            LblName.Text = "N/D";

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
                return;
            }

            LblNamePlaceholder.Text = LblNamePlaceholder.Text.Substring(1);
        }

        private void ResetRegisterValues()
        {
            currentGenre = new Genre();
            TbxName.Text = "";
            SwitchComponentsVisibility();
        }

        private void SwitchComponentsVisibility()
        {
            LblUid.Visible = !LblUid.Visible;
            LblName.Visible = !LblName.Visible;

            TbxName.Visible = !TbxName.Visible;
        }

        private void SetRegisterValuesForEdit()
        {
            TbxName.Text = LblName.Text;
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
            DialogResult result = MessageBox.Show("Deseja apagar o registro?", "Gêneros", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.No) return;
            tableGenres.DeleteGenre(currentGenre);

            page = page == 0 ? page : page--;

            HandleRegisterChanges(page);
        }

        private bool IsValidForm()
        {
            if (TbxName.Text.Equals(""))
            {
                MessageBox.Show("O campo nome está vazio!", "Gêneros", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void BtnRight_Click(object sender, EventArgs e)
        {
            if (isFind)
            {
                int index = genres.FindIndex(genre => genre.GetUid() == Convert.ToInt32(TbxUid.Text));

                if (index < 0)
                {
                    MessageBox.Show("Não existe nenhum gênero com esse id!", "Gêneros", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                TbxUid.Text = "";
                SwitchFindComponentsVisibility();
                ChangeCRUDValidations(false, false, false);
                ChangeButtonsText("Anterior", "Próximo");

                if (index >= 0)
                {
                    page = index;
                    SetFormValues(genres[page]);
                    MessageBox.Show("Registro encontrado com sucesso!", "Gêneros", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                Genre genre = new Genre();
                genre.SetName(TbxName.Text);

                string message = "";

                if (isCreate)
                {
                    tableGenres.CreateGenre(genre);
                    message = "Gênero criado com successo!";
                    page = genres.Count == 0 ? page : page++;
                }
                else
                {
                    tableGenres.UpdateGenre(Convert.ToInt32(LblUid.Text), genre);
                    message = "Gênero alterado com successo!";
                }

                MessageBox.Show(message, "Gêneros", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetRegisterValues();
                ChangePlaceholdersText(false);
                ChangeCRUDValidations(false, false, false);
                ChangeButtonsText("Anterior", "Próximo");
                HandleRegisterChanges(page);

                return;
            }

            page++;
            SetFormValues(genres[page]);
        }

        private void BtnLeft_Click(object sender, EventArgs e)
        {
            if (isFind)
            {
                DialogResult result = MessageBox.Show("Deseja cancelar a busca?", "Gêneros", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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

                DialogResult result = MessageBox.Show(message, "Gêneros", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.No) return;

                ResetRegisterValues();
                ChangePlaceholdersText(false);
                ChangeCRUDValidations(false, false, false);
                ChangeButtonsText("Anterior", "Próximo");
                HandleRegisterChanges(page);

                return;
            }

            page--;
            SetFormValues(genres[page]);
        }

        private void FrmGenre_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmMainMenu.SetIsFormOpen(false);
        }
    }
}
