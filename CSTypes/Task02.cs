using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSTypes
{
    public class Task02
    {
        public static void Run()
        {
            int two = 2;
            decimal dec = 1.1m;
            float fl = 2.9f;
            //float fl2 =
            double myDouble = 3.678908765436578;

            decimal twoAsDecimal = two;
            double decAsDouble = (double)dec;
            int floatAsInt = (int)fl;
            float mydoubleAsFloat = (float)myDouble;

            Console.WriteLine(twoAsDecimal);
            Console.WriteLine(decAsDouble);
            Console.WriteLine(floatAsInt);
            Console.WriteLine(mydoubleAsFloat);
        }
    }
}
