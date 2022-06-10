using System;
using System.Collections.Generic;

namespace NN_EsercitazioneIntermedia
{
    sealed class Ordine
    {
        public int IdOrdine { get; set; }
        public DateTime Data { get; set; }
        public Venditore Venditore { get; set; }
        public List<ProdottoScelto> ElencoProdotti { get; set; }

        public Ordine()
        {
            Data = DateTime.Now;
            ElencoProdotti = new List<ProdottoScelto>();
        }

        public Ordine(int idOrdine, DateTime data, Venditore venditore, List<ProdottoScelto> elencoProdotti)
        {
            IdOrdine = idOrdine;
            Data = data;
            Venditore = venditore;
            ElencoProdotti = elencoProdotti;
        }

        public int NoProdotti() {
            return ElencoProdotti.Count;
        }

        public double Totale() {

            double totale = 0;
            foreach (var p in ElencoProdotti)
                totale += p.SubTotale();

            return totale;
        }

        public string StampaElenco() {

            //return string.Join("\n", ElencoProdotti);

            string msg = "";
            foreach (var ps in ElencoProdotti)
                msg += (!string.IsNullOrEmpty(msg) ? "\n":"") + ps.Stampa();
            return msg;
        }

        public string Scontrino() {

            string txt = "";
            txt += $"N. scontrino: {IdOrdine}" +
                $"\nData: {Data}" +
                $"\nVenditore: {Venditore.Cognome}" +
                $"\n\nElenco prodotti:" +
                $"\n{StampaElenco()}"
                ;

            return txt;        
        }

        public override string ToString()
        {
            return $"{{{nameof(IdOrdine)}={IdOrdine.ToString()}, {nameof(Data)}={Data.ToString()}, {nameof(Venditore)}={Venditore}, {nameof(ElencoProdotti)}={ElencoProdotti}}}";
        }
    }
}