using Microsoft.Extensions.Configuration;
using MySql.Data.MySqlClient;
using ORM_Dapper.Models;
using ORM_Dapper.Repositories;
using System.ComponentModel.DataAnnotations;
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

        // department CRUD
        //RunDepartment(conn);

        // product CRUD
        RunProduct(conn);
    }

    private static void RunProduct(IDbConnection conn)
    {
        // create connection to db
        var productRepo = new DapperProductRepository(conn);

        // create new product
        //productRepo.CreateProduct("IN DA JUNGLE, DA MIGHTY JUNGLE!", 12.34, 10, "9999");

        // store all products as an IEnumerable
        var products = productRepo.GetAllProducts();
        //products.ToList().ForEach(x => Console.WriteLine(x.Name + ": " + x.Price));

        // get single product
        var product = productRepo.GetSingleProduct(940);
        Console.WriteLine(product.Name + " " + product.Price);
    }

    private static void RunDepartment(IDbConnection conn)
    {
        // create connection to db
        var departmentRepo = new DapperDepartmentRepository(conn);

        // create new department
        //departmentRepo.CreateDepartment("XR");

        // store all departments as an IEnumerable
        var departments = departmentRepo.GetAllDepartments();

        // display all departments
        departments.ToList().ForEach(x => Console.WriteLine($"\n{x.DepartmentID}: {x.Name}"));

        // update created department
        //departmentRepo.UpdateDepartment(6, "AR");

        // display all departments
        //departments = departmentRepo.GetAllDepartments();
        //departments.ToList().ForEach(x => Console.WriteLine($"\n{x.DepartmentID}: {x.Name}"));

        // delete department from db
        //departmentRepo.DeleteDepartment(7);

        // display all departments
        //departments = departmentRepo.GetAllDepartments();
        //departments.ToList().ForEach(x => Console.WriteLine($"\n{x.DepartmentID}: {x.Name}"));
    }
}
