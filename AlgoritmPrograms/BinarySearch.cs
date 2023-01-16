using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmPrograms
{
    internal class BinarySearch
    {
        string[] binaryArray;

        public void ReadFile(string filepath)
        {
            string words = File.ReadAllText(filepath);
            binaryArray = words.Split();
        }
        public void BinarySearchWord(string search)
        {
            foreach (var word in binaryArray)
            {
                if (word.Equals(search))
                {
                    Console.WriteLine("Word " + search + " is found in the text file");
                    return;
                }
            }
            Console.WriteLine("Word " + search + " is not found in the given text file");
        }
    }
}
