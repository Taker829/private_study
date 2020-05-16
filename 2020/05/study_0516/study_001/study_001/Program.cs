using System;
using static System.Console;

namespace study_001
{
    class Program
    {
        // 메소드 내 로컬 함수 사용 예
        static string ToLowerString(string input)
        {
            var arr = input.ToCharArray();
            for(int i=0; i<arr.Length; i++)
            {
                // 로컬함수 사용
                arr[i] = ToLowerChar(i);
            }

            char ToLowerChar(int i)
            {
                if (arr[i] < 65 || arr[i] > 90) // A~Z의 아스키 값은 65 ~ 90
                    return arr[i];
                else // a~z의 아스키 값 : 97~122
                    return (char)(arr[i] + 32);
            }

            return new string(arr);
        }

        static void Main(string[] args)
        {
            WriteLine(ToLowerString("Hello"));
            WriteLine(ToLowerString("Good Morning"));
            WriteLine(ToLowerString("This is C#"));
        }
    }
}
