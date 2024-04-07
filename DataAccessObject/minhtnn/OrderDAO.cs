using BussinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject.minhtnn
{
    public class OrderDAO
    {
        private static OrderDAO instance;
        private static object lockObject = new object();

        private OrderDAO() { }
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
        public List<Order> GetOrdersByCustomerId(int customerId)
        {
            using var db = new HacoloCinemaContext();
            return db.Orders.Include(f => f.Tickets).Where(f => f.CustomerId.Equals(customerId)).ToList();
        }
        public List<Order> GetOrdersByCustomerIdAndDate(int customerId, DateTime startDate, DateTime endDate)
        {
            using var db = new HacoloCinemaContext();
            return db.Orders.Include(f => f.Tickets).Where(f => f.CustomerId.Equals(customerId) && f.OrderDate >= startDate && f.OrderDate <= endDate).ToList();
        }
        public Order GetTicketsByOrderId(int orderId)
        {
            using var db = new HacoloCinemaContext();
            return db.Orders.Include(f => f.Tickets).SingleOrDefault(f => f.OrderId == orderId);
        }
        public decimal GetOrderPrice(int orderId)
        {
            decimal total = 0;
            using var db = new HacoloCinemaContext();
            var comboList = db.OrderDetailCombos.Where(f => f.OrderId == orderId).ToList();
            var ticketList = db.Orders.Include(f => f.Tickets).SingleOrDefault(f => f.OrderId == orderId).Tickets.ToList();
            foreach (var combo in comboList)
            {
                var comboPrice = db.Combos.SingleOrDefault(f => f.ComboId == combo.ComboId).ComboPrice;
                total += (decimal)combo.Quantity * comboPrice.Value;
            }
            foreach (var ticket in ticketList)
            {
                total += ticket.TicketPrice.Value;
            }
            return total;
        }
    }
}
