using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MainApp.Model;

namespace MainApp
{
    public class EntityDbService: IDbService
    {
        public IEnumerable<Employee> LoadEmployee()
        {
            using (var dbContext = new TestDbContext())
            {
                var sql = "SELECT * FROM Empoyee";
                return dbContext.Database.SqlQuery<Employee>(sql).ToList();
            }
        }

        public IEnumerable<Department> LoadDepartment()
        {
            return null;
        }
    }
}
