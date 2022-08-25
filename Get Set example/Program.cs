using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Get_Set_example
{
     class Person
    {
        static void Main(string[] args)
        {
            Person myobj = new Person();
            myobj.Name = "Reddy";
            Console.WriteLine(myobj.Name);
        }
    }
}
