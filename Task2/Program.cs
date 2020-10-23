using System;

namespace Alex2
{
    class Program
    {
        static void Main(string[] args)
        {
            float x;
            float a;

            Console.WriteLine("Введите x, a");

            x = float.Parse(Console.ReadLine());
            a = float.Parse(Console.ReadLine());
            float result = 0;

            Console.WriteLine("Введите количество элементов ряда: ");
            int n = int.Parse(Console.ReadLine());

            int key = 1;
            float fact = 1 * 2 * 3 * 4;
            while (n >= key)
            {
                float data = 10;
                fact = fact * (4 + key);
                result += (MathF.Pow(x, 2 * key) + fact) /
                          MathF.Sqrt(MathF.Sin(x) + MathF.Pow(-1, key) * ((data + 5 * key) * a));
            }

            Console.WriteLine(result);
        }
    }
}