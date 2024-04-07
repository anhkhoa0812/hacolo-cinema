using BussinessObject;
using DataAccessObject.BookTicket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.BookTicket
{
    public class OrderDetailComboRepository : IOrderDetailComboRepository
    {
        public List<OrderDetailComboDTO> GetOrderDetailCombosByOrderId(int orderId) => OrderDetailComboDAO.GetOrderDetailCombosByOrderId(orderId);
    }
}
