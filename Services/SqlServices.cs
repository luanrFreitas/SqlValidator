using SqlValidator.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlValidator.Services
{
    public class SqlServices
    {
        private string connectionString;

        public SqlServices(string server,string database,string user,string password)
        {
            connectionString = $"user id={user};Server={server};persist security info=False;initial catalog={database}; Password={password}";


        }

        public List<Column> GetColumns()
        {
            List<Column> resultado = new List<Column>();

            string query = "SELECT TABLE_NAME, COLUMN_NAME,    DATA_TYPE,    CHARACTER_MAXIMUM_LENGTH\r\nFROM    INFORMATION_SCHEMA.COLUMNS";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                // Para cada linha do resultado, cria um objeto ResultadoSelect e adiciona na lista
                while (reader.Read())
                {
                    Column linha = new Column();
                    linha.TableName = reader.GetString(0);
                    linha.ColumnName = reader.GetString(1);
                    linha.DataType = reader.GetString(2);
                    linha.MaximunLength = reader.GetString(2);
                    resultado.Add(linha);
                }

                reader.Close();
            }

            return resultado;
        }
    }
}
