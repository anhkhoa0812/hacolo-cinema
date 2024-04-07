using BussinessObject.Models;
using DataAccessObject.minhtnn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.mintnn
{
    public class OrderDetailRRepository : IOrderDetailRepository
    {
        public List<OrderDetailCombo> GetOrderDetailCombosByOrderId(int orderId)
            => OrderDetailDAO.Instance.GetOrderDetailCombosByOrderId(orderId);
    }
}
