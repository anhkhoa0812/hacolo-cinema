using BussinessObject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.mintnn
{
    public interface ICustomerRepository
    {
        List<Customer> GetCustomers();
        List<Customer> GetCustomerByName(string name);
        List<Customer> GetCustomersAscending();
        Customer GetCustomerByPhoneAndPassword(string phone, string password);
        int GetNewCustomerId();
        bool AddCustomer(Customer customer);
        bool UpdateCustomer(Customer newCustomer);
        Admin GetAdmin();
        bool IsPhoneExist(string phone);
    }
}
