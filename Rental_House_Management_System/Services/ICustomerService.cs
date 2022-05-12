using Rental_House_Management_System.Models;

namespace Rental_House_Management_System.Services
{
    public interface ICustomerService
    {
        List<Customer> GetCustomers();

        Customer GetCustomer(int customerId);
        Boolean AddCustomer(Customer customer);
        Boolean RemoveCustomer(int customerId);
        Boolean UpdateCustomer(Customer customer);

        Boolean ChangeRoom( int customerId, string roomId);
    }
}
