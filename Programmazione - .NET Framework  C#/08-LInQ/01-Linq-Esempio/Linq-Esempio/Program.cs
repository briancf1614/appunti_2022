using System;
using System.Linq;

namespace Linq_Esempio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Esempio di LinQ");

            string[] nomi = { "Pietro","Mario","Giulia","Francesca","Laura","Piero","antonio","Vito","Antonella"
            ,"Giada","Rossella","Simone","Saverio","Rosa","Michela","Andrea","Mattia","Ilaria","Alex","Vanessa"};

            Console.WriteLine("Elenco completo");
            var query = from tutti in nomi select tutti;
            Console.WriteLine(string.Join(", ",query));

            Console.WriteLine("\nElenco nomi iniziale A");
            var query2 = from iniziaA in nomi
                         //where iniziaA.StartsWith('A')
                         where iniziaA.Substring(0,1).ToUpper().Equals("A")
                         select iniziaA;
            Console.WriteLine(string.Join(", ", query2));

            Console.WriteLine("\nElenco nomi ordinato crescente");
            var query3 = from ordinaAsc in nomi orderby ordinaAsc select ordinaAsc;
            Console.WriteLine(string.Join(", ", query3));

            Console.WriteLine("\nElenco nomi con lunghezza 7 (ordine decrescente");
            var query4 = from lunghezza7 in nomi
                         where lunghezza7.Length == 7
                         orderby lunghezza7 descending
                         select lunghezza7;
            Console.WriteLine(string.Join(", ", query4));

            //esercizio
            var numeri = new[] { 12, -1, 34, 27, 56, 98, 11, 9, 45, 34, 76, 89 };
            Console.WriteLine("\n\nElenco di numeri interi:\n" + string.Join(", ", numeri));

            Console.WriteLine("\nFunzioni lambda");
            Console.WriteLine("Max: " + numeri.Max());
            Console.WriteLine("Min: " + numeri.Min());
            Console.WriteLine("Numero di elementi presenti: " + numeri.Count());
            Console.WriteLine("Somma dei numeri: " + numeri.Sum());
            //richieste
            Console.WriteLine("\nSomma dei numeri solo positivi: ");
            var q1 = from soloPositivi in numeri where soloPositivi > 0 select soloPositivi;
            Console.WriteLine(string.Join(", ", q1.Sum()));

            Console.WriteLine("\nElenco dei numeri dispari: ");
            var q2 = from dispari in numeri where dispari % 2 == 1 select dispari;
            Console.WriteLine(string.Join(", ", q2));

            Console.WriteLine("\nNumeri multipli di 3 trovati: ");
            var q3 = from multipli3 in numeri where multipli3 % 3 == 0 select multipli3;
            Console.WriteLine(string.Join(", ", q3.Count()));
        }
    }
}
