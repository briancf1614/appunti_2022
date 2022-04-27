using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Magazzino
{
    class ProdottiBiz
    {
        //classe Business Logic Layer
        //serve per implementare servizi su collezioni di dati

        public List<Prodotto> Elenco { get; set; }

        public ProdottiBiz() {
            Elenco = new List<Prodotto>();
        }

        public Prodotto PrezzoMax()
        {
            int pos = 0; //posizione del prodotto con prezzo max
            for (int i = 1; i < Elenco.Count; i++)
                if (Elenco[i].Prezzo > Elenco[pos].Prezzo)
                    pos = i;
            return Elenco[pos];

            /* con uso del ciclo foreach
            Prodotto prodotto = Elenco[0];
            foreach (var p in Elenco)
                if (p.Prezzo > prodotto.Prezzo)
                    prodotto = p;
            return prodotto;
            */
        }

        public Prodotto RicercaPerCodice(int codice)
        {
            foreach (var p in Elenco)
                if (p.Codice == codice)
                    return p;
            return null; //prodotto non trovato
        }

        public double ValoreMagazzino()
        {
            double totale = 0;
            foreach (var p in Elenco)
                totale += p.Prezzo * p.Giacenza;
            return totale;
        }

        public List<Prodotto> ProdottiInScorta()
        {
            var lista = new List<Prodotto>();
            foreach (var p in Elenco)
                if (p.IsInScorta())
                    lista.Add(p);
            return lista;
        }

        public List<Prodotto> ProdottiEsauriti()
        {
            var lista = new List<Prodotto>();
            foreach (var p in Elenco)
                if (p.IsEsaurito())
                    lista.Add(p);
            return lista;
        }

        public override string ToString()
        {
            return string.Join("\n",Elenco);
        }
    }
}
