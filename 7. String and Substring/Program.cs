using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7.String_and_Substring
{
    internal class Program
    {
        static int HowManyOccurrences(string inputString, string substring)
        {
            int count = 0;
            int index = 0;

            while ((index = inputString.IndexOf(substring, index)) != -1)
            {
                count++;
                index += substring.Length;
            }

            return count;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(); 

            Console.WriteLine("Check the occurence of the letter in a word");
            string str = "do it now";
            string substring = "do";


                  /* string str = "empty";
                    string substring = "d"¡*/

              int count = HowManyOccurrences(str, substring);
            Console.WriteLine($"The number of occurrences of {substring} in {str} is {count}");
            Console.ReadLine();
        {
            }
        }
    } }
