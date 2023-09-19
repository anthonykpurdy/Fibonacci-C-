using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonacci
{
    internal class Program
    {
        static int[] inputs = { 1, 6, 10, 20 };
        static void Main(string[] args)
        {
            RecursiveFibonacci recursiveFibonacci = new RecursiveFibonacci();
            IterativeFibonacci iterativeFibonacci = new IterativeFibonacci();



            for (int i = 0; i < inputs.Length; i++)
            {
                int n = inputs[i];


                int num = recursiveFibonacci.Fib(n - 1);
                Console.WriteLine($"Recursive for the {inputs[i]}th value: {num}");

                int num2 = iterativeFibonacci.Fib(n);
                Console.WriteLine($"Interative for the {inputs[i]}th value: {num2}");
            }

            Console.ReadLine();
        }
    }
}
