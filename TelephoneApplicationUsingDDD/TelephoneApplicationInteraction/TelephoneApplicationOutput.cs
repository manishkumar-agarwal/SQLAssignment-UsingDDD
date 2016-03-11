using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelephoneApplicationInteraction
{
    public class TelephoneApplicationOutput
    {

        public static void DisplayOnCleanConsole(string message)
        {
            Console.Clear();
            Display(message);
        }

        public static void Display(string message)
        {
            Console.WriteLine(message);
        }

        public static void DisplayWithEnumOptions(string message,Type enumType)
        {
            Display(message);
            var i = 0;
            foreach(var enumName in enumType.GetEnumNames())
            {
                i++;
                Display(i + ") " + enumName);
            }
        }
    }
}
