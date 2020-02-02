using System.Collections;
using static System.Console;

namespace example_001
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList a = null;
            a?.Add("야구");   // a?.이 null 반환 = true, 따라서 Add() 메소드는 호출되지 않음.
            a?.Add("축구");
            // null 반환하기에 그 이후에 아무것도 출력되지 않는다.
            WriteLine($"Count : {a?.Count}");
            WriteLine($"{a?[0]}");
            WriteLine($"{a?[1]}");

            // 이제 a는 더 이상 null이 아니다.
            a = new ArrayList();
            a?.Add("야구");
            a?.Add("축구");
            WriteLine($"Count : {a?.Count}");
            WriteLine($"{a?[0]}");
            WriteLine($"{a?[1]}");
        }
    }
}
