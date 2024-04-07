using BussinessObject.Models;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessObject.minhtnn
{
    public class CustomerDAO
    {
        private static CustomerDAO instance = null;
        private static object lockObject = new object();
        private CustomerDAO() { }
        public static CustomerDAO Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CustomerDAO();
                }
                return instance;
            }
        }
        public List<Customer> GetCustomers()
        {
            using var db = new HacoloCinemaContext();
            return db.Customers.ToList();
        }
        public int GetNewCustomerId()
        {
            using var db = new HacoloCinemaContext();
            return db.Customers.Max(f => f.CustomerId) + 1;
        }
        public Customer GetCustomerByPhoneAndPassword(string phone, string password)
        {
            using var db = new HacoloCinemaContext();
            return db.Customers.FirstOrDefault(f => (f.PhoneNumber.Equals(phone) && f.Password.Equals(password)));
        }
        public Admin GetAdmin()
        {
            IConfiguration configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
             .AddJsonFile("appsettings.json", true, true).Build();
            var AdminEmail = configuration["Admin:Email"];
            var AdminPassord = configuration["Admin:Password"];
            var Admin = new Admin()
            {
                Email = AdminEmail,
                Password = AdminPassord
            };
            return Admin;
        }
        public List<Customer> GetCustomerByName(string name)
        {
            using var db = new HacoloCinemaContext();
            return db.Customers.Where(f => f.CustomerName.Contains(name)).ToList();
        }
        public List<Customer> GetCustomersAscending()
        {
            using var db = new HacoloCinemaContext();
            return db.Customers.OrderBy(f => f.CustomerName).ToList();
        }
        public bool IsPhoneExist(string phone)
        {
            using var db = new HacoloCinemaContext();
            var customers = db.Customers.SingleOrDefault(f => f.PhoneNumber.Equals(phone));
            return customers != null;
        }
        public bool IsEmailExist(string email)
        {
            using var db = new HacoloCinemaContext();
            var customers = db.Customers.SingleOrDefault(f => f.Email.Equals(email));
            return customers != null;
        }
        public bool AddCustomer(Customer customer)
        {
            using var db = new HacoloCinemaContext();
            db.Customers.Add(customer);
            var change = db.SaveChanges();
            return change > 0;
        }
        public bool UpdateCustomer(Customer newCustomer)
        {
            var customer = GetCustomerByPhoneAndPassword(newCustomer.PhoneNumber, newCustomer.Password);
            if (customer != null)
            {
                customer = newCustomer;
                using var db = new HacoloCinemaContext();
                db.Customers.Update(customer);
                var change = db.SaveChanges();
                return change > 0;
            }
            return false;
        }
    }
}
