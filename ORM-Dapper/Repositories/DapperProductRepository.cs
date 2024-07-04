using ORM_Dapper.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_Dapper.Repositories;

public class DapperProductRepository : IProductRepository
{
    private readonly IDbConnection _conn;

    public DapperProductRepository(IDbConnection conn)
    {
        _conn = conn;
    }

    public void CreateProduct(string name, double price, int categoryID)
    {
        throw new NotImplementedException();
    }

    public void DeleteProduct(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Product> GetAllProducts()
    {
        throw new NotImplementedException();
    }

    public Product GetSingleProduct(int productID)
    {
        throw new NotImplementedException();
    }

    public void UpdateProduct(Product p)
    {
        throw new NotImplementedException();
    }
}
