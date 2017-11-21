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
            var taEmployee = new EmpoyeeTableAdapter();
            taEmployee.Fill(_dbDataSet.Empoyee);
            return taEmployee.GetData();
        }

        public IEnumerable LoadDepartment()
        {
            var taDepartment= new DepartmentTableAdapter();
            taDepartment.Fill(_dbDataSet.Department);
            return taDepartment.GetData();
        }

        public void SaveEmployee()
        {
            EmpoyeeTableAdapter taEmployee = new EmpoyeeTableAdapter();
            taEmployee.Update(_dbDataSet.Empoyee);
        }
    }
}
