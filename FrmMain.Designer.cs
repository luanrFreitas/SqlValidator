﻿namespace SqlValidator
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
            this.btnCompare = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbServer
            // 
            this.txbServer.Location = new System.Drawing.Point(482, 179);
            this.txbServer.Name = "txbServer";
            this.txbServer.Size = new System.Drawing.Size(138, 22);
            this.txbServer.TabIndex = 0;
            this.txbServer.Text = "localhost";
            this.txbServer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbDatabase
            // 
            this.txbDatabase.Location = new System.Drawing.Point(482, 224);
            this.txbDatabase.Name = "txbDatabase";
            this.txbDatabase.Size = new System.Drawing.Size(138, 22);
            this.txbDatabase.TabIndex = 1;
            this.txbDatabase.Text = "TactiumIP";
            this.txbDatabase.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txbUser
            // 
            this.txbUser.Location = new System.Drawing.Point(482, 272);
            this.txbUser.Name = "txbUser";
            this.txbUser.Size = new System.Drawing.Size(138, 22);
            this.txbUser.TabIndex = 2;
            this.txbUser.Text = "callback";
            this.txbUser.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(411, 179);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(58, 16);
            this.lblServer.TabIndex = 3;
            this.lblServer.Text = "Servidor";
            // 
            // lblDatabase
            // 
            this.lblDatabase.AutoSize = true;
            this.lblDatabase.Location = new System.Drawing.Point(362, 227);
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
            this.txbPassword.Location = new System.Drawing.Point(482, 326);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(138, 22);
            this.txbPassword.TabIndex = 7;
            this.txbPassword.Text = "softium";
            this.txbPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnCompare
            // 
            this.btnCompare.Location = new System.Drawing.Point(461, 385);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(182, 50);
            this.btnCompare.TabIndex = 8;
            this.btnCompare.Text = "Comparar";
            this.btnCompare.UseVisualStyleBackColor = true;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 662);
            this.Controls.Add(this.btnCompare);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblDatabase);
            this.Controls.Add(this.lblServer);
            this.Controls.Add(this.txbUser);
            this.Controls.Add(this.txbDatabase);
            this.Controls.Add(this.txbServer);
            this.Name = "FrmMain";
            this.Text = "Validação de tabelas do TactiumIP";
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
        private System.Windows.Forms.Button btnCompare;
    }
}

