using Rental_House_Management_System.Models;

namespace Rental_House_Management_System.Services
{
    public interface IElectricBillService
    {
        List<ElectricBill> GetElectricBills(string roomId);
        Boolean AddElectricBill(ElectricBill electricBill);
        ElectricBill GetLatestElectricBill(string roomId);
    }
}
