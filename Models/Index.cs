using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlValidator.Models
{
    public class Index
    {
        public string TableName { get; set; }
        public string ColumnName { get; set; }
        public string IndexName { get; set; }
        public string IndexType { get; set; }
    }
    public class IndexesComparer : IComparer<Index>, IEqualityComparer<Index>
    {
        public int Compare(Index x, Index y)
        {
            int resultado = x.TableName.CompareTo(y.TableName);
            if (resultado == 0)
            {
                resultado = x.ColumnName.CompareTo(y.ColumnName);
            }
            if (resultado == 0)
            {
                resultado = x.IndexName.CompareTo(y.IndexName);
            }

            return resultado;
        }

        public bool Equals(Index x, Index y)
        {
            if (x == null || y == null)
                return false;
            return x.TableName.ToLower() == y.TableName.ToLower() && x.ColumnName.ToLower() == y.ColumnName.ToLower() && x.IndexName.ToLower() == y.IndexName.ToLower() && x.IndexType.ToLower() == y.IndexType.ToLower();
        }

        public int GetHashCode(Index obj)
        {
            int hashTableName = obj.TableName == null ? 0 : obj.TableName.ToLower().GetHashCode();
            int hashColumnName = obj.ColumnName == null ? 0 : obj.ColumnName.ToLower().GetHashCode();
            int hashIndexName = obj.IndexName == null ? 0 : obj.IndexName.ToLower().GetHashCode();
            int hashIndexType = obj.IndexType == null ? 0 : obj.IndexType.ToLower().GetHashCode();
            return hashTableName + hashColumnName + hashIndexName + hashIndexType;
        }
    }
}
