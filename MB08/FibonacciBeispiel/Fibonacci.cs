using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MB08.FibonacciBeispiel
{
    public static class Fibonacci
    {

        public static int FibIterativ(int n)
        {
            int number1 = 0;
            int number2 = 1;
            int number3 = 0;
            int fibonacci = 0;
            for (int i = 0; i < n; i++)
            {
                fibonacci = number2;
                number3 = number1 + number2;
                number1 = number2;
                number2 = number3;
            }
            return fibonacci;
        }


        public static int FibRecursiv(int n)
        {
            if (n <= 1)
                return n;

            return FibRecursiv(n - 1) + FibRecursiv(n - 2);
        }

    }
}
