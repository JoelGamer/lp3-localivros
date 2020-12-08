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
            this.mstClient = new System.Windows.Forms.MenuStrip();
            this.MstItemCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.MstItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.MstItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.CbxBooks = new System.Windows.Forms.ComboBox();
            this.LblProviderPlaceholder = new System.Windows.Forms.Label();
            this.LblAuthorPlaceholder = new System.Windows.Forms.Label();
            this.CbxProviders = new System.Windows.Forms.ComboBox();
            this.TbxQuantity = new System.Windows.Forms.TextBox();
            this.LblQuantityPlaceholder = new System.Windows.Forms.Label();
            this.TbxUid = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnRight = new System.Windows.Forms.Button();
            this.BtnLeft = new System.Windows.Forms.Button();
            this.MstItemFind = new System.Windows.Forms.ToolStripMenuItem();
            this.mstClient.SuspendLayout();
            this.SuspendLayout();
            // 
            // mstClient
            // 
            this.mstClient.AllowMerge = false;
            this.mstClient.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MstItemFind,
            this.MstItemCreate,
            this.MstItemEdit,
            this.MstItemDelete});
            this.mstClient.Location = new System.Drawing.Point(0, 0);
            this.mstClient.Name = "mstClient";
            this.mstClient.Size = new System.Drawing.Size(396, 29);
            this.mstClient.TabIndex = 31;
            this.mstClient.Text = "menuStrip1";
            // 
            // MstItemCreate
            // 
            this.MstItemCreate.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.MstItemCreate.Name = "MstItemCreate";
            this.MstItemCreate.Size = new System.Drawing.Size(56, 25);
            this.MstItemCreate.Text = "&Criar";
            // 
            // MstItemEdit
            // 
            this.MstItemEdit.Enabled = false;
            this.MstItemEdit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.MstItemEdit.Name = "MstItemEdit";
            this.MstItemEdit.Size = new System.Drawing.Size(62, 25);
            this.MstItemEdit.Text = "&Editar";
            // 
            // MstItemDelete
            // 
            this.MstItemDelete.Enabled = false;
            this.MstItemDelete.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.MstItemDelete.Name = "MstItemDelete";
            this.MstItemDelete.Size = new System.Drawing.Size(72, 25);
            this.MstItemDelete.Text = "&Apagar";
            // 
            // CbxBooks
            // 
            this.CbxBooks.Enabled = false;
            this.CbxBooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxBooks.FormattingEnabled = true;
            this.CbxBooks.Location = new System.Drawing.Point(153, 81);
            this.CbxBooks.Name = "CbxBooks";
            this.CbxBooks.Size = new System.Drawing.Size(231, 33);
            this.CbxBooks.TabIndex = 36;
            this.CbxBooks.Visible = false;
            // 
            // LblProviderPlaceholder
            // 
            this.LblProviderPlaceholder.AutoSize = true;
            this.LblProviderPlaceholder.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProviderPlaceholder.Location = new System.Drawing.Point(12, 127);
            this.LblProviderPlaceholder.Name = "LblProviderPlaceholder";
            this.LblProviderPlaceholder.Size = new System.Drawing.Size(128, 26);
            this.LblProviderPlaceholder.TabIndex = 34;
            this.LblProviderPlaceholder.Text = "Fornecedor:";
            // 
            // LblAuthorPlaceholder
            // 
            this.LblAuthorPlaceholder.AutoSize = true;
            this.LblAuthorPlaceholder.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAuthorPlaceholder.Location = new System.Drawing.Point(12, 84);
            this.LblAuthorPlaceholder.Name = "LblAuthorPlaceholder";
            this.LblAuthorPlaceholder.Size = new System.Drawing.Size(65, 26);
            this.LblAuthorPlaceholder.TabIndex = 32;
            this.LblAuthorPlaceholder.Text = "Livro:";
            // 
            // CbxProviders
            // 
            this.CbxProviders.Enabled = false;
            this.CbxProviders.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbxProviders.FormattingEnabled = true;
            this.CbxProviders.Location = new System.Drawing.Point(152, 124);
            this.CbxProviders.Name = "CbxProviders";
            this.CbxProviders.Size = new System.Drawing.Size(232, 33);
            this.CbxProviders.TabIndex = 37;
            this.CbxProviders.Visible = false;
            // 
            // TbxQuantity
            // 
            this.TbxQuantity.Enabled = false;
            this.TbxQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxQuantity.Location = new System.Drawing.Point(152, 165);
            this.TbxQuantity.MaxLength = 6;
            this.TbxQuantity.Name = "TbxQuantity";
            this.TbxQuantity.Size = new System.Drawing.Size(232, 32);
            this.TbxQuantity.TabIndex = 74;
            this.TbxQuantity.Visible = false;
            // 
            // LblQuantityPlaceholder
            // 
            this.LblQuantityPlaceholder.AutoSize = true;
            this.LblQuantityPlaceholder.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQuantityPlaceholder.Location = new System.Drawing.Point(12, 168);
            this.LblQuantityPlaceholder.Name = "LblQuantityPlaceholder";
            this.LblQuantityPlaceholder.Size = new System.Drawing.Size(130, 26);
            this.LblQuantityPlaceholder.TabIndex = 75;
            this.LblQuantityPlaceholder.Text = "Quantidade:";
            // 
            // TbxUid
            // 
            this.TbxUid.Enabled = false;
            this.TbxUid.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxUid.Location = new System.Drawing.Point(153, 40);
            this.TbxUid.Name = "TbxUid";
            this.TbxUid.Size = new System.Drawing.Size(231, 32);
            this.TbxUid.TabIndex = 76;
            this.TbxUid.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 26);
            this.label5.TabIndex = 77;
            this.label5.Text = "ID:";
            // 
            // BtnRight
            // 
            this.BtnRight.Enabled = false;
            this.BtnRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRight.Location = new System.Drawing.Point(274, 235);
            this.BtnRight.Name = "BtnRight";
            this.BtnRight.Size = new System.Drawing.Size(110, 48);
            this.BtnRight.TabIndex = 79;
            this.BtnRight.Text = "Confirmar";
            this.BtnRight.UseVisualStyleBackColor = true;
            this.BtnRight.Click += new System.EventHandler(this.BtnRight_Click);
            // 
            // BtnLeft
            // 
            this.BtnLeft.Enabled = false;
            this.BtnLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLeft.Location = new System.Drawing.Point(17, 235);
            this.BtnLeft.Name = "BtnLeft";
            this.BtnLeft.Size = new System.Drawing.Size(110, 48);
            this.BtnLeft.TabIndex = 78;
            this.BtnLeft.Text = "Cancelar";
            this.BtnLeft.UseVisualStyleBackColor = true;
            // 
            // MstItemFind
            // 
            this.MstItemFind.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.MstItemFind.Name = "MstItemFind";
            this.MstItemFind.Size = new System.Drawing.Size(82, 25);
            this.MstItemFind.Text = "&Procurar";
            this.MstItemFind.Click += new System.EventHandler(this.MstItemFind_Click);
            // 
            // FrmPurchases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 300);
            this.Controls.Add(this.BtnRight);
            this.Controls.Add(this.BtnLeft);
            this.Controls.Add(this.TbxUid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TbxQuantity);
            this.Controls.Add(this.LblQuantityPlaceholder);
            this.Controls.Add(this.CbxProviders);
            this.Controls.Add(this.CbxBooks);
            this.Controls.Add(this.LblProviderPlaceholder);
            this.Controls.Add(this.LblAuthorPlaceholder);
            this.Controls.Add(this.mstClient);
            this.Name = "FrmPurchases";
            this.Text = "Compras";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmPurchases_FormClosing);
            this.mstClient.ResumeLayout(false);
            this.mstClient.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mstClient;
        private System.Windows.Forms.ToolStripMenuItem MstItemCreate;
        private System.Windows.Forms.ToolStripMenuItem MstItemEdit;
        private System.Windows.Forms.ToolStripMenuItem MstItemDelete;
        private System.Windows.Forms.ComboBox CbxBooks;
        private System.Windows.Forms.Label LblProviderPlaceholder;
        private System.Windows.Forms.Label LblAuthorPlaceholder;
        private System.Windows.Forms.ComboBox CbxProviders;
        private System.Windows.Forms.TextBox TbxQuantity;
        private System.Windows.Forms.Label LblQuantityPlaceholder;
        private System.Windows.Forms.TextBox TbxUid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnRight;
        private System.Windows.Forms.Button BtnLeft;
        private System.Windows.Forms.ToolStripMenuItem MstItemFind;
    }
}