using System;
using System.Collections.Generic;

namespace NN_EsercitazioneIntermedia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Esercitazione intermedia");

            var v1 = new Venditore { Nome = "Pino", Cognome = "Delillo", Stipendio = 1250, Settore = Settore.AUTO };
            var v2 = new Venditore { Nome = "Dino", Cognome = "Delfino", Stipendio = 1150, Settore = Settore.MOTO };
            var elencoVenditori = new List<Venditore>();
            elencoVenditori.Add(v1);
            elencoVenditori.Add(v2);

            Console.WriteLine("Stampa elenco venditori");
            foreach (var item in elencoVenditori)
                Console.WriteLine(item);


            var m1 = new Meccanico { Nome = "Mino", Cognome = "Delillo", Stipendio = 1450, Tipologia = Tipologia.CARROZZERIA };
            var m2 = new Meccanico { Nome = "Gino", Cognome = "Delfino", Stipendio = 1050, Tipologia = Tipologia.MECCANICA };
            var elencoMeccanici = new List<Meccanico> { m1, m2 };
            Console.WriteLine("\n\nStampa elenco meccanici");
            Console.WriteLine(string.Join("\n", elencoMeccanici));


            var rv = new ResponsabileVenditori { Nome = "Rino", Cognome = "Casillo", Stipendio = 1550, Settore = Settore.AUTO };
            rv.AggiungiVenditore(v1);
            rv.AggiungiVenditore(v2);
            Console.WriteLine("\n\nStampa responsabile venditori");
            Console.WriteLine(rv);

            var p1 = new Prodotto { Codice = 1, Denominazione = "Prodotto 1", Descrizione = "Descrizione 1", Prezzo = 10.15 };
            var p2 = new Prodotto { Codice = 2, Denominazione = "Prodotto 2", Descrizione = "Descrizione 2", Prezzo = 11.15 };
            var p3 = new Prodotto { Codice = 3, Denominazione = "Prodotto 3", Descrizione = "Descrizione 3", Prezzo = 12.15 };
            var p4 = new Prodotto { Codice = 4, Denominazione = "Prodotto 4", Descrizione = "Descrizione 4", Prezzo = 13.15 };
            var p5 = new Prodotto { Codice = 5, Denominazione = "Prodotto 5", Descrizione = "Descrizione 5", Prezzo = 14.15 };

            var ps1 = new ProdottoScelto { Prodotto = p1, Quantita = 3 };
            var ps2 = new ProdottoScelto { Prodotto = p2, Quantita = 1 };
            var ps3 = new ProdottoScelto { Prodotto = p3, Quantita = 7 };
            var ps4 = new ProdottoScelto { Prodotto = p2, Quantita = 4 };
            var ps5 = new ProdottoScelto { Prodotto = p4, Quantita = 11 };
            var ps6 = new ProdottoScelto { Prodotto = p5, Quantita = 2 };

            var listaOrdini = new List<Ordine>
            {
                new Ordine { IdOrdine = 1, Data=new DateTime(2022,5,16, 15,25,26), Venditore=v1, ElencoProdotti = new List<ProdottoScelto>{ ps1,ps2}},
                new Ordine { IdOrdine = 2, Venditore=v1, ElencoProdotti = new List<ProdottoScelto>{ ps1,ps4}},
                new Ordine { IdOrdine = 3, Venditore=v2, ElencoProdotti = new List<ProdottoScelto>{ ps6,ps2}},
                new Ordine { IdOrdine = 4, Venditore=v2, ElencoProdotti = new List<ProdottoScelto>{ ps3,ps4}},
                new Ordine { IdOrdine = 5, Venditore=v1, ElencoProdotti = new List<ProdottoScelto>{ ps5,ps2}}
            };

            Console.WriteLine("\n\nStampa ordine n. 2");
            Console.WriteLine(listaOrdini[2].Scontrino());

            var co = new CapoOfficina { Nome = "Giulio", Cognome = "Pistolotto", Stipendio = 1750, Tipologia = Tipologia.CARROZZERIA, Ordini= listaOrdini };
            Console.WriteLine("\n\nStampa Capo officina");
            Console.WriteLine(co);
        }
    }
}
