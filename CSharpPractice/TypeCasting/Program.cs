using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeCasting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int myInt = 28;
            double myDouble = myInt;     //implicit
            double myDouble2 = 3.13;
            int myInt2 = (int)myDouble2;      //expicit (my be data loss)

            int myInt3 = 39;
            double myDouble3 = Convert.ToDouble(myInt3);

            double myDouble4 = 98.501;
            int myInt4 = Convert.ToInt32(myDouble4);//built method

            string rollno = "1234.9000";
            double rollnum = Convert.ToDouble(rollno);
          


                                
            Console.WriteLine(myInt);
            Console.WriteLine(myDouble);
            Console.WriteLine(myDouble2);
            Console.WriteLine(myInt2);
            Console.WriteLine(myInt3);
            Console.WriteLine(myDouble3);
            Console.WriteLine(myDouble4);
            Console.WriteLine(myInt4);
            Console.WriteLine( rollnum.GetType());
            Console.WriteLine(rollno.GetType());  
            Console.ReadLine();


        }
    }
}
