using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryWinFormsApp
{
    public static class InputValidator
    {
        public static bool TryParseToNumber(string input, out int number, out string errorMessage)
        {
            try
            {
                number = Convert.ToInt32(input);
                if(number < 1)
                {
                    number = 0;
                    errorMessage = "Введите число от 1 до 2*10^9";
                    return false;
                }
                errorMessage = "";
                return true;
            }
            catch(FormatException)
            {
                number = 0;
                errorMessage = "Введите число!";
                return false;
            }
            catch (OverflowException)
            {
                number = 0;
                errorMessage = "Введите число от 1 до 2*10^9";
                return false;
            }
        }
    }
}
