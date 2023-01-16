using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmPrograms
{
    internal class Program
    {
        public static string binaryTextPath = @"C:\Users\shiv\Desktop\new git\AlgorithmPrograms236\AlgoritmPrograms\File\BinarySearch.txt";
        static void Main(string[] args)
        {
             
        Console.WriteLine("Welcome to the Algorithm Programs");
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("------------------------------------------------");
                Console.WriteLine("1.BinarySearch\n2.Insertion Sort\n3.Exit");
                Console.Write("Select any one from the above option: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        BinarySearch search = new BinarySearch();
                        search.ReadFile(binaryTextPath);
                        search.BinarySearchWord("bridgelabz");
                        break;
                    case 2:
                        InsertionSort sort = new InsertionSort();
                        int[] arr = { 20, 39, 2, 3, 6, 54, 3 };
                        sort.Sort(arr);
                        break;
                    case 3:
                        flag = false;
                        break;
                }
                Console.ReadLine();
            }
        }
    }
}
