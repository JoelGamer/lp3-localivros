namespace TrabalhoLP3.Forms.Register
{
    partial class FrmBooks
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.LblDescription = new System.Windows.Forms.Label();
            this.LblDescriptionPlaceholder = new System.Windows.Forms.Label();
            this.LblAuthor = new System.Windows.Forms.Label();
            this.LblAuthorPlaceholder = new System.Windows.Forms.Label();
            this.LblPages = new System.Windows.Forms.Label();
            this.LblPagesPlaceholder = new System.Windows.Forms.Label();
            this.LblGenre = new System.Windows.Forms.Label();
            this.LblGenrePlaceholder = new System.Windows.Forms.Label();
            this.LblReleaseDate = new System.Windows.Forms.Label();
            this.LblReleaseDatePlaceholder = new System.Windows.Forms.Label();
            this.LblPrice = new System.Windows.Forms.Label();
            this.LblPricePlaceholder = new System.Windows.Forms.Label();
            this.TbxDescription = new System.Windows.Forms.TextBox();
            this.TbxPages = new System.Windows.Forms.TextBox();
            this.MtxtReleaseDate = new System.Windows.Forms.MaskedTextBox();
            this.TbxPrice = new System.Windows.Forms.TextBox();
            this.CbxAuthors = new System.Windows.Forms.ComboBox();
            this.CbxGenre = new System.Windows.Forms.ComboBox();
            this.mstBooks = new System.Windows.Forms.MenuStrip();
            this.MstItemFind = new System.Windows.Forms.ToolStripMenuItem();
            this.MstItemCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.MstItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.MstItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.TbxUid = new System.Windows.Forms.TextBox();
            this.TbxName = new System.Windows.Forms.TextBox();
            this.LblUid = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.LblNamePlaceholder = new System.Windows.Forms.Label();
            this.BtnRight = new System.Windows.Forms.Button();
            this.BtnLeft = new System.Windows.Forms.Button();
            this.mstBooks.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblDescription
            // 
            this.LblDescription.AutoSize = true;
            this.LblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescription.Location = new System.Drawing.Point(166, 318);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(141, 26);
            this.LblDescription.TabIndex = 3;
            this.LblDescription.Text = "_description_";
            // 
            // LblDescriptionPlaceholder
            // 
            this.LblDescriptionPlaceholder.AutoSize = true;
            this.LblDescriptionPlaceholder.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescriptionPlaceholder.Location = new System.Drawing.Point(12, 318);
            this.LblDescriptionPlaceholder.Name = "LblDescriptionPlaceholder";
            this.LblDescriptionPlaceholder.Size = new System.Drawing.Size(115, 26);
            this.LblDescriptionPlaceholder.TabIndex = 2;
            this.LblDescriptionPlaceholder.Text = "Descrição:";
            // 
            // LblAuthor
            // 
            this.LblAuthor.AutoSize = true;
            this.LblAuthor.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAuthor.Location = new System.Drawing.Point(166, 126);
            this.LblAuthor.Name = "LblAuthor";
            this.LblAuthor.Size = new System.Drawing.Size(97, 26);
            this.LblAuthor.TabIndex = 5;
            this.LblAuthor.Text = "_author_";
            // 
            // LblAuthorPlaceholder
            // 
            this.LblAuthorPlaceholder.AutoSize = true;
            this.LblAuthorPlaceholder.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAuthorPlaceholder.Location = new System.Drawing.Point(12, 124);
            this.LblAuthorPlaceholder.Name = "LblAuthorPlaceholder";
            this.LblAuthorPlaceholder.Size = new System.Drawing.Size(70, 26);
            this.LblAuthorPlaceholder.TabIndex = 4;
            this.LblAuthorPlaceholder.Text = "Autor:";
            // 
            // LblPages
            // 
            this.LblPages.AutoSize = true;
            this.LblPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPages.Location = new System.Drawing.Point(166, 163);
            this.LblPages.Name = "LblPages";
            this.LblPages.Size = new System.Drawing.Size(95, 26);
            this.LblPages.TabIndex = 7;
            this.LblPages.Text = "_pages_";
            // 
            // LblPagesPlaceholder
            // 
            this.LblPagesPlaceholder.AutoSize = true;
            this.LblPagesPlaceholder.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPagesPlaceholder.Location = new System.Drawing.Point(12, 161);
            this.LblPagesPlaceholder.Name = "LblPagesPlaceholder";
            this.LblPagesPlaceholder.Size = new System.Drawing.Size(97, 26);
            this.LblPagesPlaceholder.TabIndex = 6;
            this.LblPagesPlaceholder.Text = "Páginas:";
            // 
            // LblGenre
            // 
            this.LblGenre.AutoSize = true;
            this.LblGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGenre.Location = new System.Drawing.Point(166, 199);
            this.LblGenre.Name = "LblGenre";
            this.LblGenre.Size = new System.Drawing.Size(91, 26);
            this.LblGenre.TabIndex = 9;
            this.LblGenre.Text = "_genre_";
            // 
            // LblGenrePlaceholder
            // 
            this.LblGenrePlaceholder.AutoSize = true;
            this.LblGenrePlaceholder.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblGenrePlaceholder.Location = new System.Drawing.Point(12, 201);
            this.LblGenrePlaceholder.Name = "LblGenrePlaceholder";
            this.LblGenrePlaceholder.Size = new System.Drawing.Size(90, 26);
            this.LblGenrePlaceholder.TabIndex = 8;
            this.LblGenrePlaceholder.Text = "Gênero:";
            // 
            // LblReleaseDate
            // 
            this.LblReleaseDate.AutoSize = true;
            this.LblReleaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblReleaseDate.Location = new System.Drawing.Point(166, 240);
            this.LblReleaseDate.Name = "LblReleaseDate";
            this.LblReleaseDate.Size = new System.Drawing.Size(156, 26);
            this.LblReleaseDate.TabIndex = 11;
            this.LblReleaseDate.Text = "_release-date_";
            // 
            // LblReleaseDatePlaceholder
            // 
            this.LblReleaseDatePlaceholder.AutoSize = true;
            this.LblReleaseDatePlaceholder.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblReleaseDatePlaceholder.Location = new System.Drawing.Point(12, 240);
            this.LblReleaseDatePlaceholder.Name = "LblReleaseDatePlaceholder";
            this.LblReleaseDatePlaceholder.Size = new System.Drawing.Size(138, 26);
            this.LblReleaseDatePlaceholder.TabIndex = 10;
            this.LblReleaseDatePlaceholder.Text = "Lançamento:";
            // 
            // LblPrice
            // 
            this.LblPrice.AutoSize = true;
            this.LblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPrice.Location = new System.Drawing.Point(166, 279);
            this.LblPrice.Name = "LblPrice";
            this.LblPrice.Size = new System.Drawing.Size(83, 26);
            this.LblPrice.TabIndex = 13;
            this.LblPrice.Text = "_price_";
            // 
            // LblPricePlaceholder
            // 
            this.LblPricePlaceholder.AutoSize = true;
            this.LblPricePlaceholder.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPricePlaceholder.Location = new System.Drawing.Point(12, 277);
            this.LblPricePlaceholder.Name = "LblPricePlaceholder";
            this.LblPricePlaceholder.Size = new System.Drawing.Size(75, 26);
            this.LblPricePlaceholder.TabIndex = 12;
            this.LblPricePlaceholder.Text = "Preço:";
            // 
            // TbxDescription
            // 
            this.TbxDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxDescription.Location = new System.Drawing.Point(166, 315);
            this.TbxDescription.Name = "TbxDescription";
            this.TbxDescription.Size = new System.Drawing.Size(231, 32);
            this.TbxDescription.TabIndex = 20;
            this.TbxDescription.Visible = false;
            // 
            // TbxPages
            // 
            this.TbxPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxPages.Location = new System.Drawing.Point(167, 160);
            this.TbxPages.Name = "TbxPages";
            this.TbxPages.Size = new System.Drawing.Size(231, 32);
            this.TbxPages.TabIndex = 22;
            this.TbxPages.Visible = false;
            this.TbxPages.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxPages_KeyPress);
            // 
            // MtxtReleaseDate
            // 
            this.MtxtReleaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MtxtReleaseDate.Location = new System.Drawing.Point(167, 237);
            this.MtxtReleaseDate.Mask = "00/00/0000";
            this.MtxtReleaseDate.Name = "MtxtReleaseDate";
            this.MtxtReleaseDate.Size = new System.Drawing.Size(120, 32);
            this.MtxtReleaseDate.TabIndex = 24;
            this.MtxtReleaseDate.ValidatingType = typeof(System.DateTime);
            this.MtxtReleaseDate.Visible = false;
            // 
            // TbxPrice
            // 
            this.TbxPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxPrice.Location = new System.Drawing.Point(166, 276);
            this.TbxPrice.Name = "TbxPrice";
            this.TbxPrice.Size = new System.Drawing.Size(231, 32);
            this.TbxPrice.TabIndex = 25;
            this.TbxPrice.Visible = false;
            this.TbxPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxPrice_KeyPress);
            // 
            // CbxAuthors
            // 
            this.CbxAuthors.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxAuthors.FormattingEnabled = true;
            this.CbxAuthors.Location = new System.Drawing.Point(167, 123);
            this.CbxAuthors.Name = "CbxAuthors";
            this.CbxAuthors.Size = new System.Drawing.Size(231, 33);
            this.CbxAuthors.TabIndex = 26;
            this.CbxAuthors.Visible = false;
            // 
            // CbxGenre
            // 
            this.CbxGenre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxGenre.FormattingEnabled = true;
            this.CbxGenre.Location = new System.Drawing.Point(167, 198);
            this.CbxGenre.Name = "CbxGenre";
            this.CbxGenre.Size = new System.Drawing.Size(231, 33);
            this.CbxGenre.TabIndex = 27;
            this.CbxGenre.Visible = false;
            // 
            // mstBooks
            // 
            this.mstBooks.AllowMerge = false;
            this.mstBooks.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MstItemFind,
            this.MstItemCreate,
            this.MstItemEdit,
            this.MstItemDelete});
            this.mstBooks.Location = new System.Drawing.Point(0, 0);
            this.mstBooks.Name = "mstBooks";
            this.mstBooks.Size = new System.Drawing.Size(412, 29);
            this.mstBooks.TabIndex = 29;
            this.mstBooks.Text = "menuStrip1";
            // 
            // MstItemFind
            // 
            this.MstItemFind.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.MstItemFind.Name = "MstItemFind";
            this.MstItemFind.Size = new System.Drawing.Size(82, 25);
            this.MstItemFind.Text = "&Procurar";
            this.MstItemFind.Click += new System.EventHandler(this.MstItemFind_Click);
            // 
            // MstItemCreate
            // 
            this.MstItemCreate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.MstItemCreate.Name = "MstItemCreate";
            this.MstItemCreate.Size = new System.Drawing.Size(56, 25);
            this.MstItemCreate.Text = "&Criar";
            this.MstItemCreate.Click += new System.EventHandler(this.MstItemCreate_Click);
            // 
            // MstItemEdit
            // 
            this.MstItemEdit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.MstItemEdit.Name = "MstItemEdit";
            this.MstItemEdit.Size = new System.Drawing.Size(62, 25);
            this.MstItemEdit.Text = "&Editar";
            this.MstItemEdit.Click += new System.EventHandler(this.MstItemEdit_Click);
            // 
            // MstItemDelete
            // 
            this.MstItemDelete.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.MstItemDelete.Name = "MstItemDelete";
            this.MstItemDelete.Size = new System.Drawing.Size(72, 25);
            this.MstItemDelete.Text = "&Apagar";
            this.MstItemDelete.Click += new System.EventHandler(this.MstItemDelete_Click);
            // 
            // TbxUid
            // 
            this.TbxUid.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxUid.Location = new System.Drawing.Point(166, 49);
            this.TbxUid.Name = "TbxUid";
            this.TbxUid.Size = new System.Drawing.Size(231, 32);
            this.TbxUid.TabIndex = 30;
            this.TbxUid.Visible = false;
            // 
            // TbxName
            // 
            this.TbxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxName.Location = new System.Drawing.Point(166, 87);
            this.TbxName.Name = "TbxName";
            this.TbxName.Size = new System.Drawing.Size(231, 32);
            this.TbxName.TabIndex = 31;
            this.TbxName.Visible = false;
            // 
            // LblUid
            // 
            this.LblUid.AutoSize = true;
            this.LblUid.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUid.Location = new System.Drawing.Point(166, 54);
            this.LblUid.Name = "LblUid";
            this.LblUid.Size = new System.Drawing.Size(53, 26);
            this.LblUid.TabIndex = 35;
            this.LblUid.Text = "_id_";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 26);
            this.label5.TabIndex = 34;
            this.label5.Text = "ID:";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.Location = new System.Drawing.Point(166, 90);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(91, 26);
            this.LblName.TabIndex = 33;
            this.LblName.Text = "_name_";
            // 
            // LblNamePlaceholder
            // 
            this.LblNamePlaceholder.AutoSize = true;
            this.LblNamePlaceholder.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNamePlaceholder.Location = new System.Drawing.Point(12, 88);
            this.LblNamePlaceholder.Name = "LblNamePlaceholder";
            this.LblNamePlaceholder.Size = new System.Drawing.Size(77, 26);
            this.LblNamePlaceholder.TabIndex = 32;
            this.LblNamePlaceholder.Text = "Nome:";
            // 
            // BtnRight
            // 
            this.BtnRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRight.Location = new System.Drawing.Point(290, 494);
            this.BtnRight.Name = "BtnRight";
            this.BtnRight.Size = new System.Drawing.Size(110, 48);
            this.BtnRight.TabIndex = 37;
            this.BtnRight.Text = "Próximo";
            this.BtnRight.UseVisualStyleBackColor = true;
            this.BtnRight.Click += new System.EventHandler(this.BtnRight_Click);
            // 
            // BtnLeft
            // 
            this.BtnLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLeft.Location = new System.Drawing.Point(12, 494);
            this.BtnLeft.Name = "BtnLeft";
            this.BtnLeft.Size = new System.Drawing.Size(110, 48);
            this.BtnLeft.TabIndex = 36;
            this.BtnLeft.Text = "Anterior";
            this.BtnLeft.UseVisualStyleBackColor = true;
            this.BtnLeft.Click += new System.EventHandler(this.BtnLeft_Click);
            // 
            // FrmBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 554);
            this.Controls.Add(this.BtnRight);
            this.Controls.Add(this.BtnLeft);
            this.Controls.Add(this.TbxUid);
            this.Controls.Add(this.TbxName);
            this.Controls.Add(this.LblUid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.LblNamePlaceholder);
            this.Controls.Add(this.mstBooks);
            this.Controls.Add(this.CbxGenre);
            this.Controls.Add(this.CbxAuthors);
            this.Controls.Add(this.TbxPrice);
            this.Controls.Add(this.MtxtReleaseDate);
            this.Controls.Add(this.TbxPages);
            this.Controls.Add(this.TbxDescription);
            this.Controls.Add(this.LblPrice);
            this.Controls.Add(this.LblPricePlaceholder);
            this.Controls.Add(this.LblReleaseDate);
            this.Controls.Add(this.LblReleaseDatePlaceholder);
            this.Controls.Add(this.LblGenre);
            this.Controls.Add(this.LblGenrePlaceholder);
            this.Controls.Add(this.LblPages);
            this.Controls.Add(this.LblPagesPlaceholder);
            this.Controls.Add(this.LblAuthor);
            this.Controls.Add(this.LblAuthorPlaceholder);
            this.Controls.Add(this.LblDescription);
            this.Controls.Add(this.LblDescriptionPlaceholder);
            this.MaximizeBox = false;
            this.Name = "FrmBooks";
            this.Text = "Livros";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmBooks_FormClosing);
            this.mstBooks.ResumeLayout(false);
            this.mstBooks.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LblDescription;
        private System.Windows.Forms.Label LblDescriptionPlaceholder;
        private System.Windows.Forms.Label LblAuthor;
        private System.Windows.Forms.Label LblAuthorPlaceholder;
        private System.Windows.Forms.Label LblPages;
        private System.Windows.Forms.Label LblPagesPlaceholder;
        private System.Windows.Forms.Label LblGenre;
        private System.Windows.Forms.Label LblGenrePlaceholder;
        private System.Windows.Forms.Label LblReleaseDate;
        private System.Windows.Forms.Label LblReleaseDatePlaceholder;
        private System.Windows.Forms.Label LblPrice;
        private System.Windows.Forms.Label LblPricePlaceholder;
        private System.Windows.Forms.TextBox TbxDescription;
        private System.Windows.Forms.TextBox TbxPages;
        private System.Windows.Forms.MaskedTextBox MtxtReleaseDate;
        private System.Windows.Forms.TextBox TbxPrice;
        private System.Windows.Forms.ComboBox CbxAuthors;
        private System.Windows.Forms.ComboBox CbxGenre;
        private System.Windows.Forms.MenuStrip mstBooks;
        private System.Windows.Forms.ToolStripMenuItem MstItemFind;
        private System.Windows.Forms.ToolStripMenuItem MstItemCreate;
        private System.Windows.Forms.ToolStripMenuItem MstItemEdit;
        private System.Windows.Forms.ToolStripMenuItem MstItemDelete;
        private System.Windows.Forms.TextBox TbxUid;
        private System.Windows.Forms.TextBox TbxName;
        private System.Windows.Forms.Label LblUid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblNamePlaceholder;
        private System.Windows.Forms.Button BtnRight;
        private System.Windows.Forms.Button BtnLeft;
    }
}