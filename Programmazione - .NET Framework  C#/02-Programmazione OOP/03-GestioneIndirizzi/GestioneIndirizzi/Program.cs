using System;

namespace GestioneIndirizzi
{
    class Program
    {
        static void Main(string[] args)
        {
            IndirizzoGenerico[] elenco =
            {
            new IndirizzoEmail { Account="info@its-ictpiemonte.it"},
            new IndirizzoWeb{ Url="https://www.its-ictpiemonte.it"},
            new IndirizzoFisico
            {
                Via="via J. Durandi",Numero="10A",Cap="10143",
                Citta="Torino",Provincia="TO",Regione="Piemonte"
                ,RipartizioneGeografica="Nord-Ovest"
            }
            };

            foreach (var i in elenco)
                Console.WriteLine(i);
        }
    }
}
