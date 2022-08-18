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
            string str1 = "running";
            string str2 = "running";
            Console.WriteLine("Original strings :" + str1 + " " + str2);
            Console.WriteLine("\nCommon ending between said two strings : " + test(str1, str2));
            str1 = "thisisatest";
            str2 = "testing123testing";
            Console.WriteLine("\nOriginal strings :" + str1 + "  " + str2);
            Console.WriteLine("\nCommon ending between said two strings :" + test(str1, str2));
        }
        public static string test(string st1, string st2)
        {
            for (int i = 0; i < st1.Length; i++)
            {
                string end = st1.Substring(i);
                if (st2.EndsWith(end))
                {
                    return end;
                }
            }
            return "";
            Console.ReadLine();
        }
       
    }
}

        


        
    
