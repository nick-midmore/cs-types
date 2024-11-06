using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSTypes
{
    public class Task00
    {
        public static void Run()
        {
            Console.WriteLine("This works!");
            Car myCar = new Car();
            Car NicksCar = new Car();
            Car copyOfMyCar = myCar;
            myCar.makeNoise();

            Console.WriteLine(myCar==NicksCar);
            Console.WriteLine(myCar==copyOfMyCar);
            Console.WriteLine(myCar.GetType());
            Console.WriteLine(myCar.Equals(NicksCar));
            Console.WriteLine(System.Object.ReferenceEquals(myCar, copyOfMyCar));
            
        }
    }
}
