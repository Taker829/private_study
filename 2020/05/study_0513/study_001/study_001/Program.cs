using System;
using static System.Console;

namespace study_001
{
    class Program
    {
        static void PrintProfile(string name, string phone = "")
        {
            WriteLine($"Name:{name}, Phone:{phone}");
        }
        static void Main(string[] args)
        {
            PrintProfile("태연");
            PrintProfile("윤아", "010-1234-1234");
            PrintProfile(name : "유리");
            PrintProfile(name: "서현", phone: "010-7894-7895");
        }
    }
}
