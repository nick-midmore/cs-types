using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSTypes
{
    public class SportsCar:Car
    {
        public override void MakeNoise()
        {
            Console.WriteLine("beep beep beep");
        }
        public override string ToString()
        {
            //return base.ToString();
            Console.WriteLine("hello");
            return "Hello";
        }

        public override bool Equals(object? obj)
        {
            //return base.Equals(obj);
            string isEqual = "Objects are equal";
            if (obj == null)
            {
                return false;
            }
            if (obj is Car) {
                Car car = (Car)obj;
                if (car.Brand == this.Brand) {
                    return true;
                }
                //Console.WriteLine(car.Brand);
                return false;
            }
            else
            {
                return false;
            }
        }
    }
}
