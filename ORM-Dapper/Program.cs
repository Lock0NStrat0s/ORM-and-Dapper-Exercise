using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using System.Data;

namespace ORM_Dapper;

public class Program
{
    static void Main(string[] args)
    {
        var config = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

        string connString = config.GetConnectionString("DefaultConnection");

        IDbConnection conn = new MySqlConnection(connString);

        var departmentRepo = new DapperDepartmentRepository(conn);

        //departmentRepo.InsertDepartment("Bippity Bop Dept");

        var departments = departmentRepo.GetAllDepartments();

        foreach (var item in departments)
        {
            Console.WriteLine($"{item.DepartmentID}: {item.Name}");
        }
    }
}
