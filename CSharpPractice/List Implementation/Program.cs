using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Generic;

namespace List_Implementation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> my_list = new List<int>(); 
            my_list.Add(1);
            my_list.Add(10);
            my_list.Add(100);
            my_list.Add(1000);
            my_list.Add(10000);
            my_list.Add(100000);
            my_list.Add(1000000);
            my_list.Add(10000000);
            Console.WriteLine("initial Count : {0}", my_list.Count);
            my_list.Remove(1);
            Console.WriteLine("2nd Count : {0}", my_list.Count);
            my_list.RemoveAt(4);
            Console.WriteLine("3rd Count : {0}",my_list.Count);
            my_list.RemoveRange(0, 4);
            Console.WriteLine("4th Count : {0}", my_list.Count);
            my_list.Clear();
            Console.WriteLine("5th Count : {0}", my_list.Count);
            Console.ReadLine(); 


        }
    }
}
