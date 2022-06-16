using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NN_EsercitazioneIntermedia
{
    class Venditore:Persona,ICloneable
    {
        public Settore Settore { get; set; }

        

        public override double Tredicesima()
        {
            return Stipendio + 91 * Stipendio / 100;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }

        public override string ToString()
        {
            return $"{{{nameof(Settore)}={Settore.ToString()}, {nameof(Nome)}={Nome}, {nameof(Cognome)}={Cognome}, {nameof(Stipendio)}={Stipendio.ToString()}}}";
        }
    }
}
