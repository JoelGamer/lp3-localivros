namespace TrabalhoLP3.Forms.Finance
{
    partial class FrmSales
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
            this.mstSales = new System.Windows.Forms.MenuStrip();
            this.MstItemFind = new System.Windows.Forms.ToolStripMenuItem();
            this.MstItemCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.MstItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.MstItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.TbxUid = new System.Windows.Forms.TextBox();
            this.TbxBook = new System.Windows.Forms.TextBox();
            this.BtnRight = new System.Windows.Forms.Button();
            this.BtnLeft = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.LblBook = new System.Windows.Forms.Label();
            this.TbxQuantity = new System.Windows.Forms.TextBox();
            this.LblQuantity = new System.Windows.Forms.Label();
            this.TbxClient = new System.Windows.Forms.TextBox();
            this.LblClient = new System.Windows.Forms.Label();
            this.TbxClientId = new System.Windows.Forms.TextBox();
            this.TbxBookId = new System.Windows.Forms.TextBox();
            this.mstSales.SuspendLayout();
            this.SuspendLayout();
            // 
            // mstSales
            // 
            this.mstSales.AllowMerge = false;
            this.mstSales.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MstItemFind,
            this.MstItemCreate,
            this.MstItemEdit,
            this.MstItemDelete});
            this.mstSales.Location = new System.Drawing.Point(0, 0);
            this.mstSales.Name = "mstSales";
            this.mstSales.Size = new System.Drawing.Size(513, 29);
            this.mstSales.TabIndex = 31;
            this.mstSales.Text = "menuStrip1";
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
            this.TbxUid.Enabled = false;
            this.TbxUid.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxUid.Location = new System.Drawing.Point(211, 39);
            this.TbxUid.Name = "TbxUid";
            this.TbxUid.Size = new System.Drawing.Size(290, 32);
            this.TbxUid.TabIndex = 1;
            this.TbxUid.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxUid_KeyPress);
            // 
            // TbxBook
            // 
            this.TbxBook.Enabled = false;
            this.TbxBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxBook.Location = new System.Drawing.Point(296, 79);
            this.TbxBook.Name = "TbxBook";
            this.TbxBook.Size = new System.Drawing.Size(205, 32);
            this.TbxBook.TabIndex = 3;
            this.TbxBook.Leave += new System.EventHandler(this.TbxBook_Leave);
            // 
            // BtnRight
            // 
            this.BtnRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRight.Location = new System.Drawing.Point(391, 216);
            this.BtnRight.Name = "BtnRight";
            this.BtnRight.Size = new System.Drawing.Size(110, 48);
            this.BtnRight.TabIndex = 8;
            this.BtnRight.Text = "Próximo";
            this.BtnRight.UseVisualStyleBackColor = true;
            this.BtnRight.Click += new System.EventHandler(this.BtnRight_Click);
            // 
            // BtnLeft
            // 
            this.BtnLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLeft.Location = new System.Drawing.Point(12, 216);
            this.BtnLeft.Name = "BtnLeft";
            this.BtnLeft.Size = new System.Drawing.Size(110, 48);
            this.BtnLeft.TabIndex = 7;
            this.BtnLeft.Text = "Anterior";
            this.BtnLeft.UseVisualStyleBackColor = true;
            this.BtnLeft.Click += new System.EventHandler(this.BtnLeft_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 26);
            this.label5.TabIndex = 77;
            this.label5.Text = "ID:";
            // 
            // LblBook
            // 
            this.LblBook.AutoSize = true;
            this.LblBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBook.Location = new System.Drawing.Point(12, 82);
            this.LblBook.Name = "LblBook";
            this.LblBook.Size = new System.Drawing.Size(65, 26);
            this.LblBook.TabIndex = 75;
            this.LblBook.Text = "Livro:";
            // 
            // TbxQuantity
            // 
            this.TbxQuantity.Enabled = false;
            this.TbxQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxQuantity.Location = new System.Drawing.Point(211, 163);
            this.TbxQuantity.Name = "TbxQuantity";
            this.TbxQuantity.Size = new System.Drawing.Size(290, 32);
            this.TbxQuantity.TabIndex = 6;
            // 
            // LblQuantity
            // 
            this.LblQuantity.AutoSize = true;
            this.LblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQuantity.Location = new System.Drawing.Point(12, 166);
            this.LblQuantity.Name = "LblQuantity";
            this.LblQuantity.Size = new System.Drawing.Size(130, 26);
            this.LblQuantity.TabIndex = 79;
            this.LblQuantity.Text = "Quantidade:";
            // 
            // TbxClient
            // 
            this.TbxClient.Enabled = false;
            this.TbxClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxClient.Location = new System.Drawing.Point(296, 121);
            this.TbxClient.Name = "TbxClient";
            this.TbxClient.Size = new System.Drawing.Size(205, 32);
            this.TbxClient.TabIndex = 5;
            this.TbxClient.Leave += new System.EventHandler(this.TbxClient_Leave);
            // 
            // LblClient
            // 
            this.LblClient.AutoSize = true;
            this.LblClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblClient.Location = new System.Drawing.Point(12, 124);
            this.LblClient.Name = "LblClient";
            this.LblClient.Size = new System.Drawing.Size(86, 26);
            this.LblClient.TabIndex = 81;
            this.LblClient.Text = "Cliente:";
            // 
            // TbxClientId
            // 
            this.TbxClientId.Enabled = false;
            this.TbxClientId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxClientId.Location = new System.Drawing.Point(211, 121);
            this.TbxClientId.Name = "TbxClientId";
            this.TbxClientId.Size = new System.Drawing.Size(79, 32);
            this.TbxClientId.TabIndex = 4;
            this.TbxClientId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxClientId_KeyPress);
            this.TbxClientId.Leave += new System.EventHandler(this.TbxClientId_Leave);
            // 
            // TbxBookId
            // 
            this.TbxBookId.Enabled = false;
            this.TbxBookId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxBookId.Location = new System.Drawing.Point(211, 79);
            this.TbxBookId.Name = "TbxBookId";
            this.TbxBookId.Size = new System.Drawing.Size(79, 32);
            this.TbxBookId.TabIndex = 2;
            this.TbxBookId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxBookId_KeyPress);
            this.TbxBookId.Leave += new System.EventHandler(this.TbxBookId_Leave);
            // 
            // FrmSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 275);
            this.Controls.Add(this.TbxBookId);
            this.Controls.Add(this.TbxClientId);
            this.Controls.Add(this.TbxClient);
            this.Controls.Add(this.LblClient);
            this.Controls.Add(this.TbxQuantity);
            this.Controls.Add(this.LblQuantity);
            this.Controls.Add(this.TbxUid);
            this.Controls.Add(this.TbxBook);
            this.Controls.Add(this.BtnRight);
            this.Controls.Add(this.BtnLeft);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LblBook);
            this.Controls.Add(this.mstSales);
            this.Name = "FrmSales";
            this.Text = "Vendas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmSales_FormClosing);
            this.mstSales.ResumeLayout(false);
            this.mstSales.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mstSales;
        private System.Windows.Forms.ToolStripMenuItem MstItemFind;
        private System.Windows.Forms.ToolStripMenuItem MstItemCreate;
        private System.Windows.Forms.ToolStripMenuItem MstItemEdit;
        private System.Windows.Forms.ToolStripMenuItem MstItemDelete;
        private System.Windows.Forms.TextBox TbxUid;
        private System.Windows.Forms.TextBox TbxBook;
        private System.Windows.Forms.Button BtnRight;
        private System.Windows.Forms.Button BtnLeft;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblBook;
        private System.Windows.Forms.TextBox TbxQuantity;
        private System.Windows.Forms.Label LblQuantity;
        private System.Windows.Forms.TextBox TbxClient;
        private System.Windows.Forms.Label LblClient;
        private System.Windows.Forms.TextBox TbxClientId;
        private System.Windows.Forms.TextBox TbxBookId;
    }
}