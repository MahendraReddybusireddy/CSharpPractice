﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number to check grade");
            int num =
                Convert.ToInt32(Console.ReadLine());
            if (num <=0|| num > 100)
            {
                Console.WriteLine("Wrong number");
            }
            else if (num >=0 && num < 50)
            {
                Console.WriteLine("Fail");
            }
            else if (num >=50 && num < 60)
            {
                Console.WriteLine("D grade");
            }
            else if (num >=60 && num < 70)
            {
                Console.WriteLine("C grade");
            }
            else if (num >=70 && num < 80)
            {
                Console.WriteLine("B grade");
            }
            else if (num >=80 && num < 90)
            {
                Console.WriteLine("A Grade");

            }
            else if (num >=90 && num < 100)
            {
                Console.WriteLine("A+ grade");
            }
            Console.ReadLine();
        } 
    }
}
