using System;

namespace ClassePersona
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             Di una persona si conoscon il nome, cognome, data di nascita e luogo di nascita, il sesso

             Si richiede di calcolare l'eta della persona

             Si richiede la stampa mediante metodo ToString
             
             */

            var pino = new Persona();
            var lina = new Persona("Lina","Cardillo");
            var mina = new Persona("Mina","Giuffrida",new DateTime(2000,3,30),"Genova");
            var gino = new Persona("Gino","Ruspino",new DateTime(1995,5,25),"Frosinone",Sesso.M);

            Console.WriteLine(pino);
            Console.WriteLine(lina);
            Console.WriteLine(mina);
            Console.WriteLine(gino);
        }
    }
}
