using BussinessObject;
using BussinessObject.Models;
using DataAccessObject.BookTicket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.BookTicket
{
    public class TicketRepository : ITicketRepository
    {
        public int GetMaxTicketId() => TicketDAO.GetMaxTicketId();

        public Seat getSeatBySeatPosition(string seatPosition) => TicketDAO.getSeatBySeatPosition(seatPosition);

        public Ticket getTicketById(int id) => TicketDAO.getTicketById(id);

        public List<Ticket> GetTicketListByOrderId(int orderId) => TicketDAO.GetTicketListByOrderId(orderId);

        public List<TicketDTO> GetTicketsByOrderId(int orderId) => TicketDAO.GetTicketsByOrderId(orderId);

        public bool IsSeatBooked(int showtimeId, string seatPosition) => TicketDAO.IsSeatBooked(showtimeId, seatPosition);

        public void SaveTicket(Ticket ticket) => TicketDAO.SaveTicket(ticket); 

        public void UpdateTicket(Ticket ticket) => TicketDAO.UpdateTicket(ticket);
    }
}
