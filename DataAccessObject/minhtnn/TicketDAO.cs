using BussinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject
{
    public class TicketDAO
    {
        private static TicketDAO instance = null;
        private static object lockObject = new object();
        public static TicketDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new TicketDAO();
                }
                return instance;
            }
        }
        public TicketDAO() { }
        public Ticket GetTicketById(int ticketId)
        {
            using var db = new HacoloCinemaContext();
            return db.Tickets.Include(f => f.Seat).SingleOrDefault(f => f.TicketId == ticketId);
        }
        public List<Ticket> GetTicketsByOrderId(int orderId)
        {
            using var db = new HacoloCinemaContext();
            return db.Orders.Include(f => f.Tickets).SingleOrDefault(f => f.OrderId == orderId)?.Tickets.ToList();
        }
    }
}
