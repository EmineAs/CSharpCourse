using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    public class Program
    {
        static void Main(string[] args)
        {
            //ForLoop();
            //WhileLoop();
            //DoWhile();
            //ForeachLoop();


            if (IsPrimeNumber(7)) 
            {
                Console.WriteLine("This a prime number");
            }
            else 
            {
                Console.WriteLine("This a prime number");

            }

            Console.ReadLine();

        }

        private static bool IsPrimeNumber(int number) 
        {
            bool result = true;
            for (int i = 2; i < number - 1; i++)
            {
                if(number % i == 0)
                {
                    result = false;
                    i = number;
                }
            }


            return result;
        }


        private static void ForeachLoop()
        {
            string[] students = new string[3] { "Engin", "Emine", "Nazmiye" };

            foreach (var student in students)
            {
                Console.WriteLine(student);
            }
        }

        private static void DoWhile()
        {
            int number = 8;

            do
            {
                Console.WriteLine(number);
                number--;

            } while (number >= 10);
        }

        private static void WhileLoop()
        {
            int number = 100;
            while (number >= 0)
            {
                Console.WriteLine(number);
                number--;
            }
            Console.WriteLine("Number is {0}", number);
        }

        private static void ForLoop()
        {
            for (int i = 100; i >= 0; i -= 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("finished!");

        }
    }
}
