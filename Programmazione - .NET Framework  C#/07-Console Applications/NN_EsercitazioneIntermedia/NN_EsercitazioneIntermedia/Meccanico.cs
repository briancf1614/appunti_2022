using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NN_EsercitazioneIntermedia
{
    class Meccanico:Persona
    {
        public Tipologia Tipologia { get; set; }
                
        public override double Tredicesima()
        {
            return Stipendio+93*Stipendio/100;
        }
        
        public override bool Equals(object obj)
        {
            return obj is Meccanico meccanico &&
                   Nome == meccanico.Nome &&
                   Cognome == meccanico.Cognome &&
                   Stipendio == meccanico.Stipendio &&
                   Tipologia == meccanico.Tipologia;
        }

        public override string ToString()
        {
            return $"{{{nameof(Tipologia)}={Tipologia.ToString()}, {nameof(Nome)}={Nome}, {nameof(Cognome)}={Cognome}, {nameof(Stipendio)}={Stipendio.ToString()}}}";
        }
    }
}
