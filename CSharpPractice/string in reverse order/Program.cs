using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_in_reverse_order
{
    internal class Program
    {
        public static void Main()
        {
            string str;
            int I = 0;
            Console.Write("Input the string :");
            str = Console.ReadLine();
            I = str.Length - 1;
            Console.Write(" The characters of the string in reverse are : \n");
            while (I >= 0)
            {
                Console.Write("{0}", str[1]);
                I --;
            }
            Console.Write("\n\n");
            Console.ReadLine();
           
        }
    }
}
