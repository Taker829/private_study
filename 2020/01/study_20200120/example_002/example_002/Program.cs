using System;
using static System.Console;

namespace example_002
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine("\nTesting <<...\n");

            int a = 1;
            WriteLine("a      : {0:D5} (0x{0:x8})", a);
            WriteLine("a << 1 : {0:D5} (0x{0:x8})", a << 1);
            WriteLine("a << 2 : {0:D5} (0x{0:x8})", a << 2);
            WriteLine("a << 5 : {0:D5} (0x{0:x8})", a << 5);

            WriteLine("\nTesting >>...\n");

            int b = 255;
            WriteLine("b      : {0:D5} (0x{0:x8})", b);
            WriteLine("b >> 1 : {0:D5} (0x{0:x8})", b >> 1);
            WriteLine("b >> 2 : {0:D5} (0x{0:x8})", b >> 2);
            WriteLine("b >> 5 : {0:D5} (0x{0:x8})", b >> 5);

            WriteLine("\nTesting >> with 음수 케이스\n");

            int c = -255;
            WriteLine("c      : {0:D5} (0x{0:x8})", c);
            WriteLine("c >> 1 : {0:D5} (0x{0:x8})", c >> 1);
            WriteLine("c >> 2 : {0:D5} (0x{0:x8})", c >> 2);
            WriteLine("c >> 5 : {0:D5} (0x{0:x8})", c >> 5);
        }
    }
}
