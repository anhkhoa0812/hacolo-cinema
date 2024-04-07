using BussinessObject.Models;
using DataAccessObject.BookTicket;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.BookTicket
{
    public class ComboRepository : IComboRepository
    {
        public List<Combo> GetCombos() => ComboDAO.GetCombos();
    }
}
