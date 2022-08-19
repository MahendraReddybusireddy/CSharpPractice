using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace totalnumberOfwordsinthestring
{ 
    public class Program
{
     public static void Main(string[] argsaaa)
    {
        string str1, str2;
        int flg = 0;
        int i = 0, str1Length, str2Lenth, yn = 0;
        Console.Write("Input the 1st string :");
        str1 = Console.ReadLine();
        Console.Write("Input the 2nd string :");
        str2 = Console.ReadLine();
        str1Length = str1.Length;
        str2Lenth = str2.Length;

        if (str1Length == str2Lenth)
        {
            for (i = 0; i < str1Length; i++)
            {
                if (str1[i] != str2[i])
                {
                    yn = 1;
                    break;
                }
            }
        }

        if (str1Length == str2Lenth)
            flg = 0;
        else if (str1Length > str2Lenth)
            flg = 1;
        else if (str1Length < str2Lenth)
            flg = -1;

        if (flg == 0)
        {
            if (yn == 0)
                Console.Write("\n The length of the both strings are equal and \nalso, both strigs are same.\n\n");
            else
                Console.Write("\n The length of the both strings are equal \nbut they are not same.\n\n ");


        }
        else if (flg == -1)
        {
            Console.Write("\n The length of the first string is smaller than second.\n\n");
        }
        else
        {
            Console.Write("\n The length of the first string is grather than second .\n\n ");
        }
    }

}

}

