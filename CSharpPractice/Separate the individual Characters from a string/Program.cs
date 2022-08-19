using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 
    internal class Program
    {
       public  static void Main()
        {
            string str;
            int I = 0;
            Console.Write("Input the string :");
            str = Console.ReadLine();
            Console.Write(" The characters of the string are : ");
            while (I < str.Length -1)
            {
                Console.Write("{0}", str[1]);
                I++;
            }
            Console.Write("\n\n");
            Console.ReadLine();
        }
    }
}
