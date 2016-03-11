using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace TelephoneSystemEntities
{
    public class Employee: ISqlToEntityConverter<Employee>
    {
        public Employee()
        {
            AssociatedCustomers = new List<Customer>();
        }

        public Employee(SqlDataReader employeeData) : this()
        {
            employeeData.Read();
            this.EmployeeId = (int)employeeData[0];
            this.EmployeeName = (string)employeeData[1];
            this.DateOfBirth = (DateTime)employeeData[2];
            this.JoinDate = (DateTime)employeeData[3];
            this.TShirtSize = (Int16)employeeData[4];
        }

        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public List<Customer> AssociatedCustomers { get; set; }
        public DateTime DateOfBirth { get; set; }
        public DateTime JoinDate { get; set; }
        public int TShirtSize { get; set; }

        public override string ToString()
        {
            return (EmployeeId + "\t" +
                    EmployeeName + "\t" +
                    DateOfBirth + "\t" +
                    JoinDate + "\t" +
                    TShirtSize);
        }

        public void ConvertSqlDataToObject(SqlDataReader employeeData)
        {
            employeeData.Read();
            this.EmployeeId = (int)employeeData[0];
            this.EmployeeName = (string)employeeData[1];
            this.DateOfBirth = (DateTime)employeeData[2];
            this.JoinDate = (DateTime)employeeData[3];
            this.TShirtSize = (Int16)employeeData[4];
        }
    }
}
