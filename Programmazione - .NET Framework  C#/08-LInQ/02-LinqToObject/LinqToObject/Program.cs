using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqToObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("LinQ to Object");

            //creare una lista di clienti
            var elenco = new List<Cliente>
            {
                new Cliente{CodiceFiscale="VRDFBA76A01L219J",Nome="Fabio",Cognome="Verdi" }
                , new Cliente{CodiceFiscale="BNCMRA80A15L219M",Nome="Mario",Cognome="Bianchi"}
                , new Cliente{CodiceFiscale="MNNLRA91G52L219G",Nome="Laura",Cognome="Manno"}
            };

            //stampare elenco codici fiscali
            var q = from codiciFiscali in elenco select codiciFiscali.CodiceFiscale;
            Console.WriteLine("Elenco Codici fiscali: "+string.Join(", ",q));
            


        }
    }
}
