using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Укажите диаметр d");
            int d = int.Parse(Console.ReadLine());
            double p = 3.14;
            double l;
            l = p * d;
            Console.WriteLine("Длина окружности равна " + l);
            Console.ReadKey();
        }
    }
}
