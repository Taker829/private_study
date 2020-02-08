using System;
using static System.Console;

namespace example_002
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i=0; i < 5; i++)
            {
                for (int j=0; j <= i; j++)
                {
                    Write("*");
                }
                WriteLine();
            }
        }
    }
}
