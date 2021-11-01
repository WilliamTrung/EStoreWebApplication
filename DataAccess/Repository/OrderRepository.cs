using BusinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repository
{
    public class OrderRepository : IOrderRepository
    {
        public List<Order> GetOrders() => OrderDAO.Instance.GetListOrders();
        public Order GetOrderById(int id) => OrderDAO.Instance.GetOrderById(id);
        public void Insert(Order order) => OrderDAO.Instance.InsertOrder(order);
        public void Update(Order order) => OrderDAO.Instance.UpdateOrder(order);
        public void Remove(int id) => OrderDAO.Instance.RemoveOrder(id);

        public List<Order> GetOrdersByDate(DateTime start, DateTime end) => OrderDAO.Instance.GetOrdersByDate(start, end);
    }
}
