using BussinessObject.Models;
using DataAccessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.mintnn
{
    public class TicketRepository : ITicketRepository
    {
        public Ticket GetTicketById(int ticketId)
            => TicketDAO.Instance.GetTicketById(ticketId);

        public List<Ticket> GetTicketsByOrderId(int orderId)
            => TicketDAO.Instance.GetTicketsByOrderId(orderId);
    }
}
