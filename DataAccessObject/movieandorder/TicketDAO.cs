using BussinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject.movieandorder
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

        public List<Ticket> GetTicketsByOrderId(int orderId)
        {
            using var db = new HacoloCinemaContext();
            return db.Tickets
                .Include(t => t.Showtime)
                .Include(t => t.Showtime.Movie)
                .Include(t => t.Showtime.Theater)
                .Include(t => t.Seat)
                .ToList()
                .Where(t => t.OrderId == orderId).ToList();
        }
    }
}
