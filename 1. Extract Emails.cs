using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;



namespace Extract_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"\s([0-9A-Za-z]+(-*|_*|\.*)[0-9a-zA-Z]*@[a-z]+-*[a-z]*(\.[a-z]+)+\b)";
            string input = Console.ReadLine();

            foreach (Match m in Regex.Matches(input, pattern))
            {
                Console.WriteLine(m);
            }
        }
    }
}