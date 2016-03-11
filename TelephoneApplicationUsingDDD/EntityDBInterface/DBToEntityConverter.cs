using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TelephoneSystemEntities;

namespace EntityDBInterface
{
    class DBToEntityConverter
    {
        internal static Employee ConvertToEmployee(SqlDataReader employeeData, int loggedinEmployeeId)
        {
            
            if (!(employeeData.HasRows && employeeData.Depth < 1))
            {
                throw new InvalidOperationException("Data Does not exists");
            }
            var employee = new Employee(employeeData);
            return employee;
        }

        internal static T ConvertToObject<T>(SqlDataReader sqlData, int id) 
                                where T : ISqlToEntityConverter<T> ,new()
        {
            if (!(sqlData.HasRows && sqlData.Depth < 1))
            {
                throw new InvalidOperationException(typeof(T).Name +" id: " + id +
                    " does not exists ");
            }
            T entityObject = new T();

            entityObject.ConvertSqlDataToObject(sqlData);
            return entityObject;
        }

    }
}
