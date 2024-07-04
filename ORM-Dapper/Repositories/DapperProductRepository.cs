using Dapper;
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

    public void CreateProduct(string name, double price, int categoryID, string stock)
    {
        _conn.Execute("INSERT INTO products (name, price, categoryID, stocklevel) VALUES (@name, @price, @categoryID, @stocklevel);", new { name, price, categoryID, stocklevel = stock });
    }

    public void DeleteProduct(int id)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Product> GetAllProducts()
    {
        return _conn.Query<Product>("SELECT * FROM products;");
    }

    public Product GetSingleProduct(int productID)
    {
        return _conn.QuerySingle<Product>("SELECT * FROM products WHERE productID = @productID", new { productID });
    }

    public void UpdateProduct(int id, Product p)
    {
        throw new NotImplementedException();
    }
}
