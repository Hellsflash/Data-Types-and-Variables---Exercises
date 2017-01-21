using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _17.Print_Part_Of_ASCII_Table
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                int firstNumber = int.Parse(Console.ReadLine());
                int secondNumber = int.Parse(Console.ReadLine());
               
                for (int ascii=firstNumber; ascii <= secondNumber; ascii++)
                {
                    Console.Write("{0} ",(char)ascii);
                    
                }
                Console.WriteLine();

            }
        }
    }
}
