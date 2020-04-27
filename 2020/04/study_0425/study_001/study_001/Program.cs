using System;
using static System.Console;

namespace Method
{
    class Calculator
    {
        public static int Plus(int a, int b)
        {
            return a + b;
        }
          
        public static int Minus(int a, int b)
        {
            return a - b;
        }

        class MainApp
        {
            public static void Main()
            {
                // 더하기 메소드 활용
                int result_001 = Calculator.Plus(3, 4);
                WriteLine(result_001);

                // 뺄셈 메소드 활용
                int result_002 = Calculator.Minus(5, 2);
                WriteLine(result_002);
            }
        }
    }
}
