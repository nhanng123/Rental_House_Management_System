using Rental_House_Management_System.Models;

namespace Rental_House_Management_System.Services
{
    public interface IBillService
    {
        List<Bill> GetBills();
        Bill GetBill(string id);
        Boolean AddBill(Bill bill);
        Boolean UpdateBill(Bill bill);
        Boolean RemoveBill(string id);
    }
}
