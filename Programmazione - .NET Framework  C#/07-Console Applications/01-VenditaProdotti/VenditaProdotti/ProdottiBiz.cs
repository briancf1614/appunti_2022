using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VenditaProdotti
{
    class ProdottiBiz
    {
        public List<Prodotto> Elenco { get; set; }

        public ProdottiBiz()
        {
            Elenco = new List<Prodotto>();
        }

        public string StampaElenco() {
            return string.Join("\n", Elenco);
        }

        public List<Prodotto> ElencoProdottiInScadenza()
        {
            var lista = new List<Prodotto>();
            foreach (var p in Elenco)
                if (p is ProdottoAlimentare inScadenza)
                    if (inScadenza.IsInScadenza())
                        lista.Add(p);
            return lista;
        }

        public List<Prodotto> ElencoProdottiPercentualeMateriaPrima()
        {
            var lista = new List<Prodotto>();
            foreach (var p in Elenco)
                if (p is ProdottoNonAlimentare)
                    lista.Add(p);
            return lista;
        }
    }
}
