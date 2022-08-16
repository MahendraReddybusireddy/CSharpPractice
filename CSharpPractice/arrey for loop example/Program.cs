using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrey_for_loop_example
{
    internal class Program
    {
       public static void Main(string[] args)
        {
            int[] arr = new int[10];
            int i;
            Console.WriteLine("Input 10 elements in the array:\n");
            for (i = 0; i < 10; i++)
            {
                Console.Write("element - {0}:",i);  
                arr[i] = 
                    Convert.ToInt32(Console.ReadLine());    
            }
            Console.WriteLine("\nElements in arrey are:");
            for(i =0; i < 10;i ++)
            {
                Console.Write("{0}", arr[i]);
            }
            Console.WriteLine("\n");
        }
    }
}
