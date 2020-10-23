using System;

namespace Alex3
{
    class Program
    {
        static void Main(string[] args)
        {
            float a;
            float b;
            float x;
            float n0;
            float nk;
            float deltaN;
            Console.WriteLine("Введите a,b,x,n0,nk,deltaN по порядку.");
            a = float.Parse(Console.ReadLine());
            b = float.Parse(Console.ReadLine());
            x = float.Parse(Console.ReadLine());
            n0 = float.Parse(Console.ReadLine());
            nk = float.Parse(Console.ReadLine());
            deltaN = float.Parse(Console.ReadLine());
            float U;
            Console.WriteLine("Введите количество элементов ряда: ");
            while (nk >= n0)
            {
                U = (MathF.Cos(a) + b) / (2 * MathF.Pow(MathF.Tan(MathF.Sqrt(a * a + b - n0)), 2));
                Console.WriteLine("При n=" + n0 + "U=" + U);
                n0++;
            }
        }
    }
}