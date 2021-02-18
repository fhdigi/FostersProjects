using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FosterBalancer
{
    class Program
    {
        private static string DatabaseConnection = "";

        static void Main(string[] args)
        {
            // Local Machine 
            // DatabaseConnection = @"Data Source=LCCSWORK002\SQLEXPRESS;Initial Catalog=DisposalData;Integrated Security=True";
            
            // Server at Office 
            DatabaseConnection = @"Data Source=DESKTOP-JE8H0DC\SQLEXPRESS;Initial Catalog=DisposalData;Integrated Security=True";

            // First run the commercial balance routine 
            RunBalanceRoutineCommercial();

            // Next run the residential balance routine 
            RunBalanceRoutineResidential();
        }

        private static void RunBalanceRoutineCommercial()
        {
            try
            {
                PickupTransaction.RentalCustomer.SetCustomerBalances(DatabaseConnection);
            }
            catch 
            {
            }
        }

        private static void RunBalanceRoutineResidential()
        {
            try
            {
                PickupTransaction.Customer.SetCustomerBalances(DatabaseConnection);
            }
            catch
            {
            }
        }
    }
}
