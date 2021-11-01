using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    class ProductDAO
    {
        private static ProductDAO instance = null;
        private static readonly object instanceLock = new object();
        private ProductDAO() { }
        public static ProductDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new ProductDAO();
                    }
                    return instance;
                }
            }
        }
        public List<Product> GetListProducts()
        {
            var list = new List<Product>();
            using (var db = new FStoreContext())
            {
                list = db.Products.ToList();
            }
            return list;
        }
        public Product GetProductById(int id)
        {
            Product product = null;
            using (var db = new FStoreContext())
            {
                product = db.Products.Find(id);
            }
            return product;
        }
        public void InsertProduct(Product product)
        {
            Product check = GetProductById(product.ProductId);
            if (check == null)
            {
                using (var db = new FStoreContext())
                {
                    db.Products.Add(product);
                    db.SaveChanges();
                }
            }
            else
            {
                throw new Exception("Product exists already!");
            }
        }
        public void UpdateProduct(Product product)
        {
            Product check = GetProductById(product.ProductId);
            if (check != null)
            {
                using (var db = new FStoreContext())
                {
                    db.Products.Update(product);
                    db.SaveChanges();
                }
            }
            else
            {
                throw new Exception("Product does not exist!");
            }
        }
        public void RemoveProduct(int id)
        {
            Product check = GetProductById(id);
            if (check != null)
            {
                using (var db = new FStoreContext())
                {
                    db.Products.Remove(check);
                    db.SaveChanges();
                }
            }
            else
            {
                throw new Exception("Product does not exist!");
            }
        }
        public Product GetProductsById_Name(int id,string productName)
        {
            Product product = null;
            using (var db = new FStoreContext())
            {
                product = db.Products.Find(id);
                if (!product.ProductName.Equals(productName))
                {
                    product = null;
                }
            }
            return product;
        }
        public List<Product> GetProductsByUnitPrice_UnitInStock(int unitPrice, int unitInStock)
        {
            List<Product> list = new List<Product>();
            using(var db = new FStoreContext())
            {
                list = db.Products.Where(pro => pro.UnitPrice == unitPrice && pro.UnitsInStock == unitInStock).ToList();
            }
            return list;
        }
    }
}
