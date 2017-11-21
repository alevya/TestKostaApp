using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MainApp.Model
{
    internal interface IDbService
    {
        IEnumerable<Employee> LoadEmployee();
        IEnumerable<Department> LoadDepartment();

    }
}
