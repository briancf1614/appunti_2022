using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NN_EsercitazioneIntermedia
{
    class ProdottoScelto
    {
        public Prodotto Prodotto { get; set; }
        public int Quantita { get; set; }

        public double SubTotale() {
            return Prodotto.Prezzo * Quantita;       
        }

        public string Stampa()
        {
            return $"{Prodotto.Codice} - {Prodotto.Denominazione} prezzo: {Prodotto.Prezzo} quantità: {Quantita} subtotale: {SubTotale()}";
        }

        public override string ToString()
        {
            return Prodotto.ToString()
                + $"{nameof(Quantita)}={Quantita.ToString()}";
        }

    }
}
