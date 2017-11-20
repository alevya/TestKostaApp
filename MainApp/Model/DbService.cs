using System.Collections;
using System.Collections.Generic;
using MainApp.TestDBDataSetTableAdapters;

namespace MainApp.Model
{
    internal class DbService : IDbService
    {
        private readonly TestDBDataSet _dbDataSet;

        public DbService()
        {
            _dbDataSet = new TestDBDataSet();
        }

        public IEnumerable LoadEmployee()
        {
            EmpoyeeTableAdapter taEmployee = new EmpoyeeTableAdapter();
            taEmployee.Fill(_dbDataSet.Empoyee);
            return taEmployee.GetData();
        }

        public void SaveEmployee()
        {
            EmpoyeeTableAdapter taEmployee = new EmpoyeeTableAdapter();
            taEmployee.Update(_dbDataSet.Empoyee);
        }
    }
}
