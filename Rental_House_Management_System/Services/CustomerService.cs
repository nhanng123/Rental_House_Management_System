using Rental_House_Management_System.Data;
using Rental_House_Management_System.Models;

namespace Rental_House_Management_System.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly CustomerDbContext _customerDbContext;

        public CustomerService(CustomerDbContext customerDbContext)
        {
            _customerDbContext = customerDbContext;
        }
        public bool AddCustomer(Customer customer)
        {
            _customerDbContext.customers.Add(customer);
            _customerDbContext.SaveChanges();
            return true;
        }

        public bool ChangeRoom( int customerId, string roomId)
        {
            Customer customer = _customerDbContext.customers.Find(customerId);
            if(customer == null)
            {
                return false;
            }
            customer.Room = roomId;
            _customerDbContext.customers.Update(customer);
            _customerDbContext.SaveChanges();
            return true;
        }

        public Customer GetCustomer(int customerId)
        {
            return _customerDbContext.customers.Find(customerId);
        }

        public List<Customer> GetCustomers()
        {
            return _customerDbContext.customers.ToList();
        }

        public bool RemoveCustomer(int customerId)
        {
            Customer cus = _customerDbContext.customers.Find(customerId);
            _customerDbContext.customers.Remove(cus);
            _customerDbContext.SaveChanges();
            return true;
        }

        public bool UpdateCustomer(Customer customer)
        {
            _customerDbContext.customers.Update(customer);
            _customerDbContext.SaveChanges();
            return true;
        }
    }
}
