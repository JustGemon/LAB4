using System;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Укажите a");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Укажите b");
            double b = double.Parse(Console.ReadLine());
            double c;
            c = (a + b) / 2;
            Console.WriteLine("Среднее арифметическое равно " +c);
            Console.ReadKey();
        }
    }
}
