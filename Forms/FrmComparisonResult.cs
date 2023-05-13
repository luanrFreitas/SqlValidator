using SqlValidator.Models;
using SqlValidator.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        List<Column> _columnsTemplate;
        List<Column> _columnsNotInDB;
        List<Column> _columnsNotInTemplate;

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


        public FrmComparisonResult(List<Column> template, List<Column> columns, List<Column> notInDB, List<Column> notInTemplate,SqlServices sqlServices, SqliteServices sqliteServices,string product)
        {
            _columns = columns;
            _columnsTemplate = template;
            _columnsNotInDB = notInDB;
            _columnsNotInTemplate = notInTemplate;
            _compareType = "Column";
            InitializeComponent();
            _sqlServices = sqlServices;
            _sqliteServices = sqliteServices;
            _sqliteServices = sqliteServices;

            _modelCollation = _sqliteServices.LoadParameters(product)["collation"];
            _dbCollation = _sqlServices.GetParameters()["collation"];
            _modelVersion = _sqliteServices.LoadParameters(product)["version"];
            _dbVersion = _sqlServices.GetParameters()["version"];
 
        }
        public FrmComparisonResult(List<Index> template, List<Index> indexes, List<Index> notInDB, List<Index> notInTemplate, SqlServices sqlServices, SqliteServices sqliteServices,string product)
        {
            _indexes = indexes;
            _indexesTemplate = template;
            _indexesNotInDB = notInDB;
            _indexesNotInTemplate = notInTemplate;
            _compareType = "Index";
            InitializeComponent();
            _sqlServices = sqlServices;
            _sqliteServices= sqliteServices;

            _modelCollation = _sqliteServices.LoadParameters(product)["collation"];
            _dbCollation = _sqlServices.GetParameters()["collation"];
            _modelVersion = _sqliteServices.LoadParameters(product)["version"];
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

            if (_dbVersion == _modelVersion)
            {
                lblDBVersion.ForeColor = Color.Black;
                lblModelVersion.ForeColor = Color.Black;
            }
            else
            {
                lblDBVersion.ForeColor = Color.Red;
                lblModelVersion.ForeColor = Color.Red;
            }

            if (_modelCollation == _dbCollation)
            {
                lblDBCollate.ForeColor = Color.Black;
                lblModelCollate.ForeColor = Color.Black;
            }
            else
            {
                lblDBCollate.ForeColor = Color.Red;
                lblModelCollate.ForeColor = Color.Red;
            }
        }

        private void btnViewDatabaseModel_Click(object sender, EventArgs e)
        {
            btnViewDatabaseModel.Enabled = false;
            btnViewDatabaseConsulted.Enabled = true;
            btnViewDiffDatabaseModel.Enabled = true;
            btnViewDiffDatabaseConsulted.Enabled = true;
            if (_compareType == "Column")
            {
                lblResultDetail.Text = "Exibindo as colunas da base de referência";
                lblResultDetail.Location = new Point(188, 80);
                lblResultDetail.Font = new Font(lblResultDetail.Font.FontFamily, 11);
                dtgComparisonResult.Columns.Clear();
                dtgComparisonResult.DataSource = _columnsTemplate;
            }
            else
            {
                lblResultDetail.Text = "Exibindo os índices da base de referência";
                lblResultDetail.Location = new Point(188, 80);
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
                lblResultDetail.Location = new Point(188, 80);
                lblResultDetail.Font = new Font(lblResultDetail.Font.FontFamily, 11);
                dtgComparisonResult.Columns.Clear();
                dtgComparisonResult.DataSource = _columns;
            }
            else
            {
                lblResultDetail.Text = "Exibindo os índices da base de consultada";
                lblResultDetail.Location = new Point(188, 80);
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
                lblResultDetail.Text = "Exibindo as colunas que existem na base consultada que não existem ou estão diferentes da base referência";
                lblResultDetail.Location = new Point(18, 80);
                lblResultDetail.Font = new Font(lblResultDetail.Font.FontFamily, 11);
                dtgComparisonResult.Columns.Clear();
                dtgComparisonResult.DataSource = _columnsNotInTemplate;
            }
            else
            {
                lblResultDetail.Text = "Exibindo os índices que existem na base consultada que não existem ou estão diferentes da base referência";
                lblResultDetail.Location = new Point(18, 80);
                lblResultDetail.Font = new Font(lblResultDetail.Font.FontFamily, 11);
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
                lblResultDetail.Text = "Exibindo as colunas que existem na base referência que não existem ou estão diferentes da base consultada";
                lblResultDetail.Location = new Point(18, 83);
                lblResultDetail.Font = new Font(lblResultDetail.Font.FontFamily,11);
                dtgComparisonResult.Columns.Clear();
                dtgComparisonResult.DataSource = _columnsNotInDB;
            }
            else
            {
                lblResultDetail.Text = "Exibindo os índices que existem na base referência que não existem ou estão diferentes da base consultada";
                lblResultDetail.Location = new Point(18, 83);
                lblResultDetail.Font = new Font(lblResultDetail.Font.FontFamily, 11);
                dtgComparisonResult.Columns.Clear();
                dtgComparisonResult.DataSource = _indexesNotInDB;
            }
        }

        private void btnDownloadDiffs_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "csv files (*.csv)|*.csv";
            saveFileDialog.RestoreDirectory = true;

            if (saveFileDialog.ShowDialog()== DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    if (_compareType == "Column")
                    {

                        writer.WriteLine("**-Colunas que existem na base consultada que não existem ou estão diferentes da base modelo-**");
                        writer.WriteLine("TableName;ColumnName;DataType;MaximunLength;IsNullable");

                        foreach (Column column in _columnsNotInTemplate)
                        {
                            writer.WriteLine($"{column.TableName};{column.ColumnName};{column.DataType};{column.MaximunLength};{column.IsNullable}");
                        }

                        writer.WriteLine("**-Colunas que existem na base modelo que não existem ou estão diferentes da base consultada-**");
                        writer.WriteLine("TableName;ColumnName;DataType;MaximunLength;IsNullable");

                        foreach (Column column in _columnsNotInDB)
                        {
                            writer.WriteLine($"{column.TableName};{column.ColumnName};{column.DataType};{column.MaximunLength};{column.IsNullable}");
                        }

                    }
                    else
                    {
                        writer.WriteLine("**-Índices que existem na base consultada que não existem ou estão diferentes da base modelo-**");
                        writer.WriteLine("TableName;ColumnName;IndexName;IndexType");

                        foreach (Index index in _indexesNotInTemplate)
                        {
                            writer.WriteLine($"{index.TableName};{index.ColumnName};{index.IndexName};{index.IndexType}");
                        }

                        writer.WriteLine("**-Colunas que existem na base modelo que não existem ou estão diferentes da base consultada-**");
                        writer.WriteLine("TableName;ColumnName;IndexName;IndexType");

                        foreach (Index index in _indexesNotInDB)
                        {
                            writer.WriteLine($"{index.TableName};{index.ColumnName};{index.IndexName};{index.IndexType}");
                        }
                    }
                   
                }
                 DialogResult result = MessageBox.Show("Arquivo salvo com sucesso! "+ Environment.NewLine + "Clique OK para abrir o arquivo","Sucesso!",MessageBoxButtons.OKCancel,MessageBoxIcon.None);

                if(result == DialogResult.OK)
                    Process.Start(saveFileDialog.FileName);
            }
        }


    }
}
