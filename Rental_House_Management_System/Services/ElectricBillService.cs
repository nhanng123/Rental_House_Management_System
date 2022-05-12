using Rental_House_Management_System.Data;
using Rental_House_Management_System.Models;

namespace Rental_House_Management_System.Services
{
    public class ElectricBillService : IElectricBillService
    {
        private readonly ElectricBillDbContext electricBillDbContext;

        public ElectricBillService(ElectricBillDbContext electricBillDbContext)
        {
            this.electricBillDbContext = electricBillDbContext;
        }
        public bool AddElectricBill(ElectricBill electricBill)
        {
            electricBillDbContext.electricBills.Add(electricBill);
            electricBillDbContext.SaveChanges();
            return true;
        }

        public List<ElectricBill> GetElectricBills(string roomId)
        {
           return electricBillDbContext.electricBills.Where(e => e.RoomId == roomId).ToList();
        }

        public ElectricBill GetLatestElectricBill(string roomId)
        {
                List<ElectricBill> temp =  electricBillDbContext.electricBills
                .Where(e => e.RoomId == roomId)
                .OrderByDescending(e => e.Electric_Date)
                .Take(1).ToList();
            return temp[0];
        }
    }
}
