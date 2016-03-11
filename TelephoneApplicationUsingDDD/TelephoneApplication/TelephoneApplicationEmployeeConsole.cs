using System;
using System.Configuration;
using TelephoneApplicationInteraction;
using TelephoneSystemEntities;
using EntityDBInterface;

namespace TelephoneApplication
{
    class TelephoneApplicationEmployeeConsole : ITelephoneApplicationInterface
    {
        private static string ApplicationEnterMessage =
            ConfigurationManager.AppSettings.Get("EmployeeApplicationEnterMessage");

        private static string ApplicationExitMessage =
            ConfigurationManager.AppSettings.Get("EmployeeApplicationExitMessage");

        private EmployeeApplicationUserActions EmployeeAction { get; set; }

        public bool IsApplicationActive { get; set; }

        private Employee LoggedinEmployee { get; set; }

        public TelephoneApplicationEmployeeConsole()
        {
            LoggedinEmployee = new Employee();
        }

        public void StartApplication()
        {
            TelephoneApplicationOutput.Display(ApplicationEnterMessage);
            IsApplicationActive = true;
        }

        public bool RunApplication()
        {
            StartApplication();
            GetUserAuthentication();
            ValidateEmployee();
            InvokeUserRoleApplication();
            return IsApplicationActive;
        }

        public void GetUserAuthentication()
        {
            LoggedinEmployee.EmployeeId =
                TelephoneApplicationInput.GetEmployeeId("Enter the Employee Id");
            LoggedinEmployee = EntityDBInteraction.GetEmployeeByID(LoggedinEmployee.EmployeeId);
        }

        private void ValidateEmployee()
        {
            if(LoggedinEmployee.EmployeeId == 0)
            {
                TelephoneApplicationOutput.Display("Invalid Employee ID");
                throw new InvalidOperationException(" ");
            }
        }

        public bool StopApplication()
        {
            IsApplicationActive = false;
            TelephoneApplicationOutput.Display(ApplicationExitMessage + LoggedinEmployee.EmployeeName );
            return IsApplicationActive;
        }

        public void InvokeUserRoleApplication()
        {
            do
            {
                EmployeeAction = TelephoneApplicationInput.GetEmployeeAction("Enter the Action Choice");
               // PerformEmployeeAtion();

            } while (EmployeeAction != EmployeeApplicationUserActions.EndApplication);
        }
    }
}
