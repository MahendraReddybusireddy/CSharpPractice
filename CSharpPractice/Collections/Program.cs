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
            al.Add(200); al.Add(300); al.Add(400);
            Console.WriteLine(al.Capacity);
            al.Add(500);
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
