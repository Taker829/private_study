using System;
using static System.Console;

namespace ThisConstructor
{
    class MyClass
    {
        int a, b, c;

        public MyClass()
        {
            this.a = 5425;
            WriteLine("MyClass()");
        }
        // this()는 MyClass()를 호출
        // 즉, this() = 이 클래스의 MyClass()
        public MyClass(int b) : this()
        {
            this.b = b;
            WriteLine($"MyClass({b})");
        }
        //this(-int-)는 MyClass(-int-)를 호출
        // 즉, this(-int-) = 이 클래스의 MyClass(-int-)
        public MyClass(int b, int c) : this(b)
        {
            this.c = c;
            WriteLine($"MyClass({b}. {c}");
        }
        public void PrintFields()
        {
            WriteLine($"a : {a}, b : {b}, c : {c}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyClass a = new MyClass();
            a.PrintFields();
            WriteLine();

            MyClass b = new MyClass(1);
            b.PrintFields();
            WriteLine();

            MyClass c = new MyClass(10, 20);
            c.PrintFields();
        }
    }
}
