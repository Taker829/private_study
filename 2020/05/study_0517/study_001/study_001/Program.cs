using System;
using static System.Console;

namespace study_001
{
    class Cat
    {
        public string Name;
        public string Color;

        public void Meow()
        {
            WriteLine($"{Name} 고양이가 야옹하고 포효했다.");
        }
    }
    class MainApp
    {
        static void Main(string[] args)
        {
            Cat kitty = new Cat();
            kitty.Color = "하얀색";
            kitty.Name = "키티";
            kitty.Meow();
            WriteLine($"{kitty.Name} : {kitty.Color}");

            Cat nero = new Cat();
            nero.Color = "검은색";
            nero.Name = "네로";
            nero.Meow();
            WriteLine($"{nero.Name} : {nero.Color}");
        }
    }
}
