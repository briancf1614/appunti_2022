using System;

namespace Auto
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             marca, modello, cilindrata, alimentazione,colore

            metodo che restituisce la velocità max

            calcolo cilindrata/10 e aggiungo bonus che è determinato dall'alimentazione

            se benzina => 30
            se Diesel => 20
            se GPL => -10
            se metano => -30           
             
            Aggiungere due metodi: accelera, frena

            accelera aumenta la velocità dell'auto di 10 km/h
            frena decrementa la velocità dell'auto di 5 km/h

            l'auto non può superare la velocitaMax
            l'auto non può avere velocità negativa


             */

            var a = new Auto {Velocita=50, Alimentazione = Alimentazione.GPL, Marca = "BMW", Modello = "X5", Cilindrata = 2000, Colore = "Verde" };
            Console.WriteLine(a);

            string menu = 
                $"\n\nScegli una tra le seguneti operazioni:" +
                $"\n1 - Accelera" +
                $"\n2 - Frena" +
                $"\n0 - Termina";
            int scelta;
            do
            {
                Console.WriteLine($"\nVelocità: {a.Velocita} km/h");
                Console.WriteLine(menu);
                Console.Write("Scelta: ");
                scelta = int.Parse(Console.ReadLine());
                switch (scelta) {
                    case 1: a.Accelera();break;
                    case 2: a.Frena();break;
                    case 0: break;
                    default:Console.WriteLine("Valore inserito non valido");break;                
                }
            } while (scelta!=0);

            Console.WriteLine("Programma terminato!");


            
        }
    }
}
