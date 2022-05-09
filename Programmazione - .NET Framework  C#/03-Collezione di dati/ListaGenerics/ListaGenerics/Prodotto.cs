using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaGenerics
{
    class Prodotto
    {
        public int Codice { get; set; }
        public string Nome { get; set; }
        public string Descrizione { get; set; }
        public double Prezzo { get; set; }
        public int Giacenza { get; set; }

        //metodi

        //prodotto in scorta se giacenza [1-9]
        public bool IsInScorta() {
            return Giacenza >= 1 && Giacenza <= 9;
        }

        //prodotto esaurito quando la giacenza = 0
        public bool IsEsaurito() {
            return Giacenza == 0;
        }

        public override string ToString()
        {
            return $"{{{nameof(Codice)}={Codice.ToString()}" +
                $", {nameof(Nome)}={Nome}" +
                $", {nameof(Descrizione)}={Descrizione}" +
                $", {nameof(Prezzo)}={Prezzo.ToString()}" +
                $", {nameof(Giacenza)}={Giacenza.ToString()}" +
                $"}}";
        }
    }
}
