﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSTypes
{
    public class Car
    {
        public string Brand { get; set; } = "BMW";

        public virtual void MakeNoise() 
        {
            Console.WriteLine("Beep");
        }
    }
}
