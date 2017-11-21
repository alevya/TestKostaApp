using System;
using System.Collections;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using MainApp.TestDBDataSetTableAdapters;

namespace MainApp.Model
{
    internal class DbService : IDbService
    {

        private readonly string _connectionString;
        private readonly TestDBDataSet _dbDataSet;

        public DbService()
        {
            _dbDataSet = new TestDBDataSet();

            _connectionString = ConfigurationManager
                .ConnectionStrings["MainApp.Properties.Settings.TestDBConnectionString"]
                .ConnectionString;
        }

        public IEnumerable LoadEmployee()
        {
            var taEmployee = new EmpoyeeTableAdapter();
            taEmployee.Fill(_dbDataSet.Empoyee);
            return taEmployee.GetData();
        }

        public IEnumerable LoadDepartment()
        {
            var taDepartment = new DepartmentTableAdapter();
            taDepartment.Fill(_dbDataSet.Department);
            return taDepartment.GetData();
            //IEnumerable result = null;
            //string sql = "SELECT * FROM Department";
            //using (SqlConnection connection = new SqlConnection(_connectionString))
            //{
            //    connection.Open();
            //    var sqlAdapter = new SqlDataAdapter(sql, connection);
            //    DataSet ds = new DataSet();
            //    sqlAdapter.Fill(ds);
            //    return ds.Tables.Count == 1 ? ds.Tables[0].Rows : null;
            //}
        }

        public IEnumerable LoadEmployee(Guid pkDepartment)
        {
            return null;

        }

        public void SaveEmployee()
        {
            EmpoyeeTableAdapter taEmployee = new EmpoyeeTableAdapter();
            taEmployee.Update(_dbDataSet.Empoyee);
        }
    }
}
