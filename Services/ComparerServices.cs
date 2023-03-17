using SqlValidator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SqlValidator.Services
{
    public class ComparerServices
    {
        public void CompareColumn(List<Column> columnsFromDB, List<Column> columnsFromTemplate, out List<Column> notInDB, out List<Column> notInTemplate)
        {
            notInTemplate = columnsFromDB.Except(columnsFromTemplate, new ColumnsComparer()).ToList();
            notInDB  = columnsFromTemplate.Except(columnsFromDB, new ColumnsComparer()).ToList();
        }

        public void CompareIndex(List<Index> columnsFromDB, List<Index> columnsFromTemplate, out List<Index> notInDB, out List<Index> notInTemplate)
        {
            notInTemplate = columnsFromDB.Except(columnsFromTemplate, new IndexesComparer()).ToList();
            notInDB = columnsFromTemplate.Except(columnsFromDB, new IndexesComparer()).ToList();
        }
    }
}
