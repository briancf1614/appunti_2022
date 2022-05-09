using System;

namespace ProdottoQuantitaPercentualeSconto
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Esercizio n. 1 – PrezzoQuantitaPercentualeSconto

            Dati in input il prezzo e la quantità di un certo prodotto, 
            determinare la fascia di sconto da applicare 
            e stampare i dati inseriti, la percentuale di sconto applicata, 
            lo sconto effettuato e il totale da pagare.

            Fasce di sconto

            Quantita < 3  --- percentuale di sconto 0%
            3<= Quantita < 8 --- percentuale di sconto 4%
            8<= Quantita < 12 --- percentuale di sconto 9%
            12<= Quantita < 20 --- percentuale di sconto 13%
            Quantita >= 20 --- percentuale di sconto 21%
            */

            double prezzo;
            Console.Write("Inserisci il prezzo del prodotto: ");
            prezzo = Convert.ToDouble(Console.ReadLine());

            int quantita;
            Console.Write("Inserisci la quantità del prodotto: ");
            quantita = Convert.ToInt32(Console.ReadLine());

            int percentuale = 0;

            if (quantita >= 3 && quantita < 8)
                percentuale = 4;
            else if (quantita >= 8 && quantita < 12)
                percentuale = 9;
            else if (quantita >= 12 && quantita < 20)
                percentuale = 13;
            else if (quantita >= 20)
                percentuale = 21;

            double subTotale = prezzo * quantita;
            double sconto = subTotale * percentuale / 100;
            double totale = subTotale - sconto;

            string msg = $"Risultati: ";
                    msg += $"\nPrezzo: {prezzo} euro";
                    msg += $"\nQuantità: {quantita}";
                    msg += $"\nPercentuale di sconto applicato: {(double)percentuale/100:P}";
                    msg += $"\nSub Totale: {subTotale} euro";
                    msg += $"\nSconto effettuato: {sconto} euro";
                    msg += $"\nTotale scontato: {totale} euro";

            Console.WriteLine(msg);


        }
    }
}
