using System;

namespace ArrayReali
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numeri = { 12.5, 4.78, -9.67, Math.Sqrt(6), -12.12 };

            for (int i = 0; i < numeri.Length; i++)
                Console.WriteLine($"{i}: {numeri[i]}");

            

        }
    }
}
