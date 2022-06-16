using System;
using System.Collections.Generic;

namespace Magazzino
{
    class Program
    {
        static void Main(string[] args)
        {
            var lista = new List<Prodotto> { 
            new Prodotto{ Codice=1,Nome="Prodotto 1",Descrizione="Descrizione prodotto 1", Prezzo=10.15,Giacenza=100},
            new Prodotto{ Codice=2,Nome="Prodotto 2",Descrizione="Descrizione prodotto 2", Prezzo=100.15,Giacenza=0},
            new Prodotto{ Codice=3,Nome="Prodotto 3",Descrizione="Descrizione prodotto 3", Prezzo=11.15,Giacenza=1},
            new Prodotto{ Codice=4,Nome="Prodotto 4",Descrizione="Descrizione prodotto 4", Prezzo=112.15,Giacenza=10},
            new Prodotto{ Codice=5,Nome="Prodotto 5",Descrizione="Descrizione prodotto 5", Prezzo=13.15,Giacenza=7},
            };

            ProdottiBiz prodottiBiz = new ProdottiBiz();
            prodottiBiz.Elenco = lista;

            string menu = "Scegliuna tra le seguenti operazioni: " +
                "\n1 - visualizzare il prodotto con prezzo maggiore" +
"\n2 - cercare un prodotto di cui si conosce il codice" +
"\n3 - stabilire quanto è il valore del magazzino(per ogni prodotto, il valore = prezzo del prodotto * quantità)" +
"\n4 - elencare i prodotti che sono in scorta(giacenza[1 - 9])" +
"\n5 - elencare i prodotti esauriti(giacenza= 0)" +
"\n6 - elencare tutti i prodotti" +
"\n0 - esci";

            int scelta;
            do
            {
                Console.WriteLine();
                Console.WriteLine(menu);
                Console.Write("\nScelta: ");
                scelta = int.Parse(Console.ReadLine());

                switch (scelta) {
                    case 1: Console.WriteLine($"Prodotto con prezzo max: {prodottiBiz.PrezzoMax()}");break;
                    case 2: Console.Write("Codice del prodotto da cercare: ");
                        Prodotto p = prodottiBiz.RicercaPerCodice(int.Parse(Console.ReadLine()));
                        if (p != null)
                            Console.WriteLine(p);
                        else
                            Console.WriteLine("Prodotto non trovato");
                        break;
                    case 3: Console.WriteLine("Valore magazzino: " + prodottiBiz.ValoreMagazzino() + " euro");break;
                    case 4: Console.WriteLine("Prodotti in scorta:\n" + string.Join("\n", prodottiBiz.ProdottiInScorta()));break;
                    case 5: Console.WriteLine("Prodotti esauriti:\n" + string.Join("\n", prodottiBiz.ProdottiEsauriti()));break;
                    case 6: Console.WriteLine("Elenco Prodotti:\n" + prodottiBiz.ToString()); break;
                    default: Console.WriteLine("Scelta inserita non valida");break;
                }
            }
            while (scelta != 0);
            Console.WriteLine();
            Console.WriteLine("Programma terminato");


        }
    }
}
