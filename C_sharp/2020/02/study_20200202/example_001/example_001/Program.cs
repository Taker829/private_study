using System;
using static System.Console;

namespace example_001
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("숫자를 입력하세요 : ");

            // Console.ReadLine()은 사용자로부터 문자열을 입력받아 그 결과를 반환하는 기능.
            //string input = Console.ReadLine();
            string input = ReadLine();
            int number = Int32.Parse(input);

            if (number < 0)
                WriteLine("음수");
            else if (number > 0)
                WriteLine("양수");
            else
                WriteLine("0");

            if (number % 2 == 0)
                WriteLine("짝수");
            else
                WriteLine("홀수");
        }
    }
}
