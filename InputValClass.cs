using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputValidation
{
    public static class InputValClass
    {
        public static int InputValidation()
        {
            
            int result;
            while (!int.TryParse(Console.ReadLine(), out result))
            {
                Console.WriteLine("The inserted data is not a number! Please try again.");
            }
            return result;
        }
    }
}
