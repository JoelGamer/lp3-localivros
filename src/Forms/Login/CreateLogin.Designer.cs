namespace TrabalhoLP3
{
    partial class FrmCreateLogin
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TbxName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TbxUsername = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TbxPassword = new System.Windows.Forms.TextBox();
            this.BtnCreateAccount = new System.Windows.Forms.Button();
            this.BtnVoltar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.MtxtCPF = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(107, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nova conta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 26);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nome";
            // 
            // TbxName
            // 
            this.TbxName.BackColor = System.Drawing.SystemColors.Window;
            this.TbxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxName.Location = new System.Drawing.Point(17, 98);
            this.TbxName.Name = "TbxName";
            this.TbxName.Size = new System.Drawing.Size(367, 32);
            this.TbxName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 26);
            this.label3.TabIndex = 7;
            this.label3.Text = "Usuário";
            // 
            // TbxUsername
            // 
            this.TbxUsername.BackColor = System.Drawing.SystemColors.Window;
            this.TbxUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxUsername.Location = new System.Drawing.Point(17, 262);
            this.TbxUsername.Name = "TbxUsername";
            this.TbxUsername.Size = new System.Drawing.Size(367, 32);
            this.TbxUsername.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 318);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 26);
            this.label4.TabIndex = 9;
            this.label4.Text = "Senha";
            // 
            // TbxPassword
            // 
            this.TbxPassword.BackColor = System.Drawing.SystemColors.Window;
            this.TbxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TbxPassword.Location = new System.Drawing.Point(17, 347);
            this.TbxPassword.Name = "TbxPassword";
            this.TbxPassword.PasswordChar = '*';
            this.TbxPassword.Size = new System.Drawing.Size(367, 32);
            this.TbxPassword.TabIndex = 4;
            this.TbxPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TbxPassword_KeyPress);
            // 
            // BtnCreateAccount
            // 
            this.BtnCreateAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreateAccount.Location = new System.Drawing.Point(255, 416);
            this.BtnCreateAccount.Name = "BtnCreateAccount";
            this.BtnCreateAccount.Size = new System.Drawing.Size(129, 34);
            this.BtnCreateAccount.TabIndex = 5;
            this.BtnCreateAccount.Text = "Criar conta";
            this.BtnCreateAccount.UseVisualStyleBackColor = true;
            this.BtnCreateAccount.Click += new System.EventHandler(this.BtnCreateAccount_Click);
            // 
            // BtnVoltar
            // 
            this.BtnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnVoltar.Location = new System.Drawing.Point(17, 416);
            this.BtnVoltar.Name = "BtnVoltar";
            this.BtnVoltar.Size = new System.Drawing.Size(129, 34);
            this.BtnVoltar.TabIndex = 6;
            this.BtnVoltar.Text = "Voltar";
            this.BtnVoltar.UseVisualStyleBackColor = true;
            this.BtnVoltar.Click += new System.EventHandler(this.BtnVoltar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 26);
            this.label5.TabIndex = 14;
            this.label5.Text = "CPF";
            // 
            // MtxtCPF
            // 
            this.MtxtCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MtxtCPF.Location = new System.Drawing.Point(17, 178);
            this.MtxtCPF.Mask = "000,000,000-00";
            this.MtxtCPF.Name = "MtxtCPF";
            this.MtxtCPF.Size = new System.Drawing.Size(367, 32);
            this.MtxtCPF.TabIndex = 2;
            this.MtxtCPF.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MtxtCPF_KeyPress);
            // 
            // FrmCreateLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 462);
            this.Controls.Add(this.MtxtCPF);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.BtnVoltar);
            this.Controls.Add(this.BtnCreateAccount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TbxPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TbxUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TbxName);
            this.Controls.Add(this.label2);
            this.Name = "FrmCreateLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova conta";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmCreateLogin_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TbxName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TbxUsername;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TbxPassword;
        private System.Windows.Forms.Button BtnCreateAccount;
        private System.Windows.Forms.Button BtnVoltar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox MtxtCPF;
    }
}