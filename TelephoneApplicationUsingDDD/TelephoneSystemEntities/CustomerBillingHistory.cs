using System;

namespace TelephoneSystemEntities
{
    public class CustomerBillingHistory
    {
        public int BillPaymentId { get; set; }
        public DateTime BillPaidDate { get; set; } = DateTime.Now;
        public Customer Customer { get; set; }
        public int CustomerMobileNumber { get; set; }
        public string BillPaymentMode { get; set; }
        public decimal BillAmount { get; set; }

        public override string ToString()
        {
            return (BillPaymentId + "\t" +
                    CustomerMobileNumber + "\t" +
                    BillPaymentMode + "\t" +
                    BillAmount + "\t" +
                    BillPaidDate);
        }
    }

}
