using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using SqlValidator.Models;

namespace SqlValidator.Services
{
    public class SqliteServices
    {
        private string _databaseFilePath;
        private string _tableName;
        public SqliteServices()
        {
            _databaseFilePath = "localDatabase";
            _tableName = "Tables";

            // Cria o arquivo do banco de dados SQLite caso não exista.
            if (!File.Exists(_databaseFilePath))
            {
                SQLiteConnection.CreateFile(_databaseFilePath);
            }

            // Cria a tabela para armazenar os objetos caso não exista.
            using (var connection = new SQLiteConnection($"Data Source={_databaseFilePath};Version=3;"))
            {
                connection.Open();
                var createTableCommand = new SQLiteCommand($"CREATE TABLE IF NOT EXISTS Columns ( TableName TEXT NOT NULL,ColumnName TEXT NOT NULL,DataType TEXT NOT NULL,MaximunLength TEXT NOT NULL)", connection);
                createTableCommand.ExecuteNonQuery();
                createTableCommand.CommandText = $"CREATE TABLE IF NOT EXISTS Indexes ( TableName TEXT NOT NULL,ColumnName TEXT NOT NULL,IndexName TEXT NOT NULL,IndexType TEXT NOT NULL)";
                createTableCommand.ExecuteNonQuery();

            }
        }

        public void SaveColumns(List<Column> objects)
        {
            using (var connection = new SQLiteConnection($"Data Source={_databaseFilePath};Version=3;"))
            {
                connection.Open();

                foreach (var obj in objects)
                {
                    var insertCommand = new SQLiteCommand($"INSERT INTO Columns (TableName,ColumnName,DataType,MaximunLength) VALUES (@TableName,@ColumnName ,@DataType, @MaximunLength)", connection);
                    insertCommand.Parameters.AddWithValue("@TableName", obj.TableName);
                    insertCommand.Parameters.AddWithValue("@ColumnName", obj.ColumnName);
                    insertCommand.Parameters.AddWithValue("@DataType", obj.DataType);
                    insertCommand.Parameters.AddWithValue("@MaximunLength", obj.MaximunLength);
                    insertCommand.ExecuteNonQuery();
                }
            }
        }

        public void SaveIndexes(List<Index> objects)
        {
            using (var connection = new SQLiteConnection($"Data Source={_databaseFilePath};Version=3;"))
            {
                connection.Open();

                foreach (var obj in objects)
                {
                    var insertCommand = new SQLiteCommand($"INSERT INTO Indexes (TableName,ColumnName,IndexName,IndexType) VALUES (@TableName,@ColumnName ,@IndexName, @IndexType)", connection);
                    insertCommand.Parameters.AddWithValue("@TableName", obj.TableName);
                    insertCommand.Parameters.AddWithValue("@ColumnName", obj.ColumnName);
                    insertCommand.Parameters.AddWithValue("@IndexName", obj.IndexName);
                    insertCommand.Parameters.AddWithValue("@IndexType", obj.IndexType);
                    insertCommand.ExecuteNonQuery();
                }
            }
        }

        public List<Column> LoadColumns()
        {
            var objects = new List<Column>();

            using (var connection = new SQLiteConnection($"Data Source={_databaseFilePath};Version=3;"))
            {
                connection.Open();
                var selectCommand = new SQLiteCommand($"SELECT * FROM Columns", connection);
                var reader = selectCommand.ExecuteReader();

                while (reader.Read())
                {
                    Column linha = new Column();
                    linha.TableName = reader.GetString(0);
                    linha.ColumnName = reader.GetString(1);
                    linha.DataType = reader.GetString(2);
                    linha.MaximunLength = reader[3] is DBNull ? String.Empty : reader[3].ToString();
                    objects.Add(linha);
                }
            }

            return objects;
        }
        public List<Index> LoadIndexes()
        {
            var objects = new List<Index>();

            using (var connection = new SQLiteConnection($"Data Source={_databaseFilePath};Version=3;"))
            {
                connection.Open();
                var selectCommand = new SQLiteCommand($"SELECT * FROM Indexes", connection);
                var reader = selectCommand.ExecuteReader();

                while (reader.Read())
                {
                    Index linha = new Index();
                    linha.TableName = reader.GetString(0);
                    linha.ColumnName = reader.GetString(1);
                    linha.IndexName = reader.GetString(2);
                    linha.IndexType = reader.GetString(3);
                    objects.Add(linha);
                }
            }

            return objects;
        }
    }
}
