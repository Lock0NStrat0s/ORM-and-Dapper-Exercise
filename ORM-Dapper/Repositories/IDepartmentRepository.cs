using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ORM_Dapper.Models;

namespace ORM_Dapper.Repositories;

public interface IDepartmentRepository
{
    public void CreateDepartment(string name);          // CREATE

    public IEnumerable<Department> GetAllDepartments(); // READ ALL

    public IEnumerable<Department> GetDepartment(int id);         // READ SINGLE

    public void UpdateDepartment(int id, string name);         // UPDATE

    public void DeleteDepartment(int id);               // DELETE
}
