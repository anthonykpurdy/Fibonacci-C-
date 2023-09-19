using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal class RecursiveFibonacci
    {
        public int Fib(int n)
        {
            
            if ((n == 0) || (n == 1))
            {
                return n;
            }
            else
            {
                return (Fib(n - 1) + Fib(n - 2));
            }
            

        }
    }
    
}
