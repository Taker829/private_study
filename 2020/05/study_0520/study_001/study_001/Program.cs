using System;
using static System.Console;

namespace study_001
{
    class Employee
    {
        // 객체 내부에서 자신의 변수에 접근 및 사용할 때 this 사용
        private string Name;
        private string Position;

        public void SetName(string Name)
        {
            this.Name = Name;
        }
        
        public string GetName()
        {
            return Name;
        }

        public void setPosition(string Position)
        {
            this.Position = Position;
        }

        public string GetPosition()
        {
            return this.Position;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Employee pooh = new Employee();
            pooh.SetName("Pooh");
            pooh.setPosition("Waiter");
            WriteLine($"{pooh.GetName()} {pooh.GetPosition()}");

            Employee tigger = new Employee();
            tigger.SetName("Tigger");
            tigger.setPosition("Cleaner");
            WriteLine($"{tigger.GetName()} {tigger.GetPosition()}");
        }
    }
}
