using System;
using System.Collections.Generic;

namespace ListaGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            //uso di lista con i Generics ~ <T>
            List<Prodotto> list = new List<Prodotto>();
            list.Add(new Prodotto { Codice = 1, Nome = "Prodotto 1", Descrizione = "Descrizione prodotto 1", Prezzo = 12.15, Giacenza = 23 });
            list.Add(new Prodotto { Codice = 2, Nome = "Prodotto 2", Descrizione = "Descrizione prodotto 2", Prezzo = 13.15, Giacenza = 0 });
            list.Add(new Prodotto { Codice = 3, Nome = "Prodotto 3", Descrizione = "Descrizione prodotto 3", Prezzo = 14.15, Giacenza = 2 });
            list.Add(new Prodotto { Codice = 4, Nome = "Prodotto 4", Descrizione = "Descrizione prodotto 4", Prezzo = 15.15, Giacenza = 100 });
            list.Add(new Prodotto { Codice = 5, Nome = "Prodotto 5", Descrizione = "Descrizione prodotto 5", Prezzo = 15.05, Giacenza = 9 });

            foreach(var p in list)
                Console.WriteLine(p);



        }
    }
}
