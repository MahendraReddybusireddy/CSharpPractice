using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleStatement
{
    internal class Program
    {
        public void Show(out int a, out int b)
        {
            int square = 5;
            a = square;
            b = square;
            a *= b;
            b *= b;
        }
        static void Main(string[] args)
        {
            int val1 = 50, val2 = 100;
            Program program = new Program();
            Console.WriteLine("Valvue before passing\n val1 = " + val1 + "\n val2=" + val2);
            program.Show(out val1, out val2);
            Console.WriteLine("Value after passing\n val1 =" + val1 + "\nval2 = " + val2);
            Console.ReadLine();
        }
    }
}