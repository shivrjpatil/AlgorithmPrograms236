using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmPrograms
{
    internal class primeNumber0To1000
    {
        public List<int> primeNumbers = new List<int>();
      //  public List<int> primePalindrome = new List<int>();
        public void prime()
        {
            int IsPrime = 0;
            for(int i=2;i<1000;i++)
            {
                for (int j = 1; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        IsPrime++;
                    }
                    if (IsPrime == 2) break;
                }
                if(IsPrime!=2)
                    Console.Write(" "+i);
                primeNumbers.Add(i);    
                IsPrime = 0;
            }
        }
        public void PrimePalindrome()
        {
            foreach(var data in primeNumbers)
            {
                if (data > 9)
                {
                    int sum = 0;
                    int remainder;
                    int temp = data;
                    while (temp > 0)
                    {
                        remainder = temp % 10;
                        sum = sum * 10 + remainder;
                        temp /= 10;
                    }
                    if (sum == data)
                        Console.Write(" "+data);
                }
            }
        }

    }
}
