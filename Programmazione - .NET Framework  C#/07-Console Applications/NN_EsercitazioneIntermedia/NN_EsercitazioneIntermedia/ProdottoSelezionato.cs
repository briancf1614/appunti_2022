using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NN_EsercitazioneIntermedia
{
    class ProdottoSelezionato:Prodotto
    {
        public int Quantita { get; set; }

        public double SubTotale() {

            return Prezzo * Quantita;
        }

        public string Stampa() {
            return $"{Codice} - {Denominazione} prezzo: {Prezzo} quantità: {Quantita} subtotale: {SubTotale()}";
        }

        public override string ToString()
        {
            return base.ToString() 
                + $"{nameof(Quantita)}={Quantita.ToString()}";
        }
    }
}
