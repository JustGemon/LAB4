using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Запишите значение а");
            double a = double.Parse(Console.ReadLine());
            if (a == 0)
            {
                Console.WriteLine("Данное число не является ненулевым");
            }
            else
            {
                Console.WriteLine("Введите значение b");
            }
            double b = double.Parse(Console.ReadLine());
            if (b == 0)
            {
                Console.WriteLine("Данное число не является ненулевым");

            }
            else
            {
                double c;//сумма
                double d;//разность
                double e;//частное квадратов
                double f;//произведение квадратов
                c = a + b;
                d = a - b;
                e = Math.Pow(a, 2) / Math.Pow(b, 2);
                f = Math.Pow(a, 2) * Math.Pow(b, 2);
                Console.WriteLine("Сумма:" + c);
                Console.WriteLine("Разность:" + d);
                Console.WriteLine("Частное квадратов:" + e);
                Console.WriteLine("Произведение квадратов:" + f);
            }
        }
    }
}
