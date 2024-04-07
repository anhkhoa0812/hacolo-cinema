using BussinessObject;
using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.BookTicket
{
    public interface ITicketRepository
    {
        public bool IsSeatBooked(int showtimeId, string seatPosition);
        public int GetMaxTicketId();
        public Seat getSeatBySeatPosition(string seatPosition);
        public List<TicketDTO> GetTicketsByOrderId(int orderId);
        public List<Ticket> GetTicketListByOrderId(int orderId);
        public Ticket getTicketById(int id);
        public void UpdateTicket(Ticket ticket);
        public void SaveTicket(Ticket ticket);
    }
}
