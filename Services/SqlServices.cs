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
        public string DatabaseName;

        public SqlServices(string server, string database, string user, string password)
        {
            connectionString = $"user id={user};Server={server};persist security info=False;initial catalog={database}; Password={password}";
            DatabaseName= database ;

        }

        public List<Column> GetColumns()
        {
            List<Column> resultado = new List<Column>();

            string query = "SELECT TABLE_NAME, COLUMN_NAME, DATA_TYPE, CHARACTER_MAXIMUM_LENGTH, IS_NULLABLE  FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME NOT LIKE '%T_TIM%' AND TABLE_NAME NOT LIKE '%T_TTI%' AND TABLE_NAME NOT LIKE '%T_IDG%' AND TABLE_NAME NOT LIKE '%T_TDI%' AND TABLE_NAME NOT LIKE '%T_TIT%' AND TABLE_NAME NOT LIKE '%T_IML%' AND TABLE_NAME NOT LIKE '%T_TMP%' AND TABLE_NAME NOT LIKE '%T_Mailing%' AND TABLE_NAME <> 'sysdiagrams'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Column linha = new Column();
                    linha.TableName = reader.GetString(0);
                    linha.ColumnName = reader.GetString(1);
                    linha.DataType = reader.GetString(2);
                    if (reader[3] is DBNull)
                        linha.MaximunLength = String.Empty;
                    if (reader[3].ToString() == "-1")
                        linha.MaximunLength = "MAX";
                    else
                        linha.MaximunLength = reader[3].ToString();
                    linha.IsNullable = reader.GetString(4);

                    resultado.Add(linha);
                }

                reader.Close();
            }

            return resultado;
        }

        public List<Index> GetIndexes()
        {
            List<Index> resultado = new List<Index>();

            string query = @"SELECT
                                OBJECT_NAME(i.object_id) AS TableName,
	                            c.name AS ColumnName,
                                i.name AS IndexName,
                                i.type_desc AS IndexType   
                            FROM
                                sys.indexes i
                                INNER JOIN sys.index_columns ic ON i.object_id = ic.object_id AND i.index_id = ic.index_id
                                INNER JOIN sys.columns c ON ic.object_id = c.object_id AND ic.column_id = c.column_id
                            WHERE OBJECT_NAME(i.object_id) NOT LIKE '%FILESTREAM%'
                                AND  OBJECT_NAME(i.object_id) NOT LIKE '%FILETABLE%'
                                AND  OBJECT_NAME(i.object_id) NOT LIKE '%plan_%'
	                            AND  OBJECT_NAME(i.object_id) NOT LIKE '%queue%'
	                            AND  OBJECT_NAME(i.object_id) NOT LIKE '%sqlagent_%'
	                            AND  OBJECT_NAME(i.object_id) NOT LIKE '%sys%'
	                            AND  OBJECT_NAME(i.object_id) NOT LIKE '%T_IDG%'
	                            AND  OBJECT_NAME(i.object_id) NOT LIKE '%T_IML%'
	                            AND  OBJECT_NAME(i.object_id) NOT LIKE '%T_TIT%'
	                            AND  OBJECT_NAME(i.object_id) NOT LIKE '%T_TTI%'
	                            AND  OBJECT_NAME(i.object_id) NOT LIKE '%T_TDI%'
	                            AND  OBJECT_NAME(i.object_id) NOT LIKE '%T_TIM%'
	                            AND  OBJECT_NAME(i.object_id) NOT LIKE '%wpr_bucket%'
	                            AND  i.name NOT LIKE '%PK__%'
                            ORDER BY
                                TableName,
	                            ColumnName,
                                IndexName";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Index linha = new Index();
                    linha.TableName = reader.GetString(0);
                    linha.ColumnName = reader.GetString(1);
                    linha.IndexName = reader.GetString(2);
                    linha.IndexType = reader[3].ToString();

                    resultado.Add(linha);
                }

                reader.Close();
            }

            return resultado;
        }

        public Dictionary<string,string> GetParameters()
        {
            Dictionary<string, string> parameters = new Dictionary<string, string>();

            string query = $"SELECT DATABASEPROPERTYEX('{DatabaseName}', 'Collation') AS 'Collation'";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    parameters.Add("collation", reader.GetString(0));
                }

                reader.Close();

                command.CommandText= "Select CONCAT(nr_par_sub_release,'.',nr_par_ptf) from t_par";

               

                reader = command.ExecuteReader();

                while (reader.Read())
                {
                    parameters.Add("version", reader.GetString(0));
                }

                reader.Close();
            }

            return parameters;
        }
    }
}
