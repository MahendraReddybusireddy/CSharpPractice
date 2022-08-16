using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlusMinusTest
{
    internal class Program
    {
       public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine().Trim());
            int[] numbers = new int[n];
            for (int i = 0;i < n; i++)
            {
                numbers[i] = Convert.ToInt32(Console.ReadLine().Trim());
            }
            plusMinus(numbers);
            Console.ReadLine();
        }
        public static void plusMinus(int[]numbers)
        {
            int positiveCount = 0, negativeCount = 0, zeroCount = 0;
            foreach (int number in numbers)
            {
                if (number == 0) 
                {
                    zeroCount++;
                }
                else if(number>0)
                {
                    positiveCount++;
                }
                else
                {
                    negativeCount++;
                }
            }
            double zeroNumberPercentage = (double)zeroCount / (double)numbers.Length;
            double positiveNumberPercentage = (double)positiveCount / (double)numbers.Length;
            double negativeNumberPercentage = (double)negativeCount / (double)numbers.Length;
            Console.WriteLine(positiveNumberPercentage);
            Console.WriteLine(negativeNumberPercentage);
            Console.WriteLine(zeroNumberPercentage);

        }
    }
}
