using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmPrograms
{
    internal class Anagram
    {
        public void CheckAnagram(string inputStr1, string inputStr2)
        {
            string input1 = Test(inputStr1);
            string input2 = Test(inputStr2);
            if (input1.Equals(input2))
                Console.WriteLine("entered word is Anagram");
            else
                Console.WriteLine("enetred wrod is not an anagarm");

        }
        public string Test(string input)
        {
            char[] arr = input.ToCharArray();
            Array.Sort(arr);
            return new string(arr);
        }
    }
}
