using System;

namespace Rubrica
{
    class Program
    {
        static void Main(string[] args)
        {
            var c1 = new Contatto("Petrillo","Giovanni");
            var c2 = new Contatto(
                "Delillo", "Marco", new Indirizzo { Via = "Via Trento, 28", Cap = "10100", Citta = "Torino", Provincia = "TO" }, "0110112589", "De.lillo@mnet.it");


            Console.WriteLine(c1);
            Console.WriteLine(c2);
        }
    }
}
