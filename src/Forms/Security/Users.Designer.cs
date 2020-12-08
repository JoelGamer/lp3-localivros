namespace TrabalhoLP3.Forms.Security
{
    partial class FrmUser
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
            this.mstUser = new System.Windows.Forms.MenuStrip();
            this.MstItemFind = new System.Windows.Forms.ToolStripMenuItem();
            this.MstItemCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.MstItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.MstItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.TbxUid = new System.Windows.Forms.TextBox();
            this.TbxName = new System.Windows.Forms.TextBox();
            this.BtnRight = new System.Windows.Forms.Button();
            this.BtnLeft = new System.Windows.Forms.Button();
            this.LblUid = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.LblNamePlaceholder = new System.Windows.Forms.Label();
            this.MtxtCPF = new System.Windows.Forms.MaskedTextBox();
            this.TbxUser = new System.Windows.Forms.TextBox();
            this.LblUser = new System.Windows.Forms.Label();
            this.LblUserPlaceholder = new System.Windows.Forms.Label();
            this.TbxPassword = new System.Windows.Forms.TextBox();
            this.LblPassword = new System.Windows.Forms.Label();
            this.LblPasswordPlaceholder = new System.Windows.Forms.Label();
            this.LblCPF = new System.Windows.Forms.Label();
            this.LblCpfPlaceholder = new System.Windows.Forms.Label();
            this.mstUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // mstUser
            // 
            this.mstUser.AllowMerge = false;
            this.mstUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MstItemFind,
            this.MstItemCreate,
            this.MstItemEdit,
            this.MstItemDelete});
            this.mstUser.Location = new System.Drawing.Point(0, 0);
            this.mstUser.Name = "mstUser";
            this.mstUser.Size = new System.Drawing.Size(384, 29);
            this.mstUser.TabIndex = 29;
            this.mstUser.Text = "menuStrip1";
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
            this.TbxUid.Location = new System.Drawing.Point(111, 46);
            this.TbxUid.Name = "TbxUid";
            this.TbxUid.Size = new System.Drawing.Size(262, 32);
            this.TbxUid.TabIndex = 30;
            this.TbxUid.Visible = false;
            // 
            // TbxName
            // 
            this.TbxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxName.Location = new System.Drawing.Point(111, 84);
            this.TbxName.Name = "TbxName";
            this.TbxName.Size = new System.Drawing.Size(262, 32);
            this.TbxName.TabIndex = 31;
            this.TbxName.Visible = false;
            // 
            // BtnRight
            // 
            this.BtnRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRight.Location = new System.Drawing.Point(263, 264);
            this.BtnRight.Name = "BtnRight";
            this.BtnRight.Size = new System.Drawing.Size(110, 48);
            this.BtnRight.TabIndex = 35;
            this.BtnRight.Text = "Próximo";
            this.BtnRight.UseVisualStyleBackColor = true;
            this.BtnRight.Click += new System.EventHandler(this.BtnRight_Click);
            // 
            // BtnLeft
            // 
            this.BtnLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLeft.Location = new System.Drawing.Point(17, 264);
            this.BtnLeft.Name = "BtnLeft";
            this.BtnLeft.Size = new System.Drawing.Size(110, 48);
            this.BtnLeft.TabIndex = 34;
            this.BtnLeft.Text = "Anterior";
            this.BtnLeft.UseVisualStyleBackColor = true;
            this.BtnLeft.Click += new System.EventHandler(this.BtnLeft_Click);
            // 
            // LblUid
            // 
            this.LblUid.AutoSize = true;
            this.LblUid.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUid.Location = new System.Drawing.Point(111, 51);
            this.LblUid.Name = "LblUid";
            this.LblUid.Size = new System.Drawing.Size(53, 26);
            this.LblUid.TabIndex = 39;
            this.LblUid.Text = "_id_";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 26);
            this.label5.TabIndex = 38;
            this.label5.Text = "ID:";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.Location = new System.Drawing.Point(111, 87);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(91, 26);
            this.LblName.TabIndex = 37;
            this.LblName.Text = "_name_";
            // 
            // LblNamePlaceholder
            // 
            this.LblNamePlaceholder.AutoSize = true;
            this.LblNamePlaceholder.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNamePlaceholder.Location = new System.Drawing.Point(12, 87);
            this.LblNamePlaceholder.Name = "LblNamePlaceholder";
            this.LblNamePlaceholder.Size = new System.Drawing.Size(77, 26);
            this.LblNamePlaceholder.TabIndex = 36;
            this.LblNamePlaceholder.Text = "Nome:";
            // 
            // MtxtCPF
            // 
            this.MtxtCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MtxtCPF.Location = new System.Drawing.Point(111, 123);
            this.MtxtCPF.Mask = "000,000,000-00";
            this.MtxtCPF.Name = "MtxtCPF";
            this.MtxtCPF.Size = new System.Drawing.Size(262, 32);
            this.MtxtCPF.TabIndex = 44;
            this.MtxtCPF.Visible = false;
            // 
            // TbxUser
            // 
            this.TbxUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxUser.Location = new System.Drawing.Point(111, 162);
            this.TbxUser.Name = "TbxUser";
            this.TbxUser.Size = new System.Drawing.Size(262, 32);
            this.TbxUser.TabIndex = 45;
            this.TbxUser.Visible = false;
            // 
            // LblUser
            // 
            this.LblUser.AutoSize = true;
            this.LblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUser.Location = new System.Drawing.Point(111, 165);
            this.LblUser.Name = "LblUser";
            this.LblUser.Size = new System.Drawing.Size(91, 26);
            this.LblUser.TabIndex = 47;
            this.LblUser.Text = "_name_";
            // 
            // LblUserPlaceholder
            // 
            this.LblUserPlaceholder.AutoSize = true;
            this.LblUserPlaceholder.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserPlaceholder.Location = new System.Drawing.Point(12, 165);
            this.LblUserPlaceholder.Name = "LblUserPlaceholder";
            this.LblUserPlaceholder.Size = new System.Drawing.Size(93, 26);
            this.LblUserPlaceholder.TabIndex = 46;
            this.LblUserPlaceholder.Text = "Usuário:";
            // 
            // TbxPassword
            // 
            this.TbxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxPassword.Location = new System.Drawing.Point(111, 205);
            this.TbxPassword.Name = "TbxPassword";
            this.TbxPassword.Size = new System.Drawing.Size(262, 32);
            this.TbxPassword.TabIndex = 48;
            this.TbxPassword.Visible = false;
            // 
            // LblPassword
            // 
            this.LblPassword.AutoSize = true;
            this.LblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPassword.Location = new System.Drawing.Point(111, 208);
            this.LblPassword.Name = "LblPassword";
            this.LblPassword.Size = new System.Drawing.Size(91, 26);
            this.LblPassword.TabIndex = 50;
            this.LblPassword.Text = "_name_";
            // 
            // LblPasswordPlaceholder
            // 
            this.LblPasswordPlaceholder.AutoSize = true;
            this.LblPasswordPlaceholder.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPasswordPlaceholder.Location = new System.Drawing.Point(12, 208);
            this.LblPasswordPlaceholder.Name = "LblPasswordPlaceholder";
            this.LblPasswordPlaceholder.Size = new System.Drawing.Size(81, 26);
            this.LblPasswordPlaceholder.TabIndex = 49;
            this.LblPasswordPlaceholder.Text = "Senha:";
            // 
            // LblCPF
            // 
            this.LblCPF.AutoSize = true;
            this.LblCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCPF.Location = new System.Drawing.Point(111, 126);
            this.LblCPF.Name = "LblCPF";
            this.LblCPF.Size = new System.Drawing.Size(65, 26);
            this.LblCPF.TabIndex = 51;
            this.LblCPF.Text = "_cpf_";
            // 
            // LblCpfPlaceholder
            // 
            this.LblCpfPlaceholder.AutoSize = true;
            this.LblCpfPlaceholder.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCpfPlaceholder.Location = new System.Drawing.Point(12, 126);
            this.LblCpfPlaceholder.Name = "LblCpfPlaceholder";
            this.LblCpfPlaceholder.Size = new System.Drawing.Size(62, 26);
            this.LblCpfPlaceholder.TabIndex = 52;
            this.LblCpfPlaceholder.Text = "CPF:";
            // 
            // FrmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 320);
            this.Controls.Add(this.LblCpfPlaceholder);
            this.Controls.Add(this.LblCPF);
            this.Controls.Add(this.TbxPassword);
            this.Controls.Add(this.LblPassword);
            this.Controls.Add(this.LblPasswordPlaceholder);
            this.Controls.Add(this.TbxUser);
            this.Controls.Add(this.LblUser);
            this.Controls.Add(this.LblUserPlaceholder);
            this.Controls.Add(this.MtxtCPF);
            this.Controls.Add(this.TbxUid);
            this.Controls.Add(this.TbxName);
            this.Controls.Add(this.BtnRight);
            this.Controls.Add(this.BtnLeft);
            this.Controls.Add(this.LblUid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.LblNamePlaceholder);
            this.Controls.Add(this.mstUser);
            this.Name = "FrmUser";
            this.Text = "Usuários";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmUser_FormClosing);
            this.mstUser.ResumeLayout(false);
            this.mstUser.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mstUser;
        private System.Windows.Forms.ToolStripMenuItem MstItemFind;
        private System.Windows.Forms.ToolStripMenuItem MstItemCreate;
        private System.Windows.Forms.ToolStripMenuItem MstItemEdit;
        private System.Windows.Forms.ToolStripMenuItem MstItemDelete;
        private System.Windows.Forms.TextBox TbxUid;
        private System.Windows.Forms.TextBox TbxName;
        private System.Windows.Forms.Button BtnRight;
        private System.Windows.Forms.Button BtnLeft;
        private System.Windows.Forms.Label LblUid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblNamePlaceholder;
        private System.Windows.Forms.MaskedTextBox MtxtCPF;
        private System.Windows.Forms.TextBox TbxUser;
        private System.Windows.Forms.Label LblUser;
        private System.Windows.Forms.Label LblUserPlaceholder;
        private System.Windows.Forms.TextBox TbxPassword;
        private System.Windows.Forms.Label LblPassword;
        private System.Windows.Forms.Label LblPasswordPlaceholder;
        private System.Windows.Forms.Label LblCPF;
        private System.Windows.Forms.Label LblCpfPlaceholder;
    }
}