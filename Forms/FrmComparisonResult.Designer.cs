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
            ((System.ComponentModel.ISupportInitialize)(this.dtgComparisonResult)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgComparisonResult
            // 
            this.dtgComparisonResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgComparisonResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgComparisonResult.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dtgComparisonResult.Location = new System.Drawing.Point(0, 127);
            this.dtgComparisonResult.Name = "dtgComparisonResult";
            this.dtgComparisonResult.RowHeadersWidth = 51;
            this.dtgComparisonResult.RowTemplate.Height = 24;
            this.dtgComparisonResult.Size = new System.Drawing.Size(878, 543);
            this.dtgComparisonResult.TabIndex = 0;
            // 
            // btnViewDatabaseModel
            // 
            this.btnViewDatabaseModel.Location = new System.Drawing.Point(88, 28);
            this.btnViewDatabaseModel.Name = "btnViewDatabaseModel";
            this.btnViewDatabaseModel.Size = new System.Drawing.Size(131, 33);
            this.btnViewDatabaseModel.TabIndex = 1;
            this.btnViewDatabaseModel.Text = "Base Modelo";
            this.btnViewDatabaseModel.UseVisualStyleBackColor = true;
            this.btnViewDatabaseModel.Click += new System.EventHandler(this.btnViewDatabaseModel_Click);
            // 
            // btnViewDatabaseConsulted
            // 
            this.btnViewDatabaseConsulted.Location = new System.Drawing.Point(245, 28);
            this.btnViewDatabaseConsulted.Name = "btnViewDatabaseConsulted";
            this.btnViewDatabaseConsulted.Size = new System.Drawing.Size(131, 33);
            this.btnViewDatabaseConsulted.TabIndex = 2;
            this.btnViewDatabaseConsulted.Text = "Base Consultada";
            this.btnViewDatabaseConsulted.UseVisualStyleBackColor = true;
            this.btnViewDatabaseConsulted.Click += new System.EventHandler(this.btnViewDatabaseConsulted_Click);
            // 
            // btnViewDiffDatabaseModel
            // 
            this.btnViewDiffDatabaseModel.Location = new System.Drawing.Point(425, 18);
            this.btnViewDiffDatabaseModel.Name = "btnViewDiffDatabaseModel";
            this.btnViewDiffDatabaseModel.Size = new System.Drawing.Size(138, 52);
            this.btnViewDiffDatabaseModel.TabIndex = 3;
            this.btnViewDiffDatabaseModel.Text = "Divergência Base Modelo";
            this.btnViewDiffDatabaseModel.UseVisualStyleBackColor = true;
            this.btnViewDiffDatabaseModel.Click += new System.EventHandler(this.btnViewDiffDatabaseModel_Click);
            // 
            // btnViewDiffDatabaseConsulted
            // 
            this.btnViewDiffDatabaseConsulted.Location = new System.Drawing.Point(627, 18);
            this.btnViewDiffDatabaseConsulted.Name = "btnViewDiffDatabaseConsulted";
            this.btnViewDiffDatabaseConsulted.Size = new System.Drawing.Size(138, 52);
            this.btnViewDiffDatabaseConsulted.TabIndex = 4;
            this.btnViewDiffDatabaseConsulted.Text = "Divergência Tabela Consultada";
            this.btnViewDiffDatabaseConsulted.UseVisualStyleBackColor = true;
            this.btnViewDiffDatabaseConsulted.Click += new System.EventHandler(this.btnViewDiffDatabaseConsulted_Click);
            // 
            // lblResultDetail
            // 
            this.lblResultDetail.AutoSize = true;
            this.lblResultDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultDetail.Location = new System.Drawing.Point(184, 82);
            this.lblResultDetail.Name = "lblResultDetail";
            this.lblResultDetail.Size = new System.Drawing.Size(66, 18);
            this.lblResultDetail.TabIndex = 5;
            this.lblResultDetail.Text = "Detalhes";
            // 
            // FrmComparisonResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 670);
            this.Controls.Add(this.lblResultDetail);
            this.Controls.Add(this.btnViewDiffDatabaseConsulted);
            this.Controls.Add(this.btnViewDiffDatabaseModel);
            this.Controls.Add(this.btnViewDatabaseConsulted);
            this.Controls.Add(this.btnViewDatabaseModel);
            this.Controls.Add(this.dtgComparisonResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
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
    }
}