using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15.Fast_Prime_Checker
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int numToDivide = 2; numToDivide <= number; numToDivide++)
            {
                bool result = true;
                for (int divider = 2; divider <= Math.Sqrt(numToDivide); divider++)
                {
                    if (numToDivide % divider == 0)
                    {
                        result = false;
                        break;
                    }
                }
                Console.WriteLine($"{numToDivide} -> {result}");
            }

        }
    }
}
