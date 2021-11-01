using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    class OrderDetailDAO
    {
        private static OrderDetailDAO instance = null;
        private static readonly object instanceLock = new object();
        private OrderDetailDAO() { }
        public static OrderDetailDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDetailDAO();
                    }
                    return instance;
                }
            }
        }
        public static void Remove(OrderDetail orderDetail)
        {
            try
            {
                using (var context = new FStoreContext())
                {
                    context.Remove(orderDetail);
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static void Update(OrderDetail orderDetail)
        {
            try
            {
                using (var context = new FStoreContext())
                {
                    context.Entry<OrderDetail>(orderDetail).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                    context.SaveChanges();
                }
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public static List<OrderDetail> GetOrderDetailsByOrder(Order order)
        {
            List<OrderDetail> list = new List<OrderDetail>();
            try
            {
                using (var context = new FStoreContext())
                {
                    list = context.OrderDetails.Where(order_detail => order_detail.OrderId == order.OrderId).ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return list;
        }
        private static OrderDetail GenerateOrderDetail(Product product, Order order, int quantity)
        {
            OrderDetail detail = new OrderDetail()
            {
                Order = order,
                OrderId = order.OrderId,
                Product = product,
                ProductId = product.ProductId,
                Quantity = quantity,
                UnitPrice = product.UnitPrice
            };
            return detail;
        }
        public static void InsertOrderDetail(Product product, Order order, int quantity)
        {
            try
            {
                OrderDetail detail = GenerateOrderDetail(product, order, quantity);
                using (var context = new FStoreContext())
                {
                    context.Add(detail);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
