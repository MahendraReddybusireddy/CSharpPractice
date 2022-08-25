using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = "hello world";

            int count =0;

            string repeated = "";

            foreach (char inputChar1 in input)
            {
                count = 0;

                if(repeated.Contains(inputChar1))
                {
                    continue;
                }

                foreach (char inputChar2 in input)
                {
                    if(inputChar1 == inputChar2)
                    {
                        repeated = repeated + inputChar1;
                        count++;
                    }
                }

                Console.WriteLine($"Count of {inputChar1} is {count}");
            }

            Console.ReadLine();
        }
    }
}
