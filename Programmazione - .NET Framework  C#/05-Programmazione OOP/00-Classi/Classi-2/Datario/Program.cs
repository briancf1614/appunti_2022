using System;

namespace Datario
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime oggi = DateTime.Now;

            Console.WriteLine("ToString: "+oggi);
            Console.WriteLine("ToShortDateString: " + oggi.ToShortDateString());
            Console.WriteLine("ToShortTimeString: " + oggi.ToShortTimeString());
            Console.WriteLine("ToLongDateString: " + oggi.ToLongDateString());
            Console.WriteLine("ToLongTimeString: " + oggi.ToLongTimeString());

            DateTime nascita = new DateTime(2000,7,28);
            Console.WriteLine("ToString: " + nascita);
            Console.WriteLine("ToShortDateString: " + nascita.ToShortDateString());
            Console.WriteLine("ToShortTimeString: " + nascita.ToShortTimeString());
            Console.WriteLine("ToLongDateString: " + nascita.ToLongDateString());
            Console.WriteLine("ToLongTimeString: " + nascita.ToLongTimeString());

            DateTime adesso = new DateTime();
            
            if(adesso!=default)
                Console.WriteLine("ToString: " + adesso);


        }
    }
}
