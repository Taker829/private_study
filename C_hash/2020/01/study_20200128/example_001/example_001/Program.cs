using System;
using static System.Console;

namespace example_001
{
    class Program
    {
        static void Main(string[] args)
        {
            // ?? 좌측의 비교값이 null이 맞다면 우측의 출력 실행
            int? num = null;
            WriteLine($"{num ?? 0}");

            num = 99;
            WriteLine($"{num ?? 0}");

            string str = null;
            WriteLine($"{str ?? "Default"}");

            str = "Specific";
            WriteLine($"{str ?? "Default"}");
        }
    }
}