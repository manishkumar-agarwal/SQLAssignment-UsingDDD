using TelephoneApplicationInteraction;
using System.Configuration;

namespace TelephoneApplication
{
    public class TelephoneApplicationConsole : ITelephoneApplicationInterface
    {
        private static string ApplicationEnterMessage = 
            ConfigurationManager.AppSettings.Get("ApplicationEnterMessage");

        private static string ApplicationExitMessage =
            ConfigurationManager.AppSettings.Get("ApplicationExitMessage");

        public bool IsApplicationActive { get; set; }

        private static TelephoneApplicationUserRole CurrentUsersRole { get; set; }

        public bool RunApplication()
        {
            StartApplication();
            GetUserAuthentication();
            InvokeUserRoleApplication();
            return IsApplicationActive;
        }

        public void InvokeUserRoleApplication()
        {
            ITelephoneApplicationInterface userRoleConsole;
            if(CurrentUsersRole == TelephoneApplicationUserRole.Employee)
            {
                userRoleConsole = new TelephoneApplicationEmployeeConsole();
            }
            else
            {
                //userRoleConsole = new TelephoneApplicationCustomerConsole();
                userRoleConsole = new TelephoneApplicationEmployeeConsole();
            }
         

            userRoleConsole.RunApplication();
            userRoleConsole.StopApplication();
        }

        public  void GetUserAuthentication()
        {
            CurrentUsersRole = TelephoneApplicationInput.GetUsersRole("Enter the User Role");
        }

        public  void StartApplication()
        {
            TelephoneApplicationOutput.Display(ApplicationEnterMessage);
            IsApplicationActive = true;
        }

        public  bool StopApplication()
        {
            IsApplicationActive = false;
            TelephoneApplicationOutput.Display(ApplicationExitMessage);
            return IsApplicationActive;
        }
    }
}
