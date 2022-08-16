using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrey_example_in_for_loop
{
    internal class Program
    {
        static void Main()
        {
            int[] evenNums = { 2, 4, 6, 8, 10 };
            for (int i = 0; i < evenNums.Length; i++) 
            {
                Console.WriteLine(evenNums[i]); 
            }
            for (int i = 0; i < evenNums.Length;i++)
            evenNums[i] = evenNums[i] + 10;
            {
                Console.WriteLine("After Setting the values ");
            }
            for(int i = 0; i< evenNums.Length;i++)
            {
                Console.WriteLine(evenNums[i]);
            }
            Console.ReadLine();
        }
    }
}
        

    

