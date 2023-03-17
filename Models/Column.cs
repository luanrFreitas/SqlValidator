using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlValidator.Models
{
    public class Column
    {
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public string DataType { get; set; }
        public string MaximunLength { get; set; }

    }
    public class ColumnsComparer : IComparer<Column>, IEqualityComparer<Column>
    {
        public int Compare(Column x, Column y)
        {
            int resultado = x.TableName.CompareTo(y.TableName);
            if (resultado == 0)
            {
                resultado = x.ColumnName.CompareTo(y.ColumnName);
            }

            return resultado;
        }

        public bool Equals(Column x, Column y)
        {
            if (x == null || y == null)
                return false;
            return x.TableName.ToLower() == y.TableName.ToLower() && x.ColumnName.ToLower() == y.ColumnName.ToLower() && x.DataType.ToLower() == y.DataType.ToLower() && x.MaximunLength.ToLower() == y.MaximunLength.ToLower();
        }

        public int GetHashCode(Column obj)
        {
            int hashTableName = obj.TableName == null ? 0 : obj.TableName.ToLower().GetHashCode();
            int hashColumnName = obj.ColumnName == null ? 0 : obj.ColumnName.ToLower().GetHashCode();
            int hashDataType = obj.DataType == null ? 0 : obj.DataType.ToLower().GetHashCode();
            int hashMaximunLength = obj.MaximunLength == null ? 0 : obj.MaximunLength.ToLower().GetHashCode();
            return hashTableName + hashColumnName + hashDataType + hashMaximunLength;
        }
    }


}
