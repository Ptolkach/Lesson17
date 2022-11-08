using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            BankAccount<int> BA1 = new BankAccount<int>();
            BA1.Number = 5000;
            BA1.Balance = 18400;
            BA1.Name = "Алишер Усманов";
            Console.WriteLine(BA1.GetInfo());

            BankAccount<string> BA2 = new BankAccount<string>();
            BA2.Number = "A009";
            BA2.Balance = 17200;
            BA2.Name = "Павел Дуров";
            Console.WriteLine(BA2.GetInfo());

            BankAccount<double> BA3 = new BankAccount<double>();
            BA3.Number = 16.5;
            BA3.Balance = 11100;
            BA3.Name = "Леонид Федун";
            Console.WriteLine(BA3.GetInfo());

            Console.ReadKey();
        }
    }
}
