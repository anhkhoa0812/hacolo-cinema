using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.BookTicket
{
    public interface IOrderRepository
    {
        public int GetMaxOrderId();
        public void SaveOrder(Order order);
        public void UpdateOrder(Order order);
        public void DeleteOrder(int id);
        public Order getOrderById(int id);
    }
}
