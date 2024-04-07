using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.movieandorder
{
    public interface IOrderRepository
    {
        List<Order> GetAll();

        Order GetOrderById(int orderId);

        void UpdateOrder(Order order);
    }
}
