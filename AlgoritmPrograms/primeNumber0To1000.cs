using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmPrograms
{
    internal class primeNumber0To1000
    {
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
                    Console.WriteLine(i);
                IsPrime = 0;
            }
        }
    }
}
