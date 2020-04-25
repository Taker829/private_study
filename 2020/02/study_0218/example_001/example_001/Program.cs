using System;
using static System.Console;

namespace example_001
{
    class Program
    {
        static void Main(string[] args)
        {
            int loop_cnt = 0;

            while (true)
            {
                Write("계속할까요? (예/아니오) : ");
                string answer = ReadLine();

                if (answer == "아니오")
                    break;
                else if (answer == "예")
                {
                    loop_cnt++;
                    WriteLine($"반복 횟수 : {loop_cnt}");
                }
                else
                    WriteLine("입력 오류, 재입력하세요");
            }
        }
    }
}
