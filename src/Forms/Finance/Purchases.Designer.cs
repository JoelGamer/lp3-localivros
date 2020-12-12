namespace TrabalhoLP3.Forms.Finance
{
    partial class FrmPurchases
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
            this.mstPurchases = new System.Windows.Forms.MenuStrip();
            this.MstItemFind = new System.Windows.Forms.ToolStripMenuItem();
            this.MstItemCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.MstItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.MstItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.TbxBookId = new System.Windows.Forms.TextBox();
            this.TbxProviderId = new System.Windows.Forms.TextBox();
            this.TbxProvider = new System.Windows.Forms.TextBox();
            this.LblProvider = new System.Windows.Forms.Label();
            this.TbxQuantity = new System.Windows.Forms.TextBox();
            this.LblQuantity = new System.Windows.Forms.Label();
            this.TbxUid = new System.Windows.Forms.TextBox();
            this.TbxBook = new System.Windows.Forms.TextBox();
            this.BtnRight = new System.Windows.Forms.Button();
            this.BtnLeft = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.LblBook = new System.Windows.Forms.Label();
            this.mstPurchases.SuspendLayout();
            this.SuspendLayout();
            // 
            // mstPurchases
            // 
            this.mstPurchases.AllowMerge = false;
            this.mstPurchases.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MstItemFind,
            this.MstItemCreate,
            this.MstItemEdit,
            this.MstItemDelete});
            this.mstPurchases.Location = new System.Drawing.Point(0, 0);
            this.mstPurchases.Name = "mstPurchases";
            this.mstPurchases.Size = new System.Drawing.Size(516, 29);
            this.mstPurchases.TabIndex = 32;
            this.mstPurchases.Text = "menuStrip1";
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
            // TbxBookId
            // 
            this.TbxBookId.Enabled = false;
            this.TbxBookId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxBookId.Location = new System.Drawing.Point(167, 87);
            this.TbxBookId.Name = "TbxBookId";
            this.TbxBookId.Size = new System.Drawing.Size(79, 32);
            this.TbxBookId.TabIndex = 83;
            this.TbxBookId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxBookId_KeyPress);
            this.TbxBookId.Leave += new System.EventHandler(this.TbxBookId_Leave);
            // 
            // TbxProviderId
            // 
            this.TbxProviderId.Enabled = false;
            this.TbxProviderId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxProviderId.Location = new System.Drawing.Point(167, 129);
            this.TbxProviderId.Name = "TbxProviderId";
            this.TbxProviderId.Size = new System.Drawing.Size(79, 32);
            this.TbxProviderId.TabIndex = 85;
            this.TbxProviderId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxProviderId_KeyPress);
            this.TbxProviderId.Leave += new System.EventHandler(this.TbxProviderId_Leave);
            // 
            // TbxProvider
            // 
            this.TbxProvider.Enabled = false;
            this.TbxProvider.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxProvider.Location = new System.Drawing.Point(252, 129);
            this.TbxProvider.Name = "TbxProvider";
            this.TbxProvider.Size = new System.Drawing.Size(249, 32);
            this.TbxProvider.TabIndex = 86;
            this.TbxProvider.Leave += new System.EventHandler(this.TbxProvider_Leave);
            // 
            // LblProvider
            // 
            this.LblProvider.AutoSize = true;
            this.LblProvider.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProvider.Location = new System.Drawing.Point(12, 132);
            this.LblProvider.Name = "LblProvider";
            this.LblProvider.Size = new System.Drawing.Size(128, 26);
            this.LblProvider.TabIndex = 93;
            this.LblProvider.Text = "Fornecedor:";
            // 
            // TbxQuantity
            // 
            this.TbxQuantity.Enabled = false;
            this.TbxQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxQuantity.Location = new System.Drawing.Point(167, 171);
            this.TbxQuantity.Name = "TbxQuantity";
            this.TbxQuantity.Size = new System.Drawing.Size(334, 32);
            this.TbxQuantity.TabIndex = 87;
            this.TbxQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxQuantity_KeyPress);
            // 
            // LblQuantity
            // 
            this.LblQuantity.AutoSize = true;
            this.LblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQuantity.Location = new System.Drawing.Point(12, 174);
            this.LblQuantity.Name = "LblQuantity";
            this.LblQuantity.Size = new System.Drawing.Size(130, 26);
            this.LblQuantity.TabIndex = 92;
            this.LblQuantity.Text = "Quantidade:";
            // 
            // TbxUid
            // 
            this.TbxUid.Enabled = false;
            this.TbxUid.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxUid.Location = new System.Drawing.Point(167, 47);
            this.TbxUid.Name = "TbxUid";
            this.TbxUid.Size = new System.Drawing.Size(334, 32);
            this.TbxUid.TabIndex = 82;
            this.TbxUid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxUid_KeyPress);
            // 
            // TbxBook
            // 
            this.TbxBook.Enabled = false;
            this.TbxBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxBook.Location = new System.Drawing.Point(252, 87);
            this.TbxBook.Name = "TbxBook";
            this.TbxBook.Size = new System.Drawing.Size(249, 32);
            this.TbxBook.TabIndex = 84;
            this.TbxBook.Leave += new System.EventHandler(this.TbxBook_Leave);
            // 
            // BtnRight
            // 
            this.BtnRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRight.Location = new System.Drawing.Point(391, 224);
            this.BtnRight.Name = "BtnRight";
            this.BtnRight.Size = new System.Drawing.Size(110, 48);
            this.BtnRight.TabIndex = 89;
            this.BtnRight.Text = "Próximo";
            this.BtnRight.UseVisualStyleBackColor = true;
            this.BtnRight.Click += new System.EventHandler(this.BtnRight_Click);
            // 
            // BtnLeft
            // 
            this.BtnLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLeft.Location = new System.Drawing.Point(12, 224);
            this.BtnLeft.Name = "BtnLeft";
            this.BtnLeft.Size = new System.Drawing.Size(110, 48);
            this.BtnLeft.TabIndex = 88;
            this.BtnLeft.Text = "Anterior";
            this.BtnLeft.UseVisualStyleBackColor = true;
            this.BtnLeft.Click += new System.EventHandler(this.BtnLeft_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 26);
            this.label5.TabIndex = 91;
            this.label5.Text = "ID:";
            // 
            // LblBook
            // 
            this.LblBook.AutoSize = true;
            this.LblBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBook.Location = new System.Drawing.Point(12, 90);
            this.LblBook.Name = "LblBook";
            this.LblBook.Size = new System.Drawing.Size(65, 26);
            this.LblBook.TabIndex = 90;
            this.LblBook.Text = "Livro:";
            // 
            // FrmPurchases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 287);
            this.Controls.Add(this.TbxBookId);
            this.Controls.Add(this.TbxProviderId);
            this.Controls.Add(this.TbxProvider);
            this.Controls.Add(this.LblProvider);
            this.Controls.Add(this.TbxQuantity);
            this.Controls.Add(this.LblQuantity);
            this.Controls.Add(this.TbxUid);
            this.Controls.Add(this.TbxBook);
            this.Controls.Add(this.BtnRight);
            this.Controls.Add(this.BtnLeft);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LblBook);
            this.Controls.Add(this.mstPurchases);
            this.Name = "FrmPurchases";
            this.Text = "Compras";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPurchases_FormClosing);
            this.mstPurchases.ResumeLayout(false);
            this.mstPurchases.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mstPurchases;
        private System.Windows.Forms.ToolStripMenuItem MstItemFind;
        private System.Windows.Forms.ToolStripMenuItem MstItemCreate;
        private System.Windows.Forms.ToolStripMenuItem MstItemEdit;
        private System.Windows.Forms.ToolStripMenuItem MstItemDelete;
        private System.Windows.Forms.TextBox TbxBookId;
        private System.Windows.Forms.TextBox TbxProviderId;
        private System.Windows.Forms.TextBox TbxProvider;
        private System.Windows.Forms.Label LblProvider;
        private System.Windows.Forms.TextBox TbxQuantity;
        private System.Windows.Forms.Label LblQuantity;
        private System.Windows.Forms.TextBox TbxUid;
        private System.Windows.Forms.TextBox TbxBook;
        private System.Windows.Forms.Button BtnRight;
        private System.Windows.Forms.Button BtnLeft;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblBook;
    }
}