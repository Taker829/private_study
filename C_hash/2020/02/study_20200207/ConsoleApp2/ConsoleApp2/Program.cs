using System;
using static System.Console;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 10;

            do
            {
                WriteLine("a) i : {0}", i--);
            }
            while (i > 0);

            do
            {
                WriteLine("b) i : {0}", i--);
            }
            while (i > 0);
        }
    }
}
