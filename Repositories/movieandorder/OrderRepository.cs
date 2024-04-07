using BussinessObject.Models;
using DataAccessObject.movieandorder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.movieandorder
{
    public class OrderRepository : IOrderRepository
    {
        public List<Order> GetAll() => OrderDAO.Instance.GetAllOrder();

        public Order GetOrderById(int orderId) => OrderDAO.Instance.GetOrderById(orderId);

        public void UpdateOrder(Order order) => OrderDAO.Instance.UpdateOrder(order);
    }
}
