using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strings
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string fname = "Mahesh Busi";
            //  Console.WriteLine(fname.Length);
            // Console.WriteLine(name.ToLower());
            // Console.WriteLine(name.ToUpper());
            //string lname = "Reddy";
            // Console.WriteLine(fname + " " + lname); string concottination
            // Console.WriteLine("{0} {1}",fname,lname); string formatting
            // Console.WriteLine($"{fname}{lname}");    string innterpolicition
            // Console.WriteLine(string.Concat(fname, lname)); string concat nation
            // Console.WriteLine(fname[5]);
            // Console.WriteLine(fname.IndexOf("h")); 
            // Console.WriteLine(fname.LastIndexOf("h"));
            // Console.WriteLine(fname.Substring(6));
            // string name = (string) fname.Clone();
            // Console.WriteLine(name);
            // string s1 = "hello";
            // string s2 = "hello";
            // Console.WriteLine(string.Compare(s1, s2));
            // Console.WriteLine(fname.Contains("Busi"));
            //Console.WriteLine(fname.StartsWith("M"));
            //Console.WriteLine(fname.EndsWith("i"));
            //Console.WriteLine(fname.Insert(6, "Reddy"));
            //string s3 = "  ";
            // Console.WriteLine(String.IsNullOrEmpty(s3));
            // Console.WriteLine(String.IsNullOrWhiteSpace(s3));
            // Console.WriteLine(s1.Equals(s2));
            //Console.WriteLine(fname.Remove(6,1));
           // Console.WriteLine(fname.Replace('h', 'H'));
            string s4 = "  Mahesh Reddy  ";
            Console.WriteLine(s4.Trim('y'));   


            Console.ReadLine();
           
        }
    }
}
