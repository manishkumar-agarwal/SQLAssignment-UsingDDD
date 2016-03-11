using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelephoneApplicationInteraction
{
    public class TelephoneApplicationInputValidation
    {
        public static bool ValidateEnumChoice(Type enumType, int userChoice, string userInputType)
        {
            var validEnumChoice = true;
            if (!enumType.IsEnum || !enumType.IsEnumDefined(userChoice))
            {
                TelephoneApplicationOutput.Display("Invalid Input For " + userInputType);
                validEnumChoice = false;
            }
            return validEnumChoice;
        }
    }
}
