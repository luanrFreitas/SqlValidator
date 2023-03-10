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

        public List<T> LoadObjects<T>()
        {
            var objects = new List<T>();

            using (var connection = new SQLiteConnection($"Data Source={_databaseFilePath};Version=3;"))
            {
                connection.Open();
                var selectCommand = new SQLiteCommand($"SELECT json FROM {_tableName}", connection);
                var reader = selectCommand.ExecuteReader();

                while (reader.Read())
                {
                    var json = reader.GetString(0);
                    var obj = Newtonsoft.Json.JsonConvert.DeserializeObject<T>(json);
                    objects.Add(obj);
                }
            }

            return objects;
        }
    }
}
