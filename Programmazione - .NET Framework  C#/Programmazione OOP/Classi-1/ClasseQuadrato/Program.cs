using System;

namespace ClasseQuadrato
{
    class Program
    {
        static void Main(string[] args)
        {
            Quadrato q = new Quadrato(); //istanza
            q.Lato=-1.25;
            Console.WriteLine(q.Stampa());
            

            Quadrato q1 = new Quadrato();
            q1.Lato=5.25;
            Console.WriteLine(q1.Stampa());

            Quadrato q2 = new Quadrato();
            Console.Write("Inserisci il lato del quadrato: ");
            q2.Lato=double.Parse(Console.ReadLine());
            Console.WriteLine(q2.Stampa());

        }
    }
}
