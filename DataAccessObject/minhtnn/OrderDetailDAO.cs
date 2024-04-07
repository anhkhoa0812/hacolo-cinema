using BussinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject.minhtnn
{
    public class OrderDetailDAO
    {
        private static OrderDetailDAO instance;
        private static object lockObject = new object();
        public static OrderDetailDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new OrderDetailDAO();
                }
                return instance;
            }
        }
        public OrderDetailDAO() { }
        public List<OrderDetailCombo> GetOrderDetailCombosByOrderId(int orderId)
        {
            using var db = new HacoloCinemaContext();
            return db.OrderDetailCombos.Include(x => x.Combo).Where(f => f.OrderId.Equals(orderId)).ToList();
        }

    }
}
