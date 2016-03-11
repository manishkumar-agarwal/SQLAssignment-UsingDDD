using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelephoneSystemEntities;
using DBWrapper;

namespace EntityDBInterface
{
    public class EntityDBInteraction
    {
        public static Employee GetEmployeeByID(int loggedinEmployeeId)
        {
            SqlDataReader employeeData = DBInterface.GetEmployeeById(loggedinEmployeeId);
            Employee employee = DBToEntityConverter.ConvertToObject<Employee>(employeeData, loggedinEmployeeId);
            return employee;
        }
    }
}
