using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.IO;
using SqlValidator.Models;
using System.Data.SqlTypes;

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
                var createTableCommand = new SQLiteCommand($"CREATE TABLE IF NOT EXISTS Columns ( Product TEXT NOT NULL, TableName TEXT NOT NULL,ColumnName TEXT NOT NULL,DataType TEXT NOT NULL,MaximunLength TEXT NOT NULL,IsNullable TEXT NOT NULL)", connection);
                createTableCommand.ExecuteNonQuery();
                createTableCommand.CommandText = $"CREATE TABLE IF NOT EXISTS Indexes ( Product TEXT NOT NULL, TableName TEXT NOT NULL,ColumnName TEXT NOT NULL,IndexName TEXT NOT NULL,IndexType TEXT NOT NULL)";
                createTableCommand.ExecuteNonQuery();
                createTableCommand.CommandText = $"CREATE TABLE IF NOT EXISTS Parameters ( Product TEXT NOT NULL, Version TEXT NOT NULL,Collation TEXT NOT NULL)";
                createTableCommand.ExecuteNonQuery();

            }
        }

        public void SaveColumns(List<Column> objects,string product)
        {
            using (var connection = new SQLiteConnection($"Data Source={_databaseFilePath};Version=3;"))
            {
                connection.Open();

                foreach (var obj in objects)
                {
                    var insertCommand = new SQLiteCommand($"INSERT INTO Columns (Product,TableName,ColumnName,DataType,MaximunLength,IsNullable) VALUES (@Product,@TableName,@ColumnName ,@DataType, @MaximunLength,@IsNullable)", connection);
                    insertCommand.Parameters.AddWithValue("@Product", product);
                    insertCommand.Parameters.AddWithValue("@TableName", obj.TableName);
                    insertCommand.Parameters.AddWithValue("@ColumnName", obj.ColumnName);
                    insertCommand.Parameters.AddWithValue("@DataType", obj.DataType);
                    insertCommand.Parameters.AddWithValue("@MaximunLength", obj.MaximunLength);
                    insertCommand.Parameters.AddWithValue("@IsNullable", obj.IsNullable);
                    insertCommand.ExecuteNonQuery();
                }
            }
        }

        public void SaveIndexes(List<Index> objects, string product)
        {
            using (var connection = new SQLiteConnection($"Data Source={_databaseFilePath};Version=3;"))
            {
                connection.Open();

                foreach (var obj in objects)
                {
                    var insertCommand = new SQLiteCommand($"INSERT INTO Indexes (Product,TableName,ColumnName,IndexName,IndexType) VALUES (@Product, @TableName,@ColumnName ,@IndexName, @IndexType)", connection);
                    insertCommand.Parameters.AddWithValue("@Product", product);
                    insertCommand.Parameters.AddWithValue("@TableName", obj.TableName);
                    insertCommand.Parameters.AddWithValue("@ColumnName", obj.ColumnName);
                    insertCommand.Parameters.AddWithValue("@IndexName", obj.IndexName);
                    insertCommand.Parameters.AddWithValue("@IndexType", obj.IndexType);
                    insertCommand.ExecuteNonQuery();
                }
            }
        }

        public void SaveParameters(Dictionary<string,string> parameters)
        {
            using (var connection = new SQLiteConnection($"Data Source={_databaseFilePath};Version=3;"))
            {
                connection.Open();


                var insertCommand = new SQLiteCommand($"INSERT INTO Parameters (Product,Version,Collation) VALUES (@product,@version,@collation)", connection);
                insertCommand.Parameters.AddWithValue("@product", parameters["product"]);
                insertCommand.Parameters.AddWithValue("@version", parameters["version"]);
                insertCommand.Parameters.AddWithValue("@collation", parameters["collation"]);
                insertCommand.ExecuteNonQuery();

            }
        }

        public List<Column> LoadColumns(string product)
        {
            var objects = new List<Column>();

            using (var connection = new SQLiteConnection($"Data Source={_databaseFilePath};Version=3;"))
            {
                connection.Open();
                var selectCommand = new SQLiteCommand($"SELECT TableName,ColumnName,DataType,MaximunLength,IsNullable FROM Columns where Product='{product}'", connection);
                var reader = selectCommand.ExecuteReader();

                while (reader.Read())
                {
                    Column linha = new Column();
                    linha.TableName = reader.GetString(0);
                    linha.ColumnName = reader.GetString(1);
                    linha.DataType = reader.GetString(2);
                    linha.MaximunLength = reader[3] is DBNull ? String.Empty : reader[3].ToString();
                    linha.IsNullable = reader.GetString(4);
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
                var selectCommand = new SQLiteCommand($"SELECT TableName,ColumnName,IndexName,IndexType FROM Indexes", connection);
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

        public Dictionary<string, string> LoadParameters(string product)
        {
           Dictionary<string,string> parameters = new Dictionary<string,string>();

            using (var connection = new SQLiteConnection($"Data Source={_databaseFilePath};Version=3;"))
            {
                connection.Open();
                var selectCommand = new SQLiteCommand($"SELECT version,collation FROM Parameters where Product ='{product}'", connection);
                var reader = selectCommand.ExecuteReader();

                while (reader.Read())
                {
                    parameters.Add("version", reader.GetString(0));
                    parameters.Add("collation", reader.GetString(1));
                }
            }

            return parameters;
        }

        public void DropCollumn(string table)
        {
            using (var connection = new SQLiteConnection($"Data Source={_databaseFilePath};Version=3;"))
            {
                connection.Open();


                var deleteCommand = new SQLiteCommand($"DROP TABLE {table};", connection);

                deleteCommand.ExecuteNonQuery();

            }
        }
    }
}
