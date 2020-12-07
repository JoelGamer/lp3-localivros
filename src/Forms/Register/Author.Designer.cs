namespace TrabalhoLP3.Forms.Register
{
    partial class FrmAuthor
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
            this.LblUid = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.LblNamePlaceholder = new System.Windows.Forms.Label();
            this.BtnRight = new System.Windows.Forms.Button();
            this.BtnLeft = new System.Windows.Forms.Button();
            this.LblDeathDate = new System.Windows.Forms.Label();
            this.LblDeathDatePlaceholder = new System.Windows.Forms.Label();
            this.LblBirthDate = new System.Windows.Forms.Label();
            this.LblBirthDatePlaceholder = new System.Windows.Forms.Label();
            this.mstAuthor = new System.Windows.Forms.MenuStrip();
            this.MstItemFind = new System.Windows.Forms.ToolStripMenuItem();
            this.MstItemCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.MstItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.MstItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.MtxtDeathDate = new System.Windows.Forms.MaskedTextBox();
            this.MtxtBirthDate = new System.Windows.Forms.MaskedTextBox();
            this.TbxName = new System.Windows.Forms.TextBox();
            this.TbxUid = new System.Windows.Forms.TextBox();
            this.mstAuthor.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblUid
            // 
            this.LblUid.AutoSize = true;
            this.LblUid.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUid.Location = new System.Drawing.Point(155, 50);
            this.LblUid.Name = "LblUid";
            this.LblUid.Size = new System.Drawing.Size(53, 26);
            this.LblUid.TabIndex = 21;
            this.LblUid.Text = "_id_";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 26);
            this.label5.TabIndex = 20;
            this.label5.Text = "ID:";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.Location = new System.Drawing.Point(155, 86);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(91, 26);
            this.LblName.TabIndex = 19;
            this.LblName.Text = "_name_";
            // 
            // LblNamePlaceholder
            // 
            this.LblNamePlaceholder.AutoSize = true;
            this.LblNamePlaceholder.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNamePlaceholder.Location = new System.Drawing.Point(12, 86);
            this.LblNamePlaceholder.Name = "LblNamePlaceholder";
            this.LblNamePlaceholder.Size = new System.Drawing.Size(77, 26);
            this.LblNamePlaceholder.TabIndex = 18;
            this.LblNamePlaceholder.Text = "Nome:";
            // 
            // BtnRight
            // 
            this.BtnRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRight.Location = new System.Drawing.Point(307, 212);
            this.BtnRight.Name = "BtnRight";
            this.BtnRight.Size = new System.Drawing.Size(110, 48);
            this.BtnRight.TabIndex = 5;
            this.BtnRight.Text = "Próximo";
            this.BtnRight.UseVisualStyleBackColor = true;
            this.BtnRight.Click += new System.EventHandler(this.BtnRight_Click);
            // 
            // BtnLeft
            // 
            this.BtnLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLeft.Location = new System.Drawing.Point(12, 212);
            this.BtnLeft.Name = "BtnLeft";
            this.BtnLeft.Size = new System.Drawing.Size(110, 48);
            this.BtnLeft.TabIndex = 4;
            this.BtnLeft.Text = "Anterior";
            this.BtnLeft.UseVisualStyleBackColor = true;
            this.BtnLeft.Click += new System.EventHandler(this.BtnLeft_Click);
            // 
            // LblDeathDate
            // 
            this.LblDeathDate.AutoSize = true;
            this.LblDeathDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDeathDate.Location = new System.Drawing.Point(155, 159);
            this.LblDeathDate.Name = "LblDeathDate";
            this.LblDeathDate.Size = new System.Drawing.Size(139, 26);
            this.LblDeathDate.TabIndex = 25;
            this.LblDeathDate.Text = "_death-date_";
            // 
            // LblDeathDatePlaceholder
            // 
            this.LblDeathDatePlaceholder.AutoSize = true;
            this.LblDeathDatePlaceholder.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDeathDatePlaceholder.Location = new System.Drawing.Point(12, 159);
            this.LblDeathDatePlaceholder.Name = "LblDeathDatePlaceholder";
            this.LblDeathDatePlaceholder.Size = new System.Drawing.Size(137, 26);
            this.LblDeathDatePlaceholder.TabIndex = 24;
            this.LblDeathDatePlaceholder.Text = "Falecimento:";
            // 
            // LblBirthDate
            // 
            this.LblBirthDate.AutoSize = true;
            this.LblBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBirthDate.Location = new System.Drawing.Point(155, 122);
            this.LblBirthDate.Name = "LblBirthDate";
            this.LblBirthDate.Size = new System.Drawing.Size(127, 26);
            this.LblBirthDate.TabIndex = 27;
            this.LblBirthDate.Text = "_birth-date_";
            // 
            // LblBirthDatePlaceholder
            // 
            this.LblBirthDatePlaceholder.AutoSize = true;
            this.LblBirthDatePlaceholder.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBirthDatePlaceholder.Location = new System.Drawing.Point(12, 122);
            this.LblBirthDatePlaceholder.Name = "LblBirthDatePlaceholder";
            this.LblBirthDatePlaceholder.Size = new System.Drawing.Size(134, 26);
            this.LblBirthDatePlaceholder.TabIndex = 26;
            this.LblBirthDatePlaceholder.Text = "Nascimento:";
            // 
            // mstAuthor
            // 
            this.mstAuthor.AllowMerge = false;
            this.mstAuthor.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MstItemFind,
            this.MstItemCreate,
            this.MstItemEdit,
            this.MstItemDelete});
            this.mstAuthor.Location = new System.Drawing.Point(0, 0);
            this.mstAuthor.Name = "mstAuthor";
            this.mstAuthor.Size = new System.Drawing.Size(429, 29);
            this.mstAuthor.TabIndex = 28;
            this.mstAuthor.Text = "menuStrip1";
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
            // MtxtDeathDate
            // 
            this.MtxtDeathDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MtxtDeathDate.Location = new System.Drawing.Point(155, 156);
            this.MtxtDeathDate.Mask = "00/00/0000";
            this.MtxtDeathDate.Name = "MtxtDeathDate";
            this.MtxtDeathDate.Size = new System.Drawing.Size(120, 32);
            this.MtxtDeathDate.TabIndex = 4;
            this.MtxtDeathDate.ValidatingType = typeof(System.DateTime);
            this.MtxtDeathDate.Visible = false;
            // 
            // MtxtBirthDate
            // 
            this.MtxtBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MtxtBirthDate.Location = new System.Drawing.Point(155, 119);
            this.MtxtBirthDate.Mask = "00/00/0000";
            this.MtxtBirthDate.Name = "MtxtBirthDate";
            this.MtxtBirthDate.Size = new System.Drawing.Size(120, 32);
            this.MtxtBirthDate.TabIndex = 3;
            this.MtxtBirthDate.ValidatingType = typeof(System.DateTime);
            this.MtxtBirthDate.Visible = false;
            // 
            // TbxName
            // 
            this.TbxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxName.Location = new System.Drawing.Point(155, 83);
            this.TbxName.Name = "TbxName";
            this.TbxName.Size = new System.Drawing.Size(231, 32);
            this.TbxName.TabIndex = 2;
            this.TbxName.Visible = false;
            // 
            // TbxUid
            // 
            this.TbxUid.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxUid.Location = new System.Drawing.Point(155, 45);
            this.TbxUid.Name = "TbxUid";
            this.TbxUid.Size = new System.Drawing.Size(231, 32);
            this.TbxUid.TabIndex = 1;
            this.TbxUid.Visible = false;
            // 
            // FrmAuthor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 272);
            this.Controls.Add(this.TbxUid);
            this.Controls.Add(this.TbxName);
            this.Controls.Add(this.MtxtBirthDate);
            this.Controls.Add(this.MtxtDeathDate);
            this.Controls.Add(this.LblBirthDate);
            this.Controls.Add(this.LblBirthDatePlaceholder);
            this.Controls.Add(this.LblDeathDate);
            this.Controls.Add(this.LblDeathDatePlaceholder);
            this.Controls.Add(this.BtnRight);
            this.Controls.Add(this.BtnLeft);
            this.Controls.Add(this.LblUid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.LblNamePlaceholder);
            this.Controls.Add(this.mstAuthor);
            this.MainMenuStrip = this.mstAuthor;
            this.Name = "FrmAuthor";
            this.Text = "Autores";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmAuthor_FormClosing);
            this.mstAuthor.ResumeLayout(false);
            this.mstAuthor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblUid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblNamePlaceholder;
        private System.Windows.Forms.Button BtnRight;
        private System.Windows.Forms.Button BtnLeft;
        private System.Windows.Forms.Label LblDeathDate;
        private System.Windows.Forms.Label LblDeathDatePlaceholder;
        private System.Windows.Forms.Label LblBirthDate;
        private System.Windows.Forms.Label LblBirthDatePlaceholder;
        private System.Windows.Forms.MenuStrip mstAuthor;
        private System.Windows.Forms.ToolStripMenuItem MstItemCreate;
        private System.Windows.Forms.ToolStripMenuItem MstItemEdit;
        private System.Windows.Forms.ToolStripMenuItem MstItemDelete;
        private System.Windows.Forms.MaskedTextBox MtxtDeathDate;
        private System.Windows.Forms.MaskedTextBox MtxtBirthDate;
        private System.Windows.Forms.TextBox TbxName;
        private System.Windows.Forms.ToolStripMenuItem MstItemFind;
        private System.Windows.Forms.TextBox TbxUid;
    }
}