using BussinessObject.Models;
using DataAccessObject.BookTicket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.BookTicket
{
    public class OrderDetailRepository : IOrderRepository
    {
        public void DeleteOrder(int id) => OrderDAO.DeleteOrder(id);

        public int GetMaxOrderId() => OrderDAO.GetMaxOrderId();

        public Order getOrderById(int id) => OrderDAO.getOrderById(id);

        public void SaveOrder(Order order) => OrderDAO.SaveOrder(order);

        public void UpdateOrder(Order order) => OrderDAO.UpdateOrder(order);
    }
}
