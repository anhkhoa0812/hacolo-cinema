using BussinessObject;
using BussinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject.BookTicket
{
    public class TicketDAO
    {
        public static bool IsSeatBooked(int showtimeId, string seatPosition)
        {
            using (var context = new HacoloCinemaContext())
            {
                var ticket = context.Tickets
                    .Include(t => t.Seat)
                    .Include(t => t.Showtime)
                    .FirstOrDefault(t => t.ShowtimeId == showtimeId &&
                                         t.Seat.SeatPosition == seatPosition &&
                                         t.IsSold == true);
                return ticket != null;
            }
        }
        public static List<TicketDTO> GetTicketsByOrderId(int orderId)
        {
            using var db = new HacoloCinemaContext();

            var ticketsWithRelatedData = db.Tickets
                .Where(f => f.OrderId == orderId)
                .Include(t => t.Showtime)
                    .ThenInclude(s => s.Movie) // Only need to include Showtime and its related Movie once
                .Include(t => t.Seat) // Include the Seat related to the Ticket
                .Select(tk => new TicketDTO
                {
                    MovieName = tk.Showtime.Movie.MovieName,
                    ShowDate = tk.Showtime.ShowDate,
                    StartTime = tk.Showtime.StartTime,
                    SeatPosition = tk.Seat.SeatPosition,
                    TicketPrice = tk.TicketPrice
                })
                .ToList();

            return ticketsWithRelatedData;
        }

        public static List<Ticket> GetTicketListByOrderId(int orderId)
        {
            try
            {
                using (var context = new HacoloCinemaContext())
                {
                    var ticketList = context.Tickets.Where(t => t.OrderId == orderId).ToList();
                    return ticketList;
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static int GetMaxTicketId()
        {
            try
            {
                using (var context = new HacoloCinemaContext())
                {
                    var maxId = context.Tickets.Max(p => (int?)p.TicketId); // Lấy mã ID lớn nhất
                    if (maxId.HasValue)
                    {
                        return maxId.Value;
                    }
                    else
                    {
                        // Trường hợp không có sản phẩm nào trong cơ sở dữ liệu
                        return 0;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static Seat getSeatBySeatPosition(string seatPosition)
        {
            try
            {
                using (var context = new HacoloCinemaContext())
                {
                    var seat = context.Seats.Where(s => s.SeatPosition == seatPosition);
                    return seat.FirstOrDefault();
                }

            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static Ticket getTicketById(int id)
        {
            Ticket ticket = null;
            try
            {
                using (var context = new HacoloCinemaContext())
                {
                    ticket = context.Tickets.SingleOrDefault(t => t.TicketId == id);
                }
                return ticket;
            }
            catch (Exception)
            {

                throw;
            }
        }
        public static void UpdateTicket(Ticket ticket)
        {
            try
            {
                using (var context = new HacoloCinemaContext())
                {
                    context.Tickets.Update(ticket);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static void SaveTicket(Ticket ticket)
        {
            try
            {
                using (var context = new HacoloCinemaContext())
                {
                    context.Tickets.Add(ticket);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
