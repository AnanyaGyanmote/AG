using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string type = Console.ReadLine().ToLower();
                string input = Console.ReadLine().ToLower();
                Switching(input, type);
            }
            catch
            {
                Console.WriteLine("crazy input");
            }
            
        }
        static void Switching(string input, string type)
        {
            if(input.Length >= 1)
            {
                switch (type)
                {
                    case "a1":
                        A1 a1 = new A1(input);
                        a1.CheckEquation();
                        break;
                    case "b2":
                        B2 b2 = new B2(input);
                        b2.abced();
                        break;
                    case "c1":
                        C1 c1 = new C1(input);
                        c1.GetSmallestMissingInt();
                        break;
                }
            }
            else
            {
                 Console.WriteLine("crazy input");
            }
        }
    }
}
