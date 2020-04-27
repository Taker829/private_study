using System;

namespace study_003
{
    class Program
    {
        // ref 사용 시 참조하고 있는 원본 변수에 수정이 이루어진다.
        public static void Swap(ref int a, ref int b)
        {
            // 변수에 저장된 값 스로 교환
            int temp = b;
            b = a;
            a = temp;
        }
        static void Main(string[] args)
        {
            int x = 3;
            int y = 4;

            Console.WriteLine($"Before Swap >> x:{x}, y:{y}");
            // ref에 의해서 Main 안의 int x, y에 수정이 이루어진다.
            Swap(ref x, ref y);
            Console.WriteLine($"After Swap >> x:{x}, y:{y}");
        }
    }
}