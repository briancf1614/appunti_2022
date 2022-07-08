using System;

namespace ClassePunto
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            
            punto P(2,3)

            ToString()
            (,)
            (2,3)
            P(2,-3.25)

            distanza dall'origine degli assi
            distanza da un altro punto
            */

            Punto P = new Punto();
            Punto Q = new Punto { X=2, Y=-3};
            Punto R = new Punto { Etichetta = "R", X = -9.2, Y = -3.4 };

            Console.WriteLine(P);
            Console.WriteLine(Q);
            Console.WriteLine(R);

            //Console.WriteLine($"OP={P.Distanza()}");
            Console.WriteLine($"OQ={Q.Distanza()}");
            Console.WriteLine($"OR={R.Distanza()}");

            Console.WriteLine($"QR={Q.Distanza(R)}");
            Console.WriteLine($"RQ={R.Distanza(Q)}");


        }
    }
}
