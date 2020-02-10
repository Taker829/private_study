using System;
using static System.Console;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;

            while(i>0)
            {
                //지속적으로 감소
                WriteLine($"i : {i--}");
            }
        }
    }
}
