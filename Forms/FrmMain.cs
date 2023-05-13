using SqlValidator.Models;
using SqlValidator.Services;
using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace SqlValidator.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            lblStatus.Visible = false;
            cmbProduct.SelectedIndex= 0;
            cmbProduct.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            lblStatus.Visible = true;
            lblStatus.Text = "Comparando ...";
            btnCompareColumns.Enabled = false;
            btnCompareIndexes.Enabled = false;
            lblStatus.Refresh();


            SqlServices sqlServices = new SqlServices(txbServer.Text, txbDatabase.Text, txbUser.Text, txbPassword.Text);
            SqliteServices sqliteServices = new SqliteServices();
            ComparerServices comparerServices = new ComparerServices();
            List<Column> columns = sqlServices.GetColumns();
            columns.Sort(new ColumnsComparer());
            Dictionary<string, string> parameters = sqlServices.GetParameters();
            string product = cmbProduct.SelectedItem.ToString();
            //sqliteServices.SaveColumns(columns, product);
            //parameters.Add("product", product);
            //sqliteServices.SaveParameters(parameters);

            List<Column> template = sqliteServices.LoadColumns(cmbProduct.SelectedItem.ToString());
            template.Sort(new ColumnsComparer());

            List<Column> notInDB , notInTemplate;
            comparerServices.CompareColumn(columns,template, out notInDB,out notInTemplate);

            FrmComparisonResult frmComparisonResult = new FrmComparisonResult(template, columns, notInDB, notInTemplate, sqlServices, sqliteServices, product);
            lblStatus.Visible = false;
            btnCompareColumns.Enabled = true;
            btnCompareIndexes.Enabled = true;
            lblStatus.Refresh();
            frmComparisonResult.ShowDialog();

        }

        private void btnCompareIndexes_Click(object sender, EventArgs e)
        {
            lblStatus.Visible = true;
            lblStatus.Text = "Comparando ...";

            btnCompareColumns.Enabled = false;
            btnCompareIndexes.Enabled = false;
            lblStatus.Refresh();

            SqlServices sqlServices = new SqlServices(txbServer.Text, txbDatabase.Text, txbUser.Text, txbPassword.Text);
            SqliteServices sqliteServices = new SqliteServices();
            ComparerServices comparerServices = new ComparerServices();
            List<Index> indexes = sqlServices.GetIndexes();
            indexes.Sort(new IndexesComparer());
            string product = cmbProduct.SelectedItem.ToString();

           // sqliteServices.SaveIndexes(indexes, product);
            


            List<Index> template = sqliteServices.LoadIndexes();
            template.Sort(new IndexesComparer());

            List<Index> notInDB, notInTemplate;
            comparerServices.CompareIndex(indexes, template, out notInDB, out notInTemplate);

            FrmComparisonResult frmComparisonResult = new FrmComparisonResult(template, indexes, notInDB, notInTemplate, sqlServices, sqliteServices, product);
            lblStatus.Visible = false;
            btnCompareColumns.Enabled = true;
            btnCompareIndexes.Enabled = true;

            frmComparisonResult.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmHelp frmHelp = new frmHelp();
            frmHelp.ShowDialog();
        }

        private void atualizarBaseDeReferênciaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblStatus.Text = "Atualizando ...";
            lblStatus.Visible = true;

            btnCompareColumns.Enabled = false;
            btnCompareIndexes.Enabled = false;
            lblStatus.Refresh();

            SqlServices sqlServices = new SqlServices(txbServer.Text, txbDatabase.Text, txbUser.Text, txbPassword.Text);
            SqliteServices sqliteServices = new SqliteServices();
            Dictionary<string, string> parameters = sqlServices.GetParameters();
            string product = cmbProduct.SelectedItem.ToString();
            sqliteServices.DropCollumn("Indexes");
            sqliteServices.DropCollumn("Columns");
            sqliteServices.DropCollumn("Parameters");
            sqliteServices = new SqliteServices();


            List<Index> indexes = sqlServices.GetIndexes();
            indexes.Sort(new IndexesComparer());

            List<Column> columns = sqlServices.GetColumns();
            columns.Sort(new ColumnsComparer());

            sqliteServices.SaveColumns(columns, product);
            parameters.Add("product", product);
            sqliteServices.SaveParameters(parameters);
            sqliteServices.SaveIndexes(indexes, product);

            MessageBox.Show("Base de referência atualizada com sucesso!");

            lblStatus.Visible = false;
            btnCompareColumns.Enabled = true;
            btnCompareIndexes.Enabled = true;

        }
    }
}
