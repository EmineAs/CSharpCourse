﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Value Types
            //Console.WriteLine("Merhaba ");

            decimal number6 = 10;// daha hassas para olabilir
            double number5 = 10.4;
            char character = 'B';
            bool condition=false;
            byte number4 = 255;//0-255 arası 1byte;
            short number3 = 32767;
            int number1 = 2147483647;
            long number2 = 9223372036854775807;
            var number7 = 10;
            //number7 = 'B';

            Console.WriteLine("Number1 is {0}",number1);
            Console.WriteLine("Number2 is {0}",number2);
            Console.WriteLine("Number3 is {0}",number3);
            Console.WriteLine("Number4 is {0}",number4);
            Console.WriteLine("Number5 is {0}",number5);
            Console.WriteLine("Number7 is {0}",number7);
            Console.WriteLine("Character is {0}",(int)character);
            Console.WriteLine((int)Days.Friday);
        

            Console.ReadLine();
        }

        enum Days
        {
            Monday=10,Tuesday=15,Wednesday=40,Thursday,Friday,Saturday,Sunday
        }
    }
}
