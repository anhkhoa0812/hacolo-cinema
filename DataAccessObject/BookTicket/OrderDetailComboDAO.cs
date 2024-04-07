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
    public class OrderDetailComboDAO
    {
        public static List<OrderDetailComboDTO> GetOrderDetailCombosByOrderId(int orderId)
        {
            using var db = new HacoloCinemaContext();

            var orderDetailsWithRelatedData = db.OrderDetailCombos
                .Where(f => f.OrderId == orderId)
                .Include(od => od.Combo)
                .Select(od => new OrderDetailComboDTO
                {
                    ComboName = od.Combo.ComboName,
                    ComboPrice = od.Combo.ComboPrice,
                    Quantity = od.Quantity
                })
                .ToList();

            return orderDetailsWithRelatedData;
        }
    }
}
