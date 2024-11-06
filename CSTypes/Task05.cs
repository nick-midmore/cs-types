using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSTypes
{
    public class Task05
    {
        public static void ConvertToDouble()
        {
            Console.WriteLine("Enter an int:");
            int intInput = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter a decimal:");
            decimal decInput = Convert.ToDecimal(Console.ReadLine());

            double result = Convert.ToDouble(intInput / decInput);

            Console.WriteLine(result);
        }
    }
}
