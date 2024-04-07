using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.mintnn
{
    public interface IOrderRepository
    {
        List<Order> GetOrdersByCustomerId(int customerId);
        List<Order> GetOrdersByCustomerIdAndDate(int customerId, DateTime startDate, DateTime endDate);
        decimal GetOrderPrice(int orderId);
    }
}
