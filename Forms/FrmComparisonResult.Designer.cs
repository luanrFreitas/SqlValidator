namespace SqlValidator.Forms
{
    partial class FrmComparisonResult
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
            this.dtgComparisonResult = new System.Windows.Forms.DataGridView();
            this.btnViewDatabaseModel = new System.Windows.Forms.Button();
            this.btnViewDatabaseConsulted = new System.Windows.Forms.Button();
            this.btnViewDiffDatabaseModel = new System.Windows.Forms.Button();
            this.btnViewDiffDatabaseConsulted = new System.Windows.Forms.Button();
            this.lblResultDetail = new System.Windows.Forms.Label();
            this.btnDownloadDiffs = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblModelVersion = new System.Windows.Forms.Label();
            this.lblDBVersion = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblModelCollate = new System.Windows.Forms.Label();
            this.lblDBCollate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtgComparisonResult)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgComparisonResult
            // 
            this.dtgComparisonResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgComparisonResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgComparisonResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgComparisonResult.Location = new System.Drawing.Point(0, 206);
            this.dtgComparisonResult.Margin = new System.Windows.Forms.Padding(2);
            this.dtgComparisonResult.Name = "dtgComparisonResult";
            this.dtgComparisonResult.RowHeadersWidth = 51;
            this.dtgComparisonResult.RowTemplate.Height = 24;
            this.dtgComparisonResult.Size = new System.Drawing.Size(626, 614);
            this.dtgComparisonResult.TabIndex = 0;
            // 
            // btnViewDatabaseModel
            // 
            this.btnViewDatabaseModel.Location = new System.Drawing.Point(66, 18);
            this.btnViewDatabaseModel.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewDatabaseModel.Name = "btnViewDatabaseModel";
            this.btnViewDatabaseModel.Size = new System.Drawing.Size(98, 27);
            this.btnViewDatabaseModel.TabIndex = 1;
            this.btnViewDatabaseModel.Text = "Base Modelo";
            this.btnViewDatabaseModel.UseVisualStyleBackColor = true;
            this.btnViewDatabaseModel.Click += new System.EventHandler(this.btnViewDatabaseModel_Click);
            // 
            // btnViewDatabaseConsulted
            // 
            this.btnViewDatabaseConsulted.Location = new System.Drawing.Point(184, 18);
            this.btnViewDatabaseConsulted.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewDatabaseConsulted.Name = "btnViewDatabaseConsulted";
            this.btnViewDatabaseConsulted.Size = new System.Drawing.Size(98, 27);
            this.btnViewDatabaseConsulted.TabIndex = 2;
            this.btnViewDatabaseConsulted.Text = "Base Consultada";
            this.btnViewDatabaseConsulted.UseVisualStyleBackColor = true;
            this.btnViewDatabaseConsulted.Click += new System.EventHandler(this.btnViewDatabaseConsulted_Click);
            // 
            // btnViewDiffDatabaseModel
            // 
            this.btnViewDiffDatabaseModel.Location = new System.Drawing.Point(319, 10);
            this.btnViewDiffDatabaseModel.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewDiffDatabaseModel.Name = "btnViewDiffDatabaseModel";
            this.btnViewDiffDatabaseModel.Size = new System.Drawing.Size(104, 42);
            this.btnViewDiffDatabaseModel.TabIndex = 3;
            this.btnViewDiffDatabaseModel.Text = "Divergência Base Modelo";
            this.btnViewDiffDatabaseModel.UseVisualStyleBackColor = true;
            this.btnViewDiffDatabaseModel.Click += new System.EventHandler(this.btnViewDiffDatabaseModel_Click);
            // 
            // btnViewDiffDatabaseConsulted
            // 
            this.btnViewDiffDatabaseConsulted.Location = new System.Drawing.Point(470, 10);
            this.btnViewDiffDatabaseConsulted.Margin = new System.Windows.Forms.Padding(2);
            this.btnViewDiffDatabaseConsulted.Name = "btnViewDiffDatabaseConsulted";
            this.btnViewDiffDatabaseConsulted.Size = new System.Drawing.Size(104, 42);
            this.btnViewDiffDatabaseConsulted.TabIndex = 4;
            this.btnViewDiffDatabaseConsulted.Text = "Divergência Tabela Consultada";
            this.btnViewDiffDatabaseConsulted.UseVisualStyleBackColor = true;
            this.btnViewDiffDatabaseConsulted.Click += new System.EventHandler(this.btnViewDiffDatabaseConsulted_Click);
            // 
            // lblResultDetail
            // 
            this.lblResultDetail.AutoSize = true;
            this.lblResultDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultDetail.Location = new System.Drawing.Point(138, 64);
            this.lblResultDetail.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResultDetail.Name = "lblResultDetail";
            this.lblResultDetail.Size = new System.Drawing.Size(56, 15);
            this.lblResultDetail.TabIndex = 5;
            this.lblResultDetail.Text = "Detalhes";
            // 
            // btnDownloadDiffs
            // 
            this.btnDownloadDiffs.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownloadDiffs.Location = new System.Drawing.Point(218, 121);
            this.btnDownloadDiffs.Name = "btnDownloadDiffs";
            this.btnDownloadDiffs.Size = new System.Drawing.Size(141, 43);
            this.btnDownloadDiffs.TabIndex = 6;
            this.btnDownloadDiffs.Text = "Baixar Divergências";
            this.btnDownloadDiffs.UseVisualStyleBackColor = true;
            this.btnDownloadDiffs.Click += new System.EventHandler(this.btnDownloadDiffs_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 104);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Versão da base modelo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(363, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "Versão da base consultada:";
            // 
            // lblModelVersion
            // 
            this.lblModelVersion.AutoSize = true;
            this.lblModelVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelVersion.Location = new System.Drawing.Point(169, 104);
            this.lblModelVersion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModelVersion.Name = "lblModelVersion";
            this.lblModelVersion.Size = new System.Drawing.Size(44, 18);
            this.lblModelVersion.TabIndex = 9;
            this.lblModelVersion.Text = "176.0";
            // 
            // lblDBVersion
            // 
            this.lblDBVersion.AutoSize = true;
            this.lblDBVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDBVersion.Location = new System.Drawing.Point(553, 104);
            this.lblDBVersion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDBVersion.Name = "lblDBVersion";
            this.lblDBVersion.Size = new System.Drawing.Size(44, 18);
            this.lblDBVersion.TabIndex = 10;
            this.lblDBVersion.Text = "176.0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(19, 136);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(180, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Collation da base modelo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(389, 136);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(202, 18);
            this.label6.TabIndex = 12;
            this.label6.Text = "Collation da base consultada:";
            // 
            // lblModelCollate
            // 
            this.lblModelCollate.AutoSize = true;
            this.lblModelCollate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModelCollate.Location = new System.Drawing.Point(7, 167);
            this.lblModelCollate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblModelCollate.Name = "lblModelCollate";
            this.lblModelCollate.Size = new System.Drawing.Size(231, 18);
            this.lblModelCollate.TabIndex = 13;
            this.lblModelCollate.Text = "SQL_Latin1_General_CP1_CI_AS";
            // 
            // lblDBCollate
            // 
            this.lblDBCollate.AutoSize = true;
            this.lblDBCollate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDBCollate.Location = new System.Drawing.Point(366, 167);
            this.lblDBCollate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDBCollate.Name = "lblDBCollate";
            this.lblDBCollate.Size = new System.Drawing.Size(231, 18);
            this.lblDBCollate.TabIndex = 14;
            this.lblDBCollate.Text = "SQL_Latin1_General_CP1_CI_AS";
            // 
            // FrmComparisonResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 820);
            this.Controls.Add(this.lblDBCollate);
            this.Controls.Add(this.lblModelCollate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblDBVersion);
            this.Controls.Add(this.lblModelVersion);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDownloadDiffs);
            this.Controls.Add(this.lblResultDetail);
            this.Controls.Add(this.btnViewDiffDatabaseConsulted);
            this.Controls.Add(this.btnViewDiffDatabaseModel);
            this.Controls.Add(this.btnViewDatabaseConsulted);
            this.Controls.Add(this.btnViewDatabaseModel);
            this.Controls.Add(this.dtgComparisonResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.Name = "FrmComparisonResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmComparisonResult";
            this.Load += new System.EventHandler(this.FrmComparisonResult_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgComparisonResult)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgComparisonResult;
        private System.Windows.Forms.Button btnViewDatabaseModel;
        private System.Windows.Forms.Button btnViewDatabaseConsulted;
        private System.Windows.Forms.Button btnViewDiffDatabaseModel;
        private System.Windows.Forms.Button btnViewDiffDatabaseConsulted;
        private System.Windows.Forms.Label lblResultDetail;
        private System.Windows.Forms.Button btnDownloadDiffs;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblModelVersion;
        private System.Windows.Forms.Label lblDBVersion;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblModelCollate;
        private System.Windows.Forms.Label lblDBCollate;
    }
}