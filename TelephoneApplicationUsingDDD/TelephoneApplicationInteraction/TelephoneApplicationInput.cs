using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelephoneApplicationInteraction
{
    public class TelephoneApplicationInput
    {
        public static TelephoneApplicationUserRole GetUsersRole(string userMessage)
        {
            Type enumType = typeof(TelephoneApplicationUserRole);
            TelephoneApplicationOutput.DisplayWithEnumOptions(userMessage, enumType);

            var userRole = ReadIntegerInput();

            if (!TelephoneApplicationInputValidation.ValidateEnumChoice(enumType, userRole, "User Role"))
            {
                throw new ArgumentException(" ");
            }

            return (TelephoneApplicationUserRole)userRole;
        }

        private static int ReadIntegerInput(string userMessage = null)
        {
            TelephoneApplicationOutput.Display(userMessage);
            return Int32.Parse(ReadUserInput());
        }

        public static string ReadUserInput()
        {
            return Console.ReadLine();
        }

        public static int GetEmployeeId(string userMessage)
        {
            return ReadIntegerInput(userMessage);
        }

        public static EmployeeApplicationUserActions GetEmployeeAction(string userMessage)
        {
            Type enumType = typeof(EmployeeApplicationUserActions);
            TelephoneApplicationOutput.DisplayWithEnumOptions(userMessage, enumType);

            var employeeAction = ReadIntegerInput();

            if (!TelephoneApplicationInputValidation.ValidateEnumChoice(enumType, employeeAction, "Employee Action"))
            {
                throw new ArgumentException(" ");
            }

            return (EmployeeApplicationUserActions)employeeAction;
        }
    }
}
