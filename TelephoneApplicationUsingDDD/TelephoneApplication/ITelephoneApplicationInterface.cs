using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelephoneApplication
{
    interface ITelephoneApplicationInterface
    {
        bool IsApplicationActive { get; set; }

        bool RunApplication();

        void GetUserAuthentication();

        void StartApplication();

        bool StopApplication();


    }
}
