using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainApp.TestDBDataSetTableAdapters;

namespace MainApp.Model
{
    internal class EmployeeServices
    {
        private readonly TestDBDataSet _dbDataSet;

        public EmployeeServices(TestDBDataSet dbDataSet)
        {
            _dbDataSet = dbDataSet;
        }

        public void LoadEmployee()
        {
            EmpoyeeTableAdapter taEmployee = new EmpoyeeTableAdapter();
            taEmployee.Fill(_dbDataSet.Empoyee);
        }

        public void SaveEmployee()
        {
            EmpoyeeTableAdapter taEmployee = new EmpoyeeTableAdapter();
            taEmployee.Update(_dbDataSet.Empoyee);
        }
    }
}
