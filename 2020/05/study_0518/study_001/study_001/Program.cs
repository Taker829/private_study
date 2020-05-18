using System;
using static System.Console;

// 프로그램 전체에 걸쳐 공유해야 하는 변수 -> 정적 필드 사용

class Global
{
    public static int Count = 0;
}

class ClassA
{
    public ClassA()
    {
        // Global의 static 변수 Count를 사용
        Global.Count++;
    }
}

class ClassB
{
    public ClassB()
    {
        Global.Count++;
    }
}

namespace study_001
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine($"Globla.Count_Before : {Global.Count}");

            new ClassA();
            new ClassA();
            new ClassB();
            new ClassB();

            WriteLine($"Globla.Count_After : {Global.Count}");
        }
    }
}
