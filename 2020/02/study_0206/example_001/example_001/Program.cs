using System;
using static System.Console;

namespace example_001
{
    class Program
    {
        static void Main(string[] args)
        {
            object obj = null;

            string s = ReadLine();
            if (int.TryParse(s, out int out_i))
                obj = out_i;
            else if (float.TryParse(s, out float out_f))
                obj = out_f;
            else
                obj = s;

            switch (obj)
            {
                case int i:
                    WriteLine($"{i}는 int 형식입니다.");
                    break;
                case float f:
                    WriteLine($"{f}는 float 형식입니다.");
                    break;
                default:
                    WriteLine($"{obj}는 모르는 형식입니다.");
                    break;
            }
        }
    }
}
