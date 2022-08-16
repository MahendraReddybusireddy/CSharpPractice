using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter chail 1 age:");
            int child1;
            bool isINPUTChild1valid =int.TryParse(Console.ReadLine(), out child1);
            Console.WriteLine("Enter chail 2 age");
            int child2;
            bool isINPUTChild2valid =int.TryParse(Console.ReadLine(), out child2);
            Console.WriteLine("Enter child 3 age");
            int child3;
            bool isINPUTChild3valid =int.TryParse(Console.ReadLine(), out child3);
            if (child1<child2 &&child1<child3)
            
            {
                Console.WriteLine("child one is the youngest!\n");
            }
            else if(child2<child3)
            {
                Console.WriteLine("child two is the youngest!\n");
            }
            else
            {
                Console.WriteLine("child three is the youngest!\n");
            }
            Console.ReadLine();    
        }
    }
}
