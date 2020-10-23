using System;


namespace Alex
{
    class Program
    {
        static void Main(string[] args)
        {
            float a, b, n, c;

            Console.WriteLine("Введите a, b, n, c по порядку");
            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());
            n = float.Parse(Console.ReadLine());
            c = float.Parse(Console.ReadLine());

            float k;
            if (a > b)
            {
                k = a * a;
            }
            else if (a == b)
            {
                k = a + b;
            }
            else
            {
                k = c;
            }

            float u;
            if (a * a == 529)
            {
                u = MathF.Cos(a);
            }
            else
            {
                u = MathF.Sin(a);
            }

            float m = (n + u) / (k - u) + MathF.Tan(k) - MathF.Exp(n + k * k);
            Console.WriteLine(m);
        }
    }
}