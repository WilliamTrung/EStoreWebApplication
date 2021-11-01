using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public interface IProductRepository
    {
        public List<Product> GetListProducts();
        public Product GetOrderById(int id);
        public void Insert(Product product);
        public void Update(Product product);
        public void Remove(int id);
        public Product GetProductById_Name(int id, string productName);
        public List<Product> GetProductsByUnitPrice_UnitInStock(int unitPrice, int unitInStock);
    }
}
