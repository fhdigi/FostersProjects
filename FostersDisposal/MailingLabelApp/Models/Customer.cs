using System.Collections.Generic;
using System.Linq;

namespace MailingLabelApp.Models
{
    public partial class Customer
    {
        public static List<Customer> GetCustomers()
        {
            string connectionString = @"Data Source=DESKTOP-JE8H0DC\SQLEXPRESS;Initial Catalog=DisposalData;Integrated Security=True";

            using (DataClassesAddressDataContext db = new DataClassesAddressDataContext(connectionString))
            {
                var listing = (from c in db.Customers orderby c.SequenceNumber select c);
                return listing.ToList();
            }
        }
    }
}
