using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample_Soluction
{
    internal class Program
    {
        public static void Main()
        {
            string str;
            int I = 0;
            Console.Write("Input the string :");
            str = Console.ReadLine();
            foreach (char chr in str)
            {
                I += 1;
            }
            Console.Write("Length of the string is : {0}\n\n", 1);
            Console.ReadLine();

        }
    }
}
