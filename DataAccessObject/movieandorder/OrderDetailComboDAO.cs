using BussinessObject.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject.movieandorder
{
    public class OrderDetailComboDAO
    {
        private static OrderDetailComboDAO instance = null;
        private static object lockObject = new object();

        public static OrderDetailComboDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new OrderDetailComboDAO();
                }
                return instance;
            }
        }

        public OrderDetailComboDAO() { }

        public List<OrderDetailCombo> GetOrderDetailCombosByOrderId(int orderId)
        {
            using var db = new HacoloCinemaContext();
            return db.OrderDetailCombos
                .Include(odc => odc.Combo)
                .ToList()
                .Where(odc => odc.OrderId == orderId)
                .ToList();
        }
    }
}
