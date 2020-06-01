using System;
using static System.Console;

namespace study_001
{
    class Mamal
    {
        public void Nurse()
        {
            WriteLine("Nurse()");
        }
    }
    class Dog : Mamal
    {
        public void Bark()
        {
            WriteLine("Bark()");
        }
    }
    class Cat : Mamal
    {
        public void Meow()
        {
            WriteLine("Meow()");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Mamal mamal = new Dog();
            Dog dog;

            if (mamal is Dog)
            {
                dog = (Dog)mamal;
                dog.Bark();
            }

            Mamal mamal2 = new Cat();

            Cat cat = mamal2 as Cat;
            if (cat != null)
                cat.Meow();

            Cat cat2 = mamal as Cat;
            if (cat2 != null)
                cat2.Meow();
            else
                WriteLine("cat2 is not a Cat");
        }
    }
}
