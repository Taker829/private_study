using System;
using static System.Console;

namespace study_001
{
    class Program
    {
        // out -> 출력 전용 매개 변수를 메소드 호출 시 선언
        static void Divide(int a, int b, out int quotient, out int remainder)
        {
            quotient = a / b;
            remainder = a % b;
        }
        static void Main(string[] args)
        {
            int a = 20;
            int b = 3;
            // int c;
            // int d;

            Divide(a, b, out int c, out int d);
            WriteLine($"a:{a}, b:{b}, a/b:{c}, a%b:{d}");
        }
    }
}
