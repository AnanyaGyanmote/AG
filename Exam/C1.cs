using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class C1
    {
        // properties
        int[] Numbers { get; set; }

        // Constructor
        public C1(string input)
        {
            string[] inputArr = input.Split(' ');
            int[] numbers = Array.ConvertAll(inputArr, s => Int32.Parse(s));
            Array.Sort(numbers);
            numbers = RemoveExtra(numbers);
            this.Numbers = numbers;
        }

        // Methods
        public void GetSmallestMissingInt()
        {
            int earlierNumber = this.Numbers[0];
            for(int i = 1; i < this.Numbers.Length; i++)
            {
                int number = this.Numbers[i];
                if (!number.Equals(earlierNumber + 1))
                {
                    if(earlierNumber + 1 > 0)
                    {
                        break;
                    }
                }
                earlierNumber = number;
            }
            Console.WriteLine(earlierNumber + 1);
        }
        private int[] RemoveExtra(int[] numberArr)
        {
            string existing = "";
            List<int> unique = new List<int>();
            string pattern;
            for(int i = 0; i < numberArr.Length; i++)
            {
                pattern = @"(\s{1})(" + numberArr[i] + @")(\s{1})";
                if (!Regex.Match(existing, pattern).Success)
                {
                    unique.Add(numberArr[i]);
                }
                existing += numberArr[i] + " ";
            }
            int[] numbers = unique.ToArray();
            return numbers;
        }
    }
}


