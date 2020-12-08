namespace TrabalhoLP3.Forms.Library
{
    partial class FrmProvider
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
            this.mstProvider = new System.Windows.Forms.MenuStrip();
            this.MstItemFind = new System.Windows.Forms.ToolStripMenuItem();
            this.MstItemCreate = new System.Windows.Forms.ToolStripMenuItem();
            this.MstItemEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.MstItemDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TbxAddressNumber = new System.Windows.Forms.TextBox();
            this.LblAddressNumber = new System.Windows.Forms.Label();
            this.LblAddressNumberPlaceholder = new System.Windows.Forms.Label();
            this.TbxAddress = new System.Windows.Forms.TextBox();
            this.LblAddress = new System.Windows.Forms.Label();
            this.LblAddressPlaceholder = new System.Windows.Forms.Label();
            this.LblCNPJPlaceholder = new System.Windows.Forms.Label();
            this.LblCNPJ = new System.Windows.Forms.Label();
            this.MTbxCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.TbxUid = new System.Windows.Forms.TextBox();
            this.TbxName = new System.Windows.Forms.TextBox();
            this.BtnRight = new System.Windows.Forms.Button();
            this.BtnLeft = new System.Windows.Forms.Button();
            this.LblUid = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.LblNamePlaceholder = new System.Windows.Forms.Label();
            this.mstProvider.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mstProvider
            // 
            this.mstProvider.AllowMerge = false;
            this.mstProvider.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MstItemFind,
            this.MstItemCreate,
            this.MstItemEdit,
            this.MstItemDelete});
            this.mstProvider.Location = new System.Drawing.Point(0, 0);
            this.mstProvider.Name = "mstProvider";
            this.mstProvider.Size = new System.Drawing.Size(411, 29);
            this.mstProvider.TabIndex = 31;
            this.mstProvider.Text = "menuStrip1";
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TbxAddressNumber);
            this.groupBox1.Controls.Add(this.LblAddressNumber);
            this.groupBox1.Controls.Add(this.LblAddressNumberPlaceholder);
            this.groupBox1.Controls.Add(this.TbxAddress);
            this.groupBox1.Controls.Add(this.LblAddress);
            this.groupBox1.Controls.Add(this.LblAddressPlaceholder);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(17, 161);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(374, 120);
            this.groupBox1.TabIndex = 82;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Endereço";
            // 
            // TbxAddressNumber
            // 
            this.TbxAddressNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxAddressNumber.Location = new System.Drawing.Point(108, 79);
            this.TbxAddressNumber.MaxLength = 6;
            this.TbxAddressNumber.Name = "TbxAddressNumber";
            this.TbxAddressNumber.Size = new System.Drawing.Size(262, 32);
            this.TbxAddressNumber.TabIndex = 71;
            this.TbxAddressNumber.Visible = false;
            this.TbxAddressNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxAddressNumber_KeyPress);
            // 
            // LblAddressNumber
            // 
            this.LblAddressNumber.AutoSize = true;
            this.LblAddressNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAddressNumber.Location = new System.Drawing.Point(108, 82);
            this.LblAddressNumber.Name = "LblAddressNumber";
            this.LblAddressNumber.Size = new System.Drawing.Size(91, 26);
            this.LblAddressNumber.TabIndex = 73;
            this.LblAddressNumber.Text = "_name_";
            // 
            // LblAddressNumberPlaceholder
            // 
            this.LblAddressNumberPlaceholder.AutoSize = true;
            this.LblAddressNumberPlaceholder.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAddressNumberPlaceholder.Location = new System.Drawing.Point(6, 82);
            this.LblAddressNumberPlaceholder.Name = "LblAddressNumberPlaceholder";
            this.LblAddressNumberPlaceholder.Size = new System.Drawing.Size(96, 26);
            this.LblAddressNumberPlaceholder.TabIndex = 72;
            this.LblAddressNumberPlaceholder.Text = "Número:";
            // 
            // TbxAddress
            // 
            this.TbxAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxAddress.Location = new System.Drawing.Point(108, 36);
            this.TbxAddress.Name = "TbxAddress";
            this.TbxAddress.Size = new System.Drawing.Size(262, 32);
            this.TbxAddress.TabIndex = 68;
            this.TbxAddress.Visible = false;
            // 
            // LblAddress
            // 
            this.LblAddress.AutoSize = true;
            this.LblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAddress.Location = new System.Drawing.Point(108, 39);
            this.LblAddress.Name = "LblAddress";
            this.LblAddress.Size = new System.Drawing.Size(91, 26);
            this.LblAddress.TabIndex = 70;
            this.LblAddress.Text = "_name_";
            // 
            // LblAddressPlaceholder
            // 
            this.LblAddressPlaceholder.AutoSize = true;
            this.LblAddressPlaceholder.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAddressPlaceholder.Location = new System.Drawing.Point(6, 39);
            this.LblAddressPlaceholder.Name = "LblAddressPlaceholder";
            this.LblAddressPlaceholder.Size = new System.Drawing.Size(58, 26);
            this.LblAddressPlaceholder.TabIndex = 69;
            this.LblAddressPlaceholder.Text = "Rua:";
            // 
            // LblCNPJPlaceholder
            // 
            this.LblCNPJPlaceholder.AutoSize = true;
            this.LblCNPJPlaceholder.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCNPJPlaceholder.Location = new System.Drawing.Point(12, 126);
            this.LblCNPJPlaceholder.Name = "LblCNPJPlaceholder";
            this.LblCNPJPlaceholder.Size = new System.Drawing.Size(76, 26);
            this.LblCNPJPlaceholder.TabIndex = 81;
            this.LblCNPJPlaceholder.Text = "CNPJ:";
            // 
            // LblCNPJ
            // 
            this.LblCNPJ.AutoSize = true;
            this.LblCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCNPJ.Location = new System.Drawing.Point(129, 126);
            this.LblCNPJ.Name = "LblCNPJ";
            this.LblCNPJ.Size = new System.Drawing.Size(65, 26);
            this.LblCNPJ.TabIndex = 80;
            this.LblCNPJ.Text = "_cpf_";
            // 
            // MTbxCNPJ
            // 
            this.MTbxCNPJ.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MTbxCNPJ.Location = new System.Drawing.Point(129, 123);
            this.MTbxCNPJ.Mask = "00,000,000/0000-00";
            this.MTbxCNPJ.Name = "MTbxCNPJ";
            this.MTbxCNPJ.Size = new System.Drawing.Size(262, 32);
            this.MTbxCNPJ.TabIndex = 79;
            this.MTbxCNPJ.Visible = false;
            // 
            // TbxUid
            // 
            this.TbxUid.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxUid.Location = new System.Drawing.Point(129, 46);
            this.TbxUid.Name = "TbxUid";
            this.TbxUid.Size = new System.Drawing.Size(262, 32);
            this.TbxUid.TabIndex = 71;
            this.TbxUid.Visible = false;
            // 
            // TbxName
            // 
            this.TbxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxName.Location = new System.Drawing.Point(129, 84);
            this.TbxName.Name = "TbxName";
            this.TbxName.Size = new System.Drawing.Size(262, 32);
            this.TbxName.TabIndex = 72;
            this.TbxName.Visible = false;
            // 
            // BtnRight
            // 
            this.BtnRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnRight.Location = new System.Drawing.Point(281, 319);
            this.BtnRight.Name = "BtnRight";
            this.BtnRight.Size = new System.Drawing.Size(110, 48);
            this.BtnRight.TabIndex = 74;
            this.BtnRight.Text = "Próximo";
            this.BtnRight.UseVisualStyleBackColor = true;
            this.BtnRight.Click += new System.EventHandler(this.BtnRight_Click);
            // 
            // BtnLeft
            // 
            this.BtnLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLeft.Location = new System.Drawing.Point(17, 319);
            this.BtnLeft.Name = "BtnLeft";
            this.BtnLeft.Size = new System.Drawing.Size(110, 48);
            this.BtnLeft.TabIndex = 73;
            this.BtnLeft.Text = "Anterior";
            this.BtnLeft.UseVisualStyleBackColor = true;
            this.BtnLeft.Click += new System.EventHandler(this.BtnLeft_Click);
            // 
            // LblUid
            // 
            this.LblUid.AutoSize = true;
            this.LblUid.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUid.Location = new System.Drawing.Point(129, 51);
            this.LblUid.Name = "LblUid";
            this.LblUid.Size = new System.Drawing.Size(53, 26);
            this.LblUid.TabIndex = 78;
            this.LblUid.Text = "_id_";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 26);
            this.label5.TabIndex = 77;
            this.label5.Text = "ID:";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.Location = new System.Drawing.Point(129, 87);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(91, 26);
            this.LblName.TabIndex = 76;
            this.LblName.Text = "_name_";
            // 
            // LblNamePlaceholder
            // 
            this.LblNamePlaceholder.AutoSize = true;
            this.LblNamePlaceholder.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNamePlaceholder.Location = new System.Drawing.Point(12, 87);
            this.LblNamePlaceholder.Name = "LblNamePlaceholder";
            this.LblNamePlaceholder.Size = new System.Drawing.Size(77, 26);
            this.LblNamePlaceholder.TabIndex = 75;
            this.LblNamePlaceholder.Text = "Nome:";
            // 
            // FrmProvider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 378);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LblCNPJPlaceholder);
            this.Controls.Add(this.LblCNPJ);
            this.Controls.Add(this.MTbxCNPJ);
            this.Controls.Add(this.TbxUid);
            this.Controls.Add(this.TbxName);
            this.Controls.Add(this.BtnRight);
            this.Controls.Add(this.BtnLeft);
            this.Controls.Add(this.LblUid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LblName);
            this.Controls.Add(this.LblNamePlaceholder);
            this.Controls.Add(this.mstProvider);
            this.Name = "FrmProvider";
            this.Text = "Fornecedores";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmProvider_FormClosing);
            this.mstProvider.ResumeLayout(false);
            this.mstProvider.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mstProvider;
        private System.Windows.Forms.ToolStripMenuItem MstItemFind;
        private System.Windows.Forms.ToolStripMenuItem MstItemCreate;
        private System.Windows.Forms.ToolStripMenuItem MstItemEdit;
        private System.Windows.Forms.ToolStripMenuItem MstItemDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TbxAddressNumber;
        private System.Windows.Forms.Label LblAddressNumber;
        private System.Windows.Forms.Label LblAddressNumberPlaceholder;
        private System.Windows.Forms.TextBox TbxAddress;
        private System.Windows.Forms.Label LblAddress;
        private System.Windows.Forms.Label LblAddressPlaceholder;
        private System.Windows.Forms.Label LblCNPJPlaceholder;
        private System.Windows.Forms.Label LblCNPJ;
        private System.Windows.Forms.MaskedTextBox MTbxCNPJ;
        private System.Windows.Forms.TextBox TbxUid;
        private System.Windows.Forms.TextBox TbxName;
        private System.Windows.Forms.Button BtnRight;
        private System.Windows.Forms.Button BtnLeft;
        private System.Windows.Forms.Label LblUid;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblNamePlaceholder;
    }
}