using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VenditaProdotti
{
    class ProdottoNonAlimentare:Prodotto
    {
        //la percentuale della materia prima
        public double PercentualeMateriaPrima { get; set; }

        public override string ToString()
        {
            return base.ToString()
                +$", Percentuale di materia prima= {PercentualeMateriaPrima:P}"; //format P => ? %
        }
    }
}
