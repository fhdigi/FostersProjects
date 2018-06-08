using System.Collections.Generic;
using System.Linq;

namespace MailingLabelApp.Models
{
    public partial class Customer
    {
        public static List<Customer> GetCustomers()
        {
            using (DataClassesAddressDataContext db = new DataClassesAddressDataContext())
            {
                var listing = (from c in db.Customers orderby c.SequenceNumber select c);
                return listing.ToList();
            }
        }
    }
}
