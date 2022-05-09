using System;

namespace Interfacce
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new Atleta
            {
                Nominativo = "Piero Lesto",
                Disciplina = "Podista",
                Pettorina = 2
            };
            Console.WriteLine(a);
            Console.WriteLine(a.Corro());
            Console.WriteLine(a.Rovescio());
            Console.WriteLine(a.Bevo());
            
            try
            {
                Console.WriteLine(a.Rana());
            }
            catch (NotImplementedException e) {
                Console.WriteLine("Errore!");
                Console.WriteLine("Messaggio: " + e.Message);            
            }
            
        }
    }
}
