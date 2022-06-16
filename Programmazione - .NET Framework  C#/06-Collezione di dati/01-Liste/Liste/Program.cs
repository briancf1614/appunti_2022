using System;
using System.Collections;

namespace Liste
{
    class Program
    {
        static void Main(string[] args)
        {
            //array dinamici, sono classi
            //consente di memorizzare oggetti di qualsiasi tipo

            ArrayList lista = new ArrayList();

            //capacità della lista
            Console.WriteLine($"Capacità: {lista.Capacity}");
            Console.WriteLine($"Dimensione: {lista.Count}");

            lista.Add(12);
            lista.Add(-45.23); //double
            lista.Add(-45.11F); //float
            lista.Add(false);
            lista.Add('k');
            lista.Add("Pietro");
            lista.Add(new Cerchio() { Raggio = 1.25 });
            lista.Add(new Cerchio() { Raggio = 2.25 });
            lista.Add(new Cerchio() { Raggio = 3.25 });

            Console.WriteLine($"Capacità: {lista.Capacity}");
            Console.WriteLine($"Dimensione: {lista.Count}");

            //lettura da lista
            Console.WriteLine("\nElenco degli oggetti della lista");
            foreach (var item in lista)
                Console.WriteLine(item);

            Console.WriteLine("\nStampa dei soli oggetti di tipo Cerchio");
            foreach (var item in lista)
            {
                Cerchio c = null;
                if (item is Cerchio)
                {
                    c = (Cerchio)item;
                    Console.WriteLine(c.Raggio);

                }
            }
            var c1 = new Cerchio() { Raggio = 5 };
            lista.Insert(3, c1);
            lista.Insert(7, c1);
            lista.Insert(5, c1);

            //lettura da lista
            Console.WriteLine("\nElenco degli oggetti della lista");
            for(var i=0;i<lista.Count;i++)
                Console.WriteLine($"{i}: {lista[i]}");

            Console.Write("\nInserisci il numero da cercare nella lista: ");
            int n = int.Parse(Console.ReadLine());
            if (lista.Contains(n))  //consente di cercare elementi in una lista
                Console.WriteLine($"Elemento trovato in posizione {lista.IndexOf(n)}");
            else
                Console.WriteLine("Elemento non trovato");

            Console.WriteLine("\nRimozione di oggetti");
            //rimuovo l'oggetto c1
            lista.Remove(c1);
            //Console.WriteLine("Elenco oggetti dopo rimozione:\n " + string.Join('\n',lista));
            
            lista.RemoveAt(5);

            foreach (var item in lista)
                Console.WriteLine(item);

            //svuotare la lista
            lista.Clear();
            Console.WriteLine($"Dimensione: {lista.Count}");
            //

        }
    }
}
