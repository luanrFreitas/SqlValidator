using SqlValidator.Models;
using SqlValidator.Services;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SqlValidator.Forms
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
            lblStatus.Visible = false;
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            btnCompareColumns.Enabled = false;
            btnCompareIndexes.Enabled = false;

            lblStatus.Visible = true;
            lblStatus.Text = "Comparando ...";
            SqlServices sqlServices = new SqlServices(txbServer.Text, txbDatabase.Text, txbUser.Text, txbPassword.Text);
            SqliteServices sqliteServices = new SqliteServices();
            ComparerServices comparerServices = new ComparerServices();
            List<Column> columns = sqlServices.GetColumns();
            columns.Sort(new ColumnsComparer());
            Dictionary<string, string> parameters = sqlServices.GetParameters();

            //sqliteServices.SaveColumns(columns);
            //sqliteServices.SaveParameters(parameters);

            List<Column> template = sqliteServices.LoadColumns();
            template.Sort(new ColumnsComparer());

            List<Column> notInDB , notInTemplate;
            comparerServices.CompareColumn(columns,template, out notInDB,out notInTemplate);

            FrmComparisonResult frmComparisonResult = new FrmComparisonResult(template, columns, notInDB, notInTemplate, sqlServices, sqliteServices);
            lblStatus.Visible = false;
            btnCompareColumns.Enabled = true;
            btnCompareIndexes.Enabled = true;

            frmComparisonResult.ShowDialog();

        }

        private void btnCompareIndexes_Click(object sender, EventArgs e)
        {
            btnCompareColumns.Enabled = false;
            btnCompareIndexes.Enabled = false;
            lblStatus.Visible = true;

            SqlServices sqlServices = new SqlServices(txbServer.Text, txbDatabase.Text, txbUser.Text, txbPassword.Text);
            SqliteServices sqliteServices = new SqliteServices();
            ComparerServices comparerServices = new ComparerServices();
            List<Index> indexes = sqlServices.GetIndexes();
            indexes.Sort(new IndexesComparer());


            //sqliteServices.SaveIndexes(indexes);
            


            List<Index> template = sqliteServices.LoadIndexes();
            template.Sort(new IndexesComparer());

            List<Index> notInDB, notInTemplate;
            comparerServices.CompareIndex(indexes, template, out notInDB, out notInTemplate);

            FrmComparisonResult frmComparisonResult = new FrmComparisonResult(template, indexes, notInDB, notInTemplate, sqlServices, sqliteServices);
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
    }
}
