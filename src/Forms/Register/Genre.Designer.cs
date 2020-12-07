namespace TrabalhoLP3.Forms.Register
{
    partial class FrmGenre
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
            this.TbxUid = new System.Windows.Forms.TextBox();
            this.TbxName = new System.Windows.Forms.TextBox();
            this.BtnRight = new System.Windows.Forms.Button();
            this.BtnLeft = new System.Windows.Forms.Button();
            this.LblUid = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.LblNamePlaceholder = new System.Windows.Forms.Label();
            this.MstGenre = new System.Windows.Forms.MenuStrip();
            this.MstItemFind = new System.Windows.Forms.ToolStripMenuItem();
            this.MstItemCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.MstItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.MstItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.MstGenre.SuspendLayout();
            this.SuspendLayout();
            // 
            // TbxUid
            // 
            this.TbxUid.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxUid.Location = new System.Drawing.Point(155, 47);
            this.TbxUid.Name = "TbxUid";
            this.TbxUid.Size = new System.Drawing.Size(276, 32);
            this.TbxUid.TabIndex = 28;
            this.TbxUid.Visible = false;
            // 
            // TbxName
            // 
            this.TbxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxName.Location = new System.Drawing.Point(155, 85);
            this.TbxName.Name = "TbxName";
            this.TbxName.Size = new System.Drawing.Size(276, 32);
            this.TbxName.TabIndex = 29;
            this.TbxName.Visible = false;
            // 
            // BtnRight
            // 
            this.BtnRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRight.Location = new System.Drawing.Point(321, 162);
            this.BtnRight.Name = "BtnRight";
            this.BtnRight.Size = new System.Drawing.Size(110, 48);
            this.BtnRight.TabIndex = 33;
            this.BtnRight.Text = "Próximo";
            this.BtnRight.UseVisualStyleBackColor = true;
            this.BtnRight.Click += new System.EventHandler(this.BtnRight_Click);
            // 
            // BtnLeft
            // 
            this.BtnLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLeft.Location = new System.Drawing.Point(12, 162);
            this.BtnLeft.Name = "BtnLeft";
            this.BtnLeft.Size = new System.Drawing.Size(110, 48);
            this.BtnLeft.TabIndex = 32;
            this.BtnLeft.Text = "Anterior";
            this.BtnLeft.UseVisualStyleBackColor = true;
            this.BtnLeft.Click += new System.EventHandler(this.BtnLeft_Click);
            // 
            // LblUid
            // 
            this.LblUid.AutoSize = true;
            this.LblUid.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUid.Location = new System.Drawing.Point(155, 52);
            this.LblUid.Name = "LblUid";
            this.LblUid.Size = new System.Drawing.Size(53, 26);
            this.LblUid.TabIndex = 37;
            this.LblUid.Text = "_id_";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 26);
            this.label5.TabIndex = 36;
            this.label5.Text = "ID:";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.Location = new System.Drawing.Point(155, 88);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(91, 26);
            this.LblName.TabIndex = 35;
            this.LblName.Text = "_name_";
            // 
            // LblNamePlaceholder
            // 
            this.LblNamePlaceholder.AutoSize = true;
            this.LblNamePlaceholder.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNamePlaceholder.Location = new System.Drawing.Point(12, 88);
            this.LblNamePlaceholder.Name = "LblNamePlaceholder";
            this.LblNamePlaceholder.Size = new System.Drawing.Size(77, 26);
            this.LblNamePlaceholder.TabIndex = 34;
            this.LblNamePlaceholder.Text = "Nome:";
            // 
            // MstGenre
            // 
            this.MstGenre.AllowMerge = false;
            this.MstGenre.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MstItemFind,
            this.MstItemCreate,
            this.MstItemEdit,
            this.MstItemDelete});
            this.MstGenre.Location = new System.Drawing.Point(0, 0);
            this.MstGenre.Name = "MstGenre";
            this.MstGenre.Size = new System.Drawing.Size(443, 29);
            this.MstGenre.TabIndex = 42;
            this.MstGenre.Text = "menuStrip1";
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
            // FrmGenre
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 222);
            this.Controls.Add(this.MstGenre);
            this.Controls.Add(this.TbxUid);
            this.Controls.Add(this.TbxName);
            this.Controls.Add(this.BtnRight);
            this.Controls.Add(this.BtnLeft);
            this.Controls.Add(this.LblUid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.LblNamePlaceholder);
            this.Name = "FrmGenre";
            this.Text = "Gênero";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmGenre_FormClosing);
            this.MstGenre.ResumeLayout(false);
            this.MstGenre.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TbxUid;
        private System.Windows.Forms.TextBox TbxName;
        private System.Windows.Forms.Button BtnRight;
        private System.Windows.Forms.Button BtnLeft;
        private System.Windows.Forms.Label LblUid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblNamePlaceholder;
        private System.Windows.Forms.MenuStrip MstGenre;
        private System.Windows.Forms.ToolStripMenuItem MstItemFind;
        private System.Windows.Forms.ToolStripMenuItem MstItemCreate;
        private System.Windows.Forms.ToolStripMenuItem MstItemEdit;
        private System.Windows.Forms.ToolStripMenuItem MstItemDelete;
    }
}