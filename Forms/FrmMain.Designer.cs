namespace SqlValidator.Forms
{
    partial class FrmMain
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
            this.txbServer = new System.Windows.Forms.TextBox();
            this.txbDatabase = new System.Windows.Forms.TextBox();
            this.txbUser = new System.Windows.Forms.TextBox();
            this.lblServer = new System.Windows.Forms.Label();
            this.lblDatabase = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.btnCompareColumns = new System.Windows.Forms.Button();
            this.lblCredentials = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.btnCompareIndexes = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbProduct = new System.Windows.Forms.ComboBox();
            this.lblProduct = new System.Windows.Forms.Label();
            this.atualizarBaseDeReferênciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbServer
            // 
            this.txbServer.Location = new System.Drawing.Point(483, 178);
            this.txbServer.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbServer.Name = "txbServer";
            this.txbServer.Size = new System.Drawing.Size(137, 22);
            this.txbServer.TabIndex = 0;
            this.txbServer.Text = "localhost";
            this.txbServer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbDatabase
            // 
            this.txbDatabase.Location = new System.Drawing.Point(483, 224);
            this.txbDatabase.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbDatabase.Name = "txbDatabase";
            this.txbDatabase.Size = new System.Drawing.Size(137, 22);
            this.txbDatabase.TabIndex = 1;
            this.txbDatabase.Text = "TactiumIP";
            this.txbDatabase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbUser
            // 
            this.txbUser.Location = new System.Drawing.Point(483, 272);
            this.txbUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbUser.Name = "txbUser";
            this.txbUser.Size = new System.Drawing.Size(137, 22);
            this.txbUser.TabIndex = 2;
            this.txbUser.Text = "callback";
            this.txbUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(411, 178);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(58, 16);
            this.lblServer.TabIndex = 3;
            this.lblServer.Text = "Servidor";
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.Location = new System.Drawing.Point(363, 226);
            this.lblDatabase.Name = "lblDatabase";
            this.lblDatabase.Size = new System.Drawing.Size(107, 16);
            this.lblDatabase.TabIndex = 4;
            this.lblDatabase.Text = "Banco de dados";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(423, 326);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(46, 16);
            this.lblPassword.TabIndex = 5;
            this.lblPassword.Text = "Senha";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(415, 278);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(54, 16);
            this.lblUser.TabIndex = 6;
            this.lblUser.Text = "Usuário";
            // 
            // txbPassword
            // 
            this.txbPassword.Location = new System.Drawing.Point(483, 326);
            this.txbPassword.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(137, 22);
            this.txbPassword.TabIndex = 7;
            this.txbPassword.Text = "softium";
            this.txbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCompareColumns
            // 
            this.btnCompareColumns.Location = new System.Drawing.Point(336, 452);
            this.btnCompareColumns.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCompareColumns.Name = "btnCompareColumns";
            this.btnCompareColumns.Size = new System.Drawing.Size(181, 50);
            this.btnCompareColumns.TabIndex = 8;
            this.btnCompareColumns.Text = "Comparar Colunas";
            this.btnCompareColumns.UseVisualStyleBackColor = true;
            this.btnCompareColumns.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // lblCredentials
            // 
            this.lblCredentials.AutoSize = true;
            this.lblCredentials.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCredentials.Location = new System.Drawing.Point(335, 106);
            this.lblCredentials.Name = "lblCredentials";
            this.lblCredentials.Size = new System.Drawing.Size(445, 29);
            this.lblCredentials.TabIndex = 9;
            this.lblCredentials.Text = "Insira as credenciais do banco de dados";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Location = new System.Drawing.Point(455, 523);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(177, 29);
            this.lblStatus.TabIndex = 10;
            this.lblStatus.Text = "Comparando ...";
            // 
            // btnCompareIndexes
            // 
            this.btnCompareIndexes.Location = new System.Drawing.Point(577, 452);
            this.btnCompareIndexes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCompareIndexes.Name = "btnCompareIndexes";
            this.btnCompareIndexes.Size = new System.Drawing.Size(181, 50);
            this.btnCompareIndexes.TabIndex = 11;
            this.btnCompareIndexes.Text = "Comparar Índices";
            this.btnCompareIndexes.UseVisualStyleBackColor = true;
            this.btnCompareIndexes.Click += new System.EventHandler(this.btnCompareIndexes_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1143, 28);
            this.menuStrip1.TabIndex = 12;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.atualizarBaseDeReferênciaToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.optionsToolStripMenuItem.Text = "Opções";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(117, 26);
            this.exitToolStripMenuItem.Text = "Sair";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.helpToolStripMenuItem.Text = "Ajuda";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(131, 26);
            this.aboutToolStripMenuItem.Text = "Sobre";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // cmbProduct
            // 
            this.cmbProduct.FormattingEnabled = true;
            this.cmbProduct.Items.AddRange(new object[] {
            "TactiumIP",
            "Manager"});
            this.cmbProduct.Location = new System.Drawing.Point(483, 382);
            this.cmbProduct.Name = "cmbProduct";
            this.cmbProduct.Size = new System.Drawing.Size(121, 24);
            this.cmbProduct.TabIndex = 13;
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Location = new System.Drawing.Point(416, 385);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(54, 16);
            this.lblProduct.TabIndex = 14;
            this.lblProduct.Text = "Produto";
            // 
            // atualizarBaseDeReferênciaToolStripMenuItem
            // 
            this.atualizarBaseDeReferênciaToolStripMenuItem.Name = "atualizarBaseDeReferênciaToolStripMenuItem";
            this.atualizarBaseDeReferênciaToolStripMenuItem.Size = new System.Drawing.Size(277, 26);
            this.atualizarBaseDeReferênciaToolStripMenuItem.Text = "Atualizar base de referência";
            this.atualizarBaseDeReferênciaToolStripMenuItem.Click += new System.EventHandler(this.atualizarBaseDeReferênciaToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 662);
            this.Controls.Add(this.lblProduct);
            this.Controls.Add(this.cmbProduct);
            this.Controls.Add(this.btnCompareIndexes);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblCredentials);
            this.Controls.Add(this.btnCompareColumns);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblDatabase);
            this.Controls.Add(this.lblServer);
            this.Controls.Add(this.txbUser);
            this.Controls.Add(this.txbDatabase);
            this.Controls.Add(this.txbServer);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FrmMain";
            this.Text = "Validação de tabelas do TactiumIP";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbServer;
        private System.Windows.Forms.TextBox txbDatabase;
        private System.Windows.Forms.TextBox txbUser;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.Label lblDatabase;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txbPassword;
        private System.Windows.Forms.Button btnCompareColumns;
        private System.Windows.Forms.Label lblCredentials;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Button btnCompareIndexes;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbProduct;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.ToolStripMenuItem atualizarBaseDeReferênciaToolStripMenuItem;
    }
}

