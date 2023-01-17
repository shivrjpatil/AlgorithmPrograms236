using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmPrograms
{
    internal class UserInput
    {
        public void ReplaceString()
        {
            string input = "Hello <<name>>, We have your full name as <<full name>> in our system. your contact number is 91-xxxxxxxxxx.";
            Console.WriteLine("enter your name");
            string name = Console.ReadLine();
            input = input.Replace("<<name>>", name);

            Console.WriteLine("enter your full name");
            string fullname = Console.ReadLine();
            input = input.Replace("<<full name>>", fullname);

            Console.WriteLine("enter your mobile number");
            string mobile = Console.ReadLine();
            input = input.Replace("xxxxxxxxxx", mobile);

            Console.WriteLine(input);
        }
    }
}
