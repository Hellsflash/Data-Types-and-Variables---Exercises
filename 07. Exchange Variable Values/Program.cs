﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Exchange_Variable_Values
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            var a1 = b;
            var b1 = a;

            Console.WriteLine("Before:");
            Console.WriteLine("a = {0}",a);
            Console.WriteLine("b = {0}",b);
            Console.WriteLine("After:");
            Console.WriteLine("a = {0}", a1);
            Console.WriteLine("b = {0}", b1);
        }
    }
}
