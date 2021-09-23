using System;

namespace rab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сторону a");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите сторону b");
            int b = int.Parse(Console.ReadLine());
            int p, s;
            p = 2 * (a + b);
            s = a * b;
            Console.WriteLine("Периметр равен " + p);
            Console.WriteLine("Площадь равна " + s);
            Console.ReadKey();
        }
    }
}
