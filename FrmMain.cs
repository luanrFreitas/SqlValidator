using SqlValidator.Models;
using SqlValidator.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlValidator
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnCompare_Click(object sender, EventArgs e)
        {
            SqlServices sqlServices = new SqlServices(txbServer.Text, txbDatabase.Text, txbUser.Text, txbPassword.Text);
            SqliteServices sqliteServices = new SqliteServices();
            List<Column> columns = sqlServices.GetColumns();

            sqliteServices.SaveColumns(columns);

        }
    }
}
