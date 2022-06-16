using System;

namespace Saluto
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Esercizio n. 2 – Saluto
             Recuperata l’ora, stampare buongiorno, buon pomeriggio, buone sera oppure buona notte a seconda dei casi.
             Es. input: 9 output: buongiorno
             * */

            //recupero ora dal sistema operativo

            int h = DateTime.Now.Hour; //[0-23]

            // [6-14[ -> buongiorno
            // [14-18[ -> buon pomeriggio
            // [18-22[ -> buona sera
            // [22-6[ -> buona notte

            Console.WriteLine($"Ora recuperata: {h}");

            if (h >= 6 && h < 14)
                Console.WriteLine("Buongiorno");
            else if (h >= 14 && h < 18)
                Console.WriteLine("Buon pomeriggio");
            else if (h >= 18 && h < 22)
                Console.WriteLine("Buona sera");
            else
                Console.WriteLine("Buona notte");


        }
    }
}
