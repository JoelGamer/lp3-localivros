namespace TrabalhoLP3.Forms.Finance
{
    partial class FrmStock
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
            this.mstStock = new System.Windows.Forms.MenuStrip();
            this.MstItemFind = new System.Windows.Forms.ToolStripMenuItem();
            this.BtnRight = new System.Windows.Forms.Button();
            this.BtnLeft = new System.Windows.Forms.Button();
            this.TbxBookId = new System.Windows.Forms.TextBox();
            this.TbxBook = new System.Windows.Forms.TextBox();
            this.LblBook = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.LblQuantity = new System.Windows.Forms.Label();
            this.mstStock.SuspendLayout();
            this.SuspendLayout();
            // 
            // mstStock
            // 
            this.mstStock.AllowMerge = false;
            this.mstStock.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MstItemFind});
            this.mstStock.Location = new System.Drawing.Point(0, 0);
            this.mstStock.Name = "mstStock";
            this.mstStock.Size = new System.Drawing.Size(516, 29);
            this.mstStock.TabIndex = 32;
            this.mstStock.Text = "menuStrip1";
            // 
            // MstItemFind
            // 
            this.MstItemFind.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.MstItemFind.Name = "MstItemFind";
            this.MstItemFind.Size = new System.Drawing.Size(82, 25);
            this.MstItemFind.Text = "&Procurar";
            this.MstItemFind.Click += new System.EventHandler(this.MstItemFind_Click);
            // 
            // BtnRight
            // 
            this.BtnRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRight.Location = new System.Drawing.Point(391, 138);
            this.BtnRight.Name = "BtnRight";
            this.BtnRight.Size = new System.Drawing.Size(110, 48);
            this.BtnRight.TabIndex = 34;
            this.BtnRight.Text = "Confirmar";
            this.BtnRight.UseVisualStyleBackColor = true;
            this.BtnRight.Click += new System.EventHandler(this.BtnRight_Click);
            // 
            // BtnLeft
            // 
            this.BtnLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLeft.Location = new System.Drawing.Point(12, 138);
            this.BtnLeft.Name = "BtnLeft";
            this.BtnLeft.Size = new System.Drawing.Size(110, 48);
            this.BtnLeft.TabIndex = 33;
            this.BtnLeft.Text = "Cancelar";
            this.BtnLeft.UseVisualStyleBackColor = true;
            this.BtnLeft.Click += new System.EventHandler(this.BtnLeft_Click);
            // 
            // TbxBookId
            // 
            this.TbxBookId.Enabled = false;
            this.TbxBookId.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxBookId.Location = new System.Drawing.Point(211, 46);
            this.TbxBookId.Name = "TbxBookId";
            this.TbxBookId.Size = new System.Drawing.Size(79, 32);
            this.TbxBookId.TabIndex = 76;
            this.TbxBookId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxBookId_KeyPress);
            this.TbxBookId.Leave += new System.EventHandler(this.TbxBookId_Leave);
            // 
            // TbxBook
            // 
            this.TbxBook.Enabled = false;
            this.TbxBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxBook.Location = new System.Drawing.Point(296, 46);
            this.TbxBook.Name = "TbxBook";
            this.TbxBook.Size = new System.Drawing.Size(205, 32);
            this.TbxBook.TabIndex = 77;
            this.TbxBook.Leave += new System.EventHandler(this.TbxBook_Leave);
            // 
            // LblBook
            // 
            this.LblBook.AutoSize = true;
            this.LblBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBook.Location = new System.Drawing.Point(12, 49);
            this.LblBook.Name = "LblBook";
            this.LblBook.Size = new System.Drawing.Size(65, 26);
            this.LblBook.TabIndex = 78;
            this.LblBook.Text = "Livro:";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Location = new System.Drawing.Point(12, 91);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(130, 26);
            this.lbl.TabIndex = 80;
            this.lbl.Text = "Quantidade:";
            // 
            // LblQuantity
            // 
            this.LblQuantity.AutoSize = true;
            this.LblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblQuantity.Location = new System.Drawing.Point(206, 91);
            this.LblQuantity.Name = "LblQuantity";
            this.LblQuantity.Size = new System.Drawing.Size(143, 26);
            this.LblQuantity.TabIndex = 81;
            this.LblQuantity.Text = "_quantidade_";
            // 
            // FrmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 198);
            this.Controls.Add(this.LblQuantity);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.TbxBookId);
            this.Controls.Add(this.TbxBook);
            this.Controls.Add(this.LblBook);
            this.Controls.Add(this.BtnRight);
            this.Controls.Add(this.BtnLeft);
            this.Controls.Add(this.mstStock);
            this.Name = "FrmStock";
            this.Text = "Estoque";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmStock_FormClosing);
            this.mstStock.ResumeLayout(false);
            this.mstStock.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mstStock;
        private System.Windows.Forms.ToolStripMenuItem MstItemFind;
        private System.Windows.Forms.Button BtnRight;
        private System.Windows.Forms.Button BtnLeft;
        private System.Windows.Forms.TextBox TbxBookId;
        private System.Windows.Forms.TextBox TbxBook;
        private System.Windows.Forms.Label LblBook;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label LblQuantity;
    }
}