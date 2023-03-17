using SqlValidator.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlValidator.Forms
{
    public partial class FrmComparisonResult : Form
    {
        List<Column> _columns;
        List<Column> _template;
        List<Column> _notInDB;
        List<Column> _notInTemplate;

        List<Index> _indexes;
        List<Index> _indexesTemplate;
        List<Index> _indexesNotInDB;
        List<Index> _indexesNotInTemplate;

        String _compareType;
        public FrmComparisonResult(List<Column> template, List<Column> columns, List<Column> notInDB, List<Column> notInTemplate)
        {
            _columns = columns;
            _template = template;
            _notInDB = notInDB;
            _notInTemplate = notInTemplate;
            _compareType = "Column";
            InitializeComponent();

        }
        public FrmComparisonResult(List<Index> template, List<Index> indexes, List<Index> notInDB, List<Index> notInTemplate)
        {
            _indexes = indexes;
            _indexesTemplate = template;
            _indexesNotInDB = notInDB;
            _indexesNotInTemplate = notInTemplate;
            _compareType = "Index";
            InitializeComponent();

        }

        private void FrmComparisonResult_Load(object sender, EventArgs e)
        {
            dtgComparisonResult.ReadOnly = true;
            btnViewDatabaseModel.PerformClick();
        }

        private void btnViewDatabaseModel_Click(object sender, EventArgs e)
        {
            if (_compareType == "Column")
            {
                lblResultDetail.Text = "Exibindo as colunas da base de modelo";
                lblResultDetail.Location = new Point(180, 72);
                dtgComparisonResult.Columns.Clear();
                dtgComparisonResult.DataSource = _template;
            }
            else
            {
                lblResultDetail.Text = "Exibindo os índices da base de modelo";
                lblResultDetail.Location = new Point(180, 72);
                dtgComparisonResult.Columns.Clear();
                dtgComparisonResult.DataSource = _indexesTemplate;
            }
        }

        private void btnViewDatabaseConsulted_Click(object sender, EventArgs e)
        {
            if (_compareType == "Column")
            {
                lblResultDetail.Text = "Exibindo as colunas da base de consultada";
                lblResultDetail.Location = new Point(180, 72);
                dtgComparisonResult.Columns.Clear();
                dtgComparisonResult.DataSource = _columns;
            }
            else
            {
                lblResultDetail.Text = "Exibindo os índices da base de consultada";
                lblResultDetail.Location = new Point(180, 72);
                dtgComparisonResult.Columns.Clear();
                dtgComparisonResult.DataSource = _indexes;
            }
        }

        private void btnViewDiffDatabaseModel_Click(object sender, EventArgs e)
        {
            if (_compareType == "Column")
            {
                lblResultDetail.Text = "Exibindo as colunas que existem na base consultada que não existem ou estão diferentes da base modelo";
                lblResultDetail.Location = new Point(18, 72);
                dtgComparisonResult.Columns.Clear();
                dtgComparisonResult.DataSource = _notInTemplate;
            }
            else
            {
                lblResultDetail.Text = "Exibindo os índices que existem na base consultada que não existem ou estão diferentes da base modelo";
                lblResultDetail.Location = new Point(18, 72);
                dtgComparisonResult.Columns.Clear();
                dtgComparisonResult.DataSource = _indexesNotInTemplate;
            }
        }

        private void btnViewDiffDatabaseConsulted_Click(object sender, EventArgs e)
        {
            if (_compareType == "Column")
            {
                lblResultDetail.Text = "Exibindo as colunas que existem na base modelo que não existem ou estão diferentes da base consultada";
                lblResultDetail.Location = new Point(18, 72);
                dtgComparisonResult.Columns.Clear();
                dtgComparisonResult.DataSource = _notInDB;
            }
            else
            {
                lblResultDetail.Text = "Exibindo os índices que existem na base modelo que não existem ou estão diferentes da base consultada";
                lblResultDetail.Location = new Point(18, 72);
                dtgComparisonResult.Columns.Clear();
                dtgComparisonResult.DataSource = _indexesNotInDB;
            }
        }
    }
}
