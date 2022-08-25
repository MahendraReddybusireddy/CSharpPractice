using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParseTryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string string1 = "10000";
            string string2 = null;
            string string3 = "10000.999";
            double Double =9999999999999999999;
            int result;
            result = int.Parse(string1);
            result = int.Parse(string2);
            result = int.Parse(string3);
            
            bool parseSuccessful;
            parseSuccessful = int.TryParse(string1, out result);
            parseSuccessful = int.TryParse(string2, out result);
            parseSuccessful = int .TryParse(string3, out result);
            


        }
    }
}
