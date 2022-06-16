using ClassePunto;
using System;

namespace ClasseTriangolo
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangolo t = new Triangolo() { Lato1 = 12, Lato2 = 3, Lato3 = 2 };

            Triangolo t2 = new Triangolo(
                    new Punto { X=2,Y=3}
                    , new Punto { X = -1, Y = -3 }
                    , new Punto { X = 2.5, Y = 1.75 }
                );

            Console.WriteLine(t);
            Console.WriteLine(t2);
        }
    }
}
