using BussinessObject.Models;
using DataAccessObject.minhtnn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.mintnn
{
    public class OrderRepository : IOrderRepository
    {
        public decimal GetOrderPrice(int orderId)
            => OrderDAO.Instance.GetOrderPrice(orderId);
        public List<Order> GetOrdersByCustomerId(int customerId)
            => OrderDAO.Instance.GetOrdersByCustomerId(customerId);

        public List<Order> GetOrdersByCustomerIdAndDate(int customerId, DateTime startDate, DateTime endDate)
            => OrderDAO.Instance.GetOrdersByCustomerIdAndDate(customerId, startDate, endDate);
    }
}
