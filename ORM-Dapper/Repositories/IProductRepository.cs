using ORM_Dapper.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ORM_Dapper.Repositories;

public interface IProductRepository
{
    public void CreateProduct(string name, double price, int categoryID, string stock);   // CREATE

    public IEnumerable<Product> GetAllProducts();                           // READ ALL

    public Product GetSingleProduct(int productID);                         // READ SINGLE

    public void UpdateProduct(int id, Product p);                                   // UPDATE

    public void DeleteProduct(int id);                                      // DELETE
}
