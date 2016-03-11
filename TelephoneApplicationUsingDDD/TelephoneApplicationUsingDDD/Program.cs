using System;
using TelephoneApplication;
using TelephoneApplicationInteraction;

namespace TelephoneApplicationUsingDDD
{
    class Program
    {
        static void Main(string[] args)
        {
            TelephoneApplicationConsole telephoneApplication = new TelephoneApplicationConsole();

            try
            {
                telephoneApplication.RunApplication();
            }
            catch(Exception ex)
            {
                TelephoneApplicationOutput.Display(ex.Message);
            }
            finally
            {
                telephoneApplication.StopApplication();
            }
        }
    }
}
