using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace TelephoneSystemEntities
{
    public class Customer : ISqlToEntityConverter<Customer>
    {
        public Customer()
        {
            CustomerBills = new List<CustomerBillingHistory>();
        }

        public int MobileNumber { get; set; }
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public Employee Employee { get; set; }
        public int EmployeeId { get; set; }
        public string CustomersIdentity { get; set; }
        public List<CustomerBillingHistory> CustomerBills { get; set; }

        public override string ToString()
        {
            return (MobileNumber + "\t" +
                     Name + "\t" +
                     EmailAddress + "\t" +
                     EmployeeId + "\t" +
                     CustomersIdentity + "\t");
        }

        public void ConvertSqlDataToObject(SqlDataReader customerData)
        {
            customerData.Read();

        }
    }
}
