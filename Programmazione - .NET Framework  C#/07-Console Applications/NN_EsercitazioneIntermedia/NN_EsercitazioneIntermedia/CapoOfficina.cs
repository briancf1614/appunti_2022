using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NN_EsercitazioneIntermedia
{
    class CapoOfficina:Meccanico
    {
        public List<Ordine> Ordini { get; set; }

        public CapoOfficina()
        {
            Ordini = new List<Ordine>();
        }

        public CapoOfficina(List<Ordine> ordini)
        {
            Ordini = ordini;
        }

        public void AggiungiOrdine(Ordine ordine, int index)
        {
            Ordini.Insert(index, ordine);
        }

        public int NoOrdini() {
            return Ordini.Count;
        }

        public override double Tredicesima()
        {
            double bonus = 0;
            foreach (var o in Ordini)
                bonus += o.Totale() * 5 / 100;

            return 2*Stipendio+bonus;
        }

        public override string ToString()
        {
            return $"{{{nameof(Ordini)}={Ordini}, {nameof(Tipologia)}={Tipologia.ToString()}, {nameof(Nome)}={Nome}, {nameof(Cognome)}={Cognome}, {nameof(Stipendio)}={Stipendio.ToString()}, Tredicesima: {Tredicesima()}}}";
        }
    }
}
