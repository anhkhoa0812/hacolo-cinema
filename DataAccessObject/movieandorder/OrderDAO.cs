using BussinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject.movieandorder
{
    public class OrderDAO
    {
        private static OrderDAO instance = null;
        private static object lockObject = new object();
        public static OrderDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new OrderDAO();
                }
                return instance;
            }
        }

        public OrderDAO() { }

        public List<Order> GetAllOrder()
        {
            using var db = new HacoloCinemaContext();
            return db.Orders.Include(c => c.Customer)
                .Include(p => p.Payment).ToList();
        }

        public Order GetOrderById(int orderId)
        {
            using var db = new HacoloCinemaContext();
            return db.Orders.FirstOrDefault(o => o.OrderId == orderId);
        }

        public void UpdateOrder(Order order)
        {
            using var db = new HacoloCinemaContext();
            db.Orders.Update(order);
            db.SaveChanges();
        }
    }
}
