using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is console application\n");
            Messenger();
            var firstEmployee = new  Employee { id = 1, Name = "John doe" };
            var secondEmployee = new Employee { id = 2, Name = "Ruby Michele" };
        firstEmployee.Dispaly();
            secondEmployee.Dispaly();
            Console.ReadKey();
        }
        static void Messenger()
        {
            Console.WriteLine("<<start Messenger>>");
            Console.WriteLine("Hello shortcuts", 2);
            Console.WriteLine("<<End Messenger>>");
        }
        static void PrintMessege(string message,int numberOfTimes)
            {
            Console.WriteLine($"\t<<EndPrintMessage>>");
            for (int i = 0; i < numberOfTimes;i++)
            {
                Console.WriteLine($"\t\t<<{message}");
               
            }
            Console.WriteLine("\t<<EndPrintMessege>>");

        }
    }
    class Employee
    {
        public int id
    }
}
