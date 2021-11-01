using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    class OrderDAO
    {
        private static OrderDAO instance = null;
        private static readonly object instanceLock = new object();
        private OrderDAO() { }
        public static OrderDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new OrderDAO();
                    }
                    return instance;
                }
            }
        }
        public List<Order> GetListOrders()
        {
            var list = new List<Order>();
            using (var db = new FStoreContext())
            {
                list = db.Orders.ToList();
            }
            return list;
        }
        public Order GetOrderById(int id)
        {
            Order order = null;
            using (var db = new FStoreContext())
            {
                order = db.Orders.Find(id);
            }
            return order;
        }
        public void InsertOrder(Order order)
        {
            Order check = GetOrderById(order.OrderId);
            if (check == null)
            {
                using (var db = new FStoreContext())
                {
                    db.Orders.Add(order);
                    db.SaveChanges();
                }
            } 
            else
            {
                throw new Exception("Order exists already!");
            }
        }
        public void UpdateOrder(Order order)
        {
            Order check = GetOrderById(order.OrderId);
            if (check != null)
            {
                using (var db = new FStoreContext())
                {
                    check = db.Orders.Where(o => o.OrderId == order.OrderId).First();
                    db.Orders.Update(order);
                    db.SaveChanges();
                }
            }
            else
            {
                throw new Exception("Order does not exist!");
            }
        }
        public void RemoveOrder(int id)
        {
            Order check = GetOrderById(id);
            if (check != null)
            {
                using (var db = new FStoreContext())
                {
                    db.Orders.Remove(check);
                    db.SaveChanges();
                }
            }
            else
            {
                throw new Exception("Order does not exist!");
            }
        }
        public List<Order> GetOrdersByDate(DateTime startDate, DateTime endDate){
            using(var db = new FStoreContext())
            {
                var list = (from order in db.Orders orderby order.OrderDate where order.OrderDate >= startDate && order.OrderDate <= endDate select order).ToList();
                return list;           
            }
        }
    }
}
