using System;
using static System.Console;

namespace example_001
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[] { 0, 1, 2, 3, 4 };

            foreach (int a in arr)
            {
                WriteLine(a);
            }
        }
    }
}
