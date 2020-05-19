using System;
using static System.Console;
// 클래스는 태생이 참조 형식
// 얕은 복사 VS 깊은 복사
namespace study_001
{
    class MyClass
    {
        public int MyField1;
        public int MyField2;

        public MyClass DeepCopy()
        {
            // 객체를 힙에 새로 할당 -> 후, 그곳에 멤버를 일일이 복사해 넣는다.
            MyClass newCopy = new MyClass();
            newCopy.MyField1 = this.MyField1;
            newCopy.MyField2 = this.MyField2;

            return newCopy;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shallow Copy");
            {
                MyClass source = new MyClass();
                source.MyField1 = 10;
                source.MyField2 = 20;

                MyClass target = source;
                target.MyField2 = 30;

                WriteLine($"{source.MyField1} {source.MyField2}");
                WriteLine($"{target.MyField1} {target.MyField2}");
            }

            WriteLine("\nDeep Copy");
            {
                MyClass source = new MyClass();
                source.MyField1 = 10;
                source.MyField2 = 20;

                MyClass target = source.DeepCopy();
                target.MyField2 = 30;

                WriteLine($"{source.MyField1} {source.MyField2}");
                WriteLine($"{target.MyField1} {target.MyField2}");
            }
        }
    }
}
