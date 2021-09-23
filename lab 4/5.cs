using System;

namespace _5
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
                double e;//частное 
                double f;//произведение 
                c = Math.Abs(a) + Math.Abs(b);
                d = Math.Abs(a) - Math.Abs(b);
                e = Math.Abs(a) / Math.Abs(b);
                f = Math.Abs(a) * Math.Abs(b);
                Console.WriteLine("Сумма:" + c);
                Console.WriteLine("Разность:" + d);
                Console.WriteLine("Частное :" + e);
                Console.WriteLine("Произведение :" + f);
            }
        }
    }
}
