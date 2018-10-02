using System;

namespace SequenceNumberMove
{
    class Program
    {
        static void Main(string[] args)
        {
            //string connectionString =
            //    @"Data Source=DESKTOP-JJ1BU5E\SQLEXPRESS;Initial Catalog=DISPOSALDATA;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            string connectionString =
                @"Data Source=FOSTERDB001\FOSTERSQL;Initial Catalog=DisposalData;Integrated Security=True";

            /* hold up the program from closing */
            Console.WriteLine(@"1.  Update sequence numbers for October 2, 2018 route move.");
            Console.WriteLine(@"2.  Reset prior to October 2, 2018 route move.");

            /* hold up the program from closing */
            string userResponse = Console.ReadLine();

            if (userResponse == "1")
            {
                int stretchSeqNumber = 44120;

                /* get a list of customers that are effected */
                var customersToStretch = PickupTransaction.Customer.GetCustomerListInSeqBlock(connectionString, 43953, 44122);

                /* loop through the listing */
                foreach (var customer in customersToStretch)
                {
                    /* increase the sequence number */
                    stretchSeqNumber++;

                    /* set the old sequence number to the previous field */
                    customer.PreviousSequenceNumber = customer.SequenceNumber;

                    /* now set the new sequence number */
                    customer.SequenceNumber = stretchSeqNumber;

                    /* save the customer */
                    customer.Update(connectionString);
                }

                /* get a list of customers that are effected */
                var customerListToMove = PickupTransaction.Customer.GetCustomerListInSeqBlock(connectionString, 37303, 38108);

                int firstSeqNumber = 43947;

                /* loop through the listing */
                foreach (var customer in customerListToMove)
                {
                    /* increase the sequence number */
                    firstSeqNumber++;

                    /* set the old sequence number to the previous field */
                    customer.PreviousSequenceNumber = customer.SequenceNumber;

                    /* now set the new sequence number */
                    customer.SequenceNumber = firstSeqNumber;

                    /* now set the new pickup day */
                    customer.PickupDay = 4;

                    /* now set the route */
                    customer.Route = 2;

                    /* save the customer */
                    customer.Update(connectionString);
                }

                /* hold up the program from closing */
                Console.WriteLine("Update Complete");

                /* hold up the program from closing */
                Console.ReadLine();
            }

            if (userResponse == "2")
            {
                /* get a list of customers that are effected */
                var customerListToReset = PickupTransaction.Customer.GetCustomerListInPrevSeqBlock(connectionString, 37303, 38108, 43947, 44121);

                /* loop through the listing */
                foreach (var customer in customerListToReset)
                {
                    /* now set the new sequence number */
                    if (customer.PreviousSequenceNumber != null)
                        customer.SequenceNumber = (int) customer.PreviousSequenceNumber;

                    /* now set the new pickup day */
                    customer.PickupDay = 3;

                    /* now set the route */
                    customer.Route = 3;

                    /* save the customer */
                    customer.Update(connectionString);
                }

                /* hold up the program from closing */
                Console.WriteLine("Reset Complete");

                /* hold up the program from closing */
                Console.ReadLine();
            }
        }
    }
}
