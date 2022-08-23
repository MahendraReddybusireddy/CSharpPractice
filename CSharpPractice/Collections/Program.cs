using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArrayList al =new ArrayList(2);
            Console.WriteLine(al.Capacity);
            al.Add(100);
            Console.WriteLine(al.Capacity);
            al.Add("Hello"); al.Add(true); al.Add(23.45);
            Console.WriteLine(al.Capacity);
            al.Add('A');
            Console.WriteLine(al.Capacity);
           
            foreach (object obj in al)
                Console.Write(obj + " ");
            Console.WriteLine();

            al.Insert(3, 350);
            foreach (object obj in al)
                Console.Write(obj + " ");
            Console.WriteLine();

            // al.Remove(200);
            al.Remove(1);
            foreach (object obj in al)
                Console.Write(obj + " ");
            Console.WriteLine();

            Console.ReadLine();

        }
    }
}
