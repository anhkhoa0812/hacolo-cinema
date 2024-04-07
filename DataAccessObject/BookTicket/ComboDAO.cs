using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject.BookTicket
{
    public class ComboDAO
    {
        public static List<Combo> GetCombos()
        {
            List<Combo> list = new List<Combo>();
            try
            {
                using (var context = new HacoloCinemaContext())
                {
                    list = context.Combos.ToList();
                }
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return list;
        }
    }
}
