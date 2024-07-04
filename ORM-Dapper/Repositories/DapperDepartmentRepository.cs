using Dapper;
using ORM_Dapper.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ORM_Dapper.Repositories;

public class DapperDepartmentRepository : IDepartmentRepository
{
    private readonly IDbConnection _conn;

    public DapperDepartmentRepository(IDbConnection conn)
    {
        _conn = conn;
    }

    public void CreateDepartment(string name)
    {
        _conn.Execute("INSERT INTO departments (Name) VALUES (@name);",
            new { name });
    }

    public IEnumerable<Department> GetAllDepartments()
    {
        return _conn.Query<Department>("SELECT * FROM departments;");
    }

    public void DeleteDepartment(int id)
    {
        _conn.Execute("DELETE FROM departments WHERE DepartmentID = @id;", new { id });
    }

    public Department GetSingleDepartment(int id)
    {
        return _conn.QuerySingle<Department>("SELECT * FROM departments WHERE DepartmentID = @id;", new { id });
    }

    public void UpdateDepartment(int id, string name)
    {
        _conn.Execute("UPDATE departments SET name = @name WHERE DepartmentID = @id;", new { name, id });
    }
}
