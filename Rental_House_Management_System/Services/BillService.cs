using Rental_House_Management_System.Data;
using Rental_House_Management_System.Models;

namespace Rental_House_Management_System.Services
{
    public class BillService : IBillService
    {
        private readonly BillDbContext billDbContext;

        public BillService(BillDbContext billDbContext)
        {
            this.billDbContext = billDbContext;
        }
        public bool AddBill(Bill bill)
        {
            billDbContext.bills.Add(bill);
            billDbContext.SaveChanges();
            return true;
        }

        public Bill GetBill(string id)
        {

            return billDbContext.bills.FirstOrDefault(b => b.Id == id);
        }

        public List<Bill> GetBills()
        {
            return billDbContext.bills.ToList();
        }

        public bool RemoveBill(string id)
        {
            Bill bill = GetBill(id);
            billDbContext.bills.Remove(bill);
            billDbContext.SaveChanges();
            return true;
        }

        public bool UpdateBill(Bill bill)
        {
            billDbContext.bills.Update(bill);
            billDbContext.SaveChanges();
            return true;
        }
    }
}
