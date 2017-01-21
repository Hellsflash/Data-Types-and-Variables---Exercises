using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.Comparing_floats
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = Math.Abs(double.Parse(Console.ReadLine()));
            double secondNumber = Math.Abs(double.Parse(Console.ReadLine()));

            float eps = 0.000001f;
            bool result = true;


            if (firstNumber>secondNumber)
            {
                result = firstNumber - secondNumber < eps;
            }
            else
            {
                result = secondNumber - firstNumber < eps;
            }
            Console.WriteLine(result);
        }
    }
}
