using BussinessObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.BookTicket
{
    public interface IOrderDetailComboRepository
    {

        public List<OrderDetailComboDTO> GetOrderDetailCombosByOrderId(int orderId);
    }
}
