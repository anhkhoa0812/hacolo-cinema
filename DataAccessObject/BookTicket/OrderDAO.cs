using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject.BookTicket
{
    public class OrderDAO
    {
        public static int GetMaxOrderId()
        {
            try
            {
                using (var context = new HacoloCinemaContext())
                {
                    var maxId = context.Orders.Max(p => (int?)p.OrderId); // Lấy mã ID lớn nhất
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
        public static void SaveOrder(Order order)
        {
            try
            {
                using (var context = new HacoloCinemaContext())
                {
                    context.Orders.Add(order);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static void UpdateOrder(Order order)
        {
            try
            {
                using (var context = new HacoloCinemaContext())
                {
                    context.Orders.Update(order);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        public static void DeleteOrder(int id)
        {
            try
            {
                using (var context = new HacoloCinemaContext())
                {
                    var order = context.Orders.Find(id);
                    context.Orders.Remove(order);
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public static Order getOrderById(int id)
        {
            Order order = null;
            try
            {
                using (var context = new HacoloCinemaContext())
                {
                    order = context.Orders.SingleOrDefault(o => o.OrderId == id);
                }
                return order;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
