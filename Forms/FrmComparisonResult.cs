using SqlValidator.Models;
using SqlValidator.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        SqlServices _sqlServices;
        SqliteServices _sqliteServices;
        String _compareType;
        String _modelCollation;
        String _dbCollation;
        String _modelVersion;
        String _dbVersion;


        public FrmComparisonResult(List<Column> template, List<Column> columns, List<Column> notInDB, List<Column> notInTemplate,SqlServices sqlServices, SqliteServices sqliteServices)
        {
            _columns = columns;
            _template = template;
            _notInDB = notInDB;
            _notInTemplate = notInTemplate;
            _compareType = "Column";
            InitializeComponent();
            _sqlServices = sqlServices;
            _sqliteServices = sqliteServices;
            _sqliteServices = sqliteServices;

            _modelCollation = _sqliteServices.LoadParameters()["collation"];
            _dbCollation = _sqlServices.GetParameters()["collation"];
            _modelVersion = _sqliteServices.LoadParameters()["version"];
            _dbVersion = _sqlServices.GetParameters()["version"];
 
        }
        public FrmComparisonResult(List<Index> template, List<Index> indexes, List<Index> notInDB, List<Index> notInTemplate, SqlServices sqlServices, SqliteServices sqliteServices)
        {
            _indexes = indexes;
            _indexesTemplate = template;
            _indexesNotInDB = notInDB;
            _indexesNotInTemplate = notInTemplate;
            _compareType = "Index";
            InitializeComponent();
            _sqlServices = sqlServices;
            _sqliteServices= sqliteServices;

            _modelCollation = _sqliteServices.LoadParameters()["collation"];
            _dbCollation = _sqlServices.GetParameters()["collation"];
            _modelVersion = _sqliteServices.LoadParameters()["version"];
            _dbVersion = _sqlServices.GetParameters()["version"];
        }

        private void FrmComparisonResult_Load(object sender, EventArgs e)
        {
            dtgComparisonResult.ReadOnly = true;
            btnViewDatabaseModel.PerformClick();
            lblDBCollate.Text = _dbCollation;
            lblModelCollate.Text = _modelCollation;
            lblDBVersion.Text = _dbVersion;
            lblModelVersion.Text = _modelVersion;
        }

        private void btnViewDatabaseModel_Click(object sender, EventArgs e)
        {
            btnViewDatabaseModel.Enabled = false;
            btnViewDatabaseConsulted.Enabled = true;
            btnViewDiffDatabaseModel.Enabled = true;
            btnViewDiffDatabaseConsulted.Enabled = true;
            if (_compareType == "Column")
            {
                lblResultDetail.Text = "Exibindo as colunas da base de modelo";
                lblResultDetail.Location = new Point(180, 72);
                lblResultDetail.Font = new Font(lblResultDetail.Font.FontFamily, 11);
                dtgComparisonResult.Columns.Clear();
                dtgComparisonResult.DataSource = _template;
            }
            else
            {
                lblResultDetail.Text = "Exibindo os índices da base de modelo";
                lblResultDetail.Location = new Point(180, 72);
                lblResultDetail.Font = new Font(lblResultDetail.Font.FontFamily, 11);
                dtgComparisonResult.Columns.Clear();
                dtgComparisonResult.DataSource = _indexesTemplate;
            }
        }

        private void btnViewDatabaseConsulted_Click(object sender, EventArgs e)
        {
            btnViewDatabaseModel.Enabled = true;
            btnViewDatabaseConsulted.Enabled = false;
            btnViewDiffDatabaseModel.Enabled = true;
            btnViewDiffDatabaseConsulted.Enabled = true;
            if (_compareType == "Column")
            {
                lblResultDetail.Text = "Exibindo as colunas da base de consultada";
                lblResultDetail.Location = new Point(180, 72);
                lblResultDetail.Font = new Font(lblResultDetail.Font.FontFamily, 11);
                dtgComparisonResult.Columns.Clear();
                dtgComparisonResult.DataSource = _columns;
            }
            else
            {
                lblResultDetail.Text = "Exibindo os índices da base de consultada";
                lblResultDetail.Location = new Point(180, 72);
                lblResultDetail.Font = new Font(lblResultDetail.Font.FontFamily, 11);
                dtgComparisonResult.Columns.Clear();
                dtgComparisonResult.DataSource = _indexes;
            }
        }

        private void btnViewDiffDatabaseModel_Click(object sender, EventArgs e)
        {
            btnViewDatabaseModel.Enabled = true;
            btnViewDatabaseConsulted.Enabled = true;
            btnViewDiffDatabaseModel.Enabled = false;
            btnViewDiffDatabaseConsulted.Enabled = true;
            if (_compareType == "Column")
            {
                lblResultDetail.Text = "Exibindo as colunas que existem na base consultada que não existem ou estão diferentes da base modelo";
                lblResultDetail.Location = new Point(18, 72);
                lblResultDetail.Font = new Font(lblResultDetail.Font.FontFamily, 9);
                dtgComparisonResult.Columns.Clear();
                dtgComparisonResult.DataSource = _notInTemplate;
            }
            else
            {
                lblResultDetail.Text = "Exibindo os índices que existem na base consultada que não existem ou estão diferentes da base modelo";
                lblResultDetail.Location = new Point(18, 72);
                lblResultDetail.Font = new Font(lblResultDetail.Font.FontFamily, 9);
                dtgComparisonResult.Columns.Clear();
                dtgComparisonResult.DataSource = _indexesNotInTemplate;
            }
        }

        private void btnViewDiffDatabaseConsulted_Click(object sender, EventArgs e)
        {
            btnViewDatabaseModel.Enabled = true;
            btnViewDatabaseConsulted.Enabled = true;
            btnViewDiffDatabaseModel.Enabled = true;
            btnViewDiffDatabaseConsulted.Enabled = false;
            if (_compareType == "Column")
            {
                lblResultDetail.Text = "Exibindo as colunas que existem na base modelo que não existem ou estão diferentes da base consultada";
                lblResultDetail.Location = new Point(18, 72);
                lblResultDetail.Font = new Font(lblResultDetail.Font.FontFamily,9);
                dtgComparisonResult.Columns.Clear();
                dtgComparisonResult.DataSource = _notInDB;
            }
            else
            {
                lblResultDetail.Text = "Exibindo os índices que existem na base modelo que não existem ou estão diferentes da base consultada";
                lblResultDetail.Location = new Point(18, 72);
                lblResultDetail.Font = new Font(lblResultDetail.Font.FontFamily, 9);
                dtgComparisonResult.Columns.Clear();
                dtgComparisonResult.DataSource = _indexesNotInDB;
            }
        }

        private void btnDownloadDiffs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialogdlg = new SaveFileDialog();
            saveFileDialogdlg.Filter = "csv files (*.csv)|*.csv";
            saveFileDialogdlg.RestoreDirectory = true;

            if (saveFileDialogdlg.ShowDialog()== DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialogdlg.FileName))
                {
                    if (_compareType == "Column")
                    {

                        writer.WriteLine("**-Colunas que existem na base consultada que não existem ou estão diferentes da base modelo-**");
                        writer.WriteLine("TableName,ColumnName,DataType,MaximunLength,IsNullable");

                        foreach (Column column in _notInTemplate)
                        {
                            writer.WriteLine($"{column.TableName},{column.ColumnName},{column.DataType},{column.MaximunLength},{column.IsNullable}");
                        }

                        writer.WriteLine("**-Colunas que existem na base modelo que não existem ou estão diferentes da base consultada-**");
                        writer.WriteLine("TableName,ColumnName,DataType,MaximunLength,IsNullable");

                        foreach (Column column in _notInDB)
                        {
                            writer.WriteLine($"{column.TableName},{column.ColumnName},{column.DataType},{column.MaximunLength},{column.IsNullable}");
                        }

                    }
                    else
                    {
                        writer.WriteLine("**-Índices que existem na base consultada que não existem ou estão diferentes da base modelo-**");
                        writer.WriteLine("TableName,ColumnName,IndexName,IndexType");

                        foreach (Index index in _indexesNotInTemplate)
                        {
                            writer.WriteLine($"{index.TableName},{index.ColumnName},{index.IndexName},{index.IndexType}");
                        }

                        writer.WriteLine("**-Colunas que existem na base modelo que não existem ou estão diferentes da base consultada-**");
                        writer.WriteLine("TableName,ColumnName,IndexName,IndexType");

                        foreach (Index index in _indexesNotInDB)
                        {
                            writer.WriteLine($"{index.TableName},{index.ColumnName},{index.IndexName},{index.IndexType}");
                        }
                    }
                   
                }
                MessageBox.Show("Arquivo salvo com sucesso!");
            }
        }


    }
}
