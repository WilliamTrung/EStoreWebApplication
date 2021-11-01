using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class ProductRepository : IProductRepository
    {
        public List<Product> GetListProducts() => ProductDAO.Instance.GetListProducts();

        public Product GetOrderById(int id) => ProductDAO.Instance.GetProductById(id);

        public Product GetProductById_Name(int id, string productName) => ProductDAO.Instance.GetProductsById_Name(id, productName);

        public List<Product> GetProductsByUnitPrice_UnitInStock(int unitPrice, int unitInStock) => ProductDAO.Instance.GetProductsByUnitPrice_UnitInStock(unitPrice, unitInStock);

        public void Insert(Product product) => ProductDAO.Instance.InsertProduct(product);

        public void Remove(int id) => ProductDAO.Instance.RemoveProduct(id);

        public void Update(Product product) => ProductDAO.Instance.UpdateProduct(product);
    }
}
