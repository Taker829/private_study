using System;
using static System.Console;

namespace study_001
{
    class Program
    {
        static void PrintProfile(string name, string phone)
        {
            WriteLine($"Name:{name}, Phone:{phone}");
        }

        static void Main(string[] args)
        {
            PrintProfile("박찬호", "010-1234-5959");
            PrintProfile(name:"박지성", phone:"010-4234-6512");
            PrintProfile(phone: "010-7894-5123", name: "김경태");
        }
    }
}
