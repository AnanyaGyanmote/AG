using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Exam
{
    class B2
    {
        //properties
        StreamReader Doc { get; set; }
        char LastCharacter { get; set; }

        //Constructor
        public B2(string character)
        {
            StreamReader file = File.OpenText("file.txt");
            this.Doc = file;
            this.LastCharacter = Convert.ToChar(character.ToLower());
        }

        //methods
        public void abced()
        {
            string word = "";
            string previous = "";
            string longestStringWord = "";
            while((word = Doc.ReadLine()) != (null))
            {
                word = word.ToLower();
                char[] characters = word.ToCharArray();
                Array.Sort(characters);
                string sorted = new string(characters);
                if (sorted.EndsWith(LastCharacter))
                {
                    if(sorted.Equals(word))
                    {
                        if(previous.Length > longestStringWord.Length)
                        {
                            longestStringWord = previous;
                        }
                        previous = word;
                    }
                }
            }
            if(longestStringWord == "")
            {
                longestStringWord = "not found";
            }
            Console.WriteLine(longestStringWord);
        }
    }
}
