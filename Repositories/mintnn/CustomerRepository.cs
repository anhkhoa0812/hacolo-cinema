using BussinessObject.Models;
using DataAccessObject.minhtnn;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.mintnn
{
    public class CustomerRepository : ICustomerRepository
    {
        public bool AddCustomer(Customer customer)
            => CustomerDAO.Instance.AddCustomer(customer);

        public Admin GetAdmin()
            => CustomerDAO.Instance.GetAdmin();

        public List<Customer> GetCustomerByName(string name)
            => CustomerDAO.Instance.GetCustomerByName(name);

        public Customer GetCustomerByPhoneAndPassword(string phone, string password)
            => CustomerDAO.Instance.GetCustomerByPhoneAndPassword(phone, password);

        public List<Customer> GetCustomers()
            => CustomerDAO.Instance.GetCustomers();

        public List<Customer> GetCustomersAscending()
            => CustomerDAO.Instance.GetCustomersAscending();

        public int GetNewCustomerId()
            => CustomerDAO.Instance.GetNewCustomerId();

        public bool IsPhoneExist(string phone)
            => CustomerDAO.Instance.IsPhoneExist(phone);

        public bool UpdateCustomer(Customer newCustomer)
            => CustomerDAO.Instance.UpdateCustomer(newCustomer);
    }
}
