using System;
using static System.Console;

namespace study_001
{
    class Product
    {
        private int price = 100;

        public ref int GetPrice()
        {
            return ref price;
        }

        public void PrintPrice()
        {
            WriteLine($"Price : {price}");
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            Product carrot = new Product();
            // ref_local_price를 수정하면 carro.price도 같이 변경된다.
            ref int ref_local_price = ref carrot.GetPrice();
            int normal_local_price = carrot.GetPrice();

            carrot.PrintPrice();
            WriteLine($"Ref Local Price : {ref_local_price}");
            WriteLine($"Normal Local Price : {normal_local_price}");

            ref_local_price = 200;

            carrot.PrintPrice();
            WriteLine($"Ref Local Price : {ref_local_price}");
            WriteLine($"Normal Local Price : {normal_local_price}");
        }
    }
}
