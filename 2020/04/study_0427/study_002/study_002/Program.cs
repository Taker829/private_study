using System;
using static System.Console;

namespace study_002
{
    class Calculator
    {
        public static int Plus(int a, int b)
        {
            WriteLine("Input : {0}, {1}", a, b);

            int result = a + b;
            return result;
        }
    }
    
    class Program
    {
        static void Main()
        {
            int x = 3;
            int y = 4;

            int result = Calculator.Plus(x, y);
        }
    }
}
