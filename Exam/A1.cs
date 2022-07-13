using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class A1
    {
        // properties
        string Equation { get; set; }

        // constructor
        public A1(string input)
        {
            this.Equation = input;
        }

        // methods
        public void CheckEquation()
        {
            string equation = "";
            Boolean isEquation = true;
            char[] elements = this.Equation.ToCharArray();
            for(int i = 0; i < elements.Length; i++)
            {
                if(elements[i] == '(' || elements[i] == ')')
                {
                    equation += elements[i];
                }
            }
            int lastIndex = equation.Length - 1;
            for(int i = 0; i < equation.Length; i++)
            {
                if(equation.Length % 2 != 0)
                {
                    isEquation = false;
                    break;
                }
                if(equation[0] == ')')
                {
                    isEquation = false;
                    break;
                }
                if(i != equation.Length - 1)
                {
                    if (equation[i].Equals('('))
                    {
                        if(!equation[lastIndex].Equals(')'))
                        {
                            isEquation = false;
                            break;
                        }
                        lastIndex--;
                    }
                }
            }
            Console.WriteLine(isEquation);
        }
    }
}
/*
 * 
                    else if (equation[i].Equals(')') && i > 0)
                    {
                        if (!equation[lastIndex].Equals(')'))
                        {
                            wrong = elements[lastIndex];
                            isEquation = false;
                            break;
                        }
                        lastIndex--;
                    }
 * */
